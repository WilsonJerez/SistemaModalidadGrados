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
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }
        public int IdPersona;
        public int IdEstudianteRecibido;
        //objetos utilizdos
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        //data tables para recuperar datos
        DataTable DtEstudiante = new DataTable();
        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            ObjEstudiante.ESTADO = 1;
            ObjEstudiante.ID_PERSONA = IdPersona;
            DtEstudiante= ObjEstudiante.SeleccionarEstudiantexCriterios2Bss();
            if (Validaciones.ci(DtEstudiante.Rows[0]["ci"].ToString()) == true)
            {
                RdbCi.Checked = true;
                TxtCi.Text = DtEstudiante.Rows[0]["ci"].ToString();
            }
            else
            {
                RdbDni.Checked = true;
                TxtCi.Text = DtEstudiante.Rows[0]["ci"].ToString();
            }            
            TxtNombre.Text = DtEstudiante.Rows[0]["nombre"].ToString();
            TxtPaterno.Text = DtEstudiante.Rows[0]["paterno"].ToString();
            TxtMaterno.Text = DtEstudiante.Rows[0]["materno"].ToString();
            TxtTelefono.Text = DtEstudiante.Rows[0]["telefono"].ToString();
            TxtCelular.Text = DtEstudiante.Rows[0]["celular"].ToString();
            TxtDirecion.Text = DtEstudiante.Rows[0]["direccion"].ToString();
            TxtMail.Text = DtEstudiante.Rows[0]["mail"].ToString();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string ci = "";
            if (RdbCi.Checked == true)
            {
                if (Validaciones.ci(TxtCi.Text) == true)
                {
                    ci = TxtCi.Text;
                }
                else
                {
                    MessageBox.Show("El ci introducido no es valido, debe contener 7 digitos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                ci = TxtCi.Text.ToUpper();
            }



            if (ci != "")
            {
                TxtCi.BackColor = Color.White;
                if (Validaciones.texto(TxtNombre.Text)==true)
                {
                    TxtNombre.BackColor = Color.White;
                    if (Validaciones.texto(TxtPaterno.Text)==true)
                    {
                        TxtPaterno.BackColor = Color.White;
                        if (Validaciones.texto(TxtMaterno.Text) == true)
                        {
                            TxtMaterno.BackColor = Color.White;
                            if (Validaciones.telefono(TxtTelefono.Text) == true)
                            {
                                TxtTelefono.BackColor = Color.White;
                                if (Validaciones.celular(TxtCelular.Text) == true)
                                {
                                    TxtCelular.BackColor = Color.White;
                                    if (TxtDirecion.Text != "")
                                    {
                                        TxtDirecion.BackColor = Color.White;
                                        if (Validaciones.email(TxtMail.Text) == true)
                                        {
                                            TxtMail.BackColor = Color.White;
                                            ObjEstudiante.ESTADO = 1;
                                            ObjEstudiante.ID_PERSONA = IdPersona;
                                            ObjEstudiante.CI = TxtCi.Text.ToUpper();
                                            ObjEstudiante.NOMBRE = TxtNombre.Text.ToUpper();
                                            ObjEstudiante.PATERNO = TxtPaterno.Text.ToUpper();
                                            ObjEstudiante.MATERNO = TxtMaterno.Text.ToUpper();
                                            ObjEstudiante.TELEFONO = Convert.ToInt32(TxtTelefono.Text);
                                            ObjEstudiante.CELULAR = Convert.ToInt32(TxtCelular.Text);
                                            ObjEstudiante.DIRECCION = TxtDirecion.Text.ToUpper();
                                            ObjEstudiante.MAIL = TxtMail.Text;
                                            ObjEstudiante.ModificarEstudianteBss();
                                            //liberamos los atributos de estudiante para que no perjudique la siguiente actualizacion
                                            ObjEstudiante.CI = null;
                                            ObjEstudiante.NOMBRE = null;
                                            ObjEstudiante.PATERNO = null;
                                            ObjEstudiante.MATERNO = null;
                                            ObjEstudiante.TELEFONO = 0;
                                            ObjEstudiante.CELULAR = 0;
                                            ObjEstudiante.DIRECCION = null;
                                            ObjEstudiante.MAIL = null;                                            
                                            MessageBox.Show("Los datos personales del estudiante fueron modificados correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            this.Close();
                                    
                                        }
                                        else
                                        {
                                            MessageBox.Show("El mail no cumple el formato Ej. correo@ejemplo.com , corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            TxtMail.BackColor = Color.Red;
                                            TxtMail.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo dirección no es correcto, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        TxtDirecion.BackColor = Color.Red;
                                        TxtDirecion.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo celular no es correcto debe contener 8 dígitos, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    TxtCelular.BackColor = Color.Red;
                                    TxtCelular.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo telefono no es correcto, debe cumplir el siguiente formato 66NNNNN, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                TxtTelefono.BackColor = Color.Red;
                                TxtTelefono.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo apellido materno esta vacio o no contiene solo texto, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            TxtMaterno.BackColor = Color.Red;
                            TxtMaterno.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo apellido paterno esta vacio o no contiene solo texto, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtPaterno.BackColor = Color.Red;
                        TxtPaterno.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El campo nombre esta vacio o no contiene solo texto, introduzca un nombre", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtNombre.BackColor = Color.Red;
                    TxtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("El ci no corresponde o esta vacio, corrija el dato", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtCi.BackColor = Color.Red;
                TxtCi.Focus();
            }
        }
    }
}
