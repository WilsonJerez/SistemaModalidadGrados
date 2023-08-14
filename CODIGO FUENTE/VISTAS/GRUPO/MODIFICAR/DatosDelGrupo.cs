using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.GRUPO.MODIFICAR
{
    public partial class DatosDelGrupo : Form
    {
        public DatosDelGrupo()
        {
            InitializeComponent();
        }
        //variables para recibir datos
        public int IdGrupoRecibidoRe;
        public int IdContratoRecibido;
        public int IdAulaRecibido;
        public int IdTurnoRecibido;
        public string NroGrupoRe;
        public string FechaInicioRe;
        public string FechaFinalRe;
        public string AulaRe;
        public string TurnoRe;
        //funciones
        private ComboBox CargarAulas(ComboBox CmbX, DataTable Dtx)
        {
            CmbX.Items.Clear();
            for (int i = 0; i < Dtx.Rows.Count; i++)
            {
                CmbX.Items.Add(Dtx.Rows[i]["n_aula"].ToString());
            }
            return CmbX;
        }
        private ComboBox CargarTurno(ComboBox CmbX, DataTable Dtx)
        {
            CmbX.Items.Clear();
            for (int i = 0; i < Dtx.Rows.Count; i++)
            {
                CmbX.Items.Add(Dtx.Rows[i]["turno"].ToString());
            }
            return CmbX;
        }
        //objetos a utilizar
        BSS.Bss_Turno ObjTurno = new BSS.Bss_Turno();
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        //data tables para recupera ids
        DataTable DtTurnos = new DataTable();
        DataTable DtAulas = new DataTable();
        //variables para ids
        int IdAula = 0;
        int IdTurno = 0;
        //otras utilizadas
        bool semaforo = false;
        bool SemaforoAula = false;
        bool SemaforoTurno = false;
        private void DatosDelGrupo_Load(object sender, EventArgs e)
        {
             //habilitamos los controles para que se realice el seteo con datos del grupo
           

            //cargamos la lista de aulas y turnos
            ObjTurno.ESTADO = 1;
            DtTurnos=ObjTurno.SeleccionarTurnoCriterioBss();
            CmbTurno = CargarTurno(CmbTurno,DtTurnos );
            

            ObjAula.ESTADO = 1;
            DtAulas = ObjAula.SeleccionarAulaCriterioBss();
            CmbAula = CargarAulas(CmbAula, DtAulas);
           
            
            //hacemos que los controles carguen los datos del grupo por defecto 
            TxtGrupo.Text = NroGrupoRe;
            semaforo = true;
            DtpFechaInicio.Value = Convert.ToDateTime(FechaInicioRe);
            DtpFechaFinal.Value = Convert.ToDateTime(FechaFinalRe);
            //habilitamos los controles para que se realice el seteo con datos del grupo
            
            CmbAula.SelectedItem = AulaRe;
            CmbTurno.SelectedItem = TurnoRe;

            SemaforoAula = true;
            SemaforoTurno = true;
            //volvemos a deshabilitar los controles
           


            

        }

        private void CmbTurno_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbAula_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CkbFechaInicio_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFechaInicio.Checked == true)
            {
                if (DAL.Dal_Login.fecha <= Convert.ToDateTime(FechaInicioRe))
                {
                    DtpFechaInicio.Enabled = true;
                }
                else
                {
                    CkbFechaInicio.Checked = false;
                    MessageBox.Show("La fecha de inicio no se la puede cambiar por que el grupo ya inicio sus clases", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                DtpFechaInicio.Value = Convert.ToDateTime(FechaInicioRe);
                DtpFechaInicio.Enabled = false;
            }
        }

        private void CkbFechaFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFechaFinal.Checked == true)
            {
                DtpFechaFinal.Enabled = true;
            }
            else
            {
                DtpFechaFinal.Value = Convert.ToDateTime(FechaFinalRe);
                DtpFechaFinal.Enabled = false;
            }
        }

        private void CkbTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTurno.Checked == true)
            {
                CmbTurno.Enabled = true;
            }
            else
            {
                CmbTurno.SelectedItem = TurnoRe;
                CmbTurno.Enabled = false;
            }
        }

        private void CkbAula_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbAula.Checked == true)
            {
                CmbAula.Enabled = true;
            }
            else
            {
                CmbAula.SelectedItem = AulaRe;
                CmbAula.Enabled = false;
            }
        }

        private void CkbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbGrupo.Checked == true)
            {
                TxtGrupo.Enabled = true;
                TxtGrupo.Clear();
            }
            else
            {
                TxtGrupo.Text = NroGrupoRe;
                TxtGrupo.Enabled = false;
            }
        }
        private void CmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTurno = Convert.ToInt32(DtTurnos.Rows[CmbTurno.SelectedIndex]["id_turno"].ToString());
            //cargamos parametros para validar que el docente no tenga grupos en el turno seleccionado
            if (IdTurno != IdTurnoRecibido &SemaforoTurno==true)
            {
                ObjGrupo.ESTADO = 1;
                ObjGrupo.ID_TURNO = IdTurno;
                ObjGrupo.ID_CONTRATO = IdContratoRecibido;
                if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                {

                    MessageBox.Show("El docente que fue asignado al grupo ya tiene un grupo al cual debe asistir en el turno que desea asignar al grupo, no se puede realizar la modificacion, seleccione otro turno o cambie de docente para el grupo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CmbTurno.SelectedItem = TurnoRe;
                    CmbTurno.Enabled = false;
                    CkbTurno.Checked = false;
                }
                //liberamos atributos que perjudican en la verificacion del aula                              
                ObjGrupo.ID_CONTRATO = 0;
                //cargamos id de aula para poder validar que no choque en el mismo turno
                ObjGrupo.ID_AULA = IdAula;
                if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                {
                    MessageBox.Show("No se puede asignar el turno seleccionado al grupo ya provocaria un choque de aulas, seleccione otro turno o cambie de aula para el grupo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CmbTurno.SelectedItem = TurnoRe;
                    CmbTurno.Enabled = false;
                    CkbTurno.Checked = false;
                }
                //liberamos todos los atributos
                ObjGrupo.ID_TURNO = 0;
                ObjGrupo.ID_AULA = 0;
            }
            
           
            
        }
        private void CmbAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            IdAula = Convert.ToInt32(DtAulas.Rows[CmbAula.SelectedIndex]["id_aula"].ToString());
            //cargamos parametros para validad que verificar que el aula no este ocupada con otro egrupo en el turno seleccionado
            if (IdAula != IdAulaRecibido & SemaforoAula==true)
            {
                ObjGrupo.ESTADO = 1;
                ObjGrupo.ID_TURNO = IdTurno;
                ObjGrupo.ID_AULA = IdAula;
                if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                {
                    MessageBox.Show("El aula seleccionada ya esta ocupada con otro grupo en el turno asignado al grupo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CmbAula.SelectedItem = AulaRe;
                    CmbAula.Enabled = false;
                    CkbAula.Checked = false;
                }
                //liberamos atributos
                ObjGrupo.ID_AULA = 0;
                ObjGrupo.ID_TURNO = 0;

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //para validad de que exista al menos un campo seleccionado para modificar
            if (CkbGrupo.Checked == true || CkbFechaInicio.Checked == true || CkbFechaFinal.Checked == true || CkbTurno.Checked == true || CkbAula.Checked == true)
            {
                // para validar y asignar el nro de grupo
                if (CkbTurno.Checked == true)
                {
                    
                }
                else
                {
                    ObjGrupo.N_GRUPO = 0;
                }

                //para la fecha d einicio
                if (CkbFechaInicio.Checked == true)
                {
                    ObjGrupo.FECHA_INICIO = DtpFechaInicio.Value.ToString("MM/dd/yyyy");
                }
                else
                {
                    ObjGrupo.FECHA_INICIO = null;
                }
                //para la fecha final
                if (CkbFechaFinal.Checked == true)
                {
                    ObjGrupo.FECHA_FINAL = DtpFechaFinal.Value.ToString("MM/dd/YYYY");
                }
                else
                {

                    ObjGrupo.FECHA_FINAL = null;
                }

                //para el turno

                if (CkbTurno.Checked == true)
                {
                    ObjGrupo.ID_TURNO = IdTurno;
                }
                else
                {
                    ObjGrupo.ID_TURNO = 0;
                }
                //para el aula
                if (CkbAula.Checked == true)
                {
                    ObjGrupo.ID_AULA = IdAula;
                }
                else
                {
                    ObjGrupo.ID_AULA = 0;
                }
                //realizamos la modificacion
                ObjGrupo.ESTADO = 1;
                ObjGrupo.ID_GRUPO = IdGrupoRecibidoRe;
                ObjGrupo.ModificarGrupoBss();
                MessageBox.Show("Se realizo la modificacion exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();

            }
            else
            {
                MessageBox.Show("Para realizar una actualizacion debe seleccionar al menos un campo a modificar, caso contrario cierre este formulario para volver al anterio", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }




        }

        
        private void TxtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }

        private void TxtGrupo_TextChanged(object sender, EventArgs e)
        {
            if (TxtGrupo.Text != "" & semaforo==true & TxtGrupo.Text!=NroGrupoRe)
            {
                if (Validaciones.numero(TxtGrupo.Text) == true)
                {
                    //validamos que no exista un grupo con ese numero
                    ObjGrupo.ESTADO = 1;
                    ObjGrupo.N_GRUPO = Convert.ToInt32(TxtGrupo.Text);
                    ObjGrupo.GESTION = DAL.Dal_Login.fecha.Year;

                    if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                    {
                        ObjGrupo.ESTADO = 1;
                        ObjGrupo.N_GRUPO = 0;
                        ObjGrupo.GESTION = 0;
                        MessageBox.Show("El numero de grupo que esta inentando asignar ya existe en esta gestion, introduzca otro numero", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtGrupo.Clear();
                        CkbGrupo.Checked = false;
                    }
                    else
                    {
                        ObjGrupo.ESTADO = 0;
                        if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count == 0)
                        {
                            ObjGrupo.N_GRUPO = Convert.ToInt32(TxtGrupo.Text);
                        }
                        else
                        {
                            ObjGrupo.N_GRUPO = 0;

                            ObjGrupo.ESTADO = 1;
                            ObjGrupo.N_GRUPO = 0;
                            ObjGrupo.GESTION = 0;
                            MessageBox.Show("El numero de grupo que esta inentando asignar ya existe en esta gestion, introduzca otro numero", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            TxtGrupo.Clear();
                            CkbGrupo.Checked = false;

                        }


                    }

                }
                else
                {
                    MessageBox.Show("El Numero de grupo solo puede contener numeros", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtGrupo.Clear();
                }
            }
        }

        

        
        
    }
}
