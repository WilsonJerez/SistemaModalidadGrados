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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // formularios que aparecen en el contenedor

        VISTAS.ESTUDIANTE.InsertarEstudiante estu;
        VISTAS.FACULTAD.InsertarFacultad facu;
        VISTAS.CARRERA.InsertarCarrera carre;
        VISTAS.TIPOMODALIDAD.InsertarTipoModalidad tipomo;
        VISTAS.GRUPO.InsertarGrupo grup;
        VISTAS.AULA.InsertarAula au;
        VISTAS.TURNO.InsertarTurno tutu;
        VISTAS.CARGO.InsertarCargo car;
        VISTAS.DOCENTE.InsertarDocente aca;
        VISTAS.MODALIDAD_II.RegistrarModalidadII mo2;
        VISTAS.CRONOGRAMA.InsertarCronograma cro;
        VISTAS.DEFENSAS.InsertarDefensas de;
        VISTAS.DEFENSA_II.InsertarDefesaModalidadII df;
        VISTAS.CRONOGRAMA.ActualizarCronograma crono;
        VISTAS.DEFENSA_II.Actualizar.ActualizarNotas ActNotas;
        VISTAS.DEFENSA_II.Actualizar.ActualizarTribunales ActTribunales;
        VISTAS.DEFENSA_II.Actualizar.ActualizarFecha ActFechaDefensaII;
        VISTAS.DEFENSAS.Actualizar.ActualizarNotas ActNotasDefensaI;
        VISTAS.DEFENSAS.Actualizar.ActualizarTribunales ActTribuDefensaI;
        VISTAS.DEFENSAS.Actualizar.ActualizarFecha ActFechaDefensaI;
        VISTAS.DOCENTE.ModificarDocente ActDocente;
        VISTAS.GRUPO.ModificarGrupo ActGrupo;
        VISTAS.FACULTAD.ActualizarFacultad ActFacul;
        VISTAS.AULA.ModificarAula mau;
        VISTAS.CARGO.ModificarCargo mcar;
        VISTAS.CARRERA.ModificarCarrera ActCarrera;
        VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.SeleccionDeEstudiante ActEstudiante;
        VISTAS.MODALIDAD_II.ActualizarModalidadII ActModalidad_II;
        VISTAS.TIPOMODALIDAD.ACTUALIZAR.ACTUALIZAR_TIPO_DE_MODALIDAD ActTipoModalidad;
        VISTAS.TURNO.ActualizarTurno ActTurno;
        VISTAS.LklAlumnos Alertas;
        VISTAS.ESTUDIANTE.InsertarEstudianteRepitente RegistroEstudianteRepitente;
        VISTAS.ESTUDIANTE.InsertarEstudianteNuevaCarrera RegistroEstudianteNuevaCarrera;
        VISTAS.USUARIOS.InsertarUsuario UsuSis;
        VISTAS.USUARIOS.MODIFICAR.DatosPersonales ModDatUsuSis;
        VISTAS.USUARIOS.MODIFICAR.Contraseña ModContra;
        VISTAS.DEFENSA_III.InsertarDefensaIII DefMin;
        VISTAS.DEFENSA_III.ACTUALIZAR.Notas ActNotasModIII;
        VISTAS.DEFENSA_III.ACTUALIZAR.TribunalesDefensaMinisterio ActTribModIII;
        VISTAS.DEFENSA_III.ACTUALIZAR.FechaDefensaModIII ActFechaDefModIII;
        VISTAS.MODALIDAD_OLVIDADA.InsertarModalidadOlvidada InsModOlvi;
        VISTAS.AMPLIACION.Retrazar RetModII;

        //VISTAS.REPORTES.FACULTAD.ReporteFacultad ReporteModI;
        VISTAS.REPORTES.AULA.ReporteAula ReporteAula;
        VISTAS.REPORTES.MODALIDAD_I.ReporteModalidad_I_I ReporteModI_I;
        VISTAS.REPORTES.MODALIDAD_II.RepModalidadIIPorTutor ReporteModIIPorTutor;
        VISTAS.REPORTES.DEFENSA.ReporteGraduadosPorFechas ReporteGraduadosIntervaloDeFechas;
        VISTAS.REPORTES.MODALIDAD_I.ReporteTemas RptsTemas;
        VISTAS.REPORTES.DEFENSA.HabilitadosModalidadII RptHabilitadosModII;
        VISTAS.REPORTES.DEFENSA.HabilitadosSegundaInstancia RptHabiDefSegInsModI;
        VISTAS.REPORTES.DEFENSA.DefensasParaHoy RptDefHoy;
        VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas RepAlumnosSinDefensa;
        VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII RpSinDefModII;
        VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII RpDefHoyModII;
        VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma RpEsSinCro;
        VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha RpPreCroFecha;
        VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas RpDefModIPenNotas;
        VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas RpDefModIIPenNotas;

        // banderas que nos permiten controlar si se abrieron alguna vez
      bool BandEstudiante = false;
      bool BandFacultad = false;
       bool BandCarrera=false;
       bool BandTipoModa = false;
       bool BandGrupo = false;
       bool BanAula = false;
       bool BandTurno = false;
       bool BandCar = false;
       bool BandDoce = false;
       bool BandMo2 = false;
       bool BandCronogram = false;
       bool BanDefensas = false;
       bool BanDefensasII = false;
       bool BandAulaModi = false;
       bool BandCargomodi = false;
       bool BanActualizarCronograma = false;
       bool BandActualizarNotas = false;
       bool BandActTribunales = false;
       bool BandActFechaDefensa = false;
       bool BandActNotasDefensaI = false;
       bool BandActTribuDefensaI = false;
       bool BandActFechaDefensaI = false;
       bool BandActDocente = false;
       bool BandActGrupo = false;
       bool BandActFacult = false;
       bool BandActCarrera = false;
       bool BandActEstudiante = false;
       bool BandActModalidad_II = false;
       bool BandAlertas = false;
       bool BandActTipoModalidad = false;
       bool BandActTurno = false;
       bool BandRegistroEstudianteRepitente = false;
       bool BandRegistroEstudianteNuevaCarrera = false;
       bool BandUsuSis = false;
       bool BandModDatUsuSis = false;
       bool BandModContra = false;
       bool BandDefMin = false;
       bool BandActNotasModIII = false;
       bool BandActTribModIII = false;
       bool BandActFechaDefModIII = false;
       bool BandInsModOlvi = false;
       bool BandRetModII = false;

       //bool BandReporteModI = false;
       bool BandReporteAula = false;
       bool BandReporteModI_I = false;
       bool BandReporteModIIPorTutor = false;
       bool BandReporteGraduadosIntervaloDeFechas = false;
       bool BandRptsTemas = false;
       bool BandRptHabilitadosModII = false;
       bool BandRptHabiDefSegInsModI = false;
       bool BandRptDefHoy = false;
       bool BandRepAlumnosSinDefensa = false;
       bool BandRpSinDefModII = false;
       bool BandRpDefHoyModII = false;
       bool BandRpEsSinCro = false;
       bool BandRpPreCroFecha = false;
       bool BandRpDefModIPenNotas = false;
       bool BandRpDefModIIPenNotas = false;

       private void Form1_Load(object sender, EventArgs e)
       {
           DateTime fechapc=DateTime.Now;
           
           menuStrip1.Focus();
           TxtFecha.Text = DAL.Conexion.getdatos("select convert(varchar, getdate(),103)as fecha").Rows[0]["fecha"].ToString();
           DAL.Dal_Login.fecha = Convert.ToDateTime(TxtFecha.Text);
           if (Convert.ToDateTime(fechapc.ToShortDateString()) != Convert.ToDateTime(TxtFecha.Text))
               MessageBox.Show("LA FECHA DEL ORDENADOR DONDE ESTA TRABJANDO ES INCORRECTA", "ERROR DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
           
           // servicios

           BSS.Bss_Grupo objgrupo = new BSS.Bss_Grupo();
           objgrupo.ServicioGrupoBss();

           BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();
           ObjModalidadI.ServicioModalidadIBss();

           BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
           ObjDefensa.ServicioDefensaBss();

           BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();
           ObjCronograma.ServicioCronogramaBss();

           BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
           ObjModalidadII.ServicioMOdalidadIIBss();

           Alertas = new LklAlumnos();
           Alertas.MdiParent = this;
           Alertas.Show();

           // fin servicio
       }        

        private void facultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandFacultad == false)
            {
                facu = new VISTAS.FACULTAD.InsertarFacultad();
                facu.MdiParent = this;
                //facu.WindowState = FormWindowState.Maximized;
                facu.Show();
                BandFacultad = true;
            }
            else
            {
                facu.Close();
                facu = new VISTAS.FACULTAD.InsertarFacultad();
                facu.MdiParent = this;
                //facu.WindowState = FormWindowState.Maximized;
                facu.Show();
 
            }
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandCarrera == false)
            {
                carre = new VISTAS.CARRERA.InsertarCarrera();
                carre.MdiParent = this;
                //carre.WindowState = FormWindowState.Maximized;
                carre.Show();
                BandCarrera = true;
            }
            else
            {
                carre.Close();
                carre = new VISTAS.CARRERA.InsertarCarrera();
                carre.MdiParent = this;
                //carre.WindowState = FormWindowState.Maximized;
                carre.Show();
            }
        }

        private void tipoModalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandTipoModa == false)
            {
                tipomo = new VISTAS.TIPOMODALIDAD.InsertarTipoModalidad();
                tipomo.MdiParent = this;
                //tipomo.WindowState = FormWindowState.Maximized;
                tipomo.Show();
                BandTipoModa = true;
            }
            else
            {
                tipomo.Close();
                tipomo = new VISTAS.TIPOMODALIDAD.InsertarTipoModalidad();
                tipomo.MdiParent = this;
                //tipomo.WindowState = FormWindowState.Maximized;
                tipomo.Show();
            }
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandGrupo == false)
            {
                grup = new VISTAS.GRUPO.InsertarGrupo();
                grup.MdiParent = this;
                //grup.WindowState = FormWindowState.Maximized;
                grup.Show();
                BandGrupo = true;
            }
            else
            {
                grup.Close();
                grup = new VISTAS.GRUPO.InsertarGrupo();
                grup.MdiParent = this;
                //grup.WindowState = FormWindowState.Maximized;
                grup.Show();
            }
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BanAula == false)
            {
                au = new VISTAS.AULA.InsertarAula();
                au.MdiParent = this;
                //au.WindowState = FormWindowState.Maximized;
                au.Show();
                BanAula = true;
            }
            else
            {
                au.Close();
                au = new VISTAS.AULA.InsertarAula();
                au.MdiParent = this;
                //au.WindowState = FormWindowState.Maximized;
                au.Show();
            }
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandTurno == false)
            {
                tutu = new VISTAS.TURNO.InsertarTurno();
                tutu.MdiParent = this;
                //tutu.WindowState = FormWindowState.Maximized;
                tutu.Show();
                BandTurno = true;
            }
            else
            {
                tutu.Close();
                tutu = new VISTAS.TURNO.InsertarTurno();
                tutu.MdiParent = this;
                //tutu.WindowState = FormWindowState.Maximized;
                tutu.Show();

            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandCar == false)
            {
                car = new VISTAS.CARGO.InsertarCargo();
                car.MdiParent = this;
                //car.WindowState = FormWindowState.Maximized;
                car.Show();
                BandCar = true;
            }
            else
            {
                car.Close();
                car = new VISTAS.CARGO.InsertarCargo();
                car.MdiParent = this;
                //car.WindowState = FormWindowState.Maximized;
                car.Show();                
            }
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandDoce == false)
            {
                aca = new VISTAS.DOCENTE.InsertarDocente();
                aca.MdiParent = this;
                //aca.WindowState = FormWindowState.Maximized;
                aca.Show();
                BandDoce = true;
            }
            else
            {
                aca.Close();
                aca = new VISTAS.DOCENTE.InsertarDocente();
                aca.MdiParent = this;
                //aca.WindowState = FormWindowState.Maximized;
                aca.Show();
            }
        }

        private void modalidadIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandMo2 == false)
            {
                mo2 = new VISTAS.MODALIDAD_II.RegistrarModalidadII();
                mo2.MdiParent = this;
                //mo2.WindowState = FormWindowState.Maximized;
                mo2.Show();
                BandMo2 = true;
            }
            else
            {
                mo2.Close();
                mo2 = new VISTAS.MODALIDAD_II.RegistrarModalidadII();
                mo2.MdiParent = this;
                //mo2.WindowState = FormWindowState.Maximized;
                mo2.Show();
            }
        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandCronogram == false)
            {
                cro = new VISTAS.CRONOGRAMA.InsertarCronograma();
                cro.MdiParent = this;
                //cro.WindowState = FormWindowState.Maximized;
                cro.Show();
                BandCronogram = true;
            }
            else
            {
                cro.Close();
                cro = new VISTAS.CRONOGRAMA.InsertarCronograma();
                cro.MdiParent = this;
                //cro.WindowState = FormWindowState.Maximized;
                cro.Show();
            }
        }

        private void modalidadIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BanDefensas == false)
            {
                de = new VISTAS.DEFENSAS.InsertarDefensas();
                de.MdiParent = this;
                //de.WindowState = FormWindowState.Maximized;
                de.Show();
                BanDefensas = true;
            }
            else
            {
                de.Close();
                de = new VISTAS.DEFENSAS.InsertarDefensas();
                de.MdiParent = this;
                //de.WindowState = FormWindowState.Maximized;
                de.Show();
            }
        }

        private void modalidadIIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BanDefensasII == false)
            {
                df = new VISTAS.DEFENSA_II.InsertarDefesaModalidadII();
                df.MdiParent = this;
                //df.WindowState = FormWindowState.Maximized;
                df.Show();
                BanDefensasII = true;
            }
            else
            {
                df.Close();
                df = new VISTAS.DEFENSA_II.InsertarDefesaModalidadII();
                df.MdiParent = this;
                //df.WindowState = FormWindowState.Maximized;
                df.Show();

            }
        }

        private void aulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandAulaModi == false)
            {
                mau = new VISTAS.AULA.ModificarAula();
                mau.MdiParent = this;
                mau.Show();
            }
            else
            {
                mau.Close();
                mau = new VISTAS.AULA.ModificarAula();
                mau.MdiParent = this;
                mau.Show();
            }
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandCargomodi == false)
            {
                mcar = new VISTAS.CARGO.ModificarCargo();
                mcar.MdiParent = this;
                mcar.Show();
            }
            else
            {
                mcar.Close();
                mcar = new VISTAS.CARGO.ModificarCargo();
                mcar.MdiParent = this;
                mcar.Show();
            }
        }

        private void cronogramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BanActualizarCronograma == false)
            {
                crono = new VISTAS.CRONOGRAMA.ActualizarCronograma();
                crono.MdiParent = this;
                crono.Show();
                BanActualizarCronograma = true;
            }
            else
            {
                crono.Close();
                crono = new  VISTAS.CRONOGRAMA.ActualizarCronograma();
                crono.MdiParent = this;
                crono.Show();
            }
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActualizarNotas == false)
            {
                ActNotas = new VISTAS.DEFENSA_II.Actualizar.ActualizarNotas();
                ActNotas.MdiParent = this;
                ActNotas.Show();
                BandActualizarNotas = true;
            }
            else
            {
                ActNotas.Close();
                ActNotas = new VISTAS.DEFENSA_II.Actualizar.ActualizarNotas();
                ActNotas.MdiParent = this;
                ActNotas.Show();
            }
        }

        private void tribunalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActTribunales == false)
            {
                ActTribunales = new VISTAS.DEFENSA_II.Actualizar.ActualizarTribunales();
                ActTribunales.MdiParent = this;
                ActTribunales.Show();
                BandActTribunales=true;
            }
            else
            {
                ActTribunales.Close();
                ActTribunales = new VISTAS.DEFENSA_II.Actualizar.ActualizarTribunales();
                ActTribunales.MdiParent = this;
                ActTribunales.Show();
            }
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActFechaDefensa == false)
            {
                ActFechaDefensaII = new VISTAS.DEFENSA_II.Actualizar.ActualizarFecha();
                ActFechaDefensaII.MdiParent = this;
                ActFechaDefensaII.Show();
                BandActFechaDefensa = true;
            }
            else
            {
                ActFechaDefensaII.Close();
                ActFechaDefensaII = new VISTAS.DEFENSA_II.Actualizar.ActualizarFecha();
                ActFechaDefensaII.MdiParent = this;
                ActFechaDefensaII.Show();
            }
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActNotasDefensaI == false)
            {
                ActNotasDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarNotas();
                ActNotasDefensaI.MdiParent = this;
                ActNotasDefensaI.Show();
                BandActNotasDefensaI = true;
            }
            else
            {
                ActNotasDefensaI.Close();
                ActNotasDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarNotas();
                ActNotasDefensaI.MdiParent = this;
                ActNotasDefensaI.Show();
            }
        }

        private void tribunalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActTribuDefensaI == false)
            {
                ActTribuDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarTribunales();
                ActTribuDefensaI.MdiParent = this;
                ActTribuDefensaI.Show();
                BandActTribuDefensaI = true;
            }
            else
            {
                ActTribuDefensaI.Close();
                ActTribuDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarTribunales();
                ActTribuDefensaI.MdiParent = this;
                ActTribuDefensaI.Show();
            }
        }

        private void fechaDefensaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActFechaDefensaI == false)
            {
                ActFechaDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarFecha();
                ActFechaDefensaI.MdiParent = this;
                ActFechaDefensaI.Show();
                BandActFechaDefensaI = true;
            }
            else
            {
                ActFechaDefensaI.Close();
                ActFechaDefensaI = new VISTAS.DEFENSAS.Actualizar.ActualizarFecha();
                ActFechaDefensaI.MdiParent = this;
                ActFechaDefensaI.Show();
            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActDocente == false)
            {
                ActDocente = new VISTAS.DOCENTE.ModificarDocente();
                ActDocente.MdiParent = this;
                ActDocente.Show();
                BandActDocente = true;
            }
            else
            {
                ActDocente.Close();
                ActDocente = new VISTAS.DOCENTE.ModificarDocente();
                ActDocente.MdiParent = this;
                ActDocente.Show();              

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActGrupo == false)
            {
                ActGrupo = new VISTAS.GRUPO.ModificarGrupo();
                ActGrupo.MdiParent = this;
                ActGrupo.Show();
                BandActGrupo = true;
            }
            else
            {
                ActGrupo.Close();
                ActGrupo = new VISTAS.GRUPO.ModificarGrupo();
                ActGrupo.MdiParent = this;
                ActGrupo.Show();    

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BandActFacult == false)
            {
                ActFacul = new VISTAS.FACULTAD.ActualizarFacultad();
                ActFacul.MdiParent = this;
                ActFacul.Show();
                BandActFacult = true;
            }
            else
            {
                ActFacul.Close();
                ActFacul = new VISTAS.FACULTAD.ActualizarFacultad();
                ActFacul.MdiParent = this;
                ActFacul.Show();
            }

        }

        private void carreraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActCarrera == false)
            {
                ActCarrera = new VISTAS.CARRERA.ModificarCarrera();
                ActCarrera.MdiParent = this;
                ActCarrera.Show();
                BandActCarrera = true;
            }
            else
            {
                ActCarrera.Close();
                ActCarrera = new VISTAS.CARRERA.ModificarCarrera();
                ActCarrera.MdiParent = this;
                ActCarrera.Show();
            }
        }

        private void estudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActEstudiante == false)
            {
                ActEstudiante = new VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.SeleccionDeEstudiante();
                ActEstudiante.MdiParent = this;
                ActEstudiante.Show();
                BandActCarrera = true;
            }
            else
            {
                ActEstudiante.Close();
                ActEstudiante = new  VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.SeleccionDeEstudiante();
                ActEstudiante.MdiParent = this;
                ActEstudiante.Show();
            }
        }

        private void modalidadIIToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandAlertas == false)
            {
                Alertas = new LklAlumnos();
                Alertas.MdiParent = this;
                Alertas.Show();
                BandAlertas = true;
            }
            else
            {
                Alertas.Close();
                Alertas = new LklAlumnos();
                Alertas.MdiParent = this;
                Alertas.Show();
                
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (BandActTipoModalidad== false)
            {
                ActTipoModalidad = new VISTAS.TIPOMODALIDAD.ACTUALIZAR.ACTUALIZAR_TIPO_DE_MODALIDAD();
                ActTipoModalidad.MdiParent = this;
                ActTipoModalidad.Show();
                BandActTipoModalidad = true;
            }
            else
            {
                ActTipoModalidad.Close();
                ActTipoModalidad = new VISTAS.TIPOMODALIDAD.ACTUALIZAR.ACTUALIZAR_TIPO_DE_MODALIDAD();
                ActTipoModalidad.MdiParent = this;
                ActTipoModalidad.Show();
                
            }
            
        }

        private void turnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BandActTurno == false)
            {
                ActTurno = new VISTAS.TURNO.ActualizarTurno();
                ActTurno.MdiParent = this;
                ActTurno.Show();
                BandActTurno = true;
            }
            else
            {
                ActTurno.Close();
                ActTurno = new VISTAS.TURNO.ActualizarTurno();
                ActTurno.MdiParent = this;
                ActTurno.Show();
            }
        }

        private void modalidadIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (BandReporteModI == false)
            //{
            //    ReporteModI = new VISTAS.REPORTES.FACULTAD.ReporteFacultad();
            //    ReporteModI.MdiParent = this;
            //    ReporteModI.Show();
            //    BandReporteModI = true;
            //}
            //else
            //{
            //    ReporteModI.Close();
            //    ReporteModI = new VISTAS.REPORTES.FACULTAD.ReporteFacultad();
            //    ReporteModI.MdiParent = this;
            //    ReporteModI.Show();
            //}
        }

        private void aulaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BandReporteAula == false)
            {
                ReporteAula = new VISTAS.REPORTES.AULA.ReporteAula();
                ReporteAula.MdiParent = this;
                ReporteAula.Show();
                BandReporteAula = true;
            }
            else
            {
                ReporteAula.Close();
                ReporteAula = new VISTAS.REPORTES.AULA.ReporteAula();
                ReporteAula.MdiParent = this;
                ReporteAula.Show();
            }
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandReporteModI_I == false)
            {
                ReporteModI_I = new VISTAS.REPORTES.MODALIDAD_I.ReporteModalidad_I_I();
                ReporteModI_I.MdiParent = this;
                ReporteModI_I.Show();
                BandReporteModI_I = true;
            }
            else
            {
                ReporteModI_I.Close();
                ReporteModI_I = new VISTAS.REPORTES.MODALIDAD_I.ReporteModalidad_I_I();
                ReporteModI_I.MdiParent = this;
                ReporteModI_I.Show();
            }
        }

        private void porTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandReporteModIIPorTutor == false)
            {
                ReporteModIIPorTutor = new VISTAS.REPORTES.MODALIDAD_II.RepModalidadIIPorTutor();
                ReporteModIIPorTutor.MdiParent = this;
                ReporteModIIPorTutor.Show();
                BandReporteModIIPorTutor = true;
            }
            else
            {
                ReporteModIIPorTutor.Close();
                ReporteModIIPorTutor = new VISTAS.REPORTES.MODALIDAD_II.RepModalidadIIPorTutor();
                ReporteModIIPorTutor.MdiParent = this;
                ReporteModIIPorTutor.Show();
            }
        }

        private void graduadosPorIntervaloDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandReporteGraduadosIntervaloDeFechas == false)
            {
                ReporteGraduadosIntervaloDeFechas = new VISTAS.REPORTES.DEFENSA.ReporteGraduadosPorFechas();
                ReporteGraduadosIntervaloDeFechas.MdiParent = this;
                ReporteGraduadosIntervaloDeFechas.Show();
                BandReporteGraduadosIntervaloDeFechas = true;
            }
            else
            {
                ReporteGraduadosIntervaloDeFechas.Close();
                ReporteGraduadosIntervaloDeFechas = new VISTAS.REPORTES.DEFENSA.ReporteGraduadosPorFechas();
                ReporteGraduadosIntervaloDeFechas.MdiParent = this;
                ReporteGraduadosIntervaloDeFechas.Show();
            }
        }

        private void repitentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRegistroEstudianteRepitente == false)
            {
                RegistroEstudianteRepitente = new VISTAS.ESTUDIANTE.InsertarEstudianteRepitente();
                RegistroEstudianteRepitente.MdiParent = this;
                RegistroEstudianteRepitente.Show();
                BandRegistroEstudianteRepitente = true;
            }
            else
            {
                RegistroEstudianteRepitente.Close();
                RegistroEstudianteRepitente = new VISTAS.ESTUDIANTE.InsertarEstudianteRepitente();
                RegistroEstudianteRepitente.MdiParent = this;
                RegistroEstudianteRepitente.Show();
            }
        }

        private void primerIntentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandEstudiante == false)
            {
                BandEstudiante = true;
                estu = new VISTAS.ESTUDIANTE.InsertarEstudiante();
                estu.MdiParent = this;
                //estu.WindowState = FormWindowState.Maximized;
                estu.Show();
            }
            else
            {
                estu.Close();
                estu = new VISTAS.ESTUDIANTE.InsertarEstudiante();
                estu.MdiParent = this;
                //estu.WindowState = FormWindowState.Maximized;
                estu.Show();
            }
        }

        private void segundaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRegistroEstudianteNuevaCarrera == false)
            {
                RegistroEstudianteNuevaCarrera = new VISTAS.ESTUDIANTE.InsertarEstudianteNuevaCarrera();
                RegistroEstudianteNuevaCarrera.MdiParent = this;
                RegistroEstudianteNuevaCarrera.Show();
                BandRegistroEstudianteNuevaCarrera = true;
            }
            else
            {
                RegistroEstudianteNuevaCarrera.Close();
                RegistroEstudianteNuevaCarrera = new VISTAS.ESTUDIANTE.InsertarEstudianteNuevaCarrera();
                RegistroEstudianteNuevaCarrera.MdiParent = this;
                RegistroEstudianteNuevaCarrera.Show();
            }
        }

        private void temasDesarrolladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRptsTemas == false)
            {
                RptsTemas = new VISTAS.REPORTES.MODALIDAD_I.ReporteTemas();
                RptsTemas.MdiParent = this;
                RptsTemas.Show();
                BandRptsTemas = true;
            }
            else
            {
                RptsTemas.Close();
                RptsTemas = new VISTAS.REPORTES.MODALIDAD_I.ReporteTemas();
                RptsTemas.MdiParent = this;
                RptsTemas.Show();
            }
        }

        private void habilitadosModalidadIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRptHabilitadosModII == false)
            {
                RptHabilitadosModII = new VISTAS.REPORTES.DEFENSA.HabilitadosModalidadII();
                RptHabilitadosModII.MdiParent = this;
                RptHabilitadosModII.Show();
                BandRptHabilitadosModII = true;
            }
            else
            {
                RptHabilitadosModII.Close();
                RptHabilitadosModII = new VISTAS.REPORTES.DEFENSA.HabilitadosModalidadII();
                RptHabilitadosModII.MdiParent = this;
                RptHabilitadosModII.Show();
            }
        }

        private void habilitadosSegundaDefensaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRptHabiDefSegInsModI == false)
            {
                RptHabiDefSegInsModI = new VISTAS.REPORTES.DEFENSA.HabilitadosSegundaInstancia();
                RptHabiDefSegInsModI.MdiParent = this;
                RptHabiDefSegInsModI.Show();
                BandRptHabiDefSegInsModI = true;
            }
            else
            {
                RptHabiDefSegInsModI.Close();
                RptHabiDefSegInsModI = new VISTAS.REPORTES.DEFENSA.HabilitadosSegundaInstancia();
                RptHabiDefSegInsModI.MdiParent = this;
                RptHabiDefSegInsModI.Show();
            }
        }

        private void defensasParaHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRptDefHoy == false)
            {
                RptDefHoy = new VISTAS.REPORTES.DEFENSA.DefensasParaHoy();
                RptDefHoy.MdiParent = this;
                RptDefHoy.Show();
                BandRptDefHoy = true;
            }
            else
            {
                RptDefHoy.Close();
                RptDefHoy = new VISTAS.REPORTES.DEFENSA.DefensasParaHoy();
                RptDefHoy.MdiParent = this;
                RptDefHoy.Show();
            }
        }

        private void usuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandUsuSis == false)
            {
                UsuSis = new VISTAS.USUARIOS.InsertarUsuario();
                UsuSis.MdiParent = this;
                UsuSis.Show();
                BandUsuSis = true;
            }
            else
            {
                UsuSis.Close();
                UsuSis = new VISTAS.USUARIOS.InsertarUsuario();
                UsuSis.MdiParent = this;
                UsuSis.Show();
            }
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandModDatUsuSis == false)
            {
                ModDatUsuSis = new VISTAS.USUARIOS.MODIFICAR.DatosPersonales();
                ModDatUsuSis.MdiParent = this;
                ModDatUsuSis.Show();
                BandModDatUsuSis = true;
            }
            else
            {
                ModDatUsuSis.Close();
                ModDatUsuSis = new VISTAS.USUARIOS.MODIFICAR.DatosPersonales();
                ModDatUsuSis.MdiParent = this;
                ModDatUsuSis.Show();
            }
        }

        private void contraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandModContra == false)
            {
                ModContra = new VISTAS.USUARIOS.MODIFICAR.Contraseña();
                ModContra.MdiParent = this;
                ModContra.Show();
                BandModContra = true;
            }
            else
            {
                ModContra.Close();
                ModContra = new VISTAS.USUARIOS.MODIFICAR.Contraseña();
                ModContra.MdiParent = this;
                ModContra.Show();
            }
        }

        private void alumnosSinProgramarDefensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRepAlumnosSinDefensa == false)
            {
                RepAlumnosSinDefensa = new VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas();
                RepAlumnosSinDefensa.MdiParent = this;
                RepAlumnosSinDefensa.Show();
                BandRepAlumnosSinDefensa = true;
            }
            else
            {
                RepAlumnosSinDefensa.Close();
                RepAlumnosSinDefensa = new VISTAS.REPORTES.MODALIDAD_I.ReporteAlumnosSinProgramarDefensas();
                RepAlumnosSinDefensa.MdiParent = this;
                RepAlumnosSinDefensa.Show();
            }
        }

        private void estudiantesSinProgramarDefensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRpSinDefModII == false)
            {
                RpSinDefModII = new VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII();
                RpSinDefModII.MdiParent = this;
                RpSinDefModII.Show();
                BandRpSinDefModII = true;
            }
            else
            {
                RpSinDefModII.Close();
                RpSinDefModII = new VISTAS.REPORTES.MODALIDAD_II.RepEsSinDefModII();
                RpSinDefModII.MdiParent = this;
                RpSinDefModII.Show();
            }
        }

        private void defensasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BandRpDefHoyModII == false)
            {
                RpDefHoyModII = new VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII();
                RpDefHoyModII.MdiParent = this;
                RpDefHoyModII.Show();
                BandRpDefHoyModII = true;
            }
            else
            {
                RpDefHoyModII.Close();
                RpDefHoyModII = new VISTAS.REPORTES.DEFENSA_II.DefensasHoyModII();
                RpDefHoyModII.MdiParent = this;
                RpDefHoyModII.Show();
            }
        }

        private void estudiantesSinPresentarCronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRpEsSinCro == false)
            {
                RpEsSinCro = new VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma();
                RpEsSinCro.MdiParent = this;
                RpEsSinCro.Show();
                BandRpEsSinCro = true;
            }
            else
            {
                RpEsSinCro.Close();
                RpEsSinCro = new VISTAS.REPORTES.MODALIDAD_II.RepEstudiantesSinCronograma();
                RpEsSinCro.MdiParent = this;
                RpEsSinCro.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (BandRpPreCroFecha == false)
            {
                RpPreCroFecha = new VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha();
                RpPreCroFecha.MdiParent = this;
                RpPreCroFecha.Show();
                BandRpPreCroFecha = true;
            }
            else
            {
                RpPreCroFecha.Close();
                RpPreCroFecha = new VISTAS.REPORTES.CRONOGRAMA.RepPresentacionCronogramaPorFecha();
                RpPreCroFecha.MdiParent = this;
                RpPreCroFecha.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (BandRpDefModIPenNotas == false)
            {
                RpDefModIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas();
                RpDefModIPenNotas.MdiParent = this;
                RpDefModIPenNotas.Show();
                BandRpDefModIPenNotas = true;
            }
            else
            {
                RpDefModIPenNotas.Close();
                RpDefModIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IPendientesDeNotas();
                RpDefModIPenNotas.MdiParent = this;
                RpDefModIPenNotas.Show();
            }
        }

        private void defensasPendientesDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRpDefModIIPenNotas == false)
            {
                RpDefModIIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas();
                RpDefModIIPenNotas.MdiParent = this;
                RpDefModIIPenNotas.Show();
                BandRpDefModIIPenNotas = true;
            }
            else
            {
                RpDefModIIPenNotas.Close();
                RpDefModIIPenNotas = new VISTAS.REPORTES.DEFENSA.ReporteDefensasMod_IIPendientesDeNotas();
                RpDefModIIPenNotas.MdiParent = this;
                RpDefModIIPenNotas.Show();
            }
        }

        private void modalidadIIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandDefMin == false)
            {
                DefMin = new VISTAS.DEFENSA_III.InsertarDefensaIII();
                DefMin.MdiParent = this;
                DefMin.Show();
                BandDefMin = true;
            }
            else
            {
                DefMin.Close();
                DefMin = new VISTAS.DEFENSA_III.InsertarDefensaIII();
                DefMin.MdiParent = this;
                DefMin.Show();
            }
        }

        private void notasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BandActNotasModIII == false)
            {
                ActNotasModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.Notas();
                ActNotasModIII.MdiParent = this;
                ActNotasModIII.Show();
                BandActNotasModIII = true;
            }
            else
            {
                ActNotasModIII.Close();
                ActNotasModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.Notas();
                ActNotasModIII.MdiParent = this;
                ActNotasModIII.Show();
            }
        }

        private void tribunalesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BandActTribModIII == false)
            {
                ActTribModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.TribunalesDefensaMinisterio();
                ActTribModIII.MdiParent = this;
                ActTribModIII.Show();
                BandActTribModIII = true;
            }
            else
            {
                ActTribModIII.Close();
                ActTribModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.TribunalesDefensaMinisterio();
                ActTribModIII.MdiParent = this;
                ActTribModIII.Show();
            }
        }

        private void fechaDeDefensaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActFechaDefModIII == false)
            {
                ActFechaDefModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.FechaDefensaModIII();
                ActFechaDefModIII.MdiParent = this;
                ActFechaDefModIII.Show();
                BandActFechaDefModIII = true;
            }
            else
            {
                ActFechaDefModIII.Close();
                ActFechaDefModIII = new VISTAS.DEFENSA_III.ACTUALIZAR.FechaDefensaModIII();
                ActFechaDefModIII.MdiParent = this;
                ActFechaDefModIII.Show();
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandInsModOlvi == false)
            {
                InsModOlvi = new VISTAS.MODALIDAD_OLVIDADA.InsertarModalidadOlvidada();
                InsModOlvi.MdiParent = this;
                InsModOlvi.Show();
                BandInsModOlvi = true;
            }
            else
            {
                InsModOlvi.Close();
                InsModOlvi = new VISTAS.MODALIDAD_OLVIDADA.InsertarModalidadOlvidada();
                InsModOlvi.MdiParent = this;
                InsModOlvi.Show();
            }
        }

        private void datosDeLaModalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandActModalidad_II == false)
            {
                ActModalidad_II = new VISTAS.MODALIDAD_II.ActualizarModalidadII();
                ActModalidad_II.MdiParent = this;
                ActModalidad_II.Show();
                BandActModalidad_II = true;
            }
            else
            {
                ActModalidad_II.Close();
                ActModalidad_II = new VISTAS.MODALIDAD_II.ActualizarModalidadII();
                ActModalidad_II.MdiParent = this;
                ActModalidad_II.Show();
            }
        }

        private void ampliarModalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BandRetModII == false)
            {
                RetModII = new VISTAS.AMPLIACION.Retrazar();
                RetModII.MdiParent = this;
                RetModII.Show();
                BandRetModII = true;
            }
            else 
            {
                RetModII.Close();
                RetModII = new VISTAS.AMPLIACION.Retrazar();
                RetModII.MdiParent = this;
                RetModII.Show();
            }

        }

         
    }
}