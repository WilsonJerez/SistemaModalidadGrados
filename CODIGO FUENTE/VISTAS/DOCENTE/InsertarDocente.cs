using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DOCENTE
{
    public partial class InsertarDocente : Form
    {
        public InsertarDocente()
        {
            InitializeComponent();
        }
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Persona ObjPersona = new BSS.Bss_Persona();
        BSS.Bss_Curriculum ObjCurriculum = new BSS.Bss_Curriculum();
        BSS.Bss_Cargo ObjCargo = new BSS.Bss_Cargo();
        BSS.Bss_Facultad ObjFacultad = new BSS.Bss_Facultad();
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        DataTable Cargos = new DataTable();
        DataTable Facultades = new DataTable();
        int Id_Cargo;
        int Id_Facultad;
        int Id_Persona;
        
        private void InsertarDocente_Load(object sender, EventArgs e)
        {
            Cargos = ObjCargo.SeleccionarCargoBss();
            Facultades = ObjFacultad.SeleccionarFacultadBss();
            CmbCargos.DataSource = ObjCargo.SeleccionarCargoBss();            
            CmbCargos.DisplayMember = "cargo";
            ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
            //ObjCarrera.ESTADO = 1;
            //CmbCarreras.DataSource = ObjCarrera.SeleccionarCarreraCriterioBss();
            //CmbCarreras.DisplayMember = "carrera";
        }

        private void BtnrGuardar_Click(object sender, EventArgs e)
        {
            //dfinir que tipo de documento y validar
            string ci="";
            if(RbtnCi.Checked==true)
            {
                if(Validaciones.ci(Txtci.Text)==true)
                {
                    ci=Txtci.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Introduzca un ci valido o dni cambiando la opcion de tipo de documento", "ERROR DE DATO");
                   Txtci.BackColor = Color.Red;
                }

            }
            else
            {
                ci=Txtci.Text.ToUpper();
            }
            //********************************************
            if (CmbCargos.Text != null)
            {
                CmbCargos.BackColor = Color.White;

                if (Txtci.Text!="")
                {
                    Txtci.BackColor = Color.White;
                    if(Validaciones.texto(txtnombre.Text.ToUpper())==true)
                    {
                        txtnombre.BackColor = Color.White;
                        if (Validaciones.texto(txtpaterno.Text.ToUpper()) == true)
                        {
                            txtpaterno.BackColor = Color.White;
                            if (Validaciones.texto(txtmaterno.Text.ToUpper()) == true)
                            {
                                txtmaterno.BackColor = Color.White;
                                if (Validaciones.telefono(txttelefono.Text.ToUpper()) == true)
                                {
                                    txttelefono.BackColor = Color.White;
                                    if (Validaciones.celular(txtcelular.Text.ToUpper()) == true)
                                    {
                                        txtcelular.BackColor = Color.White;
                                        if (txtdireccion.Text !="")
                                        {
                                            txtdireccion.BackColor = Color.White;
                                            if (Validaciones.email(txtmail.Text) == true)
                                            {
                                                txtmail.BackColor = Color.White;
                                                
                                                   
                                                    if (TxtCurriculum.Text !="")
                                                    {
                                                        TxtCurriculum.BackColor = Color.White;
                                                        if (TxtProfesion.Text !="")
                                                        {
                                                            TxtProfesion.BackColor = Color.White;


                                                            ObjContrato.CI = ci.ToUpper(); //cargamos el ci para la verificacion si existe pesona ya con ese ci

                                                            ObjContrato.ID_CARGO =0;                                                            
                                                            
                                                            ObjContrato.TELEFONO =0;
                                                            ObjContrato.CELULAR =0;
                                                            
                                                            ObjContrato.ID_FACULTAD =0;
                                                            ObjContrato.ESTADO = 1;

                                                            if (ObjContrato.SeleccionarContratoCriterioBss().Rows.Count > 0)
                                                            {
                                                                if (MessageBox.Show("Ya existe un academico con el mismo identificador ¿Desea continuar?", "ALERTA DE DUPLICIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                                                                {
                                                                    ObjContrato.ID_CARGO = Id_Cargo;
                                                                    ObjContrato.CI = Txtci.Text.ToUpper();
                                                                    ObjContrato.NOMBRE = txtnombre.Text.ToUpper();
                                                                    ObjContrato.PATERNO = txtpaterno.Text.ToUpper();
                                                                    ObjContrato.MATERNO = txtmaterno.Text.ToUpper();
                                                                    ObjContrato.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                                                    ObjContrato.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                                    ObjContrato.DIRECCION = txtdireccion.Text.ToUpper();
                                                                    ObjContrato.MAIL = txtmail.Text;
                                                                    ObjContrato.ID_FACULTAD = Id_Facultad;
                                                                    ObjContrato.ESTADO = 1;

                                                                    

                                                                    Id_Persona = ObjContrato.InsertarContratoBss();
                                                                    ObjCurriculum.CURRICULUM = TxtCurriculum.Text.ToUpper();
                                                                    ObjCurriculum.PROFESION = TxtProfesion.Text.ToUpper();
                                                                    ObjCurriculum.ESPECIALIDAD = TxtEspecialidad.Text.ToUpper();
                                                                    ObjCurriculum.ID_PERSONA = Id_Persona;
                                                                    ObjCurriculum.InsertarCurriculumBss();


                                                                    Txtci.Clear();
                                                                    txtnombre.Clear();
                                                                    txtpaterno.Clear();
                                                                    txtmaterno.Clear();
                                                                    txttelefono.Clear();
                                                                    txtcelular.Clear();
                                                                    txtdireccion.Clear();
                                                                    txtmail.Clear();

                                                                    TxtCurriculum.Clear();
                                                                    TxtProfesion.Clear();
                                                                    TxtEspecialidad.Clear();

                                                                    CkbSinCelular.Checked = false;
                                                                    CkbSinTelefono.Checked = false;
                                                                    CkbSinMail.Checked = false;
                                                                    CkbSinDirecion.Checked = false;

                                                                    MessageBox.Show("El personal academico fue guardado con exito", "EXITO");

                                                                }                                                                                                                                                                      
                                                                
                                                                
                                                                
                                                            }
                                                            else
                                                            {
                                                                
                                                                

                                                                ObjContrato.ID_CARGO = Id_Cargo;
                                                                ObjContrato.CI = Txtci.Text.ToUpper();
                                                                ObjContrato.NOMBRE = txtnombre.Text.ToUpper();
                                                                ObjContrato.PATERNO = txtpaterno.Text.ToUpper();
                                                                ObjContrato.MATERNO = txtmaterno.Text.ToUpper();
                                                                ObjContrato.TELEFONO = Convert.ToInt32(txttelefono.Text);
                                                                ObjContrato.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                                ObjContrato.DIRECCION = txtdireccion.Text.ToUpper();
                                                                ObjContrato.MAIL = txtmail.Text;
                                                                ObjContrato.ID_FACULTAD = Id_Facultad;
                                                                ObjContrato.ESTADO = 1;

                                                                

                                                                Id_Persona = ObjContrato.InsertarContratoBss();
                                                                ObjCurriculum.CURRICULUM = TxtCurriculum.Text.ToUpper();
                                                                ObjCurriculum.PROFESION = TxtProfesion.Text.ToUpper();
                                                                ObjCurriculum.ESPECIALIDAD = TxtEspecialidad.Text.ToUpper();
                                                                ObjCurriculum.ID_PERSONA = Id_Persona;
                                                                ObjCurriculum.InsertarCurriculumBss();


                                                                Txtci.Clear();
                                                                txtnombre.Clear();
                                                                txtpaterno.Clear();
                                                                txtmaterno.Clear();
                                                                txttelefono.Clear();
                                                                txtcelular.Clear();
                                                                txtdireccion.Clear();
                                                                txtmail.Clear();

                                                                TxtCurriculum.Clear();
                                                                TxtProfesion.Clear();
                                                                TxtEspecialidad.Clear();

                                                                CkbSinCelular.Checked = false;
                                                                CkbSinTelefono.Checked = false;
                                                                CkbSinMail.Checked = false;
                                                                CkbSinDirecion.Checked = false;

                                                                MessageBox.Show("El personal academico fue guardado con exito", "EXITO");

                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El campo profesion esta vacio", "ERROR DE DATO");
                                                          TxtProfesion.BackColor = Color.Red;
 
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El campo curriculum esta vacio", "ERROR DE DATO");
                                                        TxtCurriculum.BackColor = Color.Red;
                                                    }

                                                   
                                                    


                                                
                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("El campo mail no esta correctamente llenado ej. correo@servidor.com ", "ERROR DE DATO");
                                                txtmail.BackColor = Color.Red;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El campo direccion esta vacio", "ERROR DE DATO");
                                            txtdireccion.BackColor = Color.Red;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo celular esta vacio, debe contener solo numeros ej. 76180941", "ERROR DE DATO");
                                        txtcelular.BackColor = Color.Red;

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo telefono esta vacio, debe contener solo numeros ej. 66nnnnn", "ERROR DE DATO");
                                    txttelefono.BackColor = Color.Red;

                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo apellido materno esta vacio o no contiene solo texto", "ERROR DE DATO");
                                txtmaterno.BackColor = Color.Red;

                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo apellido paterno  esta vacio o no contiene solo texto", "ERROR DE DATO");
                           txtpaterno.BackColor = Color.Red;
 
                        }
                    }
                    else
                    {
                       MessageBox.Show("El campo nombre esta vacio o no contiene solo texto", "ERROR DE DATO");
                    txtnombre.BackColor = Color.Red;
 
                    }
                }
                else
                {
                    MessageBox.Show("Introduzca un ci y seleccione el departamento donde fue emitido", "ERROR DE DATO");
                   Txtci.BackColor = Color.Red;
 
                }

            }
            else
            {
                MessageBox.Show("Seleccione un cargo", "ERROR DE DATO");
                CmbCargos.BackColor = Color.Red;
            }
        }

        private void CmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {

            Id_Cargo = Convert.ToInt32(Cargos.Rows[CmbCargos.SelectedIndex]["id_cargo"]);
        }

        private void CmbFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbCargos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CkbSinTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinTelefono.Checked == true)
            {
                txttelefono.ReadOnly = true;
                txttelefono.Text = "6600000";
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
                txtcelular.ReadOnly = false;
                txtcelular.Clear();
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

        private void CkbSinDirecion_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSinDirecion.Checked == true)
            {
                txtdireccion.Text = "sin diereccion";
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
