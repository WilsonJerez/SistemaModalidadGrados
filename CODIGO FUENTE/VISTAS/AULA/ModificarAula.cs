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
    public partial class ModificarAula : Form
    {
        public ModificarAula()
        {
            InitializeComponent();
          
        }
        BSS.Bss_Aula objaula = new BSS.Bss_Aula();
        DataTable listaaula = new DataTable();
        int Colorindex;
        int estadordb;
        
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            gvaulas.Rows.Clear();
            if (CmbPiso.Text != "")
            {
                
                objaula.PISO = Convert.ToInt32(CmbPiso.Text);
            }
            objaula.N_AULA = TxtN_Aula.Text;
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            objaula.ESTADO = Convert.ToInt32(estadordb);
            listaaula = objaula.SeleccionarAulaCriterioBss();
            for (int fila = 0; fila < listaaula.Rows.Count; fila++)
            {
                gvaulas.Rows.Add();
                gvaulas["n_aula", fila].Value = listaaula.Rows[fila]["n_aula"];
                gvaulas["disponible", fila].Value = listaaula.Rows[fila]["disponible"];
                gvaulas["id_aula", fila].Value = listaaula.Rows[fila]["id_aula"];
                gvaulas["piso", fila].Value = listaaula.Rows[fila]["piso"];
                gvaulas["capacidad", fila].Value = listaaula.Rows[fila]["capacidad"];
                if (Convert.ToInt32(listaaula.Rows[fila]["estado"]) == 1)
                {
                    gvaulas["estado", fila].Value = "ACTIVO";
                }
                else
                {
                    gvaulas["estado", fila].Value = "INACTIVO";
                }

            }
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (rdbactivomod.Checked)
            {
                estadordb = 1;   
            }
            else
            {
                estadordb = 0;
            }
                if (Validaciones.numero(cmbpisocmodif.Text) == true & cmbpisocmodif.Text != "")
                {
                    cmbpisocmodif.BackColor = Color.White;
                    objaula.PISO = Convert.ToInt32(cmbpisocmodif.Text);
                    if (txtn_aulamodif.Text != "")
                    {
                        txtn_aulamodif.BackColor = Color.White;
                        objaula.N_AULA = txtn_aulamodif.Text.ToUpper();
                        if (Validaciones.numero(txtcapacidadmodif.Text) == true)
                        {
                            txtcapacidadmodif.BackColor = Color.White;
                            objaula.CAPACIDAD = Convert.ToInt32(txtcapacidadmodif.Text);

                            if (Validaciones.numero(lblid.Text) == true)
                            {
                                objaula.ESTADO = Convert.ToInt32(estadordb);
                                objaula.ID_AULA = Convert.ToInt32(lblid.Text);
                                objaula.ModificarAulasBss();
                                MessageBox.Show("El Aula fue modificada correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtcapacidadmodif.Text = "";
                                txtn_aulamodif.Text = "";
                                lblid.Text = "";
                                cmbpisocmodif.Text = "";
                                objaula.CAPACIDAD = 0;
                                rdbactivomod.Checked = true;
                               //gvaulas.DataSource = objaula.SeleccionarAulaBss();
                                rdbactivo.Checked = true;
                            }
                        }
                        else
                        {
                            txtcapacidadmodif.BackColor = Color.Red;
                            MessageBox.Show("La capacidad del aula debe estar escrita en forma númerica", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        txtn_aulamodif.BackColor = Color.Red;
                        MessageBox.Show("El campo aula esta vacio", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    cmbpisocmodif.BackColor = Color.Red;
                    MessageBox.Show("El campo piso esta vacio o escrito incorrectamente", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void gvaulas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvaulas.Rows[Colorindex].DefaultCellStyle.BackColor = Color.White;
                gvaulas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                Colorindex= e.RowIndex;

                txtcapacidadmodif.Text = listaaula.Rows[e.RowIndex]["Capacidad"].ToString();
                txtn_aulamodif.Text = listaaula.Rows[e.RowIndex]["n_aula"].ToString();
                cmbpisocmodif.Text = listaaula.Rows[e.RowIndex]["piso"].ToString();
                lblid.Text = listaaula.Rows[e.RowIndex]["id_aula"].ToString();
                if (rdbactivo.Checked)
                {
                    rdbactivomod.Checked = true;
                }
                else
                {
                    rdbinactivomod.Checked = true;
                }
            }
            catch (Exception ee)
            {
                Colorindex = 0;
                MessageBox.Show(ee.ToString());
            }
           
        }

        private void CmbPiso_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbpisocmodif_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void gvaulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
