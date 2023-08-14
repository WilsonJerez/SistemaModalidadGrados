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
    public partial class ReporteTemas : Form
    {
        public ReporteTemas()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        VISTAS.REPORTES.MODALIDAD_I.CrTemas TemasCr = new CrTemas();
        // data tables para recuperar listas de datos
        DataTable DtListaCarreras = new DataTable();
        DataTable DtListaTemas = new DataTable();
        DataTable DtListaTipoModalidad = new DataTable();
        //data table para la cabecera del reporte
        DataTable DtCabezaReporte = new DataTable();
        // variables para recuperar los ids que sirven como parametros de filtracion para el reporte
        int IdFacultad=0;
        int IdCarrera=0;
        int IdCarreraCombo = 0;
        int IdTipoModalidad = 0;
        int IdTipoModalidadCombo = 0;
       
        private void ReporteTemas_Load(object sender, EventArgs e)
        {
            TxtFacultad.Text = DAL.Dal_Login.facultad.ToString();
            // seteamos el estado para que solo se filtren las carreras activas
            ObjCarrera.ESTADO = 1;
            ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
            DtListaCarreras = ObjCarrera.SeleccionarCarreraCriterioBss();
            //cargamos el combo de carreras
            CmbCarrera.DataSource = DtListaCarreras;
            CmbCarrera.DisplayMember = "carrera";
            
            //cargamos la lista de tipo de modalidades
            ObjTipoModalidad.ESTADO = 1;
            DtListaTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss();
            CmbTipoModalidad.DataSource = DtListaTipoModalidad;
            CmbTipoModalidad.DisplayMember = "tipo_modalidad";

            //adicionamos las columnas de la cabecera del reporte
            DtCabezaReporte.Columns.Add("facultad");
            DtCabezaReporte.Columns.Add("coordinador");
            DtCabezaReporte.Columns.Add("nro_temas");
            DtCabezaReporte.Columns.Add("carrera");
            DtCabezaReporte.Columns.Add("Facultades");
            DtCabezaReporte.Columns.Add("tipo_modalidad");
            //agregamos una fila para los datos de la cabecera del reporte
            DtCabezaReporte.Rows.Add();
           

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //cargamos los datos para la cabeza
            DtCabezaReporte.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            DtCabezaReporte.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            
            if (IdFacultad > 0)
            {
                DtCabezaReporte.Rows[0]["facultades"] = TxtFacultad.Text.ToUpper();
            }
            else
            {
                DtCabezaReporte.Rows[0]["facultades"] = "TODAS";
            }
            if (IdCarrera > 0)
            {
                DtCabezaReporte.Rows[0]["carrera"] = CmbCarrera.Text;
            }
            else
            {
                DtCabezaReporte.Rows[0]["carrera"] = "TODAS";
            }
            if (IdTipoModalidad > 0)
            {
                DtCabezaReporte.Rows[0]["tipo_modalidad"] = CmbTipoModalidad.Text.ToUpper();
            }
            else
            {
                DtCabezaReporte.Rows[0]["tipo_modalidad"] = "TODOS";
            }
            //recuperamos la lista de temas 
            if (IdTipoModalidad > 0)
                ObjModalidad_I.ID_TIPO_MODALIDAD = IdTipoModalidad;
            else
                ObjModalidad_I.ID_TIPO_MODALIDAD = 0;

            DtListaTemas = ObjModalidad_I.ReporteTemasBss(IdCarrera, IdFacultad);
            //sacamos el nro de registros que existe
            DtCabezaReporte.Rows[0]["nro_temas"] = DtListaTemas.Rows.Count;

            //cargamos los datos para el reporte
            TemasCr.Database.Tables["CABEZAREPORTE_TEMAS"].SetDataSource(DtCabezaReporte);
            TemasCr.Database.Tables["REPORTE_TEMAS"].SetDataSource(DtListaTemas);
            CrvTemas.ReportSource = TemasCr;
        }

        private void CkbFacultad_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFacultad.Checked == true)
            {
                IdFacultad = DAL.Dal_Login.id_facultad;
            }
            else
            {
                IdFacultad = 0;
            }
        }

        private void CkbCarrera_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarrera.Checked == true)
            {
                CmbCarrera.Enabled = true;
                IdCarrera = IdCarreraCombo;
                
            }
            else
            {
                IdCarrera = 0;
                CmbCarrera.Enabled = false;
            }
        }

        private void CmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCarreraCombo = Convert.ToInt32(DtListaCarreras.Rows[CmbCarrera.SelectedIndex]["id_carrera"].ToString());
            if(CkbCarrera.Checked==true)
            IdCarrera = IdCarreraCombo;
        }

        private void CkbTipoModalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTipoModalidad.Checked == true)
            {
                CmbTipoModalidad.Enabled = true;
                IdTipoModalidad = IdTipoModalidadCombo;
            }
            else
            {
                IdTipoModalidad = 0;
                CmbTipoModalidad.Enabled = false;
            }
        }

        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipoModalidadCombo=Convert.ToInt32(DtListaTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"].ToString());
            if(CkbTipoModalidad.Checked==true)
            IdTipoModalidad = IdTipoModalidadCombo;
        }
                

        private void CmbCarrera_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
