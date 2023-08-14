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
    public partial class RepEsSinDefModII : Form
    {
        public RepEsSinDefModII()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        VISTAS.REPORTES.MODALIDAD_II.CrRepEsSinDefModII CrRep = new CrRepEsSinDefModII();
        //data tables para recuperar datos
        DataTable DtEstudiantes = new DataTable();
        //data table utilizado para modelar la cabecera del reporte
        DataTable DtCabezaRep = new DataTable();
        private void RepEsSinDefModII_Load(object sender, EventArgs e)
        {
            //creamos las columnas para la cabecera
            DtCabezaRep.Columns.Add("coordinador");
            DtCabezaRep.Columns.Add("facultad");
            DtCabezaRep.Columns.Add("nro_registros");
            //agregamos una fila para guardar los datos
            DtCabezaRep.Rows.Add();
        }
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            DtEstudiantes = ObjModalidadII.ReporteEtudiantesSinProgramarDefensasModIIBss();
            //cargamos los datos de la cabecera
            DtCabezaRep.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabezaRep.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabezaRep.Rows[0]["nro_registros"] = DtEstudiantes.Rows.Count;

            //cargamos el reporte
            CrRep.Database.Tables["CA_SIN_DEF_MOD_II"].SetDataSource(DtCabezaRep);
            CrRep.Database.Tables["SIN_DEF_MOD_II"].SetDataSource(DtEstudiantes);

            //mostramos el reporte
            CrvReporte.ReportSource = CrRep;
        }

        
    }
}
