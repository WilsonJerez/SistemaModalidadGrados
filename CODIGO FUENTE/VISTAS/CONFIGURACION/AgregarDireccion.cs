using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VISTAS.CONFIGURACION
{
    public partial class AgregarDireccion : Form
    {
        public AgregarDireccion()
        {
            InitializeComponent();
        }
        string archivo = @"d:\ModalidadesConfi.txt";
        public string ip = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones.numero(textBox1.Text) == true)
            {
                if (Validaciones.numero(textBox2.Text) == true)
                {
                    if (Validaciones.numero(textBox3.Text) == true)
                    {
                        if (Validaciones.numero(textBox4.Text) == true)
                        {
                            ip = textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + "." + textBox4.Text;

                            StreamWriter sw = new StreamWriter(archivo);
                            sw.Flush();
                            sw.Write(ip);
                            sw.Close();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Todos los campos  deben contener números", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos  deben contener números", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
 
                }
                else
                    MessageBox.Show("Todos los campos  deben contener números", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Todos los campos  deben contener números", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void AgregarDireccion_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        
    }
}
