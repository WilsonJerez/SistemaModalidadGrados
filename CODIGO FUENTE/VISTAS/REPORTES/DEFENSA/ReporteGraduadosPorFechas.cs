using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.DEFENSA
{
    public partial class ReporteGraduadosPorFechas : Form
    {
        public ReporteGraduadosPorFechas()
        {
            InitializeComponent();
        }

        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        DataTable DtCabeceraGraduadosPorFechas = new DataTable();
        DataTable DtCuerpoReporteGraduadoPorFechas = new DataTable();

        VISTAS.REPORTES.DEFENSA.CrReporteGraduadosPorFechas CrGraduadosPorFechas=new CrReporteGraduadosPorFechas();


        private void ReporteGraduadosPorFechas_Load(object sender, EventArgs e)
        {
            DtCabeceraGraduadosPorFechas.Columns.Add("facultad");
            DtCabeceraGraduadosPorFechas.Columns.Add("coordinador");
            DtCabeceraGraduadosPorFechas.Columns.Add("fecha1");
            DtCabeceraGraduadosPorFechas.Columns.Add("fecha2");
            DtCabeceraGraduadosPorFechas.Columns.Add("nro_graduados");
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (Validaciones.fecha(TxtFecha1.Text) == true)
            {
                TxtFecha1.BackColor = Color.White;
                if (Validaciones.fecha(TxtFecha2.Text) == true)
                {
                    TxtFecha2.BackColor = Color.White;

                    //cargamos la cabecera del informe
                    DtCabeceraGraduadosPorFechas.Rows.Clear();
                    DtCabeceraGraduadosPorFechas.Rows.Add();
                    DtCabeceraGraduadosPorFechas.Rows[0]["fecha1"] = TxtFecha1.Text;
                    DtCabeceraGraduadosPorFechas.Rows[0]["fecha2"] = TxtFecha2.Text;
                    DtCabeceraGraduadosPorFechas.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                    DtCabeceraGraduadosPorFechas.Rows[0]["facultad"] = DAL.Dal_Login.facultad;

                    //cargamos el cuerpo del informe
                    DtCuerpoReporteGraduadoPorFechas = ObjDefensa.ReporteEstudiantesGraduadosRangoFechasBss(Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha1.Text), Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha2.Text));

                    // cargamos el nro de registros a la cabecera
                    DtCabeceraGraduadosPorFechas.Rows[0]["nro_graduados"] = DtCuerpoReporteGraduadoPorFechas.Rows.Count;

                    // mostramos el informe
                    CrGraduadosPorFechas.Database.Tables["CABEZ_GRADUADOS_POR_FECHAS"].SetDataSource(DtCabeceraGraduadosPorFechas);
                    CrGraduadosPorFechas.Database.Tables["GRADUADOS_POR_FECHAS"].SetDataSource(DtCuerpoReporteGraduadoPorFechas);
                    CrvReporteGraduados.ReportSource = CrGraduadosPorFechas;
                }
                else
                {
                    TxtFecha2.BackColor = Color.Red;
                    MessageBox.Show("La fecha 2 no cumple el formato de fecha exigido por el sistema, ej. dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                TxtFecha1.BackColor = Color.Red;
                MessageBox.Show("La fecha 1 no cumple el formato de fecha exigido por el sistema, ej. dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
