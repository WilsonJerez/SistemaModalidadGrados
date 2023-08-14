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
    public partial class ActualizarModalidadII : Form
    {
        public ActualizarModalidadII()
        {
            InitializeComponent();
        }
        // objetos utilizados
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();

        // data tables para recuperas datos 
        DataTable DtModalidadII = new DataTable();
        DataTable DtTutor = new DataTable();
        

        DataTable DtTutoresUnidos = new DataTable();

        int ColorModalidad;
        int colorContrtato;

        int IdContrato;


        private void ActualizarModalidadII_Load(object sender, EventArgs e)
        {
            BtnCambiarTribunal.Enabled = false;

            //definimos columnas para unir  a los tutores con y sin tutorias
            DtTutoresUnidos.Columns.Add("id_contrato");
            DtTutoresUnidos.Columns.Add("nombre");
            DtTutoresUnidos.Columns.Add("paterno");
            DtTutoresUnidos.Columns.Add("materno");
            DtTutoresUnidos.Columns.Add("ci");
            DtTutoresUnidos.Columns.Add("n");
            // cargamos las modalidades 
            ObjModalidadII.ESTADO = 1;
            DtModalidadII = ObjModalidadII.SeleccionarModalidad_IICriterioBss("", "", "", "");
            DtGridModalidadII = CargarModalidadesII(DtGridModalidadII, DtModalidadII);

            // cargamos todos los tutores
            DtTutoresUnidos = UnirLosTutores(ObjContrato.TutoresConTutoriasBss(), ObjContrato.TutoresSinTutorias());
            GridContratos = CargarContratos(GridContratos,DtTutoresUnidos,"");            

            
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ColorModalidad = 0;
            GridContratos.Enabled = false;
            GridContratos.Rows[colorContrtato].DefaultCellStyle.BackColor = Color.White;
            IdContrato = 0;
            GriTutor.Rows.Clear();
            BtnCambiarTribunal.Enabled = false;

            string ConNombre="";
            string ConPaterno="";
            string ConMaterno="";
            string ConCi="";


            if (TxtNombre.Text != "")
                ConNombre = TxtNombre.Text.ToUpper();
            if (TxtPaterno.Text != "")
                ConPaterno = TxtPaterno.Text.ToUpper();
            if (TxtMaterno.Text != "")
                ConMaterno = TxtMaterno.Text.ToUpper();
            if (TxtCi.Text != "")
                ConCi = TxtCi.Text.ToUpper();

            ObjModalidadII.ESTADO = 1;

            DtModalidadII = ObjModalidadII.SeleccionarModalidad_IICriterioBss(ConNombre, ConPaterno, ConMaterno, ConCi);
            DtGridModalidadII = CargarModalidadesII(DtGridModalidadII, DtModalidadII);

            GridContratos.Enabled = false;

        }
        private void DtGridModalidadII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtGridModalidadII.Rows[ColorModalidad].DefaultCellStyle.BackColor = Color.White;
                DtGridModalidadII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorModalidad = e.RowIndex;

                ObjContrato.ID_CONTRATO = Convert.ToInt32(DtGridModalidadII["ID_CONTRATO", e.RowIndex].Value);
                DtTutor = ObjContrato.SeleccionarContratoPorIdBss();

                GriTutor = CargarTutor(GriTutor, DtTutor);

                GridContratos.Enabled = true;
            }
            catch (Exception ee)
            {
                ColorModalidad = 0;
                MessageBox.Show(ee.ToString());
            }
            
        }
        private void GridContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                GridContratos.Rows[colorContrtato].DefaultCellStyle.BackColor = Color.White;
                GridContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                colorContrtato = e.RowIndex;                
                IdContrato = Convert.ToInt32(GridContratos["ID_CONTRATOC", e.RowIndex].Value);
                BtnCambiarTribunal.Enabled = true;
            }
            catch (Exception ee)
            {
                colorContrtato = 0;
                MessageBox.Show(ee.ToString());
            }
        }
               

        private void BtnBuscarTutor_Click(object sender, EventArgs e)
        {
            string cmdbusqueda = "";
            string PorNumero = "n>=0";
            string PorNombre = "";
            string PorPaterno = "";
            string PorMaterno = "";
            string PorCi = "";


            if (TxtNombreTu.Text != "")
            {
                PorNombre = " AND nombre='" + TxtNombreTu.Text.ToUpper()+"'";
            }
            if (TxtPaternoTu.Text != "")
                PorPaterno = " AND paterno='" +TxtPaternoTu.Text.ToUpper()+"'";
            if (TxtMaternoTu.Text != "")
                PorMaterno = " AND materno='" +TxtMaternoTu.Text.ToUpper() + "'";
            if (TxtCiTu.Text != "")
                PorCi = " AND ci='" + TxtCiTu.Text + "'";

            cmdbusqueda = PorNumero + PorNombre + PorPaterno + PorMaterno + PorCi;
            GridContratos = CargarContratos(GridContratos, DtTutoresUnidos,cmdbusqueda);
        }
        private void BtnCambiarTribunal_Click(object sender, EventArgs e)
        {
            if (IdContrato > 0)
            {
                ObjModalidadII.ID_CONTRATO = IdContrato;
                ObjModalidadII.ID_MODALIDAD_II = Convert.ToInt32(DtGridModalidadII["ID_MODALIDAD_II", ColorModalidad].Value);
                ObjModalidadII.ActualizarModalidadIIBss();
                // recuperamos el nuevo tutor
                ObjContrato.ID_CONTRATO = IdContrato;
                DtTutor = ObjContrato.SeleccionarContratoPorIdBss();
                GriTutor = CargarTutor(GriTutor, DtTutor);
                // recargamos la lista de tutores
                DtTutoresUnidos = UnirLosTutores(ObjContrato.TutoresConTutoriasBss(), ObjContrato.TutoresSinTutorias());
                GridContratos = CargarContratos(GridContratos, DtTutoresUnidos, "");

               
                BtnCambiarTribunal.Enabled = false;
                IdContrato = 0;

                MessageBox.Show("El cambio de tutor se cumplio con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se puede cumplir la actualizacion no se ha seleccionado ningun tutor como suplente", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        


        // funcion para cargar las modalidades de grado
        public DataGridView CargarModalidadesII(DataGridView GridModaliadIIX, DataTable DtModalidadIIX)
        {
            GridModaliadIIX.Rows.Clear();
            for (int fila = 0; fila < DtModalidadIIX.Rows.Count; fila++)
            {
                GridModaliadIIX.Rows.Add();
                GridModaliadIIX["ID_MODALIDAD_II", fila].Value = DtModalidadIIX.Rows[fila]["id_modalidad_II"];
                GridModaliadIIX["NOMBRE", fila].Value = DtModalidadIIX.Rows[fila]["nombre"];
                GridModaliadIIX["PATERNO", fila].Value = DtModalidadIIX.Rows[fila]["paterno"];
                GridModaliadIIX["MATERNO", fila].Value = DtModalidadIIX.Rows[fila]["materno"];
                GridModaliadIIX["CI", fila].Value = DtModalidadIIX.Rows[fila]["ci"];
                GridModaliadIIX["ID_CONTRATO",fila].Value=DtModalidadIIX.Rows[fila]["id_contrato"];
            }
            return GridModaliadIIX;
        }
        public DataGridView CargarTutor(DataGridView gridTutorX, DataTable DtTutorX)
        {
            gridTutorX.Rows.Clear();
            for (int i = 0; i < DtTutorX.Rows.Count; i++)
            {
                gridTutorX.Rows.Add();
                gridTutorX["ID_CONTRATOT", i].Value = DtTutorX.Rows[i]["id_contrato"];
                gridTutorX["NOMBRET", i].Value = DtTutorX.Rows[i]["nombre"];
                gridTutorX["PATERNOT", i].Value = DtTutorX.Rows[i]["paterno"];
                gridTutorX["MATERNOT", i].Value = DtTutorX.Rows[i]["materno"];
                gridTutorX["CIT", i].Value = DtTutorX.Rows[i]["ci"];
            }
            return gridTutorX;
        }
        public DataGridView CargarContratos(DataGridView GridContratosX, DataTable DtcontratosX,string cmdbusqueda)
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
                DataRow[] filtracion =DtcontratosX.Select(cmdbusqueda);
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
        public DataTable UnirLosTutores(DataTable TutoresConTutorias,DataTable TutoresSinTutorias)
        {
            DtTutoresUnidos.Rows.Clear();
            int IndiceConTutorias =TutoresConTutorias.Rows.Count;
            int IndiceSinTutorias=TutoresSinTutorias.Rows.Count;
            int IndiceGeneral=0;
            for(int fila=0;fila<TutoresConTutorias.Rows.Count;fila++)
            {
                DtTutoresUnidos.Rows.Add();
                DtTutoresUnidos.Rows[IndiceGeneral]["id_contrato"] = TutoresConTutorias.Rows[fila]["id_contrato"];
                DtTutoresUnidos.Rows[IndiceGeneral]["nombre"] = TutoresConTutorias.Rows[fila]["nombre"];
                DtTutoresUnidos.Rows[IndiceGeneral]["paterno"] = TutoresConTutorias.Rows[fila]["paterno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["materno"] = TutoresConTutorias.Rows[fila]["materno"];
                DtTutoresUnidos.Rows[IndiceGeneral]["ci"] = TutoresConTutorias.Rows[fila]["ci"];
                DtTutoresUnidos.Rows[IndiceGeneral]["n"] = TutoresConTutorias.Rows[fila]["n"];

                IndiceGeneral++;
            }

            for(int fila=0;fila<TutoresSinTutorias.Rows.Count;fila++)
            {
                DtTutoresUnidos.Rows.Add();
                DtTutoresUnidos.Rows[ IndiceGeneral]["id_contrato"] = TutoresSinTutorias.Rows[fila]["id_contrato"];
                DtTutoresUnidos.Rows[ IndiceGeneral]["nombre"] = TutoresSinTutorias.Rows[fila]["nombre"];
                DtTutoresUnidos.Rows[ IndiceGeneral]["paterno"] = TutoresSinTutorias.Rows[fila]["paterno"];
                DtTutoresUnidos.Rows[ IndiceGeneral]["materno"] = TutoresSinTutorias.Rows[fila]["materno"];
                DtTutoresUnidos.Rows[ IndiceGeneral]["ci"] = TutoresSinTutorias.Rows[fila]["ci"];
                DtTutoresUnidos.Rows[ IndiceGeneral]["n"] = 0;
                IndiceGeneral++;
               
            }
            return DtTutoresUnidos;
        }

        







    }
}
