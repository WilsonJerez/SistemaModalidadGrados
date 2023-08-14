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
    public partial class ReporteDefensasMod_IIPendientesDeNotas : Form
    {
        public ReporteDefensasMod_IIPendientesDeNotas()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        VISTAS.REPORTES.DEFENSA.CrDefensaModIIPendientesDeNotas CrDefPenNotas = new  CrDefensaModIIPendientesDeNotas();
        //data table para la cabecera del reporte
        DataTable DtCabecera = new DataTable();
        //data table para recuperar el reporte
        DataTable DtReporte = new DataTable();
        DataTable DtReporteModificado = new DataTable();
        private void ReporteDefensasMod_IIPendientesDeNotas_Load(object sender, EventArgs e)
        {
            //agregamos las columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("nro_registros");
            //agregamos una fila para los datos
            DtCabecera.Rows.Add();
            //modelamos un data table para el reporte para cambiar el tipo de fecha ya que este nos devuelve el formato fecha larga
            DtReporteModificado.Columns.Add("ci");
            DtReporteModificado.Columns.Add("nombre");
            DtReporteModificado.Columns.Add("paterno");
            DtReporteModificado.Columns.Add("materno");
            DtReporteModificado.Columns.Add("fecha");
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //DateTime fecha;
            //recuperamos el reporte
            DtReporte = ObjDefensa.ReporteDefensaModIIPendientesDeNotasBss();
            //cargamos los datos para la cabecera del reporte
            DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabecera.Rows[0]["nro_registros"] = DtReporte.Rows.Count;
            //cargamos el data table de reporte modificado con el nuevo tipo de fecha
            for (int i = 0; i < DtReporte.Rows.Count; i++)
            {
                DtReporteModificado.Rows.Add();
                DtReporteModificado.Rows[i]["ci"] = DtReporte.Rows[i]["ci"];
                DtReporteModificado.Rows[i]["nombre"] = DtReporte.Rows[i]["nombre"];
                DtReporteModificado.Rows[i]["paterno"] = DtReporte.Rows[i]["paterno"];
                DtReporteModificado.Rows[i]["materno"] = DtReporte.Rows[i]["materno"];
                DtReporteModificado.Rows[i]["fecha"] = Convert.ToDateTime(DtReporte.Rows[i]["fecha"]).ToShortDateString();
            }
            //cargamos el reporte
            CrDefPenNotas.Database.Tables["CAB_DEF_MOD_II_PEND_NOTAS"].SetDataSource(DtCabecera);
            CrDefPenNotas.Database.Tables["DEF_MOD_II_PEND_NOTAS"].SetDataSource(DtReporteModificado);
            //mostramos el reporte
            CrvReporte.ReportSource = CrDefPenNotas;
        }
    }
}
