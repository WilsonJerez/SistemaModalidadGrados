using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.ESTUDIANTE
{
    public partial class InsertarEstudiante : Form
    {
        public InsertarEstudiante()
        {
            InitializeComponent();
        }
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        BSS.Bss_Facultad ObjFacultad = new BSS.Bss_Facultad();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();

        //variables para recuperar los ids necesarios para registrar un estudiante
        int IdCarrera;
        int idFacultad;
        int IdTipoMOdalidad;
        int IdGrupo;
        int IndiceParaColor=0;

        
        // variables para recuperar los registros des la base de datos para cargar el formulario de registro de studiante
        DataTable Carreras = new DataTable();// tabla para recuperar las carreras y su id 
        DataTable Facultades = new DataTable();// tabla que contiene las facultades, para filtarar las carreras de acuerdo a las facultades
        DataTable TipoModalidad = new DataTable();
        DataTable Grupos = new DataTable();
        DataTable AlumnosRegistrados = new DataTable();// tabla para recuperar el numero de alumnos registrados por grupo

        private void InsertarEstudiante_Load(object sender, EventArgs e)
        {
            Facultades = ObjFacultad.SeleccionarFacultadBss();
            TipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadBss();

            idFacultad = DAL.Dal_Login.id_facultad;
            ObjCarrera.ID_FACULTAD = idFacultad;
            ObjCarrera.ESTADO = 1;
            Carreras = ObjCarrera.SeleccionarCarreraCriterioBss();
            cmbcarrera.DataSource = Carreras;
            cmbcarrera.DisplayMember = "carrera";
            
            

            CmbTipoModalidad.DataSource = TipoModalidad;
            CmbTipoModalidad.DisplayMember = "tipo_modalidad";

            //cargando grid de grupos


            ObjGrupo.ID_AULA = 0;
            ObjGrupo.ID_CONTRATO = 0;
            ObjGrupo.ID_GRUPO = 0;
            ObjGrupo.ID_TURNO = 0;
            ObjGrupo.N_GRUPO = 0;
            ObjGrupo.GESTION = DateTime.Now.Year;
            ObjGrupo.ESTADO = 1;
            Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();// recuperamos el dato de los grupos
            AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();

            // cargamos el grid d grupos mediante la funcion
            GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);
            
                
            

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            bool BandCarta = false;
            bool BandTema = false;

            //dfinir que tipo de documento y validar
            string ci = "";
            if (RbtnCi.Checked == true)
            {
                if (Validaciones.ci(Txtci.Text) == true)
                {
                    ci = Txtci.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Introduzca un ci valido o dni cambiando la opcion de tipo de documento", "ERROR DE DATO");
                    Txtci.BackColor = Color.Red;
                }

            }
            else
            {
                ci = Txtci.Text.ToUpper();
            }
            //********************************************


            if (ci != "")
            {
                Txtci.BackColor = Color.White;
                
                if (Validaciones.texto(txtnombre.Text.ToUpper()) == true)
                {
                    txtnombre.BackColor = Color.White;
                    
                    if(Validaciones.texto(txtpaterno.Text.ToUpper())==true)
                    {
                        txtpaterno.BackColor = Color.White;
                    
                        if (Validaciones.texto(txtmaterno.Text.ToUpper()) == true)
                        {
                            txtmaterno.BackColor = Color.White;
                            
                            if (Validaciones.telefono(txttelefono.Text) == true)
                            {
                                txttelefono.BackColor = Color.White;
                                
                                if (Validaciones.celular(txtcelular.Text) == true)
                                {
                                    txtcelular.BackColor = Color.White;
                                   
                                    if (txtdireccion.Text != null)
                                    {
                                        txtdireccion.BackColor = Color.White;
                                       
                                        if (Validaciones.email(txtmail.Text) == true)
                                        {
                                            txtmail.BackColor = Color.White;
                                            //validaciones para la modalidad I
                                            if (IdTipoMOdalidad > 0)
                                            {
                                                CmbTipoModalidad.BackColor = Color.White;

                                                if (TxtTema.Text != "")
                                                {
                                                    TxtTema.BackColor = Color.White;

                                                    //if (TxtNroCarta.Text!="")
                                                    //{
                                                        TxtNroCarta.BackColor = Color.White;


                                                        if (IdGrupo > 0)
                                                        {
                                                            //verificamo que no exista el nro d cartar en las modalidaddes activas
                                                            //ObjModalidadI.ESTADO=1;
                                                            //ObjModalidadI.N_CARTA=TxtNroCarta.Text.ToUpper();
                                                            //if (ObjModalidadI.SeleccionarNroCartaBss().Rows.Count > 0)
                                                            //{
                                                            //    BandCarta = true;
                                                            //}
                                                            ////verificamos que no exista el nro de carta en las modalidades inactivas
                                                            //ObjModalidadI.ESTADO = 0;
                                                            //if (ObjModalidadI.SeleccionarNroCartaBss().Rows.Count > 0)
                                                            //{
                                                            //    BandCarta = true;
                                                            //}

                                                            ////quitamos el nro  de carta para que no perjudique la busqueda del tema 
                                                            //ObjModalidadI.N_CARTA = null;
                                                            // busqueda de tema en las modalidades inactivas
                                                            ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                                            if (ObjModalidadI.SeleccionarTemaBss().Rows.Count > 0)
                                                            {
                                                                BandTema = true;
                                                            }
                                                            //busqueda en las modalidades activas
                                                            ObjModalidadI.ESTADO = 1;
                                                            if (ObjModalidadI.SeleccionarTemaBss().Rows.Count > 0)
                                                            {
                                                                BandTema = true;
                                                            }

                                                            if (BandCarta == false)// preguntamos si existe el nro de carta
                                                            {
                                                                if (BandTema == false)// preguntamos si se econtro el tema dentro de las modalidades desarrolladas
                                                                {

                                                                    //quitamos tema para buscar solo ci
                                                                    ObjModalidadI.TEMA = null;

                                                                    ObjEstudiante.CI = Txtci.Text.ToUpper();
                                                                    ObjEstudiante.ESTADO = 1;

                                                                    // CONSULTAMOS SI EXISTE UNALUMNO CON EL NUMERO DE CI
                                                                    if (ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows.Count > 0)
                                                                    {
                                                                        if (MessageBox.Show("Ya existe un estudiante con ese C.I.", "ALERTA DE DUPLICIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                                        {
                                                                            ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
                                                                            ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
                                                                            ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
                                                                            ObjEstudiante.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                                                            ObjEstudiante.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                                            ObjEstudiante.DIRECCION = txtdireccion.Text.ToUpper();

                                                                            ObjEstudiante.MAIL = txtmail.Text;
                                                                            ObjEstudiante.ESTADO = 1;
                                                                            ObjEstudiante.ID_CARRERA = IdCarrera;
                                                                            ObjEstudiante.InsertarEstudianteBss();//GUARDAMOS AL ESTUDIANTE

                                                                            // CARGAMOS LOS VALORES PARA LA MODALIDAD_I
                                                                            ObjModalidadI.ESTADO = 1;
                                                                            ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                                                            ObjModalidadI.ID_ESTUDIANTE = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"]);// RECUPERAMOS EL ID DEL ESTUDIANTE
                                                                            ObjModalidadI.ID_GRUPO = IdGrupo;
                                                                            ObjModalidadI.ID_TIPO_MODALIDAD = IdTipoMOdalidad;
                                                                            ObjModalidadI.N_CARTA = TxtNroCarta.Text.ToUpper();
                                                                            ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                                                            ObjModalidadI.FECHA_INSCRIPCION = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToShortDateString());


                                                                            ObjModalidadI.InsertarModalidadIBss();// GUARDAMOS LOS DATOS DE LA MODALIDAD

                                                                            //actualizamo el grid de grupos
                                                                            Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();// recuperamos el dato de los grupos
                                                                            AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();
                                                                            GridGrupos.Rows.Clear();
                                                                            GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

                                                                            MessageBox.Show("El registro del estudiante fue exitoso", "EXITO");
                                                                            // LIMPIAMOS LOS CAMPOS DE LOS DATOS
                                                                            Txtci.Clear();
                                                                            txtnombre.Clear();
                                                                            txtpaterno.Clear();
                                                                            txtmaterno.Clear();
                                                                            txttelefono.Clear();
                                                                            txtcelular.Clear();
                                                                            txtdireccion.Clear();
                                                                            txtmail.Clear();
                                                                            TxtNroCarta.Clear();
                                                                            TxtTema.Clear();

                                                                            IdGrupo = 0;

                                                                            CkbSinCelular.Checked = false;
                                                                            CkbSinTelefono.Checked = false;
                                                                            CkbSinMail.Checked = false;
                                                                            CkbDireccion.Checked = false;

                                                                        }


                                                                    }
                                                                    else
                                                                    {
                                                                        ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
                                                                        ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
                                                                        ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
                                                                        ObjEstudiante.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                                                        ObjEstudiante.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                                        ObjEstudiante.DIRECCION = txtdireccion.Text.ToUpper();

                                                                        ObjEstudiante.MAIL = txtmail.Text;
                                                                        ObjEstudiante.ESTADO = 1;
                                                                        ObjEstudiante.ID_CARRERA = IdCarrera;
                                                                        ObjEstudiante.InsertarEstudianteBss();//GUARDAMOS AL ESTUDIANTE

                                                                        // CARGAMOS LOS VALORES PARA LA MODALIDAD_I
                                                                        ObjModalidadI.ESTADO = 1;
                                                                        ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                                                        ObjModalidadI.ID_ESTUDIANTE = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"]);// RECUPERAMOS EL ID DEL ESTUDIANTE
                                                                        ObjModalidadI.ID_GRUPO = IdGrupo;
                                                                        ObjModalidadI.ID_TIPO_MODALIDAD = IdTipoMOdalidad;
                                                                        ObjModalidadI.N_CARTA = TxtNroCarta.Text.ToUpper();
                                                                        ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                                                        ObjModalidadI.FECHA_INSCRIPCION = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToShortDateString());


                                                                        ObjModalidadI.InsertarModalidadIBss();// GUARDAMOS LOS DATOS DE LA MODALIDAD

                                                                        //actualizamo el grid de grupos
                                                                        Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();// recuperamos el dato de los grupos
                                                                        AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();
                                                                        GridGrupos.Rows.Clear();
                                                                        GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

                                                                        MessageBox.Show("El registro del estudiante fue exitoso", "EXITO");
                                                                        // LIMPIAMOS LOS CAMPOS DE LOS DATOS
                                                                        Txtci.Clear();
                                                                        txtnombre.Clear();
                                                                        txtpaterno.Clear();
                                                                        txtmaterno.Clear();
                                                                        txttelefono.Clear();
                                                                        txtcelular.Clear();
                                                                        txtdireccion.Clear();
                                                                        txtmail.Clear();
                                                                        TxtNroCarta.Clear();
                                                                        TxtTema.Clear();

                                                                        IdGrupo = 0;

                                                                        CkbSinCelular.Checked = false;
                                                                        CkbSinTelefono.Checked = false;
                                                                        CkbSinMail.Checked = false;
                                                                        CkbDireccion.Checked = false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("El tema que intenta registrar para el estudiante ya fue desarrollado, no puede ser nuevamente desarrollado", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                                    TxtTema.BackColor = Color.Red;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El nro de carta que intenta asignar al estudiante ya fue asignado, el nro de carta debe ser unico, inserte otro nro de carta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                                TxtNroCarta.BackColor = Color.Red;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("No sea ha seleccionado el grupo al que pertenecera el alumno, haga doble click sobre elgrup al que desea registrarlo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                    //}
                                                    //else
                                                    //{
                                                    //    MessageBox.Show("El numero de carta de solicitud de modalidad_I es requisito indispensable", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    //    TxtNroCarta.BackColor = Color.Red;
                                                    //}
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Para el registro de un alumno el tema es requisito indispensable", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    TxtTema.BackColor = Color.Red;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El campo tipo modalidad no contiene un tipo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                CmbTipoModalidad.BackColor = Color.Red;
                                            }
                                           
                                        }
                                        else
                                        {
                                            MessageBox.Show("El texto del campo EMAIL es incorrecto... Ejemplo. wil.renovation@gmail.com , wilsonj_19@hotmail.com", "ERROR DE DATO");
                                            txtmail.BackColor = Color.Red;
                                            
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo del DIRECCION debe contener alguna direccion", "ERROR DE DATO");
                                        txtdireccion.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo del CELULAR debe contener solo numeros, 8 digitos, debe iniciar con 7", "ERROR DE DATO");
                                    txtcelular.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo del TELEFONO debe contener solo numeros", "ERROR DE DATO");
                            }
                        }
                        else 
                        {
                            MessageBox.Show("El campo del AP. MATERNO debe contener solo letras", "ERROR DE DATO");
                            txtmaterno.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo del AP. PATERNO debe contener solo letras", "ERROR DE DATO");
                        txtpaterno.BackColor=Color.Red;

                    }
                }
                else
                { 
                    MessageBox.Show("El campo del NOMBRE debe contener solo letras", "ERROR DE DATO");
                    txtnombre.BackColor = Color.Red;
                }
                    
            }
            else
            {
                MessageBox.Show("El campo del CI debe contener 7 digitos", "ERROR DE DATO");
                Txtci.BackColor = Color.Red;
            }

        }

        private void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCarrera = Convert.ToInt32(Carreras.Rows[cmbcarrera.SelectedIndex]["id_carrera"]);//recuperamos el id de la carrera pra ingresar el estudiante
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipoMOdalidad = Convert.ToInt32(TipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"]);
        }

        private void GridGrupos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GridGrupos["registrados", e.RowIndex].Value) < Convert.ToInt32(GridGrupos["capacidad", e.RowIndex].Value))
                {

                    GridGrupos.Rows[IndiceParaColor].DefaultCellStyle.BackColor = Color.White;
                    GridGrupos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    IdGrupo = Convert.ToInt32(Grupos.Rows[e.RowIndex]["id_grupo"]);
                    IndiceParaColor = e.RowIndex;
                }
                else
                {
                    MessageBox.Show("No se puede asignar mas estudiantes al grupo que intenta seleccionar, el aula que fue asignada al grupo no tiene capacidad para mas alumnos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ee)
            {
                IndiceParaColor = 0;
                MessageBox.Show(ee.ToString());
            }
            
        }
        // funcion para actualizar la capacidad de las aulas
        public DataGridView ActualizarGridGrupos(DataGridView GridGrpos,DataTable gruposX,DataTable alumnosregistradosX)
        {   
            for (int i = 0; i < Grupos.Rows.Count; i++)// bucle para cargar el datagridview de grupos
            {
                GridGrupos.Rows.Add();
                GridGrupos["grupo",i ].Value = Grupos.Rows[i]["n_grupo"];
                GridGrupos["turno",i ].Value = Grupos.Rows[i]["turno"];
                GridGrupos["fecha_inicio",i ].Value =Convert.ToDateTime(Grupos.Rows[i]["fecha_inicio"].ToString()).ToShortDateString();
                GridGrupos["fecha_final", i].Value =Convert.ToDateTime( Grupos.Rows[i]["fecha_final"].ToString()).ToShortDateString();
                GridGrupos["capacidad", i].Value = Grupos.Rows[i]["capacidad"];

                for (int fi = 0; fi < AlumnosRegistrados.Rows.Count; fi++)// bucle utilizado par calcular los alumnos registrado en un grupo
                {
                    if (Convert.ToInt32(Grupos.Rows[i]["n_grupo"]) == Convert.ToInt32(AlumnosRegistrados.Rows[fi]["n_grupo"]))
                    {
                        GridGrupos["registrados", i].Value = Convert.ToInt32(AlumnosRegistrados.Rows[fi]["n"]);
                    }
                    
                }
            }
            return GridGrupos;

        }

       

        private void cmbcarrera_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CkbSinTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinTelefono.Checked == true)
            {
                txttelefono.Text = "6600000";
                txttelefono.ReadOnly = true;
            }
            else
            {
                txttelefono.Clear();
                txttelefono.ReadOnly = false;
            }
        }

        private void CkbSinCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinCelular.Checked == true)
            {
                txtcelular.Text = "00000000";
                txtcelular.ReadOnly = true;
            }
            else
            {
                txtcelular.Clear();
                txtcelular.ReadOnly = false;
            }
        }

        private void CkbSinMail_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinMail.Checked == true)
            {
                txtmail.Text = "sin_mail@sin_mail.com";
                txtmail.ReadOnly = true;
            }
            else
            {
                txtmail.Clear();
                txtmail.ReadOnly = false;
            }
        }

        private void CkbDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbDireccion.Checked == true)
            {
                txtdireccion.Text = "sin direccion";
                txtdireccion.ReadOnly = true;
            }
            else
            {
                txtdireccion.Clear();
                txtdireccion.ReadOnly = false;
            }
        }

        

        

        

        
    }

}