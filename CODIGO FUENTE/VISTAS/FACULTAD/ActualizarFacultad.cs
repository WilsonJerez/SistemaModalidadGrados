using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.FACULTAD
{
    public partial class ActualizarFacultad : Form
    {
        public ActualizarFacultad()
        {
            InitializeComponent();
        }

        BSS.Bss_Facultad ojbfacultad = new BSS.Bss_Facultad();
        DataTable listafacultades = new DataTable();
        int Colorindex;

        int estadordb;

        private void ActualizarFacultad_Load(object sender, EventArgs e)
        {
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            listafacultades = ojbfacultad.SeleccionarFacultadCriterioBss();
            GrdFacultad.DataSource = ojbfacultad.SeleccionarFacultadCriterioBss();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ojbfacultad.FACULTAD = "";
          
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            ojbfacultad.ESTADO = Convert.ToInt32(estadordb);
            GrdFacultad.DataSource = ojbfacultad.SeleccionarFacultadCriterioBss();
            
        }

        private void GrdFacultad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GrdFacultad.Rows[Colorindex].DefaultCellStyle.BackColor = Color.White;
                GrdFacultad.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                Colorindex = e.RowIndex;

                listafacultades = ojbfacultad.SeleccionarFacultadCriterioBss();
                TxtFacultadModif.Text = listafacultades.Rows[e.RowIndex]["facultad"].ToString();
                LblId.Text = listafacultades.Rows[e.RowIndex]["id_facultad"].ToString();
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (rdbactivomod.Checked)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
                if (TxtFacultadModif.Text != "")
                {
                    TxtFacultadModif.BackColor = Color.White;
                    ojbfacultad.FACULTAD = TxtFacultadModif.Text.ToUpper();
   
                        if (Validaciones.numero(LblId.Text) == true)
                        {
                            ojbfacultad.ESTADO = Convert.ToInt32(estadordb);
                            ojbfacultad.ID_FACULTAD = Convert.ToInt32(LblId.Text);
                            ojbfacultad.ModificarFacultadBss();
                            MessageBox.Show("La facultad fue modificada correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtFacultadModif.Text = "";
                            LblId.Text = "";
                            rdbactivomod.Checked = true;
                            rdbactivo.Checked = true;
                        }
                    }
                    else
                    {
                        TxtFacultadModif.BackColor = Color.Red;
                        MessageBox.Show("El campo facultad esta vacio o esta mal llenado", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }            
           
        

        
    }
}
