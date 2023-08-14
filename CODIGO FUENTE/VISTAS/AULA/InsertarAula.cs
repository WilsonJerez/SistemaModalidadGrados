using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.AULA
{
    public partial class InsertarAula : Form
    {
        public InsertarAula()
        {
            InitializeComponent();
        }
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtN_Aula.Text !=null)
            {
                
                if (CmbPiso.Text !=null)
                {
                    
                    if(Validaciones.numero(TxtCapacidad.Text)==true)
                    {
                        

                        ObjAula.N_AULA = TxtN_Aula.Text.ToUpper();
                        if (ObjAula.SeleccionarAulaCriterioBss().Rows.Count > 0)
                        {
                            ObjAula.CAPACIDAD = 0;
                            ObjAula.DISPONIBLE = 0;
                            ObjAula.PISO = 0;
                            ObjAula.ESTADO = 1;
                            MessageBox.Show("El aula que intenta guardar ya existe", "ALERTA DE DUPLICIDAD"); 
                        }

                        
                        
                        else
                        {
                            ObjAula.PISO = Convert.ToInt32(CmbPiso.Text);
                            ObjAula.CAPACIDAD = Convert.ToInt32(TxtCapacidad.Text);
                            ObjAula.DISPONIBLE = 1;
                            ObjAula.ESTADO = 1;
                            ObjAula.InsertarAulaBss();
                            MessageBox.Show("Los datos fueron guardados correctamente", "EXITO");
                            TxtCapacidad.Clear();
                            TxtN_Aula.Clear();
                            CmbPiso.SelectedItem = "1";
                        }
                

                    }
                    else
                    {
                        MessageBox.Show("El campo capacidad solo permite numeros", "ERROR DE DATOS");
                        TxtCapacidad.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccine un piso", "ERROR DE DATO");
                    CmbPiso.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("El campo Nº Aula debe contener un dato", "ERROR DE DATO");
                TxtN_Aula.BackColor = Color.Red;
            }
        }

        private void CmbPiso_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }   
    }
}
