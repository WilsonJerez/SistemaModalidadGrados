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
    public partial class RepEstudiantesSinCronograma : Form
    {
        public RepEstudiantesSinCronograma()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        VISTAS.REPORTES.MODALIDAD_II.CrEstudiantesSinCronograma CrRep = new CrEstudiantesSinCronograma();
        //data table para recuperar el reporte
        DataTable DtRep = new DataTable();
        //data table para la cabecera del reporte
        DataTable DtCabecera = new DataTable();
        private void RepEstudiantesSinCronograma_Load(object sender, EventArgs e)
        { 
            //agregamos las columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("nro_registros");
            //agragamos unafila para los datos
            DtCabecera.Rows.Add();
        }               
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //recuperamos los datos del reporte
            DtRep = ObjModalidadII.ReporteEstudiantesSinCronogramaBss();
            //cargamos datos para la cabecera del reporte
            DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabecera.Rows[0]["nro_registros"] = DtRep.Rows.Count;
            //cargamos el reporte
            CrRep.Database.Tables["CAB_ES_SIN_CRONOGRAMA"].SetDataSource(DtCabecera);
            CrRep.Database.Tables["ES_SIN_CRONOGRAMA"].SetDataSource(DtRep);
            //mostramos el reporte
            CrvReporte.ReportSource = CrRep;

        }

        
    }
}
