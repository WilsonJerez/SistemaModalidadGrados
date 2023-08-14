using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_III.ACTUALIZAR
{
    public partial class FinalizarCambioFecha : Form
    {
        public FinalizarCambioFecha()
        {
            InitializeComponent();
        }
        
        //funciones
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
        public DataGridView CargarAulas(DataGridView gridX, DataTable dtX)
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
        public DataGridView CargarTribunalesExternos(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRE_EX", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNO_EX", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNO_EX", i].Value = dtX.Rows[i]["materno"];
                gridX["CI_EX", i].Value = dtX.Rows[i]["ci"];                
                gridX["ID_TRIBUNAL_EX", i].Value = dtX.Rows[i]["id_tribunal_externo"];           

            }

            IdtribunalExternoActual = Convert.ToInt32(gridX["ID_TRIBUNAL_EX", 0].Value);
            return gridX;
        }
        public DataGridView CargarDefensasProgramadasTribunalInterno(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["FECHA", i].Value = Convert.ToDateTime(dtX.Rows[i]["fecha"].ToString()).ToString("dd/MM/yyyy");
                gridX["HORA", i].Value = dtX.Rows[i]["hora"];               

            }

            return gridX;
        }
        public DataGridView CargarTribunalExternoOpcional(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRE_TEX", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNO_TEX", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNO_TEX", i].Value = dtX.Rows[i]["materno"];
                gridX["CI_TEX", i].Value = dtX.Rows[i]["ci"];
                gridX["ID_TRIBUNAL_TEX", i].Value = dtX.Rows[i]["id_tribunal_externo"];

            }

            return gridX;
        }
        public DataGridView CargarDefensasProgramadasTribunalExterno(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["FECHA_EX", i].Value = Convert.ToDateTime(dtX.Rows[i]["fecha"].ToString()).ToString("dd/MM/yyyy");
                gridX["HORA_EX", i].Value = dtX.Rows[i]["hora"];

            }

            return gridX;
        }
        

        public bool VerificarFechaHoraAula(string fechax, string horaX, int id_aulaX)
        {
            
            bool retorno = false;
            //verificamos que no exista una defensa en el aula
            ObjDefensa.ESTADO = 1;
            ObjDefensa.FECHA = Convert.ToDateTime(fechax).ToString("MM/dd/yyyy");
            ObjDefensa.ID_AULA = id_aulaX;
            ObjDefensa.HORA = horaX;
            DataTable Dtauxiliar = ObjDefensa.SeleccionarDefensaCriterioBss();
            for (int i = 0; i < Dtauxiliar.Rows.Count; i++)
            {
                if (Convert.ToInt32(Dtauxiliar.Rows[i]["id_defensa"]) != IdDefensaRecibido)
                {
                    retorno = true;
                    
                }
            }
            if (retorno == true)
                TxtAula.BackColor = Color.Red;
            else
                TxtAula.BackColor = Color.White;
            //liberamos atributos
            ObjDefensa.ESTADO = 0;
            ObjDefensa.FECHA = null;
            ObjDefensa.ID_AULA = 0;
            ObjDefensa.HORA = null;
            return retorno;
        }
        public DataGridView MarcarTribunalesInternos(DataGridView GridTribunalX)
        {
            DataTable DtAux = new DataTable();
            bool bandera = false;

                for (int i = 0; i < GridTribunalX.Rows.Count; i++)
                {
                    bandera = false;

                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.ID_CONTRATO = Convert.ToInt32(GridTribunalX["ID_CONTRATO_TRIBUNAL", i].Value);
                    ObjTribunal.FECHA = Convert.ToDateTime(FechaRecibida).ToString("MM/dd/yyyy");
                    ObjTribunal.HORA = TxtHora.Text;

                    DtAux = ObjTribunal.SeleccionarTribunalCriterioBss();
                    for (int j = 0; j < DtAux.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(DtAux.Rows[j]["id_defensa"])!= IdDefensaRecibido)
                        {
                          GridTribunalX.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            bandera = true;
                        }

                    }
                    if (bandera == false)
                    {
                        GridTribunalX.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }

                }

                //cargamos el dtg auxiliar            
            
            
            ObjTribunal.ESTADO = 0;
            ObjTribunal.ID_CONTRATO = 0;
            ObjTribunal.FECHA = null;
            ObjTribunal.HORA = null;
            return GridTribunalX;
        }
        public DataGridView MarcarTribunalExterno(DataGridView GridTribunalExternoX)
        {
            bool Bandera = false;
            ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = IdtribunalExternoActual;
            DataTable Dtaux=ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy"), TxtHora.Text);

            
            for(int i=0;i<Dtaux.Rows.Count;i++)
            {
                if (Convert.ToInt32(Dtaux.Rows[i]["id_defensa"])!= IdDefensaRecibido)
                {
                    Bandera = true;
                }

            }

            if (Bandera == true)
            {
                GridTribunalExternoX.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            }
            else
                GridTribunalExternoX.Rows[0].DefaultCellStyle.BackColor = Color.White;

            return GridTribunalExternoX;
        }
        // variables necesarias para inciar el formulario
        public string FechaRecibida;
        public int IdDefensaRecibido;
        public int IdAulaRecibido;
        public string AulaRecibido;
        public string HoraRecibido;
        public bool SemaforoRetorno = false;
        public string DefensorRecibido;
        public int IdModIIIRecibido;



        //objetos utilizados
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Mod_III ObjModIII = new BSS.Bss_Mod_III();
        BSS.Bss_Tribunal_externo ObjTribunalExterno = new BSS.Bss_Tribunal_externo();

        // data tables utilizados para recuperar los datos
        DataTable DtTribunalDefensa = new DataTable();
        DataTable DtContratos = new DataTable();
        DataTable DtAulas = new DataTable();
        DataTable DtDefensasProgramadas = new DataTable();

        //variables para cambiar colores
        int IndiceAula = 0;
        int IndiceTribunalInterno=0;
        int IndiceContrato=0;
        int IndiceTribunalExternoReemplazo = 0;

        // variable para los ids recuperados localmente
        int IdAula;
        int IdTribunalInterno;
        int IdContrato;

        int IdtribunalExternoActual = 0;
        int IdTribunalExternoReemplazo = 0;

       
        //otras
        bool red = false;
       

        

        private void FinalizarCambioFecha_Load(object sender, EventArgs e)
        {
            

            IdAula = IdAulaRecibido;

            TxtFecha.Text = FechaRecibida;
            TxtDefensor.Text = DefensorRecibido;
            TxtAula.Text = AulaRecibido;
            TxtHora.Text = HoraRecibido;

            //cargamos los tribunales internos por id defensa
            ObjTribunal.ID_DEFENSA = IdDefensaRecibido;
            DtgTribunalInterno = CargarTribunal(DtgTribunalInterno, ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss());
            //liberamos atributos
            ObjTribunal.ID_DEFENSA = 0;
            //marcamos tribunales que tienen choque
            DtgTribunalInterno = MarcarTribunalesInternos(DtgTribunalInterno);

            //recuperamos el tribunal externo
            DtgTribuanlExterno=CargarTribunalesExternos(DtgTribuanlExterno,ObjTribunalExterno.SeleccionarTribunalExternoPorIdModIIIDal(IdModIIIRecibido));

            DtgTribuanlExterno = MarcarTribunalExterno(DtgTribuanlExterno);

            //verificamos choque de defensas en el aula
           


            //cargamos aulas
            ObjAula.ESTADO = 1;
            GridAulas = CargarAulas(GridAulas, ObjAula.SeleccionarAulaCriterioBss());

            

        }
        private void GridAulas_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridAulas.Rows[IndiceAula].DefaultCellStyle.BackColor = Color.White;
                
                IndiceAula = e.RowIndex;             
               
                IdAula = Convert.ToInt32(GridAulas["ID_AULA", e.RowIndex].Value);

                ObjDefensa.ESTADO=1;
                ObjDefensa.FECHA=Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy");
                ObjDefensa.HORA=TxtHora.Text;
                ObjDefensa.ID_AULA=IdAula;

                if (ObjDefensa.SeleccionarDefensaCriterioBss().Rows.Count==0)
                {
                    GridAulas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    
                }
                else
                {
                    IdAula = 0;
                    MessageBox.Show("El aula seleccionada no esta disponible para la fecha y hora dispuesta para la defensa, seleccione otra aula", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                ObjDefensa.ESTADO = 0;
                ObjDefensa.FECHA = null;
                ObjDefensa.HORA = null;
                ObjDefensa.ID_AULA = 0;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IndiceAula = 0;
                IdAula = 0;
                for (int i = 0; i < GridAulas.Rows.Count; i++)
                {
                    GridAulas.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        private void BtnBuscarAula_Click_(object sender, EventArgs e)
        {

        }

        private void BtnCambioHora_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea realizar el cambio de hora a la defensa?, el cambio de hora se guardara permanentemente para la defensa", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TxtHora.Text = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;

                ObjDefensa.ESTADO = 1;
                ObjDefensa.HORA = TxtHora.Text;
                ObjDefensa.ID_DEFENSA = IdDefensaRecibido;
                ObjDefensa.ActualizarDefensaBss();
                //liberamos atributos
                ObjDefensa.ESTADO = 0;
                ObjDefensa.HORA = null;
                ObjDefensa.ID_DEFENSA = 0;
                
                //corremos verificaciones
                VerificarFechaHoraAula(TxtFecha.Text, TxtHora.Text, IdAulaRecibido);
                DtgTribuanlExterno = MarcarTribunalExterno(DtgTribuanlExterno);
                DtgTribunalInterno = MarcarTribunalesInternos(DtgTribunalInterno);
                
            }

        }
        
        

        private void BtnCambioTribunal_Click_1(object sender, EventArgs e)
        {
            if (IdTribunalInterno > 0)
            {
                if (IdContrato > 0)
                {
                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.ID_DEFENSA = 0;
                    ObjTribunal.ID_CONTRATO = IdContrato;
                    ObjTribunal.FECHA = Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy");
                    ObjTribunal.HORA = TxtHora.Text;
                    if(ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count==0)
                    {
                        //liberamos atributos no necesarios
                        ObjTribunal.FECHA = null;
                        ObjTribunal.HORA = null;
                        
                    //actualizamos el tribunal interno
                    ObjTribunal.ID_TRIBUNAL = IdTribunalInterno;
                    ObjTribunal.ID_CONTRATO = IdContrato;
                    if (MessageBox.Show("Seguro que desea reemplazar al tribunal, al reemplazar cualquier tribunal la fecha de la defensa se actualizara automaticamente", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //actualizamos la defensa
                        ObjDefensa.ESTADO = 1;
                        ObjDefensa.HORA = TxtHora.Text;
                        ObjDefensa.FECHA =Convert.ToDateTime( TxtFecha.Text).ToString("MM/dd/yyyy");
                        ObjDefensa.ID_AULA = IdAula;
                        ObjDefensa.ID_DEFENSA = IdDefensaRecibido;
                        ObjDefensa.ActualizarDefensaBss();
                        //actualizamos el tribunal
                        ObjTribunal.ActrualizarTribunalBss();                     
                        

                    }
                    //liberamos atributos
                    ObjTribunal.ID_TRIBUNAL = 0;
                    ObjTribunal.ID_CONTRATO = 0;
                    ObjTribunal.ESTADO = 0;

                    //resfrescamos la lista de tribunales internos
                    ObjTribunal.ID_DEFENSA=IdDefensaRecibido;
                    DtgTribunalInterno = CargarTribunal(DtgTribunalInterno, ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss());
                    //verificamos choques de defensas
                    DtgTribunalInterno = MarcarTribunalesInternos(DtgTribunalInterno);
                    //liberamos atributo
                    ObjTribunal.ID_DEFENSA = 0;

                    IdTribunalInterno = 0;
                    IdContrato = 0;
                    }
                    else
                    {
                        MessageBox.Show("El tribunal que selecciono de reemplazo ya tiene una defensa programada para la misma fecha y hora", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("No seleccionó el tribunal de reemplazo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("No seleccione el tribunal que desea reemplazar", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }




        
        
       

        private void BtnFinalizarActualizacion_Click_1(object sender, EventArgs e)
        {
            bool BandTribunalInterno = false;
            bool BandTribunalExterno = false;
            bool BandAula = false;

            for (int i = 0; i < DtgTribunalInterno.Rows.Count; i++)
            {
                if (DtgTribunalInterno.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                    BandTribunalInterno = true;
            }
            for (int i = 0; i < DtgTribuanlExterno.Rows.Count; i++)
            {
                if (DtgTribuanlExterno.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                    BandTribunalExterno = true;
            }
            if (TxtAula.BackColor == Color.Red)
                BandAula = true;

            if (BandAula == false)
            {
                if (BandTribunalInterno == false)
                {
                    if (BandTribunalExterno == false)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El tribunal externo de la defensa tiene un choque de defensas, cambie la hora o fecha o tribunal para que se pueda concluir con la modificacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Aun hay problemas con los tribunales internos, debe realizar cambios de los tribunales marcados con rojo o no se podra concluir con la modificacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Aun hay problemas con el aula para la defensa, realice el cambio del aula o no se podra concluir con la actualizacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnBuscarContrato_Click_1(object sender, EventArgs e)
        {
            ObjContrato.ESTADO = 1;
            ObjContrato.NOMBRE = TxtNombreT.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoT.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoT.Text.ToUpper();
            DtgContratos.Enabled = true;
            DtgContratos = CargarContratos(DtgContratos, ObjContrato.SeleccionarContratoCriterioBss());            
            //liberamos atributos
            ObjContrato.ESTADO = 0;
            ObjContrato.NOMBRE = null;
            ObjContrato.PATERNO = null;
            ObjContrato.MATERNO = null;            
            
        }

        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void DtgContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtgContratos.Rows[IndiceContrato].DefaultCellStyle.BackColor = Color.White;
                DtgContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceContrato = e.RowIndex;
                //recuperamos id de contrato
                IdContrato = Convert.ToInt32(DtgContratos["ID_CONTRATO", e.RowIndex].Value);

                //recùpermos las defensas programadas
                ObjTribunal.ESTADO = 1;
                ObjTribunal.ID_CONTRATO = IdContrato;
                ObjTribunal.FECHA = Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy");
                DtgDefensasProgInternos=CargarDefensasProgramadasTribunalInterno(DtgDefensasProgInternos,ObjTribunal.SeleccionarTribunalCriterioBss());
                //liberamos atributos
                ObjTribunal.ESTADO = 0;
                ObjTribunal.ID_CONTRATO = 0;
                ObjTribunal.FECHA = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgContratos.Rows.Count;i++ )
                {
                    DtgContratos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                IdContrato = 0;
                IndiceContrato = 0;
            }
        }

        private void DtgTribunalInterno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (DtgTribunalInterno.Rows[IndiceTribunalInterno].DefaultCellStyle.BackColor != Color.Red)
                {
                    if (red == true)
                        DtgTribunalInterno.Rows[IndiceTribunalInterno].DefaultCellStyle.BackColor = Color.Red;
                    else
                    {
                        DtgTribunalInterno.Rows[IndiceTribunalInterno].DefaultCellStyle.BackColor = Color.White;
                    }
                }
                
                if (DtgTribunalInterno.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red)
                    red = true;
                else
                    red = false;

                DtgTribunalInterno.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceTribunalInterno = e.RowIndex;
                //recuperamos el id del tribunal interno
                IdTribunalInterno = Convert.ToInt32(DtgTribunalInterno["ID_TRIBUNAL", e.RowIndex].Value);

                //habilitamos el grid de contratos
                DtgContratos.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgTribunalInterno.Rows.Count; i++)
                {
                    DtgTribunalInterno.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                IndiceTribunalInterno = 0;
                IdTribunalInterno = 0;
            }
        }

        private void BtnBuscarTribunalExterno_Click(object sender, EventArgs e)
        {
            IndiceTribunalExternoReemplazo = 0;
            IdTribunalExternoReemplazo = 0;

            ObjTribunalExterno.ESTADO = 1;
            ObjTribunalExterno.CI = TxtCiEx.Text.ToUpper();
            ObjTribunalExterno.NOMBRE = TxtNombreEx.Text.ToUpper();
            ObjTribunalExterno.PATERNO = TxtPaternoEx.Text.ToUpper();
            ObjTribunalExterno.MATERNO = TxtMaternoEx.Text.ToUpper();
            DtgTribunalExternoOpcional = CargarTribunalExternoOpcional(DtgTribunalExternoOpcional, ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss());
            
        }

        private void DtgTribunalExternoOpcional_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtgTribunalExternoOpcional.Rows[IndiceTribunalExternoReemplazo].DefaultCellStyle.BackColor = Color.White;
                DtgTribunalExternoOpcional.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceTribunalExternoReemplazo = e.RowIndex;
                //recuperamos id
                IdTribunalExternoReemplazo = Convert.ToInt32(DtgTribunalExternoOpcional["ID_TRIBUNAL_TEX", e.RowIndex].Value);
                //recuperamos las fecha y hora de las defensas programadas del tribunal seleccionado
                ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = IdTribunalExternoReemplazo;
                DtgAgendaExterna = CargarDefensasProgramadasTribunalExterno(DtgAgendaExterna, ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy"),""));
                //liberamos atributos de dtribunal
                ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IdTribunalExternoReemplazo = 0;
                IndiceTribunalExternoReemplazo = 0;
                for (int i = 0; i < DtgTribunalExternoOpcional.Rows.Count; i++)
                {
                    DtgTribunalExternoOpcional.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    
                }
            }
        }

        private void BtnCambiarTribunalExterno_Click(object sender, EventArgs e)
        {
            //verificamos que no tenga defensa en la fecha y hora

                ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = IdTribunalExternoReemplazo;
                if (ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy"), TxtHora.Text).Rows.Count == 0)
                {
                    //actualizamos la defensa
                    ObjDefensa.ESTADO = 1;
                    ObjDefensa.FECHA = Convert.ToDateTime(TxtFecha.Text).ToString("MM/dd/yyyy");
                    ObjDefensa.HORA = TxtHora.Text;
                    ObjDefensa.ID_DEFENSA = IdDefensaRecibido;
                    //actualizamos la defensa
                    ObjDefensa.ActualizarDefensaBss();
                    //liberamos atributos de defensa 
                    ObjDefensa.ESTADO = 0;
                    ObjDefensa.FECHA = null;
                    ObjDefensa.HORA = null;
                    ObjDefensa.ID_DEFENSA = 0;
                    //actualizamos el tribunal de la defensa III
                    ObjModIII.ESTADO = 1;
                    ObjModIII.ID_TRIBUNAL_EXTERNO = IdTribunalExternoReemplazo;
                    ObjModIII.ID_MOD_III = IdModIIIRecibido;
                    ObjModIII.ActualizarModIIIBss();
                    //liberamos atributos de modIII
                    ObjModIII.ESTADO = 0;
                    ObjModIII.ID_TRIBUNAL_EXTERNO = 0;
                    //actualizamos el grid de tribunal externo                    
                    DtgTribuanlExterno = CargarTribunalesExternos(DtgTribuanlExterno, ObjTribunalExterno.SeleccionarTribunalExternoPorIdModIIIDal(IdModIIIRecibido));
                    ObjModIII.ID_MOD_III = 0;
                    //corremos las verificaciones correspondientes para que nada choque
                    DtgTribuanlExterno = MarcarTribunalExterno(DtgTribuanlExterno);
                }
                else
                {
                    ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = 0;
                    MessageBox.Show("El tribunal que desea establecer como reemplazo ya tiene una defensa programada para la misma fecha y hora", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
        }

        private void BtnCambiarAula_Click(object sender, EventArgs e)
        {
            if (IdAula > 0)
            {
                if (MessageBox.Show("Seguro que desea cambiar el aula para la defensa, una vez realizado el cambio este es permanente", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ObjDefensa.ESTADO = 1;
                    ObjDefensa.ID_AULA = IdAula;
                    ObjDefensa.ID_DEFENSA = IdDefensaRecibido;
                    ObjDefensa.ActualizarDefensaBss();


                    ObjDefensa.ESTADO = 0;
                    ObjDefensa.ID_AULA = 0;
                    ObjDefensa.ID_DEFENSA = 0;

                    TxtAula.Text = GridAulas["NRO_AULA", IndiceAula].Value.ToString();

                    VerificarFechaHoraAula(TxtFecha.Text, TxtHora.Text, IdAula);


                }
            }
            else
            {
                MessageBox.Show("Seleccione un aula para realizar el cambio de aula para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        

       

        

        

        

        

        
        

        

    }
}
