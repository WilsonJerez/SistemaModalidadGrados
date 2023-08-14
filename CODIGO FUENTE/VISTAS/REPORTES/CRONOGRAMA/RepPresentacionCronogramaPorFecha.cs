using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.CRONOGRAMA
{
    public partial class RepPresentacionCronogramaPorFecha : Form
    {
        public RepPresentacionCronogramaPorFecha()
        {
            InitializeComponent();
        }
        //objetos utilizdos
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();
        VISTAS.REPORTES.CRONOGRAMA.CrPresentacionCronogramaPorFecha CrCro = new CrPresentacionCronogramaPorFecha();
        //data table para la cabecera del reporte
        DataTable DtCabecera = new DataTable();
        //data table para recuperar el reporte
        DataTable DtReporte = new DataTable();
        private void RepPresentacionCronogramaPorFecha_Load(object sender, EventArgs e)
        {
            //recuperamos la fecha de hoy
            TxtFechaHoy.Text = DAL.Dal_Login.fecha.ToShortDateString();
            //Agregamos las columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("fecha");
            DtCabecera.Columns.Add("nro_registros");
            //agregamos una fila pra la cabecera
            DtCabecera.Rows.Add();

        }
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (RdbHoy.Checked == true)
            {
                TxtFechaOtra.BackColor = Color.White;
                //cargamos la fecha para la busqueda
                ObjCronograma.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFechaHoy.Text);
                //recuperamos el reporte
                DtReporte = ObjCronograma.ReportePresentacionCronogramaParaLaFechaBss();
                //cargamos la cabecera
                DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                DtCabecera.Rows[0]["fecha"] = TxtFechaHoy.Text;
                DtCabecera.Rows[0]["nro_registros"] = DtReporte.Rows.Count;
                //cargamos los datos al reporte
                CrCro.Database.Tables["CAB_PRE_CRONO_FECHA"].SetDataSource(DtCabecera);
                CrCro.Database.Tables["PRE_CRONO_FECHA"].SetDataSource(DtReporte);
                //mostramos el reporte
                CrvReporte.ReportSource = CrCro;
            }
            else
            {
                if (Validaciones.fecha(TxtFechaOtra.Text) == true)
                {
                    TxtFechaOtra.BackColor = Color.White;
                    //cargamos la fecha para la busqueda
                    ObjCronograma.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFechaOtra.Text);
                    //recuperamos el reporte
                    DtReporte = ObjCronograma.ReportePresentacionCronogramaParaLaFechaBss();
                    //cargamos la cabecera
                    DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                    DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                    DtCabecera.Rows[0]["fecha"] =TxtFechaOtra.Text;
                    DtCabecera.Rows[0]["nro_registros"] = DtReporte.Rows.Count;
                    //cargamos los datos al reporte
                    CrCro.Database.Tables["CAB_PRE_CRONO_FECHA"].SetDataSource(DtCabecera);
                    CrCro.Database.Tables["PRE_CRONO_FECHA"].SetDataSource(DtReporte);
                    //mostramos el reporte
                    CrvReporte.ReportSource = CrCro;
                }
                else
                {
                    MessageBox.Show("La fecha introducida no corresponde al formato.. dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtFechaOtra.BackColor = Color.Red;
                }
            }
        }

        
    }
}
