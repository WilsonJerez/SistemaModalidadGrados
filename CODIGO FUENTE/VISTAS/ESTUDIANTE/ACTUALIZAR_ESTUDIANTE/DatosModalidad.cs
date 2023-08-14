using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE
{
    public partial class DatosModalidad : Form
    {
        public DatosModalidad()
        {
            InitializeComponent();
        }
        //parametros recibidos para el formulario
        public int IdEstudianteRecibido;
        public string ci;
        public string nombre;
        public string carrera;
        //objetos utilizados
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        //data tables para recuperar datos
        DataTable Grupos = new DataTable();
        DataTable DtTipoModalidad = new DataTable();
        DataTable DtModalidadCursadas= new DataTable();
        DataTable DtModalidadEnCurso = new DataTable();
        DataTable AlumnosRegistrados = new DataTable();
        //variables para recupera ids
        int IdModalidad;
        int IdGrupo;
        int IdTipModalidad;
        //otras variables
        int ColorModalidad = 0;
        int IndiceParaColor = 0;
        //variables para almacenar datos temporalmente
        string auxtema = "";
        string auxtipomod ="";
        string auxcarta = "";
        int auxidgrupo = 0;
        private void DatosModalidad_Load(object sender, EventArgs e)
        {
            //Cargamos los datos primarios del estudiante
            TxtCi.Text = ci;
            TxtNombre.Text = nombre;
            TxtCarrera.Text = carrera;
            // Recuperamos la o las modalidades cursadas por el estudiante
            //ObjModalidad_I.ESTADO = 0;
            ObjModalidad_I.ID_ESTUDIANTE = IdEstudianteRecibido;
            //DtModalidadCursadas = ObjModalidad_I.SeleccionarModalidadICriterioBss();
            //Recuperamos la o las modalidades en desarrollo del estudiante
            ObjModalidad_I.ESTADO = 1;
            DtModalidadEnCurso = ObjModalidad_I.SeleccionarModalidadICriterioBss();
            //cargamos el GvModalidades
            GvModalidades = CargarModalidades(GvModalidades, DtModalidadEnCurso, DtModalidadCursadas);
            //cargamos los tipos de modalidad
            ObjTipoModalidad.ESTADO = 1;
            DtTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss();
            for (int i = 0; i < DtTipoModalidad.Rows.Count; i++)
            {
                CmbTipoModalidad.Items.Add(DtTipoModalidad.Rows[i]["tipo_modalidad"]);
            }
            ////cargmos los grupos
            //ObjGrupo.ESTADO = 1;
           
            //Grupos = ObjGrupo.SeleccionarGrupoCriterioBss(); 
            ////recuperamos el conteo de registrados por grupo 
            //ObjGrupo.GESTION =Convert.ToInt32( Convert.ToDateTime(GvModalidades["FECHA_INICIO", ColorModalidad].Value.ToString()).ToString("yyyy"));
            //AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();
            //GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

            //GpActualizar.Enabled = false;
            
        }
        
        private void GvModalidades_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GvModalidades.Rows[ColorModalidad].DefaultCellStyle.BackColor = Color.White;
                if (GvModalidades["ESTADO", e.RowIndex].Value.ToString() != "FINALIZADA")
                {
                    GvModalidades.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    ColorModalidad = e.RowIndex;
                    //recuperamos el id de la modalidad para realizar una actualizacion
                    IdModalidad = Convert.ToInt32(GvModalidades["ID_MODALIDAD", e.RowIndex].Value.ToString());

                    //recuperamos datos para la actualizacion
                    CmbTipoModalidad.SelectedItem = GvModalidades["TIPO_MODALIDAD", e.RowIndex].Value.ToString();
                    TxtTema.Text = GvModalidades["TEMA", e.RowIndex].Value.ToString();
                    TxtNCarta.Text = GvModalidades["N_CARTA", e.RowIndex].Value.ToString();
                    //Recuperamos el id del grupo para que se mantenga por defecto
                    IdGrupo = Convert.ToInt32(GvModalidades["ID_GRUPO", e.RowIndex].Value.ToString());

                    //habilitamos el área de actualizaciones
                    GpActualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La modalidad ya finalizo, por lo tanto no puede modificar ningun dato de esta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    IdModalidad = 0;
                }
                
            }
            catch(Exception ex)
            {
                ColorModalidad = 0;
                MessageBox.Show(ex.ToString());
                GpActualizar.Enabled = false;
            }
        }
        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipModalidad = Convert.ToInt32(DtTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"].ToString());
        }
        private void CkbTipoModalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTipoModalidad.Checked == true)
            {
                CmbTipoModalidad.Enabled = true;
                auxtipomod = CmbTipoModalidad.Text;
            }
            else
            {
               
                CmbTipoModalidad.Enabled = false;
                CmbTipoModalidad.SelectedItem = auxtipomod;
                CmbTipoModalidad.BackColor = Color.White;
            }
        }
        private void CkbTema_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTema.Checked == true)
            {
                TxtTema.ReadOnly = false;
                auxtema = TxtTema.Text;
            }
            else
            {
                TxtTema.ReadOnly = true;
                TxtTema.Text = auxtema;
                TxtTema.BackColor = Color.White;
            }
        }
        private void CkbCarta_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarta.Checked == true)
            {
                TxtNCarta.ReadOnly = false;
                auxcarta = TxtNCarta.Text;
            }
            else
            {
                TxtNCarta.ReadOnly = true;
                TxtNCarta.Text = auxcarta;
                TxtNCarta.BackColor = Color.White;
            }

        }

        private void CkbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbGrupo.Checked == true)
            {
                GridGrupos.Enabled = true;
                auxidgrupo = IdGrupo;
                //cargmos los grupos
                ObjGrupo.ESTADO = 1;

                Grupos = ObjGrupo.SeleccionarGrupoCriterioBss();
                //recuperamos el conteo de registrados por grupo 
                ObjGrupo.GESTION = Convert.ToInt32(Convert.ToDateTime(GvModalidades["FECHA_INICIO", ColorModalidad].Value.ToString()).ToString("yyyy"));
                AlumnosRegistrados = ObjGrupo.ContarRegistradosEnModalidad_I_PorGruposBss();
                GridGrupos = ActualizarGridGrupos(GridGrupos, Grupos, AlumnosRegistrados);

                //GpActualizar.Enabled = false;
                
            }
            else
            {
                GridGrupos.Rows.Clear();
                GridGrupos.Enabled = false;
                IdGrupo = auxidgrupo;
                //GridGrupos.Rows[IndiceParaColor].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            bool bandtema=false;
            bool bandtipomodalidad=false;
            bool bandcarta=false;
            bool bandgrupo=false;
            if (IdModalidad > 0)
            {
                //para validar tema
                if (CkbTema.Checked == true)
                {
                    if (TxtTema.Text != "")
                    {
                        TxtTema.BackColor = Color.White;

                        //cargamos los datos para verificar que no exista eltema en las modalidades pasadas
                        ObjModalidad_I.ESTADO = 0;
                        ObjModalidad_I.TEMA = TxtTema.Text;
                        if (ObjModalidad_I.SeleccionarTemaBss().Rows.Count > 0)
                        {
                            bandtema = true;
                        }
                        //verificamos que no exista el tema en las modalidades actuales o en curso
                        ObjModalidad_I.ESTADO = 1;
                        if (ObjModalidad_I.SeleccionarTemaBss().Rows.Count > 0)
                        {
                            bandtema = true;
                        }
                        if (bandtema == true)
                        {
                            MessageBox.Show("El tema que intenta intenta introducir como modificacion ya fue desarrollado, los temas deber ser únicos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            TxtTema.BackColor = Color.Red;
                        }
                        else
                        {
                            TxtTema.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Si lo que desea es actualizar el tema de la modalidad, el campo tema no puede estar vacio, el campo debe contener el titulo del tema", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtTema.BackColor = Color.Red;
                    }
                }
                //para validar el tipo de modalidad
                if(CkbTipoModalidad.Checked==true)
                {
                    //cargamos los datos para validar que el estudiante no haya cursado el tipo de modalidad
                    ObjModalidad_I.ID_ESTUDIANTE=IdEstudianteRecibido;
                    ObjModalidad_I.ID_TIPO_MODALIDAD=IdTipModalidad;
                    if(ObjModalidad_I.SeleccionarEstudianteTipoModalidadBss().Rows.Count>0)
                    {
                        bandtipomodalidad=true;
                        MessageBox.Show("El estudiante ya curso el tipo de modalidad que quiere introducir como modificación, seleccione un tipo de modalidad no cursado","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        CmbTipoModalidad.BackColor=Color.Red;
                    }
                    else
                    {
                        CmbTipoModalidad.BackColor=Color.White;
                    }
                }
                // Para validar número de carta 
                if(CkbCarta.Checked==true)
                {
                    //if(Validaciones.numero(TxtNCarta.Text)==true)
                    //{
                        //cargamos el nro de carta para buscar entre las modalidades en curso
                        ObjModalidad_I.ESTADO=1;
                        ObjModalidad_I.N_CARTA=TxtNCarta.Text.ToUpper();
                        //if(ObjModalidad_I.SeleccionarNroCartaBss().Rows.Count>0)
                        //{
                        //    bandcarta=true;
                        //}
                        ////cambiamos el estado para buscar entre las modalidades pasadas
                        //ObjModalidad_I.ESTADO=0;
                        //if(ObjModalidad_I.SeleccionarNroCartaBss().Rows.Count>0)
                        //{
                        //    bandcarta=true;
                        //}
                        ////para mostrar el mensaje
                        //if(bandcarta==true)
                        //{
                        //    MessageBox.Show("El número de carta de solicitud que intenta asignar a este estudiante ya fue asignado a otro estudiante, el número de carta debe ser único","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        //    TxtNCarta.BackColor=Color.Red;
                        //}
                    //}
                    //else
                    //{
                    //    bandcarta=true;
                    //    MessageBox.Show("El campo número de carta solo puede contener digitos y  no puede estar vacio","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    //    TxtNCarta.BackColor=Color.Red;
                    //}
                }
                //validamos si se modificara el grupo
                if(CkbGrupo.Checked==true)
                {
                    if(IdGrupo==0)
                    {
                        MessageBox.Show("Usted selecciono modificar grupo pero, no seleccionó un grupo, seleccione uno o quite la opcion de actualizar grupo","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                    
                }

                //Realizamos la actualizacion individualmente por cada dato por que asi no tendremos problemas en saber cuales datos son deseado modificar
                //modificamos solamente el estado para no altera la modalidad y los demas atributos volvemos a su valor por defecto para asi modificar uno a uno 
                if(GvModalidades["ESTADO",ColorModalidad].Value.ToString()=="FINALIZADA")
                {
                    ObjModalidad_I.ESTADO=0;
                }
                else
                {
                    ObjModalidad_I.ESTADO=1;
                }
                ObjModalidad_I.TEMA=null;
                ObjModalidad_I.ID_TIPO_MODALIDAD=0;
                ObjModalidad_I.N_CARTA=null;
                ObjModalidad_I.ID_GRUPO=0;               


                //para actualizar 
                if (bandtema == false & bandtipomodalidad == false & bandcarta == false & bandgrupo == false)
                {
                    ObjModalidad_I.ID_MODALIDAD_I = IdModalidad;
                    ObjModalidad_I.TEMA=TxtTema.Text.ToUpper();
                    ObjModalidad_I.ID_ESTUDIANTE = IdEstudianteRecibido;
                    ObjModalidad_I.N_CARTA = TxtNCarta.Text.ToUpper();
                    ObjModalidad_I.ID_TIPO_MODALIDAD = IdTipModalidad;
                    ObjModalidad_I.ID_GRUPO = IdGrupo;

                    ObjModalidad_I.ModificarModalidadIBss();
                    MessageBox.Show("La modificación fue realizada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    
                    
                }
                ////para actualizar tipo de modalidad
                //if(bandtipomodalidad==false&CkbTipoModalidad.Checked==true)
                //{
                //    ObjModalidad_I.ID_TIPO_MODALIDAD=IdTipModalidad;
                //    ObjModalidad_I.ModificarModalidadIBss();
                //    //volvemos asu valor por defecto
                //    ObjModalidad_I.ID_TIPO_MODALIDAD=0;
                //}
                ////para actualizar carta
                //if(bandcarta==false & CkbCarta.Checked==true)
                //{
                //    ObjModalidad_I.N_CARTA=Convert.ToInt32(TxtNCarta.Text);
                //    ObjModalidad_I.ModificarModalidadIBss();
                //    ObjModalidad_I.N_CARTA=0;
                //}
                ////para actualizar grupo
                //if(bandgrupo==false & CkbGrupo.Checked==true)
                //{
                //    ObjModalidad_I.ID_GRUPO=IdGrupo;
                //    ObjModalidad_I.ModificarModalidadIBss();
                //    ObjModalidad_I.ID_GRUPO=0;
                //}
                
                ////para mostrar el mensaje de exito
                //if(CkbTema.Checked==true || CkbTipoModalidad.Checked==true || CkbCarta.Checked==true || CkbGrupo.Checked==true )
                //{
                //    if (bandtema == false & bandtipomodalidad == false & bandcarta == false & bandgrupo == false)
                //    {
                //        MessageBox.Show("La modificación fue realizada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        this.Close();
                //    }
                //}

            }
            else
            {
                MessageBox.Show("No se ha seleccionado una modalidad para modificar,seleccione la modalidad que desea modificar", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }
        private void GridGrupos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    IdGrupo = 0;
                    MessageBox.Show("No se puede asignar mas estudiantes al grupo que intenta seleccionar, el aula que fue asignada al grupo no tiene capacidad para mas alumnos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ee)
            {
                IndiceParaColor = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private DataGridView CargarModalidades(DataGridView GvModalidadesX, DataTable DtModalidadesEnCursoX, DataTable DtModalidadesCursadasX)
        {
            GvModalidadesX.Rows.Clear();
            int fi = 0;
            //cargamos las modalidades cursadas
            for (int i = 0; i < DtModalidadesCursadasX.Rows.Count; i++)
            {
                GvModalidadesX.Rows.Add();
                GvModalidadesX["ID_MODALIDAD", i].Value = DtModalidadesCursadasX.Rows[i]["id_modalidad_I"];
                GvModalidadesX["ID_GRUPO", i].Value = DtModalidadesCursadasX.Rows[i]["id_grupo"];
                GvModalidadesX["TIPO_MODALIDAD", i].Value = DtModalidadesCursadasX.Rows[i]["tipo_modalidad"];
                GvModalidadesX["GRUPO", i].Value = DtModalidadesCursadasX.Rows[i]["n_grupo"];
                GvModalidadesX["TEMA", i].Value = DtModalidadesCursadasX.Rows[i]["tema"];
                GvModalidadesX["N_CARTA", i].Value = DtModalidadesCursadasX.Rows[i]["n_carta"];
                GvModalidadesX["FECHA_INICIO", i].Value = Convert.ToDateTime(DtModalidadesCursadasX.Rows[i]["fecha_inicio"].ToString()).ToShortDateString();
                GvModalidadesX["FECHA_FINAL", i].Value = Convert.ToDateTime(DtModalidadesCursadasX.Rows[i]["fecha_final"].ToString()).ToShortDateString();
                GvModalidadesX["ESTADO", i].Value = "FINALIZADA";
                fi++;
            }

            for (int e = 0; e < DtModalidadesEnCursoX.Rows.Count; e++)
            {
                GvModalidadesX.Rows.Add();
                GvModalidadesX["ID_MODALIDAD", fi].Value = DtModalidadesEnCursoX.Rows[e]["id_modalidad_I"];
                GvModalidadesX["ID_GRUPO", fi].Value = DtModalidadesEnCursoX.Rows[e]["ID_GRUPO"];
                GvModalidadesX["TIPO_MODALIDAD", fi].Value = DtModalidadesEnCursoX.Rows[e]["tipo_modalidad"];
                GvModalidadesX["GRUPO", fi].Value = DtModalidadesEnCursoX.Rows[e]["n_grupo"];
                GvModalidadesX["TEMA", fi].Value = DtModalidadesEnCursoX.Rows[e]["tema"];
                GvModalidadesX["N_CARTA", fi].Value = DtModalidadesEnCursoX.Rows[e]["n_carta"];
                GvModalidadesX["FECHA_INICIO", fi].Value = Convert.ToDateTime(DtModalidadesEnCursoX.Rows[e]["fecha_inicio"].ToString()).ToShortDateString();
                GvModalidadesX["FECHA_FINAL", fi].Value = Convert.ToDateTime(DtModalidadesEnCursoX.Rows[e]["fecha_final"].ToString()).ToShortDateString();
                if (Convert.ToDateTime(DtModalidadesEnCursoX.Rows[e]["fecha_inicio"].ToString()) > DAL.Dal_Login.fecha)
                {
                    GvModalidadesX["ESTADO", fi].Value = "POR INICIAR";
                }
                else
                {
                    GvModalidadesX["ESTADO", fi].Value = "EN CURSO";
                }
                fi++;
            }

            return GvModalidadesX;

        }
        public DataGridView ActualizarGridGrupos(DataGridView GridGrpos, DataTable gruposX, DataTable alumnosregistradosX)
        {
            GridGrpos.Rows.Clear();

            for (int i = 0; i < Grupos.Rows.Count; i++)// bucle para cargar el datagridview de grupos
            {
                GridGrupos.Rows.Add();
                GridGrupos["grupoG", i].Value = Grupos.Rows[i]["n_grupo"];
                GridGrupos["turno", i].Value = Grupos.Rows[i]["turno"];
                GridGrupos["fecha_iniciog", i].Value = Convert.ToDateTime(Grupos.Rows[i]["fecha_inicio"].ToString()).ToShortDateString();
                GridGrupos["fecha_finalg", i].Value = Convert.ToDateTime(Grupos.Rows[i]["fecha_final"].ToString()).ToShortDateString();
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

        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

       
       

        

       

        
        
    }
}
