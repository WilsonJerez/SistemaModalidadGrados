using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.TRIBUNALEXTERNO
{
    public partial class InsertarTribunalExterno : Form
    {
        public InsertarTribunalExterno()
        {
            InitializeComponent();
        }
        //objetos
        BSS.Bss_Tribunal_externo ObjTribunalExterno = new BSS.Bss_Tribunal_externo();

        bool Bandci = true;
        
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            bool semaforo = false;
            //validamos el identificador
            if (Bandci == true)
            {
                if (Validaciones.ci(Txtci.Text) == true)
                {
                    semaforo = true;
                }
                else
                {
                    semaforo = false;
                }
            }
            else
            {
                semaforo = true;
            }

            //cargamos datos
            if (semaforo == true)
            {
                if (Validaciones.texto(txtnombre.Text) == true)
                {
                    if (Validaciones.texto(txtpaterno.Text) == true)
                    {
                        if (Validaciones.texto(txtmaterno.Text) == true)
                        {
                            if (Validaciones.telefono(txttelefono.Text) == true)
                            {
                                if (Validaciones.celular(txtcelular.Text) == true)
                                {
                                    if (txtdireccion.Text != "")
                                    {
                                        if (Validaciones.email(txtmail.Text) == true)
                                        {
                                            //validamos que no exista el tribunal externo para luego insertar
                                            ObjTribunalExterno.ESTADO = 1;
                                            ObjTribunalExterno.CI = Txtci.Text.ToUpper();
                                            ObjTribunalExterno.NOMBRE = txtnombre.Text.ToUpper();
                                            ObjTribunalExterno.PATERNO = txtpaterno.Text.ToUpper();
                                            ObjTribunalExterno.MATERNO = txtmaterno.Text.ToUpper();
                                            if (ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss().Rows.Count == 0)
                                            {
                                                ObjTribunalExterno.TELEFONO =Convert.ToInt32(txttelefono.Text);
                                                ObjTribunalExterno.CELULAR =Convert.ToInt32(txtcelular.Text);
                                                ObjTribunalExterno.DIRECCION = txtdireccion.Text.ToUpper();
                                                ObjTribunalExterno.MAIL = txtmail.Text;
                                                //guardamos el nuevo tribunal
                                                ObjTribunalExterno.InsertarTribunalExternoBss();
                                                MessageBox.Show("El nuevo tribunal externo fue registrado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                //limpiamos campos
                                                Txtci.Clear();
                                                txtnombre.Clear();
                                                txtpaterno.Clear();
                                                txtmaterno.Clear();
                                                txttelefono.Clear();
                                                txtcelular.Clear();
                                                txtdireccion.Clear();
                                                txtmail.Clear();

                                                CkbSinCelular.Checked = false;
                                                CkbSinTelefono.Checked = false;
                                                CkbSinMail.Checked = false;
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El tribunal externo que intenta registrar ya fue registrado no se permitira un doble registro", "ALERTA DE DUPLICIDAD", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El correo electronico no cumple el formato de un correo electronico", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo direccion no puede estar vacio, coloque una direccion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo celular no esta llenado correctamente, puede insertar solo 8 digitos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo telefono solo puede tener números, el formato del telefono es 66nnnnn", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo Ap. Materno solo acepta letras", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo Ap. Paterno solo acepta letras", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El campo nombre solo acepta letras ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else 
            {
                MessageBox.Show("Si el tipo de identificador es ci solo acepta numeros enteros", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //private void RbtnDni_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RbtnDni.Checked == true)
        //    {
        //        Banddni = true;
        //    }
        //    else
        //    {
        //        Banddni = false;
        //    }
        //}

        private void RbtnCi_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnCi.Checked == true)
            {
                Bandci = true;
            }
            else
            {
                Bandci = false;
            }
        }
    }
}
