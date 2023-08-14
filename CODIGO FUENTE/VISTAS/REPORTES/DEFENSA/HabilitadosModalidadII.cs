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
    public partial class HabilitadosModalidadII : Form
    {
        public HabilitadosModalidadII()
        {
            InitializeComponent();
        }
        VISTAS.REPORTES.DEFENSA.CrHabilitadosModalidadII CrHaModII = new CrHabilitadosModalidadII();
        //Objetos utilizados para generar el reporte
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();
        //data tables para recuperar datos
        DataTable DtListaHabilitadosModII = new DataTable();
        //data tables para modelar los datos para el reporte
        DataTable DtCabecera = new DataTable();
      



        private void HabilitadosModalidadII_Load(object sender, EventArgs e)
        {
            //agregamos columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("nro_registros");
            
            

            //cargamoslos datos para la cabecera
            DtCabecera.Rows.Add();
            DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;



        }

        private void BtnGenReporte_Click(object sender, EventArgs e)
        {
            DtListaHabilitadosModII.Rows.Clear();           
            DtListaHabilitadosModII= ObjModalidad_I.ReporteHabilitadosModalidadIIBss();
            DtCabecera.Rows[0]["nro_registros"] = DtListaHabilitadosModII.Rows.Count;
            //cargamoslos datos para la cabecera
            CrHaModII.Database.Tables["CABEZAHABILITADOSMODII"].SetDataSource(DtCabecera);
            CrHaModII.Database.Tables["HABILITADOMODALIDADII"].SetDataSource(DtListaHabilitadosModII);        
               
            
            

            //cargamos el reporte
            CrvHabilitadosModalidadII.ReportSource = CrHaModII;
        }

        
    }
}
