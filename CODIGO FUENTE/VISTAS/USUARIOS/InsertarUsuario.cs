using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.USUARIOS
{
    public partial class InsertarUsuario : Form
    {
        public InsertarUsuario()
        {
            InitializeComponent();
        }
        //objetos a utilizar
        BSS.Bss_Usuario ObjUsuario = new BSS.Bss_Usuario();

        private void BtnRegistrar_Click(object sender, EventArgs e)
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

                if (Txtci.Text != "")
                {
                    Txtci.BackColor = Color.White;
                    if (Validaciones.texto(txtnombre.Text.ToUpper()) == true)
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
                                        if (txtdireccion.Text != "")
                                        {
                                            txtdireccion.BackColor = Color.White;
                                            if (Validaciones.email(txtmail.Text) == true)
                                            {
                                                txtmail.BackColor = Color.White;

                                                ObjUsuario.CI = ci.ToUpper();
                                                ObjUsuario.NOMBRE = txtnombre.Text.ToUpper();
                                                ObjUsuario.PATERNO = txtpaterno.Text.ToUpper();
                                                ObjUsuario.MATERNO = txtmaterno.Text.ToUpper();
                                                ObjUsuario.TELEFONO =Convert.ToInt32(txttelefono.Text);
                                                ObjUsuario.CELULAR = Convert.ToInt32(txtcelular.Text);
                                                ObjUsuario.DIRECCION = txtdireccion.Text.ToUpper();
                                                ObjUsuario.MAIL = txtmail.Text;
                                                ObjUsuario.ID_FACULTAD = DAL.Dal_Login.id_facultad;
                                                ObjUsuario.USUARIO = txtnombre.Text;
                                                ObjUsuario.CONTRASEÑA = txtnombre.Text;
                                                ObjUsuario.ESTADO = 1;
                                                ObjUsuario.InsertarUsuarioSistemaBss();
                                                MessageBox.Show("El usuario para el sistema fue registrado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                Txtci.Clear();
                                                txtnombre.Clear();
                                                txtpaterno.Clear();
                                                txtmaterno.Clear();
                                                txttelefono.Clear();
                                                txtcelular.Clear();
                                                txtdireccion.Clear();
                                                txtmail.Clear();

                                                
                                                                                                        
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
    }
}
