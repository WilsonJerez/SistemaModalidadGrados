using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.MODALIDAD_II
{
    public partial class RepModalidadIIPorTutor : Form
    {
        public RepModalidadIIPorTutor()
        {
            InitializeComponent();
        }

        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();

        DataTable DtTutores = new DataTable();
        DataTable DtCabezaReporte = new DataTable();
        DataTable DtTutoreados = new DataTable();

        DataTable DtTutoriasCuerpo = new DataTable();
        DataTable DtFechas = new DataTable();

        int IndiceColor;
        int idContrato;

        VISTAS.REPORTES.MODALIDAD_II.PorTutor PortutorRpt = new PorTutor();

        private void RepModalidadIIPorTutor_Load(object sender, EventArgs e)
        {
            // columnas de la cabeza del reporte
            DtCabezaReporte.Columns.Add("ci");
            DtCabezaReporte.Columns.Add("nombre");
            DtCabezaReporte.Columns.Add("paterno");
            DtCabezaReporte.Columns.Add("materno");
            DtCabezaReporte.Columns.Add("nro_tutoreados");
            DtCabezaReporte.Columns.Add("facultad");
            DtCabezaReporte.Columns.Add("coordinador");
            
            // columnas del cuerpo del reporte
            DtTutoriasCuerpo.Columns.Add("ci");
            DtTutoriasCuerpo.Columns.Add("nombre");
            DtTutoriasCuerpo.Columns.Add("paterno");
            DtTutoriasCuerpo.Columns.Add("materno");
            DtTutoriasCuerpo.Columns.Add("fecha_ultimo_informe");


            BtnGenReporte.Enabled = false;
        }

        private void BtnFiltrar_Click_1(object sender, EventArgs e)
        {
            ObjContrato.ESTADO = 1;
            if (TxtCi.Text != "")
            {
                ObjContrato.CI = TxtCi.Text;
            }
            else
            {
                ObjContrato.CI = null;
            }
            if (dd.Text != "")
            {
                ObjContrato.NOMBRE = TxtNombre.Text.ToUpper();
            }
            else
            {
                ObjContrato.NOMBRE = null;
            }
            if (ss.Text != "")
            {
                ObjContrato.PATERNO = Txtpaterno.Text.ToUpper();
            }
            else
            {
                ObjContrato.PATERNO = null;
            }
            if (dddd.Text != "")
            {
                ObjContrato.MATERNO = TxtMaterno.Text.ToUpper();
            }
            else
            {
                ObjContrato.MATERNO = null;
            }
            IndiceColor = 0;
            DtTutores = ObjContrato.SeleccionarContratoCriterioBss();
            GvTutores = CargarTutor(GvTutores, DtTutores);
        }

        

        private void GvTutores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtCabezaReporte.Rows.Clear();

                GvTutores.Rows[IndiceColor].DefaultCellStyle.BackColor = Color.White;
                GvTutores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColor = e.RowIndex;

                idContrato = Convert.ToInt32(GvTutores["ID_CONTRATO", e.RowIndex].Value);

                DtCabezaReporte.Rows.Add();
                DtCabezaReporte.Rows[0]["ci"] = GvTutores["CI", e.RowIndex].Value.ToString();
                DtCabezaReporte.Rows[0]["nombre"] = GvTutores["NOMBRE", e.RowIndex].Value.ToString();
                DtCabezaReporte.Rows[0]["paterno"] = GvTutores["PATERNO", e.RowIndex].Value.ToString();
                DtCabezaReporte.Rows[0] ["materno"]= GvTutores["MATERNO", e.RowIndex].Value.ToString();
                BtnGenReporte.Enabled = true;
            }
            catch (Exception ex)
            {
                GvTutores.Rows[IndiceColor].DefaultCellStyle.BackColor = Color.White;
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnGenReporte_Click(object sender, EventArgs e)
        {
    
            DtTutoriasCuerpo.Rows.Clear();

            ObjModalidadII.ID_CONTRATO = idContrato;
            DtTutoreados = ObjModalidadII.ReporteModalidadIIPortutorBss();

            for (int fila = 0; fila < DtTutoreados.Rows.Count; fila++)
            {
                ObjCronograma.ID_MODALIDAD_II=Convert.ToInt32(DtTutoreados.Rows[fila]["id_contrato"]);
                DtFechas = ObjCronograma.SeleccionarCronogramaCriterioBss();

                DtTutoriasCuerpo.Rows.Add();
                DtTutoriasCuerpo.Rows[fila]["ci"] = DtTutoreados.Rows[fila]["ci"];
                DtTutoriasCuerpo.Rows[fila]["nombre"]=DtTutoreados.Rows[fila]["nombre"];
                DtTutoriasCuerpo.Rows[fila]["paterno"]=DtTutoreados.Rows[fila]["paterno"];
                DtTutoriasCuerpo.Rows[fila]["materno"]=DtTutoreados.Rows[fila]["materno"];
                DtTutoriasCuerpo.Rows[fila]["fecha_ultimo_informe"] = SacarFechaFinalizacion(DtFechas);
            }

            //completamos las cabecera del informe
            DtCabezaReporte.Rows[0]["nro_tutoreados"] = DtTutoriasCuerpo.Rows.Count;
            DtCabezaReporte.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabezaReporte.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            //cargamos el dataset para el reporte
            PortutorRpt.Database.Tables["MODALIDAD_II_TUTOR"].SetDataSource(DtTutoriasCuerpo);
            PortutorRpt.Database.Tables["CABEZA_MODALIDAD_II_TUTOR"].SetDataSource(DtCabezaReporte);
            CrvPorTutor.ReportSource = PortutorRpt;

            BtnGenReporte.Enabled = false;

            
        }
        public DataGridView CargarTutor(DataGridView GvTutorX, DataTable DtTutoresX)
        {
            GvTutorX.Rows.Clear();
            for (int fi = 0; fi < DtTutoresX.Rows.Count; fi++)
            {
                GvTutorX.Rows.Add();
                GvTutorX["ID_CONTRATO", fi].Value = DtTutoresX.Rows[fi]["id_contrato"];
                GvTutorX["CI", fi].Value = DtTutoresX.Rows[fi]["ci"];
                GvTutorX["NOMBRE", fi].Value = DtTutoresX.Rows[fi]["nombre"];
                GvTutorX["PATERNO", fi].Value = DtTutoresX.Rows[fi]["paterno"];
                GvTutorX["MATERNO", fi].Value = DtTutoresX.Rows[fi]["materno"];
            }
            return GvTutorX;
        }
        public string SacarFechaFinalizacion(DataTable DtFechasX)
        {
           DateTime fecha=Convert.ToDateTime("01/01/1000");
            if (DtFechasX.Rows.Count > 0)
            {
                for (int fi = 0; fi < DtFechasX.Rows.Count; fi++)
                {
                    if (Convert.ToDateTime(DtFechasX.Rows[fi]["fecha"]) > fecha)
                    {
                        fecha = Convert.ToDateTime(DtFechasX.Rows[fi]["fecha"]);
                    }
                }
                return fecha.ToString(); ;
            }
            else
            {
                return "sin cronograma";
            }
        }

        
        
    }
}
