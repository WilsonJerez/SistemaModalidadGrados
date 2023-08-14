using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.MODALIDAD_I
{
    public partial class ReporteAlumnosSinProgramarDefensas : Form
    {
        public ReporteAlumnosSinProgramarDefensas()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();
        //crystal report utilizado
        VISTAS.REPORTES.MODALIDAD_I.CrReporteAlumnosSinProgramarDefensas CrAlumnos = new CrReporteAlumnosSinProgramarDefensas();
        //data tables para recuperar datos
        DataTable DtAlumnos = new DataTable();
        DataTable DtCabecera = new DataTable();
        private void ReporteAlumnosSinProgramarDefensas_Load(object sender, EventArgs e)
        {
            //columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("nro_registros");
            DtCabecera.Rows.Add();
               
        }
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //recuperamos los datos para el reporte
            DtAlumnos = ObjModalidadI.ReporteAlumnosSinPrograrmarDefensaBss();
            //cargamos los datos para la cabecera
            DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabecera.Rows[0]["nro_registros"] = DtAlumnos.Rows.Count;
            //cargamos el reporte
            CrAlumnos.Database.Tables["CA_SIN_DEFENSA_MOD_I"].SetDataSource(DtCabecera);
            CrAlumnos.Database.Tables["SIN_DEFENSA_MOD_I"].SetDataSource(DtAlumnos);
            //Mostramos el reporte
            CrvReporte.ReportSource = CrAlumnos;

        }

        
    }
}
