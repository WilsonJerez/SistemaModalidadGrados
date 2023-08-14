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
    public partial class InsertarEstudianteRepitente : Form
    {
        public InsertarEstudianteRepitente()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();

        //data tables para recuperar datos y luego cargar a los controles
        DataTable DtListaEstudiantes = new DataTable();
        DataTable DtListaTipoModalidad = new DataTable();
        DataTable Grupos = new DataTable();
        DataTable AlumnosRegistrados = new DataTable();// tabla para recuperar el numero de alumnos registrados por grupo

        //indice para el color
        int IndiceColorEstudiante = 0;
        int IndiceParaColor = 0;
        //variables para captuar los ids necesarios
        int IdEstudiante = 0;
        int IdTipoModalidad = 0;
        int IdGrupo = 0;

        private void InsertarEstudianteRepitente_Load(object sender, EventArgs e)
        {
            DtListaTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadBss();
            CmbTipoModalidad.DataSource = DtListaTipoModalidad;
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

            //DtListaEstudiantes = ObjEstudiante.FiltrarEstudiantesHabilitadosParaRepetirModalidadBss();
            //DgvEstudiantes = CargarEstudiantes(DgvEstudiantes, DtListaEstudiantes);

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ObjEstudiante.ESTADO = 1;

            if (TxtCi.Text != "")
                ObjEstudiante.CI = TxtCi.Text;
            else
                ObjEstudiante.CI=null;
            if (TxtNombre.Text != "")
                ObjEstudiante.NOMBRE = TxtNombre.Text.ToUpper();
            else
                ObjEstudiante.NOMBRE=null;
            if (TxtPaterno.Text != "")
                ObjEstudiante.PATERNO = TxtPaterno.Text.ToUpper();
            else
                ObjEstudiante.PATERNO = null;
            if (TxtMaterno.Text != "")
                ObjEstudiante.MATERNO = TxtMaterno.Text.ToUpper();
            else
                ObjEstudiante.MATERNO = TxtMaterno.Text.ToUpper();

            //recuperamos la lista de estudiantes 
            DtListaEstudiantes = ObjEstudiante.FiltrarEstudiantesHabilitadosParaRepetirModalidadBss();
            DgvEstudiantes = CargarEstudiantes(DgvEstudiantes, DtListaEstudiantes);
            IdEstudiante = 0;
            IndiceColorEstudiante = 0;
        }
        private void DgvEstudiantes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // cambiaamos el color a toda la fila seleccionada
                DgvEstudiantes.Rows[IndiceColorEstudiante].DefaultCellStyle.BackColor = Color.White;
                DgvEstudiantes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorEstudiante = e.RowIndex;
                //recuperamos el id del estudiante para luego guardar modalidad I
                IdEstudiante = Convert.ToInt32(DgvEstudiantes["ID_ESTUDIANTE", e.RowIndex].Value.ToString());
            }
            catch(Exception ex)
            {
                IndiceColorEstudiante = 0;
                MessageBox.Show(ex.ToString());
            }
        }
        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipoModalidad=Convert.ToInt32(DtListaTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"].ToString());
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            bool bandCarta = false;
            bool bandTipoModalidad = false;
            bool bandTemas = false;

            if (IdTipoModalidad > 0)
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

                            if (IdEstudiante > 0)
                            {
                                //// consultamos que no exista el nro de carta
                                //ObjModalidadI.N_CARTA =TxtNroCarta.Text.ToUpper();
                                ObjModalidadI.ESTADO = 0;// que buscar primero en las modalidades inactivas
                                //if (ObjModalidadI.SeleccionarNroCartaBss().Rows.Count > 0)
                                //{
                                //    bandCarta = true;
                                //}
                                ObjModalidadI.ESTADO = 1;//para buscar en las modalidades activas
                                //if (ObjModalidadI.SeleccionarNroCartaBss().Rows.Count > 0)
                                //{
                                //    bandCarta = true;
                                //}
                                //controlamos que no exista el tema

                                ObjModalidadI.N_CARTA = null;//quitamos el  nro de carta para que no perjudique en la busquedqa
                                ObjModalidadI.TEMA = TxtTema.Text.ToUpper();

                                if (ObjModalidadI.SeleccionarTemaBss().Rows.Count > 0)//busqueda en las modalidades activas
                                {
                                    bandTemas = true;
                                }
                                ObjModalidadI.ESTADO = 0;
                                if (ObjModalidadI.SeleccionarTemaBss().Rows.Count > 0)//busqueda en las inactivas
                                {
                                    bandTemas = true;
                                }

                                //controlamos que no repita el tipo de modalidad
                                ObjModalidadI.TEMA = null;//para que no perjudique en la busqueda
                                ObjModalidadI.ID_ESTUDIANTE = IdEstudiante;
                                ObjModalidadI.ID_TIPO_MODALIDAD = IdTipoModalidad;
                                if (ObjModalidadI.SeleccionarEstudianteTipoModalidadBss().Rows.Count > 0)//busqueda en las inactivas
                                {
                                    bandTipoModalidad = true;
                                }
                                ObjModalidadI.ESTADO = 1;
                                if (ObjModalidadI.SeleccionarEstudianteTipoModalidadBss().Rows.Count > 0)//busqueda en las activas
                                {
                                    bandTipoModalidad = true;
                                }


                                //veficamos si se encontraron tema repetido,carta repetida,estudiante con el mismo tip de modalidad
                                if (bandCarta == false)
                                {
                                    if (bandTemas == false)
                                    {
                                        if (bandTipoModalidad == false)
                                        {

                                            // CARGAMOS LOS VALORES PARA LA MODALIDAD_I
                                            ObjModalidadI.ESTADO = 1;
                                            ObjModalidadI.TEMA = TxtTema.Text.ToUpper();
                                            ObjModalidadI.ID_ESTUDIANTE = IdEstudiante;
                                            ObjModalidadI.ID_GRUPO = IdGrupo;
                                            ObjModalidadI.ID_TIPO_MODALIDAD = IdTipoModalidad;
                                            ObjModalidadI.N_CARTA =TxtNroCarta.Text.ToUpper();
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

                                            TxtNroCarta.Clear();
                                            TxtTema.Clear();

                                            IdGrupo = 0;
                                            IdEstudiante = 0;

                                            //refrescamos la lista de estudiantes habilitados para repetir la modalidad I
                                            DtListaEstudiantes = ObjEstudiante.FiltrarEstudiantesHabilitadosParaRepetirModalidadBss();
                                            DgvEstudiantes = CargarEstudiantes(DgvEstudiantes, DtListaEstudiantes);
                                        }
                                        else
                                        {
                                            CmbTipoModalidad.BackColor = Color.Red;
                                            MessageBox.Show("El estudiante al repetir la modalidad de grado I no puede optar por un tipo de modalidad ya llevado, debe cambiar el tipo de modalidad", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                    }
                                    else
                                    {
                                        TxtTema.BackColor = Color.Red;
                                        MessageBox.Show("Los temas no se pueden repetir, el tema que intenta registrar ya fue desarrollado por otro estudiante", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    TxtNroCarta.BackColor = Color.Red;
                                    MessageBox.Show("El nro de carta no se puede repetir, este numero fue asignado a una solicitud anterior", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }




                                //*****




                            }
                            else
                            {
                                MessageBox.Show("No se puede continuar con el registro, no se selecciono un estudiante", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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


        public DataGridView ActualizarGridGrupos(DataGridView GridGrpos, DataTable gruposX, DataTable alumnosregistradosX)
        {
            for (int i = 0; i < Grupos.Rows.Count; i++)// bucle para cargar el datagridview de grupos
            {
                GridGrupos.Rows.Add();
                GridGrupos["grupo", i].Value = Grupos.Rows[i]["n_grupo"];
                GridGrupos["turno", i].Value = Grupos.Rows[i]["turno"];
                GridGrupos["fecha_inicio", i].Value =Convert.ToDateTime( Grupos.Rows[i]["fecha_inicio"].ToString()).ToShortDateString();
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
        // FUNCION PARA CARGAR UN ESTUDIANTE
        public DataGridView CargarEstudiantes(DataGridView DgvEstudiantesX, DataTable DtListaEstudiantesX)
        {
            DgvEstudiantesX.Rows.Clear();
            for(int fi=0;fi<DtListaEstudiantesX.Rows.Count;fi++)
            {
                DgvEstudiantesX.Rows.Add();
                DgvEstudiantesX["ID_ESTUDIANTE", fi].Value = DtListaEstudiantesX.Rows[fi]["id_estudiante"];
                DgvEstudiantesX["CI", fi].Value = DtListaEstudiantesX.Rows[fi]["ci"];
                DgvEstudiantesX["NOMBRE", fi].Value = DtListaEstudiantesX.Rows[fi]["nombre"];
                DgvEstudiantesX["PATERNO", fi].Value = DtListaEstudiantesX.Rows[fi]["paterno"];
                DgvEstudiantesX["MATERNO", fi].Value = DtListaEstudiantesX.Rows[fi]["materno"];
                DgvEstudiantesX["CARRERA", fi].Value = DtListaEstudiantesX.Rows[fi]["carrera"];
                //DgvEstudiantesX["ID_TIPO_MODALIDAD", fi].Value = DtListaEstudiantes.Rows[fi]["id_tipo_modalidad"];
            }
            return DgvEstudiantesX;
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

        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        

        

        

        
    }
}
