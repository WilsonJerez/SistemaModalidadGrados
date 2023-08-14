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
    public partial class InsertarEstudianteNuevaCarrera : Form
    {
        public InsertarEstudianteNuevaCarrera()
        {
            InitializeComponent();
        }
        // objetos utilizados
       
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        //data tables 
        DataTable DtListaCarrera = new DataTable();
        DataTable DtListaTipoModalidad=new DataTable();
        DataTable Grupos = new DataTable();
        DataTable AlumnosRegistrados = new DataTable();

        //variables para recuperar ids
        int IdCarrera;
        int IdEstudiante;
        int IdPersona;
        int IdGrupo;
        int IdTipoModalidad;

        //otras variables
        int IndiceColorEstudiante = 0;
        int IndiceColorGrupo = 0;
        

        private void InsertarEstudianteNuevaCarrera_Load(object sender, EventArgs e)
        {
            ObjCarrera.ESTADO = 1;
            ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
            DtListaCarrera = ObjCarrera.SeleccionarCarreraCriterioBss();
            CmbCarrera.DataSource = DtListaCarrera;
            CmbCarrera.DisplayMember = "carrera";


            ObjGrupo.GESTION = DateTime.Now.Year;
            ObjGrupo.ESTADO = 1;
            Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();// recuperamos el dato de los grupos
            AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();

            // cargamos el grid d grupos mediante la funcion
            GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

            ObjTipoModalidad.ESTADO = 1;
            DtListaTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss();
            CmbTipoModalidad.DataSource = DtListaTipoModalidad;
            CmbTipoModalidad.DisplayMember = "tipo_modalidad";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtCi.Text != "")
            {
              ObjEstudiante.CI = TxtCi.Text.ToUpper();
            }
            else
            {
                ObjEstudiante.CI = null;
            }
            if (TxtNombre.Text != "")
            {
                ObjEstudiante.NOMBRE = TxtNombre.Text.ToUpper();
            }
            else
            {
                ObjEstudiante.NOMBRE = null;
            }
            if (TxtPaterno.Text != "")
            {
              ObjEstudiante.PATERNO = TxtPaterno.Text.ToUpper();
            }
            else
            {
                ObjEstudiante.PATERNO = null;
            }
            if (TxtMaterno.Text != "")
            {
                ObjEstudiante.MATERNO = TxtMaterno.Text.ToUpper();
            }
            else
            {
                ObjEstudiante.MATERNO = null;
            }
            IdPersona = 0;
            IndiceColorEstudiante = 0;
            DgvPersona = CargarDatosPersonalesEstudiante(DgvPersona, ObjEstudiante.FiltrarEstudianteSegundaCarreraBss());
        }
        private void CmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCarrera = Convert.ToInt32(DtListaCarrera.Rows[CmbCarrera.SelectedIndex]["id_carrera"]);
        }
        private void DgvPersona_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DgvPersona.Rows[IndiceColorEstudiante].DefaultCellStyle.BackColor = Color.White;
                DgvPersona.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorEstudiante = e.RowIndex;
                IdPersona = Convert.ToInt32(DgvPersona["ID_PERSONA", e.RowIndex].Value.ToString());
            }
            catch (Exception ex)
            {
                IndiceColorEstudiante = 0;
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            bool BandCarta = false;
            bool BandTema = false;
            if (IdPersona > 0)
            {
                //verificamos que el estudiante no haya cursado ya la misma carrera
                ObjEstudiante.ESTADO = 1;
                ObjEstudiante.ID_PERSONA = IdPersona;
                ObjEstudiante.ID_CARRERA = IdCarrera;
                if (ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows.Count == 0)//busqueda en los activos
                {
                    CmbCarrera.BackColor = Color.White;
                    //cambiamos el estado para buscarlo entre estudiantes dados de baja
                    ObjEstudiante.ESTADO = 0;
                    if (ObjEstudiante.SeleccionarEstudianteCriterioBss().Rows.Count == 0)
                    {
                        //if (TxtNroCarta.Text !="")
                        //{
                            TxtNroCarta.BackColor = Color.White;
                            if (TxtTema.Text != "")
                            {
                                TxtTema.BackColor = Color.White;
                                if (IdTipoModalidad > 0)
                                {
                                    if (IdGrupo > 0)
                                    {
                                        //buscamos el nro de carta que no se repita
                                        ObjModalidad_I.ESTADO = 1;
                                        ObjModalidad_I.N_CARTA = TxtNroCarta.Text.ToUpper();
                                        ObjModalidad_I.TEMA = TxtTema.Text.ToUpper();
                                        //if (ObjModalidad_I.SeleccionarNroCartaBss().Rows.Count > 0)//buscamos el nro de carta en las modalidades activas
                                        //{
                                        //    BandCarta = true;
                                        //}
                                        if (ObjModalidad_I.SeleccionarTemaBss().Rows.Count > 0)//buscamos el tema en las modalidades activas
                                        {
                                            BandTema = true;
                                        }
                                        ////cambiamos el estado de la modalidad para buscar en las inactivas
                                        ObjModalidad_I.ESTADO = 0;
                                        //if (ObjModalidad_I.SeleccionarNroCartaBss().Rows.Count > 0)
                                        //{
                                        //    BandCarta = true;
                                        //}
                                        if (ObjModalidad_I.SeleccionarTemaBss().Rows.Count > 0)
                                        {
                                            BandTema = true;
                                        }

                                        //controlamos si existen la carta y el tema
                                        if (BandCarta == false)
                                        {
                                            if (BandTema == false)
                                            {
                                                // registramos primeramente al estudiante
                                                ObjEstudiante.ESTADO = 1;
                                                ObjEstudiante.ID_CARRERA = IdCarrera;
                                                ObjEstudiante.ID_PERSONA = IdPersona;
                                                ObjEstudiante.InsertarEstudianteSegundaCarreraBss();
                                                //recuperamos el id del estudiante
                                                IdEstudiante = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"]);

                                                //cargamos los atributos para la modalidad I
                                                ObjModalidad_I.ESTADO = 1;
                                                ObjModalidad_I.ID_ESTUDIANTE = IdEstudiante;
                                                ObjModalidad_I.N_CARTA = TxtNroCarta.Text.ToUpper();
                                                ObjModalidad_I.TEMA = TxtTema.Text.ToUpper();
                                                ObjModalidad_I.ID_TIPO_MODALIDAD = IdTipoModalidad;
                                                ObjModalidad_I.ID_GRUPO = IdGrupo;
                                                ObjModalidad_I.FECHA_INSCRIPCION =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                                                //registramos las modalidad I
                                                ObjModalidad_I.InsertarModalidadIBss();
                                                MessageBox.Show("El registro del estudiante con una nueva carrera fue existoso", "EXISTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                //limpiamos los campos y resfrescamos los datos
                                                DgvPersona = CargarDatosPersonalesEstudiante(DgvPersona, ObjEstudiante.FiltrarEstudianteSegundaCarreraBss());
                                                //actualizamo el grid de grupos
                                                Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();// recuperamos el dato de los grupos
                                                AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();
                                                GridGrupos.Rows.Clear();
                                                GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

                                                TxtNroCarta.Clear();
                                                TxtTema.Clear();
                                                IdGrupo = 0;
                                                IdEstudiante = 0;
                                                IdPersona = 0;
                                                IndiceColorEstudiante = 0;
                                                IndiceColorGrupo = 0;



                                            }
                                            else
                                            {
                                                MessageBox.Show("El tema que desea asignar al estudiante ya fue desarrollado, los temas no se deben realizar", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                TxtTema.BackColor = Color.Red;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El número de carta que intenta asignar al estudiante ya fue asignado a otro estudiante, introduzca otro número de carta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            TxtNroCarta.BackColor = Color.Red;
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("No se selecciono un grupo, seleccione el grupo en el que el estudiante cursará la modalidad de grado I", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se selecciono un tipo de modalidad para el estudiante", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    CmbTipoModalidad.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El nombre del tema es indispensable para cursar la modalidad de grado I", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                TxtTema.BackColor = Color.Red;
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("El campo número de carta solo puede contener números", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //    TxtNroCarta.BackColor = Color.Red;
                        //}
                    }
                    else
                    {
                        MessageBox.Show("El estudiatne que intenta registrar ya curso la misma carrera, se encuentra de baja cambie el estado y seleccione otra carrera", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        CmbCarrera.BackColor = Color.Red;
                    }

                }
                else
                {
                    MessageBox.Show("El estudiatne que intenta registrar ya curso la misma carrera, si desea inscribirlo seleccione otra carrera", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CmbCarrera.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("No se selecciono un estudiante para la incripcion a otra carrera, es necesario seleccionar un estudiante", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipoModalidad = Convert.ToInt32(DtListaTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"].ToString());

        }
        private void GridGrupos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridGrupos.Rows[IndiceColorGrupo].DefaultCellStyle.BackColor = Color.White;
                
                if (Convert.ToInt32(GridGrupos["CAPACIDAD", e.RowIndex].Value) > Convert.ToInt32(GridGrupos["REGISTRADOS", e.RowIndex].Value))
                {
                    GridGrupos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    IndiceColorGrupo = e.RowIndex;
                    IdGrupo = Convert.ToInt32(Grupos.Rows[e.RowIndex]["id_grupo"]);
                }
                else
                {
                    IdGrupo = 0;                    
                    MessageBox.Show("El grupo no puede ser seleccionado por que su capacidad no lo permite", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                IndiceColorGrupo = 0;
                MessageBox.Show(ex.ToString());
            }
        }
        public DataGridView CargarDatosPersonalesEstudiante(DataGridView DgvPersonaX,DataTable DtListaPersonaX)
        {
            DgvPersonaX.Rows.Clear();
            for (int fi = 0; fi < DtListaPersonaX.Rows.Count; fi++)
            {
                DgvPersona.Rows.Add();
                DgvPersonaX["ID_PERSONA", fi].Value = DtListaPersonaX.Rows[fi]["id_persona"];
                DgvPersonaX["CI", fi].Value = DtListaPersonaX.Rows[fi]["ci"];
                DgvPersonaX["NOMBRE", fi].Value = DtListaPersonaX.Rows[fi]["nombre"];
                DgvPersonaX["PATERNO", fi].Value = DtListaPersonaX.Rows[fi]["paterno"];
                DgvPersonaX["MATERNO", fi].Value = DtListaPersonaX.Rows[fi]["materno"];
                DgvPersonaX["DIRECCION", fi].Value = DtListaPersonaX.Rows[fi]["direccion"];
                DgvPersonaX["TELEFONO", fi].Value = DtListaPersonaX.Rows[fi]["telefono"];
                DgvPersonaX["CELULAR", fi].Value = DtListaPersonaX.Rows[fi]["celular"];
                DgvPersonaX["CARRERA", fi].Value = DtListaPersonaX.Rows[fi]["carrera"];
            }
            return DgvPersonaX;
        }

        public DataGridView ActualizarGridGrupos(DataGridView GridGrpos, DataTable gruposX, DataTable alumnosregistradosX)
        {
            for (int i = 0; i < Grupos.Rows.Count; i++)// bucle para cargar el datagridview de grupos
            {
                GridGrupos.Rows.Add();
                GridGrupos["grupo", i].Value = Grupos.Rows[i]["n_grupo"];
                GridGrupos["turno", i].Value = Grupos.Rows[i]["turno"];
                GridGrupos["fecha_inicio", i].Value =Convert.ToDateTime(Grupos.Rows[i]["fecha_inicio"].ToString()).ToShortDateString();
                GridGrupos["fecha_final", i].Value =Convert.ToDateTime(Grupos.Rows[i]["fecha_final"].ToString()).ToShortDateString();
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
