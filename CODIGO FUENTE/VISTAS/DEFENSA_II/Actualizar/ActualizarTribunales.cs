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
    public partial class ActualizarTribunales : Form
    {
        public ActualizarTribunales()
        {
            InitializeComponent();
        }
        //OBJETOS UTILIZADOS
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        // DATA TABLES PARA RECUPERAR LOS DATOS
        DataTable DtDefensas = new DataTable();
        DataTable DtTribunalesDefensa = new DataTable();
        DataTable DtContratos = new DataTable();
        DataTable DtDefensasProgramadas = new DataTable();
        // VARIABLES PARA CAPTURAR LOS DS 
        int IdDefensa;
        int IdTribunal;
        int IdContrato;
        int IdAula;
        //variables utilizadas para cambiar elcolor
        int ColorDefensa;
        int ColorTribunal;
        int ColorContrato;
        // otras
        bool BandExiste = false;
        string FechaDefensa;
        private void BtnFiltrarDefensa_Click(object sender, EventArgs e)
        {
            if (TxtCi.Text != "" & Validaciones.ci(TxtCi.Text) == true)
            {
                // seteamos la fecha para que se realicen la busqueda de las defensas cuyas fechas sean mayor a la actual 
                // solo seteamos feha por que los demas criterios de busqueda son pasados por parametros por que no son parte de los atributos de defensa pero fecha si lo es 
                ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), Convert.ToInt32(TxtCi.Text),1,0);
            }
            else
            {
                if (TxtCi.Text != "")
                {
                    MessageBox.Show("El ci es incorrecto, se mostraran todas las defensas ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 0,1,0);
            }
            GridDefensa = CargarDefensas(GridDefensa, DtDefensas);

           
            
        }

        private void GridDefensa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridDefensa.Rows[ColorDefensa].DefaultCellStyle.BackColor = Color.White;
                GridDefensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorDefensa = e.RowIndex;
                //recuperamos la fecha y el id de la defensa
                FechaDefensa = GridDefensa["FECHA_DEFENSA", e.RowIndex].Value.ToString();
                IdDefensa = Convert.ToInt32(GridDefensa["ID_DEFENSA", e.RowIndex].Value);
                // buscamos los tribunales de  la defensa y los cargamos al grid de tribunales
                ObjTribunal.ID_DEFENSA = IdDefensa;
                DtTribunalesDefensa = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                GridTribunal = CargarTribunal(GridTribunal, DtTribunalesDefensa);

                // HABILITAMOS LOS FORMULARIOS SIGUIENTES
                GridTribunal.Enabled = true;

            }
            catch (Exception ee)
            {
                ColorDefensa = 0;
                MessageBox.Show(ee.ToString());
            }
        }

        private void ActualizarTribunales_Load(object sender, EventArgs e)
        {
            ObjContrato.ESTADO=1;
            DtContratos = ObjContrato.SeleccionarContratoCriterioBss();
            GridContratos = CargarContratos(GridContratos, DtContratos);
        }

        private void GridTribunal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridTribunal.Rows[ColorTribunal].DefaultCellStyle.BackColor = Color.White;
                GridTribunal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorTribunal = e.RowIndex;
                IdTribunal = Convert.ToInt32(GridTribunal["ID_TRIBUNAL", e.RowIndex].Value);

                // habilitamos el siguiente formulario
                GridContratos.Enabled = true;
            }
            catch (Exception ee)
            {
                ColorTribunal = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            ObjContrato.ESTADO = 1;
            ObjContrato.NOMBRE = TxtNombreT.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoT.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoT.Text.ToUpper();
            ObjContrato.CI = TxtCiT.Text.ToUpper();
            DtContratos = ObjContrato.SeleccionarContratoCriterioBss();
            GridContratos = CargarContratos(GridContratos, DtContratos);
        }

        private void GridContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridContratos.Rows[ColorContrato].DefaultCellStyle.BackColor = Color.White;
                GridContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IdContrato = Convert.ToInt32(GridContratos["ID_CONTRATO", e.RowIndex].Value);
                ColorContrato = e.RowIndex;
                // buscamos todas las defensas programadas para el docente que sera el nuevo tribunal para verificar que no exita choque con otra defensa
                //cargamos los valores para la busqueda
                ObjTribunal.ID_CONTRATO = IdContrato;
                ObjTribunal.FECHA=Validaciones.ConvertirFechaSql2005_MMDDAA( FechaDefensa);
                ObjTribunal.ESTADO = 1;
                DtDefensasProgramadas=ObjTribunal.SeleccionarTribunalCriterioBss();
                //verificamos que el contrato del docente para reemplazar sea diferente al todos  lo que ya son tribunales en la defensa
                for (int i = 0; i < GridTribunal.Rows.Count; i++)
                {
                    if (IdContrato == Convert.ToInt32(GridTribunal["ID_CONTRATO_TRIBUNAL", i].Value))
                        BandExiste = true;
                }
                if (BandExiste == false)
                {
                    //limpimaos el grid de defensas programadas para que se recarge de acuerdo al docente seleccionado
                    GridDefensaProgramadas.Rows.Clear();
                    // cargamos las fechas y horas de las defensas que el tribunal ya tiene programadas
                    for (int i = 0; i < DtDefensasProgramadas.Rows.Count; i++)
                    {
                        GridDefensaProgramadas.Rows.Add();
                        GridDefensaProgramadas["FECHA", i].Value = Convert.ToDateTime(DtDefensasProgramadas.Rows[i]["fecha"]).ToShortDateString();
                        GridDefensaProgramadas["HORA", i].Value = DtDefensasProgramadas.Rows[i]["hora"];
                    }

                    //habilitamos el boton actualizar tribunal
                    BtnActualizar.Enabled = true;
                }
                else
                {
                    BandExiste = false;
                    BtnActualizar.Enabled = false;
                    MessageBox.Show("El academico de reemplazo debe ser diferente de todos los academico ya designados como tribunales", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ee)
            {
                ColorContrato = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            

            //cargamos datos de la defensa como ser la fecha y la hora para verificar que el tribunal no tenga choque de defensa
            ObjTribunal.ID_CONTRATO = IdContrato;
            ObjTribunal.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA(GridDefensa["FECHA_DEFENSA", ColorDefensa].Value.ToString());
            ObjTribunal.HORA = GridDefensa["HORA_DEFENSA", ColorDefensa].Value.ToString();

            if (ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count > 0)
            {
                MessageBox.Show("El tribunal que eligio para sustituir ya tiene una defensa para la misma fecha y hora", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ObjTribunal.FECHA = null;
                ObjTribunal.HORA = null;
                ObjTribunal.ID_DEFENSA = 0;                
                ObjTribunal.ID_TRIBUNAL = IdTribunal;
                                
                if (MessageBox.Show("Seguro que desa reemplazar el tribunal " + GridTribunal["NOMBRET", ColorTribunal].Value.ToString() + " " + GridTribunal["PATERNOT", ColorTribunal].Value.ToString() + GridTribunal["MATERNOT", ColorTribunal].Value.ToString() + "  POR  " + GridContratos["NOMBREC", ColorContrato].Value.ToString() + " " + GridContratos["PATERNOC", ColorContrato].Value.ToString() + " " + GridContratos["MATERNOC", ColorContrato].Value.ToString(), "CONFIRME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ObjTribunal.ActrualizarTribunalBss();
                    MessageBox.Show("El tribunal para la defensa fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ObjTribunal.ID_DEFENSA = IdDefensa;
                    // quitamos los atributos de tribunal utilizados para actualizar tribunal
                    ObjTribunal.ID_CONTRATO = 0;
                    ObjTribunal.ID_TRIBUNAL = 0;
                    // seteamos el id de defensa para actualizar el grid de los tribunales de la defensa
                    DtTribunalesDefensa = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                    GridTribunal = CargarTribunal(GridTribunal, DtTribunalesDefensa);
                    GridContratos.Rows[ColorContrato].DefaultCellStyle.BackColor = Color.White;
                    IdContrato = 0;
                    GridContratos.Enabled = false;
                    BtnActualizar.Enabled = false;
                }
            }

        }

        // metodos para cargar los grids
        public DataGridView CargarDefensas(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRE", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNO", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNO", i].Value = dtX.Rows[i]["materno"];
                gridX["CI", i].Value = dtX.Rows[i]["ci"];
                gridX["FECHA_DEFENSA", i].Value = Convert.ToDateTime(dtX.Rows[i]["fecha"]).ToShortDateString();
                gridX["ID_DEFENSA", i].Value = dtX.Rows[i]["id_defensa"];
                gridX["HORA_DEFENSA", i].Value = dtX.Rows[i]["hora"];
                if (Convert.ToInt32( dtX.Rows[i]["estado"])== 1)
                {
                    gridX["ESTADO", i].Value = "Pendiente";
                }
                else
                {
                    gridX["ESTADO", i].Value = "Defendida";
                }
                //gridX["NOTA", i].Value = dtX.Rows[i]["nota"];
            }
            return gridX;
        }
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

        

        

       

        

        

        

        
    }
}
