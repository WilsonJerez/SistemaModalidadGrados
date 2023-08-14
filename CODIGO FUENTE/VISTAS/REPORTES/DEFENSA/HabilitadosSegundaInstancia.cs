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
    public partial class HabilitadosSegundaInstancia : Form
    {
        public HabilitadosSegundaInstancia()
        {
            InitializeComponent();
        }
        VISTAS.REPORTES.DEFENSA.CrHabilitadosSegundaInstancia CrSegundaInstancia = new CrHabilitadosSegundaInstancia();
        //Objetos a utilizar
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();

        //data tables para recuperar y modelar datos
        DataTable DtCabezaReporte = new DataTable();
        DataTable DtListaHabilitadosSegundaInstancia = new DataTable();

        private void HabilitadosSegundaInstancia_Load(object sender, EventArgs e)
        {
            DtCabezaReporte.Columns.Add("coordinador");
            DtCabezaReporte.Columns.Add("facultad");
            DtCabezaReporte.Columns.Add("nro_registros");
            DtCabezaReporte.Rows.Add();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //recuperamos la lista de los habilitados para la defensa en segunda instancia
            DtListaHabilitadosSegundaInstancia = ObjModalidad_I.ReporteHabilitadosDefensaSegundaInstanciaBss();
            //cargamos la cabecera del reporte
            DtCabezaReporte.Rows[0]["nro_registros"] = DtListaHabilitadosSegundaInstancia.Rows.Count;
            DtCabezaReporte.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            DtCabezaReporte.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;

            //cargamos el reporte
            CrSegundaInstancia.Database.Tables["CABEZA_HABILITADOS_SEGUNDA_INSTANCIA_MOD_I"].SetDataSource(DtCabezaReporte);
            CrSegundaInstancia.Database.Tables["HABILITADOS_SEGUNDA_INSTANCIA_MOD_I"].SetDataSource(DtListaHabilitadosSegundaInstancia);

            // mostramos el reporte
            CrvHabilitadosSegundaInstancia.ReportSource = CrSegundaInstancia;



        }

        
    }
}
