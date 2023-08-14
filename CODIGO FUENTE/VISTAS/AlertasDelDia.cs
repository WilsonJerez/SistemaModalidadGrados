using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS
{
    public partial class LklAlumnos : Form
    {
        public LklAlumnos()
        {
            InitializeComponent();
        }
        //formularios que se abriran en caso de que una alerta este activa
        VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas RepAlumSinProDefModI;
        VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII RepAlumSinProDefModII;
        VISTAS.REPORTES.DEFENSA.DefensasParaHoy RepDefHoy;
        VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII RepDefHoyModII;
        VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma RepEsSinCrono;
        VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha RpCroFecha;
        VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas RpDefModIPenNotas;
        VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas RpDefModIIPenNotas;
        //banderas para controlar que se abran una sola vez
        bool BandRepAlumSinProDefModI = false;
        bool BandRepAlumSinProDefModII = false;
        bool BandRepDefHoy = false;
        bool BandRepDefHoyModII = false;
        bool BandRepEsSinCrono = false;
        bool BandRpCroFecha = false;
        bool BandRpDefModIPenNotas = false;
        bool BandRpDefModIIPenNotas = false;
        //objetos 
        BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();
        //data tables para recuperar datos
        DataTable DtAlumnosSinProgramarDefensasModI = new DataTable();
        DataTable DtAlumnosSinProgramarDefensaModII = new DataTable();
        DataTable DtDefensaHoy = new DataTable();
        DataTable DtDefHoyModII = new DataTable();
        DataTable DtEsSinCro = new DataTable();
        DataTable DtRpCroFecha = new DataTable();
        DataTable DtRpDefModIPenNotas = new DataTable();
        DataTable DtRpDefModIIPenNotas = new DataTable();
        private void LklAlumnos_Load(object sender, EventArgs e)
        {
            //verificamos si existen alumnos sin programar defensas de la modalidad de grado I
            DtAlumnosSinProgramarDefensasModI = ObjModalidadI.ReporteAlumnosSinPrograrmarDefensaBss();
            if (DtAlumnosSinProgramarDefensasModI.Rows.Count > 0)
            {
                LblAlumnosSinProgramarDefensasModI.Enabled = true;
            }
            //verificamos si existen alumnos sin programar defensas de la modalidad de grado II para activar la alerta
            DtAlumnosSinProgramarDefensaModII=ObjModalidadII.ReporteEtudiantesSinProgramarDefensasModIIBss();
            if (DtAlumnosSinProgramarDefensaModII.Rows.Count > 0)
            {
                LblAlumnosSinDefModII.Enabled = true;
            }
            //verficamos si existen defensa programadas para hoy de la modalidad de grado I para activiar la alerta
            ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToShortDateString());
            DtDefensaHoy = ObjDefensa.ReporteDefensasParaHoyBss();
            if (DtDefensaHoy.Rows.Count > 0)
            {
                LblDefHoyModI.Enabled = true;
            }
            //verificamos si existen defensas para hoy de la modalidad de grado II para activar la alerta
            DtDefHoyModII = ObjDefensa.ReporteDefensasParaHoyModalidadIIBss();
            if (DtDefHoyModII.Rows.Count > 0)
            {
                LklDefHoyModII.Enabled = true;
            }
            //verificamos is existen alumnos que tienen pendiente la presentacion de cronograma para asi activar la alerta
            DtEsSinCro = ObjModalidadII.ReporteEstudiantesSinCronogramaBss();
            if (DtEsSinCro.Rows.Count > 0)
            {
                lklEstudiantesSinCronograma.Enabled = true;
            }
            //verificamos si existen informes que deben ser presentados hoy para asi activar la alerta
            ObjCronograma.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToShortDateString());
            DtRpCroFecha = ObjCronograma.ReportePresentacionCronogramaParaLaFechaBss();
            if (DtRpCroFecha.Rows.Count > 0)
            {
                LklInformesParaHoy.Enabled = true;
            }
            //verificamos si existen defensas de la modalidad I que han sido defendidas pero estan pendientes de registrar su nota en el sistema y luego activamos la alerta
            DtRpDefModIPenNotas = ObjDefensa.ReporteDefensasModIPendientesDeNotasBss();
            if (DtRpDefModIPenNotas.Rows.Count > 0)
            {
                LklDefSinNotasModI.Enabled = true;
            }
            //verificamos si existen defensas de la modalidad I que han sido defendidas pero estan pendientes de registrar su nota en el sistema y luego activamos la alerta
            DtRpDefModIIPenNotas = ObjDefensa.ReporteDefensaModIIPendientesDeNotasBss();
            if (DtRpDefModIIPenNotas.Rows.Count > 0)
            {
                LklDefSinNotasModII.Enabled = true;
            }

        }

        private void LblAlumnosSinProgramarDefensasModI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (BandRepAlumSinProDefModI == false)
            {
                RepAlumSinProDefModI = new VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas();
                //RepAlumSinProDefModI.MdiParent = this;
                RepAlumSinProDefModI.Show();
                BandRepAlumSinProDefModI = true;
            }
            else
            {
                RepAlumSinProDefModI.Close();
                RepAlumSinProDefModI = new VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas();
                //RepAlumSinProDefModI.MdiParent = this;
                RepAlumSinProDefModI.Show();
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRepAlumSinProDefModII == false)
            {
                RepAlumSinProDefModII = new VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII();
                RepAlumSinProDefModII.Show();
                BandRepAlumSinProDefModII = true;
            }
            else
            {
                RepAlumSinProDefModII.Close();
                RepAlumSinProDefModII = new VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII();
                RepAlumSinProDefModII.Show();
            }
        }

        private void LblDefHoyModI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRepDefHoy == false)
            {
                RepDefHoy = new VISTAS.REPORTES.DEFENSA.DefensasParaHoy();
                RepDefHoy.Show();
                BandRepDefHoy = true;
            }
            else
            {
                RepDefHoy.Close();
                RepDefHoy = new VISTAS.REPORTES.DEFENSA.DefensasParaHoy();
                RepDefHoy.Show();
            }
        }

        private void LklDefHoyModII_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRepDefHoyModII == false)
            {
                RepDefHoyModII = new VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII();
                RepDefHoyModII.Show();
                BandRepDefHoyModII = true;
            }
            else
            {
                RepDefHoyModII.Close();
                RepDefHoyModII = new VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII();
                RepDefHoyModII.Show();
            }
        }

        private void lklEstudiantesSinCronograma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRepEsSinCrono == false)
            {
                RepEsSinCrono = new VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma();
                RepEsSinCrono.Show();
                BandRepEsSinCrono = true;
            }
            else
            {
                RepEsSinCrono.Close();
                RepEsSinCrono = new VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma();
                RepEsSinCrono.Show();
            }
        }

        private void LklInformesParaHoy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRpCroFecha == false)
            {
                RpCroFecha = new VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha();
                RpCroFecha.Show();
                BandRpCroFecha = true;
            }
            else
            {
                RpCroFecha.Close();
                RpCroFecha = new VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha();
                RpCroFecha.Show();
            }
        }

        private void LklDefSinNotasModI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRpDefModIPenNotas == false)
            {
                RpDefModIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas();
                RpDefModIPenNotas.Show();
                BandRpDefModIPenNotas = true;
            }
            else
            {
                RpDefModIPenNotas.Close();
                RpDefModIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas();
                RpDefModIPenNotas.Show();
            }
        }

        private void LklDefSinNotasModII_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BandRpDefModIIPenNotas == false)
            {
                RpDefModIIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas();
                RpDefModIIPenNotas.Show();
                BandRpDefModIIPenNotas = true;
            }
            else
            {
                RpDefModIIPenNotas.Close();
                RpDefModIIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas();
                RpDefModIIPenNotas.Show();
            }
        }
    }
}
