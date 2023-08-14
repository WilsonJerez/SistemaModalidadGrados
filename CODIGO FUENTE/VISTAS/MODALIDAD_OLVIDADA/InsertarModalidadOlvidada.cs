using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.MODALIDAD_OLVIDADA
{
    public partial class InsertarModalidadOlvidada : Form
    {
        public InsertarModalidadOlvidada()
        {
            InitializeComponent();
        }

        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Modalidad_I ObjModI = new BSS.Bss_Modalidad_I();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Aula ObjAulas = new BSS.Bss_Aula();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Modalidad_II ObjModII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();

        DataTable DtCarreras = new DataTable();
        DataTable DtTipoModalidad = new DataTable();
        DataTable DtAulas = new DataTable();
        DataTable DtTribunales = new DataTable();

        int IdCarrera = 0;
        int IdTipoModalidad = 0;
        int IdGrupo = 0;
        int IdEstudiante = 0;
        int IdAulaDefensaModI = 0;
        int IdModalidadI = 0;
        int IdDefensa = 0;
        int IdModII = 0;
        int IdTutor = 0;
        

        int IndiceColor = 0;

        int IndiceColorContratosModI=0;
        int IdTribunal1 = 0;
        int IdTribunal2 = 0;
        int IdTribunal3 = 0;

        int[] arrayIdContratos = new int[3];


        #region  FUNCIONES

        private DataGridView CargarGrupo(DataGridView DtgX,DataTable DtX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_GRUPO", i].Value = DtX.Rows[i]["id_grupo"];
                DtgX["GESTION", i].Value = DtX.Rows[i]["gestion"];
                DtgX["grupo", i].Value = DtX.Rows[i]["n_grupo"];
                DtgX["fecha_inicio", i].Value = DtX.Rows[i]["fecha_inicio"];
                DtgX["fecha_final", i].Value = DtX.Rows[i]["fecha_final"];
                DtgX["turno", i].Value = DtX.Rows[i]["turno"];
            }
            return DtgX;
        }

        private DataGridView CargarContratos(DataGridView DtgvX, DataTable DtX)
        {
            DtgvX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgvX.Rows.Add();
                DtgvX["ID_CONTRATO", i].Value = DtX.Rows[i]["id_contrato"];
                DtgvX["CI", i].Value = DtX.Rows[i]["ci"];
                DtgvX["PATERNO", i].Value = DtX.Rows[i]["paterno"];
                DtgvX["MATERNO", i].Value = DtX.Rows[i]["materno"];
                DtgvX["NOMBRE", i].Value = DtX.Rows[i]["nombre"];
            }
            return DtgvX;
        }
        private DataGridView CargarTutor(DataGridView DtgvX, DataTable DtX)
        {
            DtgvX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgvX.Rows.Add();
                DtgvX["ID_CONTRATOTUTOR", i].Value = DtX.Rows[i]["id_contrato"];
                DtgvX["CITUTOR", i].Value = DtX.Rows[i]["ci"];
                DtgvX["PATERNOTUTOR", i].Value = DtX.Rows[i]["paterno"];
                DtgvX["MATERNOTUTOR", i].Value = DtX.Rows[i]["materno"];
                DtgvX["NOMBRETUTOR", i].Value = DtX.Rows[i]["nombre"];
            }
            return DtgvX;
        }
        private DataGridView CargarDefensa(DataGridView DtgvX, DataTable DtX)
        {
            DtgvX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgvX.Rows.Add();
                DtgvX["ID_CONTRATODEF", i].Value = DtX.Rows[i]["id_contrato"];
                DtgvX["CIDEF", i].Value = DtX.Rows[i]["ci"];
                DtgvX["PATERNODEF", i].Value = DtX.Rows[i]["paterno"];
                DtgvX["MATERNODEF", i].Value = DtX.Rows[i]["materno"];
                DtgvX["NOMBREDEF", i].Value = DtX.Rows[i]["nombre"];
            }
            return DtgvX;
        }
        #endregion


        #region DATOS PERSONALES
        private void cmbcarrera_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        
        private void CkbSinTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinTelefono.Checked == true)
            {
                txttelefono.Text = "6600000";
                txttelefono.Enabled = false;
            }
            else
            {
                txttelefono.Clear();
                txttelefono.Enabled = true;
            }
        }

        private void CkbDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbDireccion.Checked == true)
            {
                txtdireccion.Text = "sin";
                txtdireccion.Enabled = false;
            }
            else
            {
                txtdireccion.Clear();
                txtdireccion.Enabled = true;
            }

        }

        private void CkbSinMail_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinMail.Checked == true)
            {
                txtmail.Text = "sinmail@sinmail.com";
                txtmail.Enabled = false;
            }
            else
            {
                txtmail.Clear();
                txtmail.Enabled = true;
            }
        }

        private void CkbSinCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinCelular.Checked == true)
            {
                txtcelular.Text = "00000000";
                txtcelular.Enabled = false;
            }
            else
            {
                txtcelular.Clear();
                txtcelular.Enabled = true;
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
          
            

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








                                            if (IdCarrera > 0)
                                            {

                                                ObjEstudiante.CI = Txtci.Text.ToUpper();
                                                ObjEstudiante.ESTADO = 1;

                                                // CONSULTAMOS SI EXISTE UNALUMNO CON EL NUMERO DE CI
                                                if (ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows.Count > 0)
                                                {
                                                    if (MessageBox.Show("Ya existe un estudiante con ese C.I.", "ALERTA DE DUPLICIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                    {
                                                        tabControl1.TabPages[1].Enabled = true;
                                                        tabControl1.SelectedIndex = 1;
                                                        tabControl1.TabPages[0].Enabled = false;                                                        
                                                    }


                                                }
                                                else
                                                {
                                                    tabControl1.TabPages[1].Enabled = true;
                                                    tabControl1.SelectedIndex = 1;
                                                    tabControl1.TabPages[0].Enabled = false;
                                                    
                                                }



                                                


                                            }
                                            else
                                            {
                                                MessageBox.Show("SELECCIONE UNA CARRERA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            if(DtCarreras.Rows.Count>0)
            IdCarrera = Convert.ToInt32(DtCarreras.Rows[cmbcarrera.SelectedIndex]["id_carrera"].ToString());
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[0].Enabled == true)
            {
                ObjCarrera.ESTADO = 1;
                ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
                DtCarreras = ObjCarrera.SeleccionarCarreraCriterioBss();
                cmbcarrera.DataSource = DtCarreras;
                cmbcarrera.DisplayMember = "carrera";

                //DESHABILITAMOS TODOS LOS OTROS TABPAGES PARA QUE QUE SE EDITE EN ORDEN
                tabControl1.TabPages[1].Enabled = false;
                tabControl1.TabPages[2].Enabled = false;
                tabControl1.TabPages[3].Enabled = false;
                tabControl1.TabPages[4].Enabled = false;
            }
        }
        #endregion


        //================================================= DATOS MODALIDAD I==========================================

        #region DATOS DE LA MODALIDAD

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //recuperamos tipo de Modalidad
            if (tabControl1.TabPages[1].Enabled == true)
            {
                //recuperamos tipos de modalidad
                ObjTipoModalidad.ESTADO = 1;
                DtTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss();
                //cargamos tipo de modalidad
                CmbTipoModalidad.DataSource = DtTipoModalidad;
                CmbTipoModalidad.DisplayMember = "tipo_modalidad";
                //recuperamos grupos de todas las gestiones
                ObjGrupo.ESTADO=0;
                GridGrupos=CargarGrupo(GridGrupos,ObjGrupo.SeleccionarGrupoCriterioBss());


            }
        }        
        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DtTipoModalidad.Rows.Count > 0)
                IdTipoModalidad = Convert.ToInt32(DtTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"].ToString());
        }
        private void BtnSiguienteDatosModI_Click(object sender, EventArgs e)
        {
            if (IdTipoModalidad > 0)
            {
                if (TxtTema.Text != "")
                {
                    if (IdGrupo > 0)
                    {
                        tabControl1.TabPages[2].Enabled = true;
                        tabControl1.SelectedIndex = 2;
                        tabControl1.TabPages[1].Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE UN GRUPO EN QUE EL ESTUDIANTE CURSO LA MODALIDAD DE GRADO I", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("EL CAMPO NOMBRE DEL TEMA NO PUEDE ESTAR VACIO, INTRODUZCA EL TEMA QUE DESARROLLO EL ESTUDIANTE", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN TIPO DE MODALIDAD PARA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void GridGrupos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridGrupos.Rows[IndiceColor].DefaultCellStyle.BackColor = Color.White;
                GridGrupos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColor = e.RowIndex;

                IdGrupo = Convert.ToInt32(GridGrupos["ID_GRUPO", e.RowIndex].Value.ToString());

            }
            catch (Exception ex)
            {
                IndiceColor = 0;
                for (int i = 0; i < GridGrupos.Rows.Count; i++)
                {
                    GridGrupos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                MessageBox.Show(ex.ToString());
            }
            
        }


        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }        
        
        
        #endregion

        #region DATOS DE LA DEFENSA MOD I
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[2].Enabled == true)
            {
                ObjAulas.ESTADO = 1;
                DtAulas = ObjAulas.SeleccionarAulaCriterioBss();
                CmbAulas.DataSource = DtAulas;
                CmbAulas.DisplayMember = "n_aula";
            }
        }
        private void CmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DtAulas.Rows.Count > 0)
                IdAulaDefensaModI = Convert.ToInt32(DtAulas.Rows[CmbAulas.SelectedIndex]["id_aula"].ToString());
        }
        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbAulas_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void BtnBuscarDocentes_Click(object sender, EventArgs e)
        {
            if (RdbActivos.Checked == true)
                ObjContrato.ESTADO = 1;
            else
                ObjContrato.ESTADO = 0;

            ObjContrato.CI = TxtCiDef.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoDef.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoDef.Text.ToUpper();
            ObjContrato.NOMBRE = TxtNombreDef.Text.ToUpper();

            DtgvContratos = CargarContratos(DtgvContratos, ObjContrato.SeleccionarContratoCriterioBss());            
        }

        private void DtgvContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool asignado = false;
            try
            {
                DtgvContratos.Rows[IndiceColorContratosModI].DefaultCellStyle.BackColor = Color.White;
                DtgvContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorContratosModI = e.RowIndex;

                if (TxtTrib1.Text == "" & IdTribunal1 == 0 & asignado==false)
                {
                    TxtTrib1.Text = DtgvContratos["PATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["MATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["NOMBRE", e.RowIndex].Value.ToString();
                    IdTribunal1 = Convert.ToInt32(DtgvContratos["ID_CONTRATO", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if(TxtTrib2.Text=="" & IdTribunal2==0 &asignado==false)
                {                    
                    TxtTrib2.Text = DtgvContratos["PATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["MATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["NOMBRE", e.RowIndex].Value.ToString();
                    IdTribunal2 = Convert.ToInt32(DtgvContratos["ID_CONTRATO", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if (TxtTrib3.Text == "" & IdTribunal3 == 0 & asignado == false)
                {
                    
                    TxtTrib3.Text = DtgvContratos["PATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["MATERNO", e.RowIndex].Value.ToString() + " " + DtgvContratos["NOMBRE", e.RowIndex].Value.ToString();
                    IdTribunal3 = Convert.ToInt32(DtgvContratos["ID_CONTRATO", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if (asignado == false)
                {
                    MessageBox.Show("NO SE PUEDE COLOCAR COMO TRIBUNAL A ESTE DOCENTE, LA LISTA DE TRIBUNAL YA ESTA COMPLETA, SI LO QUE DESEA ES CAMBIAR AL TRIBUNAL PRESIONE EL BOTON CAMBIAR PERTINENTE A CADA TRIBUNAL", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IndiceColorContratosModI = 0;
                for (int i = 0; i < DtgvContratos.Rows.Count; i++)
                {
                    DtgvContratos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
 
            }
        }
        private void BtnCambiarTrib1_Click(object sender, EventArgs e)
        {
            TxtTrib1.Clear();
            TxtNotaTrib1.Clear();
            IdTribunal1 = 0;
        }
        private void BtnCambiarTrib2_Click(object sender, EventArgs e)
        {
            TxtTrib2.Clear();
            TxtNotaTrib2.Clear();
            IdTribunal2 = 0;
        }
        private void BtnCambiarTrib3_Click(object sender, EventArgs e)
        {
            TxtTrib3.Clear();
            TxtNotaTrib3.Clear();
            IdTribunal3 = 0;
        }

        private void BtnRegistrarFinalizar_Click(object sender, EventArgs e)
        {
           //terminamos de validar las notas del tribunal y que los 3 tribunales se hayan seleccionado
            if(IdAulaDefensaModI>0)
            {
                if(CmbHoraDefensa.Text!="" & CmbMinutos.Text!="")
                {
                    if(TxtNroActa.Text!="")
                    {
            if (IdTribunal3 > 0 & IdTribunal2 > 0 & IdTribunal1 > 0)
            {
                int idtribunal = 0;
                //VALIDAMOS LAS NOTAS
                if (Validaciones.Decimales(TxtNotaTrib1.Text) == true & Validaciones.Decimales(TxtNotaTrib2.Text)==true & Validaciones.Decimales(TxtNotaTrib3.Text)==true)
                {
                    if (Convert.ToDecimal(TxtNotaTrib1.Text) >= 0 & Convert.ToDecimal(TxtNotaTrib1.Text) <= 100 & Convert.ToDecimal(TxtNotaTrib2.Text)>=0 & Convert.ToDecimal(TxtNotaTrib2.Text)<=100 & Convert.ToDecimal(TxtNotaTrib3.Text)>=0 & Convert.ToDecimal(TxtNotaTrib3.Text)<=100)
                    {
                        if (MessageBox.Show("¿SEGURO QUE DESEA REGISTRAR SOLO LOS DATOS PERTINENTES A LA MODALIDAD DE GRADO I, AL FINALIZAR EL PROCESO AQUI SE REGISTRARÁ, EL ESTUDIANTE, LOS DATOS DE SU MODALIDAD DE GRADO I, LOS DATOS DE LA DEFENSA DE LA MODALIDAD DE GRADO I, SOLO SI LA NOTA DE SU DEFENSA  ES DE APROBACION EL ESTUDIANTE ESTARA HABILITADO PARA LA MODALIDAD DE GRADO II Y SEGUIRA EL PROCESO NORMALMENTE", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            //REGISTRAMOS AL ESTUDIANTE
                            ObjEstudiante.ESTADO = 1;
                            ObjEstudiante.CI = Txtci.Text.ToUpper();
                            ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
                            ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
                            ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
                            ObjEstudiante.TELEFONO =Convert.ToInt32(txttelefono.Text);
                            ObjEstudiante.CELULAR = Convert.ToInt32(txtcelular.Text);
                            ObjEstudiante.DIRECCION = txtdireccion.Text.ToUpper();
                            ObjEstudiante.MAIL = txtmail.Text;
                            ObjEstudiante.ID_CARRERA = IdCarrera;
                            ObjEstudiante.InsertarEstudianteBss();
                            
                            
                            //recuperamos el id del estudiante
                            IdEstudiante = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"].ToString());
                            //registramos la modalidad de grado I
                            ObjModI.ESTADO = 0;
                            ObjModI.FECHA_INSCRIPCION = DateTime.Now.ToString("MM/dd/yyyy");
                            ObjModI.ID_TIPO_MODALIDAD = IdTipoModalidad;
                            ObjModI.ID_ESTUDIANTE = IdEstudiante;
                            ObjModI.ID_GRUPO = IdGrupo;
                            ObjModI.TEMA = TxtTema.Text.ToUpper();
                            ObjModI.N_CARTA = TxtNroCarta.Text.ToUpper();

                            ObjModI.InsertarModalidadIBss();
                            //RECUPERAMOS EL ID DE LA MODALIDAD DE GRADO I PARA LA DEFENSA
                            IdModalidadI=Convert.ToInt32(ObjModI.SeleccionarModalidadICriterioBss().Rows[0]["id_modalidad_I"].ToString());
                            //registramos la defensa de modalidad de grado I
                            ObjTribunal.ESTADO = 0;
                            ObjTribunal.FECHA = DtpFecha.Value.ToString("MM/dd/yyyy");
                            ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                            ObjTribunal.NRO_ACTA=TxtNroActa.Text.ToUpper();
                            ObjTribunal.ID_AULA = IdAulaDefensaModI;
                            ObjTribunal.ID_MODALIDAD_I = IdModalidadI;
                            ObjTribunal.NOTA =Convert.ToInt32((Convert.ToDecimal(TxtNotaTrib1.Text)+Convert.ToDecimal(TxtNotaTrib2.Text)+Convert.ToDecimal(TxtNotaTrib3.Text))/3);//promedio de la defensa total
                            
                            arrayIdContratos[0] = IdTribunal1;
                            arrayIdContratos[1] = IdTribunal2;
                            arrayIdContratos[2] = IdTribunal3;

                            ObjTribunal.InsertarTribunalBss(arrayIdContratos);

                            //recuperamos el id de la defensa para buscar sus tribunales y actualizar sus notas
                            ObjDefensa.ESTADO = 0;
                            ObjDefensa.ID_MODALIDAD_I = IdModalidadI;
                            IdDefensa=Convert.ToInt32(ObjDefensa.SeleccionarDefensaCriterioBss().Rows[0]["id_defensa"]);
                            
                            //actualizamos las notas de los tribunales
                            ObjTribunal.ID_DEFENSA = IdDefensa;
                            DtTribunales = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                            
                            //para actualizar las notas de los tribunales
                            ObjTribunal.ESTADO = 0;
                            ObjTribunal.FECHA = null;
                            ObjTribunal.NRO_ACTA = null;
                            ObjTribunal.ID_AULA = 0;
                            ObjTribunal.ID_MODALIDAD_I = 0;
                            ObjTribunal.NOTA = 0;
                            for (int i = 0; i < DtTribunales.Rows.Count; i++)
                            {
                                idtribunal = Convert.ToInt32(DtTribunales.Rows[i]["id_tribunal"]);
                                ObjTribunal.ID_TRIBUNAL = idtribunal;
                                if (i == 0)
                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib1.Text);
                                if(i==1)
                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib2.Text);
                                if(i==2)
                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib3.Text);

                                ObjTribunal.ActrualizarTribunalBss();
                            }


                            MessageBox.Show("LOS DATOS DEL ESTUDIANTE COMO DE LA MODALIDAD DE GRADO I Y SU RESPECTIVA DEFENSA FUERON GUARDADO CORRECTAMENTE", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         
                          
                            //cerramos la ventana
                            this.Close();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LAS NOTAS SOLO PUEDEN TOMAR VALORES DE 0 A 100, NO SE ACEPTAN NUMEROS NEGATIVOS NI MAYORES A 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LOS CAMPOS DE NOTAS SOLO PUEDEN ACECPTAR NÚMEROS DECIMALES Y ENTEROS MAYORES O IGUALES A CERO Y MENORES O IGUAL 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE LOS 3 DOCENTES QUE FUERON LOS TRIBUNALES DE LA DEFENSA, NO SE PODRA CONTINUAL SI NO ESTAN LOS 3", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
                    }
                    else
                    {
                        MessageBox.Show("EL NRO DE ACTA NO PUEDE SER NULO, EL NÚMERO DE ACTA ES IMPORTANTE PARA LA DEFENSA","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA HORA Y EL MINUTO EN LA QUE FUE REALIZADA LA DEFENSA","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE EL AULA DONDE SE REALIZO LA DEFENSA","ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }    

        private void BtnRegistrarSeguir_Click(object sender, EventArgs e)
        {
            int notapromedio;
            //terminamos de validar las notas del tribunal y que los 3 tribunales se hayan seleccionado
            if (IdAulaDefensaModI > 0)
            {
                if (CmbHoraDefensa.Text != "" & CmbMinutos.Text != "")
                {
                    if (TxtNroActa.Text != "")
                    {
                        if (IdTribunal3 > 0 & IdTribunal2 > 0 & IdTribunal1 > 0)
                        {
                            int idtribunal = 0;
                            //VALIDAMOS LAS NOTAS
                            if (Validaciones.Decimales(TxtNotaTrib1.Text) == true & Validaciones.Decimales(TxtNotaTrib2.Text) == true & Validaciones.Decimales(TxtNotaTrib3.Text) == true)
                            {
                                if (Convert.ToDecimal(TxtNotaTrib1.Text) >= 0 & Convert.ToDecimal(TxtNotaTrib1.Text) <= 100 & Convert.ToDecimal(TxtNotaTrib2.Text) >= 0 & Convert.ToDecimal(TxtNotaTrib2.Text) <= 100 & Convert.ToDecimal(TxtNotaTrib3.Text) >= 0 & Convert.ToDecimal(TxtNotaTrib3.Text) <= 100)
                                {
                                    //if (MessageBox.Show("¿SEGURO QUE DESEA REGISTRAR SOLO LOS DATOS PERTINENTES A LA MODALIDAD DE GRADO I, AL FINALIZAR EL PROCESO AQUI SER REGISTRARÁ, EL ESTUDIANTE, LOS DATOS DE SU MODALIDAD DE GRADO I, LOS DATOS DE LA DEFENSA DE LA MODALIDAD DE GRADO I, SOLO SI LA NOTA DE SU DEFENSA  ES DE APROBACION EL ESTUDIATNE ESTARA HABILITADO PARA LA MODALIDAD DE GRADO II Y SEGUIRA EL PROCESO NORMALMENTE?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    //{
                                        notapromedio = (Convert.ToInt32(TxtNotaTrib1.Text) + Convert.ToInt32(TxtNotaTrib2.Text) +Convert.ToInt32(TxtNotaTrib3.Text)) / 3;
                                        if (notapromedio >= 65)
                                        {
                                            //REGISTRAMOS AL ESTUDIANTE
                                            ObjEstudiante.ESTADO = 1;
                                            ObjEstudiante.CI = Txtci.Text.ToUpper();
                                            ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
                                            ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
                                            ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
                                            ObjEstudiante.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                            ObjEstudiante.CELULAR = Convert.ToInt32(txtcelular.Text);
                                            ObjEstudiante.DIRECCION = txtdireccion.Text.ToUpper();
                                            ObjEstudiante.MAIL = txtmail.Text;
                                            ObjEstudiante.ID_CARRERA = IdCarrera;
                                            ObjEstudiante.InsertarEstudianteBss();


                                            //recuperamos el id del estudiante
                                            IdEstudiante = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"].ToString());
                                            //registramos la modalidad de grado I
                                            ObjModI.ESTADO = 0;
                                            ObjModI.FECHA_INSCRIPCION = DateTime.Now.ToString("MM/dd/yyyy");
                                            ObjModI.ID_TIPO_MODALIDAD = IdTipoModalidad;
                                            ObjModI.ID_ESTUDIANTE = IdEstudiante;
                                            ObjModI.ID_GRUPO = IdGrupo;
                                            ObjModI.TEMA = TxtTema.Text.ToUpper();
                                            ObjModI.N_CARTA = TxtNroCarta.Text.ToUpper();

                                            ObjModI.InsertarModalidadIBss();
                                            //RECUPERAMOS EL ID DE LA MODALIDAD DE GRADO I PARA LA DEFENSA
                                            IdModalidadI = Convert.ToInt32(ObjModI.SeleccionarModalidadICriterioBss().Rows[0]["id_modalidad_I"].ToString());
                                            //registramos la defensa de modalidad de grado I
                                            ObjTribunal.ESTADO = 0;
                                            ObjTribunal.FECHA = DtpFecha.Value.ToString("MM/dd/yyyy");
                                            ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                            ObjTribunal.NRO_ACTA = TxtNroActa.Text.ToUpper();
                                            ObjTribunal.ID_AULA = IdAulaDefensaModI;
                                            ObjTribunal.ID_MODALIDAD_I = IdModalidadI;
                                            ObjTribunal.NOTA = Convert.ToInt32((Convert.ToDecimal(TxtNotaTrib1.Text) + Convert.ToDecimal(TxtNotaTrib2.Text) + Convert.ToDecimal(TxtNotaTrib3.Text)) / 3);//promedio de la defensa total

                                            arrayIdContratos[0] = IdTribunal1;
                                            arrayIdContratos[1] = IdTribunal2;
                                            arrayIdContratos[2] = IdTribunal3;

                                            ObjTribunal.InsertarTribunalBss(arrayIdContratos);

                                            //recuperamos el id de la defensa para buscar sus tribunales y actualizar sus notas
                                            ObjDefensa.ESTADO = 0;
                                            ObjDefensa.ID_MODALIDAD_I = IdModalidadI;
                                            IdDefensa = Convert.ToInt32(ObjDefensa.SeleccionarDefensaCriterioBss().Rows[0]["id_defensa"]);

                                            //actualizamos las notas de los tribunales
                                            ObjTribunal.ID_DEFENSA = IdDefensa;
                                            DtTribunales = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();

                                            //para actualizar las notas de los tribunales
                                            ObjTribunal.ESTADO = 0;
                                            ObjTribunal.FECHA = null;
                                            ObjTribunal.NRO_ACTA = null;
                                            ObjTribunal.ID_AULA = 0;
                                            ObjTribunal.ID_MODALIDAD_I = 0;
                                            ObjTribunal.NOTA = 0;
                                            for (int i = 0; i < DtTribunales.Rows.Count; i++)
                                            {
                                                idtribunal = Convert.ToInt32(DtTribunales.Rows[i]["id_tribunal"]);
                                                ObjTribunal.ID_TRIBUNAL = idtribunal;
                                                if (i == 0)
                                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib1.Text);
                                                if (i == 1)
                                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib2.Text);
                                                if (i == 2)
                                                    ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib3.Text);

                                                ObjTribunal.ActrualizarTribunalBss();
                                            }


                                            MessageBox.Show("LOS DATOS DEL ESTUDIANTE COMO DE LA MODALIDAD DE GRADO I Y SU RESPECTIVA DEFENSA FUERON GUARDADO CORRECTAMENTE", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            //inicializamos los id de nuevo
                                            IndiceColorContratosModI = 0;
                                            IdAulaDefensaModI = 0;
                                            IdTribunal1 = 0;
                                            IdTribunal2 = 0;
                                            IdTribunal3 = 0;
                                            IdDefensa = 0;
                                            //enviamos a la siguient ventana

                                            tabControl1.TabPages[3].Enabled = true;
                                            tabControl1.TabPages[2].Enabled = false;
                                            tabControl1.SelectedIndex = 3;
                                        }
                                        else
                                        {
                                            if (MessageBox.Show("PARA CONTINUAR CON EL REGISTRO DE LA MODALIDAD DE GRADO II LA NOTA DEL ESTUDIANTE DEBE SER IGUAL O MAYOR A 65, SI DESEA GUARDAR SOLO LOS DATOS DE LA MODALIDAD DE GRADO I PRESIONE 'SI', SI DESEA MODIFICAR LA NOTA PARA CONTINUAR CON EL REGISTRO DE LA MODALIDAD DE GRADO II PRESION 'NO'", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                            {
                                                //REGISTRAMOS AL ESTUDIANTE
                                                ObjEstudiante.ESTADO = 1;
                                                ObjEstudiante.CI = Txtci.Text.ToUpper();
                                                ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
                                                ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
                                                ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
                                                ObjEstudiante.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                                ObjEstudiante.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                ObjEstudiante.DIRECCION = txtdireccion.Text.ToUpper();
                                                ObjEstudiante.MAIL = txtmail.Text;
                                                ObjEstudiante.ID_CARRERA = IdCarrera;
                                                ObjEstudiante.InsertarEstudianteBss();


                                                //recuperamos el id del estudiante
                                                IdEstudiante = Convert.ToInt32(ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows[0]["id_estudiante"].ToString());
                                                //registramos la modalidad de grado I
                                                ObjModI.ESTADO = 0;
                                                ObjModI.FECHA_INSCRIPCION = DateTime.Now.ToString("MM/dd/yyyy");
                                                ObjModI.ID_TIPO_MODALIDAD = IdTipoModalidad;
                                                ObjModI.ID_ESTUDIANTE = IdEstudiante;
                                                ObjModI.ID_GRUPO = IdGrupo;
                                                ObjModI.TEMA = TxtTema.Text.ToUpper();
                                                ObjModI.N_CARTA = TxtNroCarta.Text.ToUpper();

                                                ObjModI.InsertarModalidadIBss();
                                                //RECUPERAMOS EL ID DE LA MODALIDAD DE GRADO I PARA LA DEFENSA
                                                IdModalidadI = Convert.ToInt32(ObjModI.SeleccionarModalidadICriterioBss().Rows[0]["id_modalidad_I"].ToString());
                                                //registramos la defensa de modalidad de grado I
                                                ObjTribunal.ESTADO = 0;
                                                ObjTribunal.FECHA = DtpFecha.Value.ToString("MM/dd/yyyy");
                                                ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                                ObjTribunal.NRO_ACTA = TxtNroActa.Text.ToUpper();
                                                ObjTribunal.ID_AULA = IdAulaDefensaModI;
                                                ObjTribunal.ID_MODALIDAD_I = IdModalidadI;
                                                ObjTribunal.NOTA = Convert.ToInt32((Convert.ToDecimal(TxtNotaTrib1.Text) + Convert.ToDecimal(TxtNotaTrib2.Text) + Convert.ToDecimal(TxtNotaTrib3.Text)) / 3);//promedio de la defensa total

                                                arrayIdContratos[0] = IdTribunal1;
                                                arrayIdContratos[1] = IdTribunal2;
                                                arrayIdContratos[2] = IdTribunal3;

                                                ObjTribunal.InsertarTribunalBss(arrayIdContratos);

                                                //recuperamos el id de la defensa para buscar sus tribunales y actualizar sus notas
                                                ObjDefensa.ESTADO = 0;
                                                ObjDefensa.ID_MODALIDAD_I = IdModalidadI;
                                                IdDefensa = Convert.ToInt32(ObjDefensa.SeleccionarDefensaCriterioBss().Rows[0]["id_defensa"]);

                                                //actualizamos las notas de los tribunales
                                                ObjTribunal.ID_DEFENSA = IdDefensa;
                                                DtTribunales = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();

                                                //para actualizar las notas de los tribunales
                                                ObjTribunal.ESTADO = 0;
                                                ObjTribunal.FECHA = null;
                                                ObjTribunal.NRO_ACTA = null;
                                                ObjTribunal.ID_AULA = 0;
                                                ObjTribunal.ID_MODALIDAD_I = 0;
                                                ObjTribunal.NOTA = 0;
                                                for (int i = 0; i < DtTribunales.Rows.Count; i++)
                                                {
                                                    idtribunal = Convert.ToInt32(DtTribunales.Rows[i]["id_tribunal"]);
                                                    ObjTribunal.ID_TRIBUNAL = idtribunal;
                                                    if (i == 0)
                                                        ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib1.Text);
                                                    if (i == 1)
                                                        ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib2.Text);
                                                    if (i == 2)
                                                        ObjTribunal.NOTA = Convert.ToInt32(TxtNotaTrib3.Text);

                                                    ObjTribunal.ActrualizarTribunalBss();
                                                }


                                                MessageBox.Show("LOS DATOS DEL ESTUDIANTE COMO DE LA MODALIDAD DE GRADO I Y SU RESPECTIVA DEFENSA FUERON GUARDADO CORRECTAMENTE, PERO NO PODRA REALIZAR EL REGISTRO DE LA MODALIDAD DE GRADO II DEBIDO A QUE EL ESTUDIANTE REPROBÓ", "INFORME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                this.Close();

                                            }
                                        }

                                    //}
                                }
                                else
                                {
                                    MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LAS NOTAS SOLO PUEDEN TOMAR VALORES DE 0 A 100, NO SE ACEPTAN NUMEROS NEGATIVOS NI MAYORES A 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LOS CAMPOS DE NOTAS SOLO PUEDEN ACECPTAR NÚMEROS DECIMALES Y ENTEROS MAYORES O IGUALES A CERO Y MENORES O IGUAL 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("SELECCIONE LOS 3 DOCENTES QUE FUERON LOS TRIBUNALES DE LA DEFENSA, NO SE PODRA CONTINUAL SI NO ESTAN LOS 3", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    else
                    {
                        MessageBox.Show("EL NRO DE ACTA NO PUEDE SER NULO, EL NÚMERO DE ACTA ES IMPORTANTE PARA LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA HORA Y EL MINUTO EN LA QUE FUE REALIZADA LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE EL AULA DONDE SE REALIZO LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        private void BtnFiltrarModII_Click(object sender, EventArgs e)
        {
            if (rdbactivosModII.Checked == true)
            {
                ObjContrato.ESTADO = 1;
            }
            else
            {
                ObjContrato.ESTADO = 0;
            }
            ObjContrato.NOMBRE = TxtNombreModII.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoModII.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoModII.Text.ToUpper();
            ObjContrato.CI = TxtCiModII.Text.ToUpper();
            IndiceColorContratosModI = 0;
            gridtutormodII = CargarTutor(gridtutormodII, ObjContrato.SeleccionarContratoCriterioBss());
        }

        private void gridtutormodII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gridtutormodII.Rows[IndiceColorContratosModI].DefaultCellStyle.BackColor = Color.White;
                gridtutormodII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorContratosModI = e.RowIndex;
                
                IdTutor = Convert.ToInt32(gridtutormodII["ID_CONTRATOTUTOR",e.RowIndex].Value.ToString());
            }
            catch (Exception ex)
            {

                IndiceColorContratosModI = 0;
                for (int i = 0; i<gridtutormodII.Rows.Count; i++)
                {
                    gridtutormodII.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                MessageBox.Show(ex.ToString());
                IdTutor = 0;
            }

        }

        private void BtnSiguienteModII_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime( DtpfechaModII.Value.ToString()) <Convert.ToDateTime( DateTime.Now.ToString()) && Convert.ToDateTime( DtpFechaFinalModII.Value.ToString())>Convert.ToDateTime( DtpfechaModII.Value.ToString()))
            {
                if (IdTutor > 0)
                {
                    
                    tabControl1.TabPages[4].Enabled = true;
                    tabControl1.TabPages[3].Enabled = false;
                    tabControl1.SelectedIndex = 4;
                }
                else
                {
                    MessageBox.Show("DEBE SELECIONAR UN TUTOR", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("LA FECHA DEBE SER MENOR A LA ACTUAL", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnFinalizarModII_Click(object sender, EventArgs e)
        {
            //terminamos de validar las notas del tribunal y que los 3 tribunales se hayan seleccionado
            if (IdAulaDefensaModI > 0)
            {
                if (CmbHoraModII.Text != "" & CmbMinutosModII.Text != "")
                {
                    if (TxtNroActaModII.Text != "")
                    {
                        if (IdTribunal3 > 0 & IdTribunal2 > 0 & IdTribunal1 > 0)
                        {
                            int idtribunal = 0;
                            //VALIDAMOS LAS NOTAS
                            if (Validaciones.Decimales(TxtNota1ModII.Text) == true & Validaciones.Decimales(TxtNota2ModII.Text) == true & Validaciones.Decimales(TxtNota3ModII.Text) == true)
                            {
                                if (Convert.ToDecimal(TxtNota1ModII.Text) >= 0 & Convert.ToDecimal(TxtNota1ModII.Text) <= 100 & Convert.ToDecimal(TxtNota2ModII.Text) >= 0 & Convert.ToDecimal(TxtNota2ModII.Text) <= 100 & Convert.ToDecimal(TxtNota3ModII.Text) >= 0 & Convert.ToDecimal(TxtNota3ModII.Text) <= 100)
                                {
                                    //if (MessageBox.Show("¿SEGURO QUE DESEA REGISTRAR SOLO LOS DATOS PERTINENTES A LA MODALIDAD DE GRADO II, AL FINALIZAR EL PROCESO AQUI SE REGISTRARÁ LOS DATOS DE SU MODALIDAD DE GRADO II, LOS DATOS DE LA DEFENSA DE LA MODALIDAD DE GRADO II", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    //{
                                        //inscribimos al estudiante en la modalidad de grado II
                                        ObjModII.ID_MODALIDAD_I = IdModalidadI;
                                        ObjModII.ESTADO = 0;
                                        ObjModII.FECHA_INSCRIPCION = DtpfechaModII.Value.ToString("MM/dd/yyyy");
                                        ObjModII.ID_CONTRATO = IdTutor;
                                        ObjModII.InsertarModalidadIIBss();
                                        //recuperamos id mod II para guardar cronograma
                                        IdModII = Convert.ToInt32(ObjModII.SeleccionarModIIPorIdModIBss().Rows[0]["id_modalidad_II"]);
                                        //registramos el cronograma
                                        ObjCronograma.ESTADO = 0;
                                        ObjCronograma.ID_MODALIDAD_II = IdModII;
                                        ObjCronograma.FECHA = DtpFechaFinalModII.Value.ToString("MM/dd/yyyy");
                                        ObjCronograma.DESCRIPCION = "ESTA MODALIDAD SOLO TIENE UN CRONOGRAMA DEBIDO A QUE NO SIGUIO EL PROCESO NORMAL";
                                        ObjCronograma.InsertarCronogramaBss();
                                        //registramos la defensa de modalidad de grado I
                                        ObjTribunal.ESTADO = 0;
                                        ObjTribunal.FECHA =DtpFechaDefensaModII.Value.ToString("MM/dd/yyyy");
                                        ObjTribunal.HORA = CmbHoraModII.Text + ":" + CmbMinutosModII.Text;
                                        ObjTribunal.NRO_ACTA = TxtNroActaModII.Text.ToUpper();
                                        ObjTribunal.ID_AULA = IdAulaDefensaModI;
                                        ObjTribunal.ID_MODALIDAD_I =0;
                                        ObjTribunal.ID_MODALIDAD_II = IdModII;
                                        ObjTribunal.NOTA = Convert.ToInt32((Convert.ToDecimal(TxtNota1ModII.Text) + Convert.ToDecimal(TxtNota2ModII.Text) + Convert.ToDecimal(TxtNota3ModII.Text)) / 3);//promedio de la defensa total

                                        arrayIdContratos[0] = IdTribunal1;
                                        arrayIdContratos[1] = IdTribunal2;
                                        arrayIdContratos[2] = IdTribunal3;

                                        ObjTribunal.InsertarTribunalBss(arrayIdContratos);

                                        //recuperamos el id de la defensa para buscar sus tribunales y actualizar sus notas
                                        ObjDefensa.ESTADO = 0;
                                        ObjDefensa.ID_MODALIDAD_II = IdModII;
                                        ObjDefensa.ID_MODALIDAD_I = 0;
                                        IdDefensa = Convert.ToInt32(ObjDefensa.SeleccionarDefensaCriterioBss().Rows[0]["id_defensa"]);

                                        //actualizamos las notas de los tribunales
                                        ObjTribunal.ID_DEFENSA = IdDefensa;
                                        DtTribunales = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();

                                        //para actualizar las notas de los tribunales
                                        ObjTribunal.ESTADO = 0;
                                        ObjTribunal.FECHA = null;
                                        ObjTribunal.HORA = null;
                                        ObjTribunal.NRO_ACTA = null;
                                        ObjTribunal.ID_AULA = 0;
                                        ObjTribunal.ID_MODALIDAD_I = 0;
                                        ObjTribunal.NOTA = 0;
                                        for (int i = 0; i < DtTribunales.Rows.Count; i++)
                                        {
                                            idtribunal = Convert.ToInt32(DtTribunales.Rows[i]["id_tribunal"]);
                                            ObjTribunal.ID_TRIBUNAL = idtribunal;
                                            if (i == 0)
                                                ObjTribunal.NOTA = Convert.ToInt32(TxtNota1ModII.Text);
                                            if (i == 1)
                                                ObjTribunal.NOTA = Convert.ToInt32(TxtNota2ModII.Text);
                                            if (i == 2)
                                                ObjTribunal.NOTA = Convert.ToInt32(TxtNota3ModII.Text);

                                            ObjTribunal.ActrualizarTribunalBss();
                                        }


                                        MessageBox.Show("LOS DATOS DE LA MODALIDAD DE GRADO II DEL ESTUDIANTE Y SU RESPECTIVA DEFENSA FUERON GUARDADO CORRECTAMENTE", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        //cerramos la ventana
                                        this.Close();

                                    //}
                                }
                                else
                                {
                                    MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LAS NOTAS SOLO PUEDEN TOMAR VALORES DE 0 A 100, NO SE ACEPTAN NUMEROS NEGATIVOS NI MAYORES A 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA NOTA DE ALGUN TRIBUNAL ES INCORRECTA, LOS CAMPOS DE NOTAS SOLO PUEDEN ACECPTAR NÚMEROS DECIMALES Y ENTEROS MAYORES O IGUALES A CERO Y MENORES O IGUAL 100", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("SELECCIONE LOS 3 DOCENTES QUE FUERON LOS TRIBUNALES DE LA DEFENSA, NO SE PODRA CONTINUAL SI NO ESTAN LOS 3", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    else
                    {
                        MessageBox.Show("EL NRO DE ACTA NO PUEDE SER NULO, EL NÚMERO DE ACTA ES IMPORTANTE PARA LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA HORA Y EL MINUTO EN LA QUE FUE REALIZADA LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE EL AULA DONDE SE REALIZO LA DEFENSA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[2].Enabled == true)
            {
                ObjAulas.ESTADO = 1;
                DtAulas = ObjAulas.SeleccionarAulaCriterioBss();
                CmbAulasModII.DataSource = DtAulas;
                CmbAulasModII.DisplayMember = "n_aula";
                
            }
        }

        private void CmbHoraModII_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutosModII_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbAulasModII_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

        }

        private void CmbAulasModII_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DtAulas.Rows.Count > 0)
                IdAulaDefensaModI = Convert.ToInt32(DtAulas.Rows[CmbAulasModII.SelectedIndex]["id_aula"].ToString());

        }

        private void BtnBuscarModII_Click(object sender, EventArgs e)
        {
            if (rdbactivosModII.Checked == true)
                ObjContrato.ESTADO = 1;
            else
                ObjContrato.ESTADO = 0;

            ObjContrato.CI = TxtCiTribModII.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoTribModII.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoTribModII.Text.ToUpper();
            ObjContrato.NOMBRE = TxtNombreTribModII.Text.ToUpper();
            IndiceColorContratosModI = 0;
            DtgvContratosTribModII = CargarDefensa(DtgvContratosTribModII, ObjContrato.SeleccionarContratoCriterioBss());
        }

        private void DtgvContratosTribModII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool asignado = false;
            try
            {
                DtgvContratosTribModII.Rows[IndiceColorContratosModI].DefaultCellStyle.BackColor = Color.White;
                DtgvContratosTribModII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorContratosModI = e.RowIndex;

                if (TxtTribunal1ModII.Text == "" & IdTribunal1 == 0 & asignado == false)
                {
                    TxtTribunal1ModII.Text = DtgvContratosTribModII["PATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["MATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["NOMBREDEF", e.RowIndex].Value.ToString();
                    IdTribunal1 = Convert.ToInt32(DtgvContratosTribModII["ID_CONTRATODEF", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if (TxtTribunal2ModII.Text == "" & IdTribunal2 == 0 & asignado == false)
                {
                    TxtTribunal2ModII.Text = DtgvContratosTribModII["PATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["MATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["NOMBREDEF", e.RowIndex].Value.ToString();
                    IdTribunal2 = Convert.ToInt32(DtgvContratosTribModII["ID_CONTRATODEF", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if (TxtTribunal3ModII.Text == "" & IdTribunal3 == 0 & asignado == false)
                {
                    TxtTribunal3ModII.Text = DtgvContratosTribModII["PATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["MATERNODEF", e.RowIndex].Value.ToString() + " " + DtgvContratosTribModII["NOMBREDEF", e.RowIndex].Value.ToString();
                    IdTribunal3 = Convert.ToInt32(DtgvContratosTribModII["ID_CONTRATODEF", e.RowIndex].Value.ToString());
                    asignado = true;
                }
                if (asignado == false)
                {
                    MessageBox.Show("NO SE PUEDE COLOCAR COMO TRIBUNAL A ESTE DOCENTE, LA LISTA DE TRIBUNAL YA ESTA COMPLETA, SI LO QUE DESEA ES CAMBIAR AL TRIBUNAL PRESIONE EL BOTON CAMBIAR PERTINENTE A CADA TRIBUNAL", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IndiceColorContratosModI = 0;
                for (int i = 0; i < DtgvContratosTribModII.Rows.Count; i++)
                {
                    DtgvContratosTribModII.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void BtnCambiarTrib1ModII_Click(object sender, EventArgs e)
        {
            IdTribunal1 = 0;
            TxtTribunal1ModII.Clear();
            TxtNota1ModII.Clear();
        }

        private void BtnCambiarTrib2ModII_Click(object sender, EventArgs e)
        {
            IdTribunal2 = 0;
            TxtTribunal2ModII.Clear();
            TxtNota2ModII.Clear();
        }

        private void BtnCambiarTrib3ModII_Click(object sender, EventArgs e)
        {
            IdTribunal3 = 0;
            TxtTribunal3ModII.Clear();
            TxtNota3ModII.Clear();
        }         
    }
}