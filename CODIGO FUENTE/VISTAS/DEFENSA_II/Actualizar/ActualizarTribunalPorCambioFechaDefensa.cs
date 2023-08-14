using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_II.Actualizar
{
    public partial class ActualizarTribunalPorCambioFechaDefensa : Form
    {
        public ActualizarTribunalPorCambioFechaDefensa()
        {
            InitializeComponent();
        }
        // variables necesarias para inciar el formulario
        public string FechaRecibida;
        public int IdDefensaRecibido;
        public int IdAulaRecibido;
        public string AulaRecibido;
        public string HoraRecibido;
        public bool SemaforoRetorno = false;
        public string DefensorRecibido;
        public string HoraDefensaRecibida;


        //objetos utilizados
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();

        // data tables utilizados para recuperar los datos
        DataTable DtTribunalDefensa = new DataTable();
        DataTable DtContratos = new DataTable();
        DataTable DtAulas = new DataTable();
        DataTable DtDefensasProgramadas = new DataTable();

        //variables para cambiar colores
        int ColorAula;
        int ColorTribunal;
        int ColorContrato;

        // variable para los ids recuperados localmente
        int IdAula;
        int IdTribunal;
        int IdContrato;
        int IdContratoTribunal;
        //bandera para saber si existe algun tribunal de la defensa que tenga un choque de defensa para la nueva fecha y hora de la defensa
        bool BandChoqueTribunal = false;

        // otras
        bool red = false;

        private void ActualizarTribunalPorCambioFechaDefensa_Load(object sender, EventArgs e)
        {
            IdAula = IdAulaRecibido;

            TxtFecha.Text = FechaRecibida;
            TxtDefensor.Text = DefensorRecibido;
            TxtAula.Text = AulaRecibido;
            TxtHora.Text = HoraRecibido;
            
            
            // recuperamos los tribunales de la defensa con el id de la defensa recibido
            ObjTribunal.ID_DEFENSA = IdDefensaRecibido;
            DtTribunalDefensa = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
            GridTribunal = CargarTribunal(GridTribunal, DtTribunalDefensa);
            // verificamos los tribunales
            GridTribunal = MarcarTribunales(GridTribunal);
            // verificamos que no  haya problemas con respecto al la fecha y la hora de la defensa en el aula designado
            // si existe problemas se puede camciar el aula o la hora 
            if (VerificarFechaHoraAula(TxtFecha.Text, TxtHora.Text, IdAulaRecibido) == true)
            {
                LblMensajeFehaAulaHora.BackColor = Color.Green;
                LblMensajeFehaAulaHora.Text = " No existe problema con respecto a la fecha, aula y hora de la defensa, puede continuar sin  modificar alguno de estos";
            }
            else
            {
                LblMensajeFehaAulaHora.BackColor = Color.Red;
                LblMensajeFehaAulaHora.Text = "Existe ya una defensa en el aula " + TxtAula.Text + " para la fecha " + TxtFecha.Text + " y en la hora " + TxtHora.Text;
            }
            // cargamos los contratos para posible reemplazo de tribunal
            ObjContrato.ESTADO=1;
            DtContratos = ObjContrato.SeleccionarContratoCriterioBss();
            GridContratos = CargarContratos(GridContratos, DtContratos);

            // cargamos todas la aulas
            ObjAula.ESTADO = 1;
            DtAulas = ObjAula.SeleccionarAulaCriterioBss();
            GridAulas = CargarAulas(GridAulas, DtAulas);


        }
        private void GridAulas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridAulas.Rows[ColorAula].DefaultCellStyle.BackColor = Color.White;
                GridAulas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorAula = e.RowIndex;
                IdAula = Convert.ToInt32(GridAulas["ID_AULA", e.RowIndex].Value);

                //verificamos que no haya choque de defensas en el aula
                if (VerificarFechaHoraAula(TxtFecha.Text, TxtHora.Text, IdAula) == true)
                {
                    LblMensajeFehaAulaHora.BackColor = Color.Green;
                    LblMensajeFehaAulaHora.Text = " No existe problema con respecto a la fecha, aula y hora de la defensa, puede continuar sin  modificar alguno de estos";
                    TxtAula.Text = GridAulas["NRO_AULA", e.RowIndex].Value.ToString();
                    BtnFinalizarActualizacion.Enabled = true;
                }
                else
                {
                    LblMensajeFehaAulaHora.BackColor = Color.Red;
                    LblMensajeFehaAulaHora.Text = "Existe ya una defensa en el aula " + TxtAula.Text + " para la fecha " + TxtFecha.Text + " y en la hora " + TxtHora.Text;
                    TxtAula.Text = GridAulas["NRO_AULA", e.RowIndex].Value.ToString();
                    BtnFinalizarActualizacion.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ColorAula = 0;
                MessageBox.Show(ex.ToString());
            }

        }
        private void BtnBuscarAula_Click(object sender, EventArgs e)
        {           

            ObjAula.ESTADO = 1;
            if (TxtPiso.Text != "")
            {
                ObjAula.PISO = Convert.ToInt32(TxtPiso.Text);
            }
            
            DtAulas = ObjAula.SeleccionarAulaCriterioBss();
            GridAulas = CargarAulas(GridAulas, DtAulas);
        }

        private void BtnCambioHora_Click(object sender, EventArgs e)
        {
            if (CmbHoraDefensa.Text != "" & CmbMinutos.Text != "")
            {
                TxtHora.Text = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                //verificamos que no haya choque de defensas en el aula
                if (VerificarFechaHoraAula(TxtFecha.Text, TxtHora.Text, IdAula) == true)
                {
                    GridTribunal = MarcarTribunales(GridTribunal);
                    LblMensajeFehaAulaHora.BackColor = Color.Green;
                    LblMensajeFehaAulaHora.Text = " No existe problema con respecto a la fecha, aula y hora de la defensa, puede continuar sin  modificar alguno de estos";
                    BtnFinalizarActualizacion.Enabled = true;
                }
                else
                {
                    GridTribunal = MarcarTribunales(GridTribunal);
                    LblMensajeFehaAulaHora.BackColor = Color.Red;
                    LblMensajeFehaAulaHora.Text = "Existe ya una defensa en el aula " + TxtAula.Text + " para la fecha " + TxtFecha.Text + " y en la hora " + TxtHora.Text;
                    BtnFinalizarActualizacion.Enabled = false;
                    
                }
                
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una hora o los minitos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void GridTribunal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {          
           
            try
            {
                
                // para no poner en blanco los rojos
                if (GridTribunal.Rows[ColorTribunal].DefaultCellStyle.BackColor != Color.Red)
                {
                    if (red == true)
                    {
                        GridTribunal.Rows[ColorTribunal].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        GridTribunal.Rows[ColorTribunal].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                if (GridTribunal.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red)
                {
                    red = true;
                }
                else
                {
                    red = false;
                }


                GridTribunal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorTribunal = e.RowIndex;
                IdTribunal = Convert.ToInt32(GridTribunal["ID_TRIBUNAL", e.RowIndex].Value);
                IdContratoTribunal = Convert.ToInt32(GridTribunal["ID_CONTRATO_TRIBUNAL", e.RowIndex].Value);
                GridContratos.Enabled = true;
            }
            catch (Exception ee)
            {
                ColorTribunal = 0;
                MessageBox.Show(ee.ToString());
            }


        }
        private void GridContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool BandExisteTribunal = false;

            try
            {
                GridContratos.Rows[ColorContrato].DefaultCellStyle.BackColor = Color.White;
                GridContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorContrato = e.RowIndex;
                IdContrato = Convert.ToInt32(GridContratos["ID_CONTRATO", e.RowIndex].Value);
                //verificamos i no existe este docente en los tribunales ya designados en la defensa
                for (int i = 0; i < GridTribunal.Rows.Count; i++)
                {
                    if (IdContrato == Convert.ToInt32(GridTribunal["ID_CONTRATO_TRIBUNAL", i].Value))
                    {
                        BandExisteTribunal = true;
                    }
                }
                // 
                if (BandExisteTribunal == true)
                {
                    BtnCambioTribunal.Enabled = false;
                    MessageBox.Show("Los tribunales seleccionados deben ser diferentes a todos los que estan ya designados como tribunales en la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    GridDefensaProgramadas.Rows.Clear();
                }
                else
                {
                    //limpimaos el grid de defensas programadas para que se recarge de acuerdo al docente seleccionado
                    GridDefensaProgramadas.Rows.Clear();
                    
                    // cargamos las fechas y horas de las defensas que el tribunal ya tiene programadas
                    ObjTribunal.ID_DEFENSA=0;
                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.ID_CONTRATO=IdContrato;
                    ObjTribunal.HORA = null;
                    ObjTribunal.FECHA=Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                    DtDefensasProgramadas = ObjTribunal.SeleccionarTribunalCriterioBss();
                    for (int i = 0; i < DtDefensasProgramadas.Rows.Count; i++)
                    {
                        GridDefensaProgramadas.Rows.Add();
                        GridDefensaProgramadas["FECHA", i].Value = Convert.ToDateTime(DtDefensasProgramadas.Rows[i]["fecha"]).ToShortDateString();
                        GridDefensaProgramadas["HORA", i].Value = DtDefensasProgramadas.Rows[i]["hora"];
                    }

                    BtnCambioTribunal.Enabled = true;

                }
            }
            catch (Exception ee)
            {
                ColorContrato = 0;
                MessageBox.Show(ee.ToString());
            }

        }

        private void BtnCambioTribunal_Click(object sender, EventArgs e)
        {
            ObjTribunal.ESTADO = 1;
            ObjTribunal.ID_CONTRATO = IdContrato;
            ObjTribunal.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);

            if (ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count == 0)
            {
                if (MessageBox.Show("Seguro que desea cambiar el tribunal " + GridTribunal["NOMBRET", ColorTribunal].Value.ToString() + " " + GridTribunal["PATERNOT", ColorTribunal].Value.ToString() + " " + GridTribunal["MATERNOT", ColorTribunal].Value.ToString() + " por " + GridContratos["NOMBREC", ColorContrato].Value.ToString() + " " + GridContratos["PATERNOC", ColorContrato].Value.ToString() + " " + GridContratos["MATERNOC", ColorContrato].Value.ToString(), "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ObjTribunal.FECHA = null;//quitamos la fecha por que aun no se puede terminar con el cambio de fecha
                    
                    ObjTribunal.ID_DEFENSA = IdDefensaRecibido;
                    ObjTribunal.ID_TRIBUNAL = IdTribunal; 
             
                    ObjTribunal.ActrualizarTribunalBss();

                    DtTribunalDefensa = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                    GridTribunal = CargarTribunal(GridTribunal, DtTribunalDefensa);
                    GridTribunal = MarcarTribunales(GridTribunal);

                    GridContratos.Rows[ColorContrato].DefaultCellStyle.BackColor = Color.White;
                    GridContratos.Enabled = false;
                    BtnCambioTribunal.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El nuevo tribunal que intenta designar ya tiene una defensa programada para la misma fecha y hora", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }




        // funciones de cargado
        public DataGridView CargarTribunal(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRET", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNOT", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNOT", i].Value = dtX.Rows[i]["materno"];
                gridX["CIT", i].Value = dtX.Rows[i]["ci"];
                gridX["NOTAT", i].Value = dtX.Rows[i]["nota"];
                gridX["ID_TRIBUNAL", i].Value = dtX.Rows[i]["id_tribunal"];
                gridX["ID_CONTRATO_TRIBUNAL", i].Value = dtX.Rows[i]["id_contrato"];

            }

            return gridX;
        }
        public DataGridView CargarContratos(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBREC", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNOC", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNOC", i].Value = dtX.Rows[i]["materno"];
                gridX["CIC", i].Value = dtX.Rows[i]["ci"];
                gridX["ID_CONTRATO", i].Value = dtX.Rows[i]["id_contrato"];

            }

            return gridX;
        }
        public DataGridView CargarAulas(DataGridView gridX,DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["ID_AULA", i].Value = dtX.Rows[i]["id_aula"];
                gridX["NRO_AULA", i].Value = dtX.Rows[i]["n_aula"];
                gridX["CAPACIDAD", i].Value = dtX.Rows[i]["capacidad"];
                gridX["PISO", i].Value = dtX.Rows[i]["piso"];
            }
            return gridX;
        }
        public bool VerificarFechaHoraAula(string fechax, string horaX, int id_aulaX)
        {
            ObjDefensa.ESTADO = 1;
            ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(fechax);
            ObjDefensa.HORA = horaX;
            ObjDefensa.ID_AULA = id_aulaX;
            if (ObjDefensa.SeleccionarDefensaCriterioBss().Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            // quitamos los valores utilizados para la busqueda
            ObjDefensa.ESTADO = 0;
            ObjDefensa.FECHA = null;
            ObjDefensa.HORA = null;
            ObjDefensa.ID_AULA = 0;
        }
        public DataGridView MarcarTribunales(DataGridView GridTribunalX)
        {
            BandChoqueTribunal = false;
            //ciclo para verificar si existe algun tribunal con choque de defensa y marcarlo con color rojo
            for (int i = 0; i < GridTribunalX.Rows.Count; i++)
            {
                ObjTribunal.ID_DEFENSA = 0;
                ObjTribunal.ID_CONTRATO = Convert.ToInt32(GridTribunalX["ID_CONTRATO_TRIBUNAL", i].Value);
                ObjTribunal.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                ObjTribunal.HORA = TxtHora.Text;
                ObjTribunal.ESTADO = 1;

                if (ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count > 0)
                {
                    GridTribunalX.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    BandChoqueTribunal = true;
                }
                else
                {
                    GridTribunalX.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            // verificamos si exiten problemas con los tribunales y mostramos un mensaje ya sea bueno o malo
            if (BandChoqueTribunal == true)
            {
                LblMensajeTribunal.BackColor = Color.Red;
                LblMensajeTribunal.Text = "Hay problemas con los tribunales para esa fecha no se podra completar la actualizacion si no se cambian los tribunales";
                BtnFinalizarActualizacion.Enabled = false;
            }
            else
            {
                LblMensajeTribunal.BackColor = Color.Green;
                LblMensajeTribunal.Text = "No existe problema de choque de defensas para los tribunales, la actualizacion puede continuar sin cambiar tribunales";
                BtnFinalizarActualizacion.Enabled = true;
            }

            return GridTribunalX;

            

        }

        private void BtnFinalizarActualizacion_Click(object sender, EventArgs e)
        {
            ObjDefensa.ID_DEFENSA = IdDefensaRecibido;
            ObjDefensa.ID_AULA = IdAula;
            ObjDefensa.HORA = TxtHora.Text;
            ObjDefensa.ActualizarDefensaBss();
            MessageBox.Show("El cambio de fecha ha sido realizado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void BtnBuscarContrato_Click(object sender, EventArgs e)
        {
            ObjContrato.ESTADO = 1;

            if (TxtNombreT.Text != "")
            {
                ObjContrato.NOMBRE = TxtNombreT.Text.ToUpper();
            }
            if (TxtMaternoT.Text != "")
                ObjContrato.MATERNO = TxtMaternoT.Text.ToUpper();
            if (TxtPaternoT.Text != "")
                ObjContrato.PATERNO = TxtPaternoT.Text.ToUpper();
            if(TxtCiT.Text!="")
                ObjContrato.CI=TxtCiT.Text.ToUpper();

            DtContratos=ObjContrato.SeleccionarContratoCriterioBss();
            GridContratos=CargarContratos(GridContratos,DtContratos);

            ObjContrato.NOMBRE = null;
            ObjContrato.PATERNO = null;
            ObjContrato.MATERNO = null;
            ObjContrato.CI = null;
        }

        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        

       

        

        

        

        
        

        
    }
}
