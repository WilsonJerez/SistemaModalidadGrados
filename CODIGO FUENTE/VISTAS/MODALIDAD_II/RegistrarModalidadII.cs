using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.MODALIDAD_II
{
    public partial class RegistrarModalidadII : Form
    {
        public RegistrarModalidadII()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_I ObjModaliadI = new BSS.Bss_Modalidad_I();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();

        //variables para recuperar los datos de Modalidades y tutores con y sin tutorias
        DataTable DtModalidadIAprovadas = new DataTable();
        DataTable DtTutores = new DataTable();
        DataTable DtTutroresCon = new DataTable();

        DataTable DtTutoresUnidos = new DataTable();

        //INDICES DE COLOR 
        int IndiceEstudiante;
        //int IndiceTutor;
        int ColorTutor;
        //int EstElimColor;
        
        // variables para los ids encontrados
        int IdModalidad_I;
        int IdTutor;

        //indice para la agregacion delista 
        //int IndiceAgregar;

        //variable para recuperar elindice del estudiante seleccionado a eliminar de la lista
        int EstudianteEliminar;

        // banderas para saber de que lista de tutor iso la seleccion
        bool BandTutoSin=false;
       

        private void RegistrarModalidadII_Load(object sender, EventArgs e)
        {
            //definimos columnas para unir  a los tutores con y sin tutorias
            DtTutoresUnidos.Columns.Add("id_contrato");
            DtTutoresUnidos.Columns.Add("nombre");
            DtTutoresUnidos.Columns.Add("paterno");
            DtTutoresUnidos.Columns.Add("materno");
            DtTutoresUnidos.Columns.Add("ci");
            DtTutoresUnidos.Columns.Add("n");
            DtTutoresUnidos.Columns.Add("estado");


            //cargamos grid estudiantes habilitados para la modalidad de grado 2
            DtModalidadIAprovadas = ObjModaliadI.SeleccionarModalidadesAprovadasBss();
            GridEstudiantes = CargarGridModalidadI(GridEstudiantes, DtModalidadIAprovadas, "");

            // cargamos los docentes que seran los tutores
            
            DtTutoresUnidos = UnirLosTutores(ObjContrato.TutoresConTutoriasBss(), ObjContrato.TutoresSinTutorias());
            GridTutores.Enabled = true;
            GridTutores = CargarContratos(GridTutores,DtTutoresUnidos,"");
            GridTutores.Enabled = false;
        }


        //funciones para cargar los grid de datos 
        public DataGridView CargarGridModalidadI(DataGridView gridX,DataTable dtX,string cmdsqlX)
        {
            
            gridX.Rows.Clear();

            if (cmdsqlX == "")
            {
                for (int i = 0; i < dtX.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_IE", i].Value = dtX.Rows[i]["id_modalidad_I"];
                    gridX["CIE", i].Value = dtX.Rows[i]["ci"];
                    gridX["NOMBREE", i].Value = dtX.Rows[i]["nombre"];
                    gridX["PATERNOE", i].Value = dtX.Rows[i]["paterno"];
                    gridX["MATERNOE", i].Value = dtX.Rows[i]["materno"];
                    gridX["TEMAE", i].Value = dtX.Rows[i]["tema"];
                    gridX["TIPO_MODALIDAD_I", i].Value = dtX.Rows[i]["tipo_modalidad"];
                }
            }
            else
            {
                DataRow [] Filtracion = dtX.Select(cmdsqlX);

                for (int i = 0; i < Filtracion.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_IE", i].Value = Filtracion[i]["id_modalidad_I"];
                    gridX["CIE", i].Value = Filtracion[i]["ci"];
                    gridX["NOMBREE", i].Value = Filtracion[i]["nombre"];
                    gridX["PATERNOE", i].Value = Filtracion[i]["paterno"];
                    gridX["MATERNOE", i].Value = Filtracion[i]["materno"];
                    gridX["TEMAE", i].Value = Filtracion[i]["tema"];
                    gridX["TIPO_MODALIDAD_I", i].Value = Filtracion[i]["tipo_modalidad"];
                }
            }

            return gridX;
        }

        public DataGridView CargarGridTutores(DataGridView dgX,DataTable dtX,string cmdsqlX)
        {
            dgX.Rows.Clear();
            if (cmdsqlX == "")
            {
                for (int i = 0; i < dtX.Rows.Count; i++)
                {
                    dgX.Rows.Add();
                    dgX["ID_CONTRATOT", i].Value = dtX.Rows[i]["id_contrato"];
                    dgX["CIT", i].Value = dtX.Rows[i]["ci"];
                    dgX["NOMBRET", i].Value = dtX.Rows[i]["nombre"];
                    dgX["PATERNOT", i].Value = dtX.Rows[i]["paterno"];
                    dgX["MATERNOT", i].Value = dtX.Rows[i]["materno"];
                    dgX["NRO_TUTORIAS", i].Value = "0";
                }
            }
            else
            {
                DataRow [] filtracion = dtX.Select(cmdsqlX);
                for (int i = 0; i < filtracion.Length; i++)
                {
                    dgX.Rows.Add();
                    dgX["ID_CONTRATOT", i].Value = filtracion[i]["id_contrato"];
                    dgX["CIT", i].Value = filtracion[i]["ci"];
                    dgX["NOMBRET", i].Value = filtracion[i]["nombre"];
                    dgX["PATERNOT", i].Value = filtracion[i]["paterno"];
                    dgX["MATERNOT", i].Value = filtracion[i]["materno"];
                    dgX["NRO_TUTORIAS", i].Value = "0";
                }
            }
            return dgX;
        }
        
        

        //CAPTURAMOS IDS
        private void GridEstudiantes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                
                    GridEstudiantes.Rows[IndiceEstudiante].DefaultCellStyle.BackColor = Color.White;
                    GridEstudiantes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    IdModalidad_I = Convert.ToInt32(GridEstudiantes["ID_MODALIDAD_IE", e.RowIndex].Value);
                    IndiceEstudiante = e.RowIndex;
                    GridTutores.Enabled = true;
                    // para habilitar btn añadir
                    if (IdTutor > 0 & IdModalidad_I > 0)
                    {
                        BtnAñadir.Enabled = true;
                    }
                
            }
            catch (Exception ee)
            {
                IndiceEstudiante = 0;
                MessageBox.Show(ee.ToString());
            }
        }

        private void GridTutores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridTutores.Rows[ColorTutor].DefaultCellStyle.BackColor = Color.White;
                GridTutores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorTutor = e.RowIndex;

                IdTutor = Convert.ToInt32(GridTutores["ID_CONTRATOC", e.RowIndex].Value);
                BtnAñadir.Enabled = true;
                
            }
            catch (Exception ee)
            {
                ColorTutor = 0;
                MessageBox.Show(ee.ToString());
            }
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            // para validad que se haya seleccionada un estudiante correctamente
            if (IdModalidad_I > 0)
            {
                // para validad que se haya seleccionado un tutor
                if (IdTutor > 0)
                {
                    if (MessageBox.Show("Seguro que desea registrar al estudiante " + GridEstudiantes["NOMBREE", IndiceEstudiante].Value.ToString() + "  " + GridEstudiantes["PATERNOE", IndiceEstudiante].Value.ToString() + "  " + GridEstudiantes["MATERNOE", IndiceEstudiante].Value.ToString() + " y asignarle el tutor " + GridTutores["NOMBREC", ColorTutor].Value.ToString() + "  " + GridTutores["PATERNOC", ColorTutor].Value.ToString() + "  " + GridTutores["MATERNOC", ColorTutor].Value.ToString(), "CONFIRME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //seteamos los datos de la modalidad 2
                        ObjModalidadII.ESTADO = 1;
                        ObjModalidadII.ID_CONTRATO = IdTutor;
                        ObjModalidadII.ID_MODALIDAD_I = IdModalidad_I;
                        ObjModalidadII.FECHA_INSCRIPCION = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToShortDateString());
                        //guardamos los datos de la modalidad 2
                        ObjModalidadII.InsertarModalidadIIBss();
                        //mostramos el mensaje de confirmacion 
                        MessageBox.Show("El registro fue completado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //refrescamos la lista de tutores para actualizar su nro de tutorias 
                        DtTutoresUnidos = UnirLosTutores(ObjContrato.TutoresConTutoriasBss(), ObjContrato.TutoresSinTutorias());
                        GridTutores = CargarContratos(GridTutores, DtTutoresUnidos, "");
                        // refrescamos la lista de modalidades de grado I
                        DtModalidadIAprovadas = ObjModaliadI.SeleccionarModalidadesAprovadasBss();
                        GridEstudiantes = CargarGridModalidadI(GridEstudiantes, DtModalidadIAprovadas, "");

                        // reiniciamos los ids
                        IdModalidad_I = 0;
                        IdTutor = 0;

                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleecionado un Tutor para el estudiante, es requisito para el registro de un estudiante a la Modalidad de grado II", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Estudiante para la modalidad_I", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
            

       

        
        // botones para hacer las filtraciones de tutores sin tutorias desde el datatable dttutores 
        private void BtnFiltrarTuS_Click(object sender, EventArgs e)
        {
            string select = " estado=1 ";
            string ByCiTuS = "";
            string ByNombreTuS = "";
            string ByPaternoTuS = "";
            string ByMaternoTuS = "";

            if (TxtCiTuS.Text != "")
            {
                ByCiTuS = " AND ci="+TxtCiTuS.Text.ToUpper();
            }
            if (TxtNombreTuS.Text != "")
            {
                ByNombreTuS = " AND nombre='" + TxtNombreTuS.Text.ToUpper() + "'";
            }
            if (TxtPaternoTuS.Text != "")
            {
                ByPaternoTuS = " AND paterno='" + TxtPaternoTuS.Text.ToUpper() + "'";
            }
            if (TxtMaternoTuS.Text != "")
            {
                ByMaternoTuS = " AND materno='" + TxtMaternoTuS.Text.ToUpper() + "'";
            }

            GridTutores = CargarContratos(GridTutores, DtTutoresUnidos, select + ByCiTuS + ByNombreTuS + ByPaternoTuS + ByMaternoTuS);
        }
        // boton para filtar los tutores con tutorias desde el datatable dttutorescon
        
 
        //boton para filtrar los estudiantes habilitados para la modalidad de grado 2

        private void BtnFiltrarEst_Click(object sender, EventArgs e)
        {
            string select = " estado=1 ";
            string ByCE = "";
            string ByNombreE = "";
            string ByPaternoE = "";
            string ByMaternoE = "";

            if (TxtCiEst.Text != "")
            {
                ByCE = " AND ci=" + TxtCiEst.Text.ToUpper();
            }
            if (TxtNombreEst.Text != "")
            {
                ByNombreE = " AND nombre='" + TxtNombreEst.Text.ToUpper() + "'";
            }
            if (TxtPaternoEst.Text != "")
            {
                ByPaternoE = " AND paterno='" + TxtPaternoEst.Text.ToUpper() + "'";
            }
            if (TxtMaternoEst.Text != "")
            {
                ByMaternoE = " AND materno='" + TxtMaternoEst.Text.ToUpper() + "'";
            }
            GridEstudiantes = CargarGridModalidadI(GridEstudiantes, DtModalidadIAprovadas, select+ByCE+ByNombreE+ByPaternoE+ByMaternoE);
        }
        /////////////////////////////////////////////////////////////////////////
        public DataGridView CargarContratos(DataGridView GridContratosX, DataTable DtcontratosX, string cmdbusqueda)
        {
            GridContratosX.Rows.Clear();
            if (cmdbusqueda == "")
            {
                for (int i = 0; i < DtcontratosX.Rows.Count; i++)
                {
                    GridContratosX.Rows.Add();
                    GridContratosX["ID_CONTRATOC", i].Value = DtcontratosX.Rows[i]["id_contrato"];
                    GridContratosX["NOMBREC", i].Value = DtcontratosX.Rows[i]["nombre"];
                    GridContratosX["PATERNOC", i].Value = DtcontratosX.Rows[i]["paterno"];
                    GridContratosX["MATERNOC", i].Value = DtcontratosX.Rows[i]["materno"];
                    GridContratosX["CIC", i].Value = DtcontratosX.Rows[i]["ci"];
                    GridContratosX["NRO_TUTORIAS", i].Value = DtcontratosX.Rows[i]["n"];

                }
            }
            else
            {
                DataRow[] filtracion = DtcontratosX.Select(cmdbusqueda);
                for (int i = 0; i < filtracion.Length; i++)
                {
                    GridContratosX.Rows.Add();
                    GridContratosX["ID_CONTRATOC", i].Value = filtracion[i]["id_contrato"];
                    GridContratosX["NOMBREC", i].Value = filtracion[i]["nombre"];
                    GridContratosX["PATERNOC", i].Value = filtracion[i]["paterno"];
                    GridContratosX["MATERNOC", i].Value = filtracion[i]["materno"];
                    GridContratosX["CIC", i].Value = filtracion[i]["ci"];
                    GridContratosX["NRO_TUTORIAS", i].Value = filtracion[i]["n"];

                }
            }
            return GridContratosX;
        }
        public DataTable UnirLosTutores(DataTable TutoresConTutorias, DataTable TutoresSinTutorias)
        {
            DtTutoresUnidos.Rows.Clear();
            int IndiceConTutorias = TutoresConTutorias.Rows.Count;
            int IndiceSinTutorias = TutoresSinTutorias.Rows.Count;
            int IndiceGeneral = 0;
            for (int fila = 0; fila < TutoresConTutorias.Rows.Count; fila++)
            {
                DtTutoresUnidos.Rows.Add();
                DtTutoresUnidos.Rows[IndiceGeneral]["id_contrato"] = TutoresConTutorias.Rows[fila]["id_contrato"];
                DtTutoresUnidos.Rows[IndiceGeneral]["nombre"] = TutoresConTutorias.Rows[fila]["nombre"];
                DtTutoresUnidos.Rows[IndiceGeneral]["paterno"] = TutoresConTutorias.Rows[fila]["paterno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["materno"] = TutoresConTutorias.Rows[fila]["materno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["ci"] = TutoresConTutorias.Rows[fila]["ci"];
                DtTutoresUnidos.Rows[IndiceGeneral]["n"] = TutoresConTutorias.Rows[fila]["n"];
                DtTutoresUnidos.Rows[IndiceGeneral]["estado"] = TutoresConTutorias.Rows[fila]["estado"];

                IndiceGeneral++;
            }

            for (int fila = 0; fila < TutoresSinTutorias.Rows.Count; fila++)
            {
                DtTutoresUnidos.Rows.Add();
                DtTutoresUnidos.Rows[IndiceGeneral]["id_contrato"] = TutoresSinTutorias.Rows[fila]["id_contrato"];
                DtTutoresUnidos.Rows[IndiceGeneral]["nombre"] = TutoresSinTutorias.Rows[fila]["nombre"];
                DtTutoresUnidos.Rows[IndiceGeneral]["paterno"] = TutoresSinTutorias.Rows[fila]["paterno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["materno"] = TutoresSinTutorias.Rows[fila]["materno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["ci"] = TutoresSinTutorias.Rows[fila]["ci"];
                DtTutoresUnidos.Rows[IndiceGeneral]["n"] = 0;
                DtTutoresUnidos.Rows[IndiceGeneral]["estado"]=TutoresSinTutorias.Rows[fila]["estado"];
                IndiceGeneral++;

            }
            return DtTutoresUnidos;
        }
       


        

        

        
    }
}
