using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.CARRERA
{
    public partial class ModificarCarrera : Form
    {
        public ModificarCarrera()
        {
            InitializeComponent();
        }
        BSS.Bss_Carrera objcarrera = new BSS.Bss_Carrera();
        DataTable listacarrera = new DataTable();
        BSS.Bss_Facultad ojbfacultad = new BSS.Bss_Facultad();
        DataTable listafacultades = new DataTable();
        int estadordb;
        int id_carreramod;
        int Colorindex;

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
            if (Validaciones.texto(txtcarreramodif.Text) == true & txtcarreramodif.Text != "")
            {
                txtcarreramodif.BackColor = Color.White;
                objcarrera.CARRERA = txtcarreramodif.Text.ToUpper();
                objcarrera.ESTADO = estadordb;
                objcarrera.ID_CARRERA = id_carreramod;
                objcarrera.ModificarCarreraBss();
                MessageBox.Show("La Carrera fue modificada correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcarreramodif.Text = "";
                estadordb = 1;
   
                rdbactivo.Checked = true;
            }
            else
            {
                txtcarreramodif.BackColor = Color.Red;
                MessageBox.Show("El campo carrera debe contener solo texto y estar llenado", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            gvcarrera.Rows.Clear();
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            objcarrera.ESTADO = Convert.ToInt32(estadordb);
            objcarrera.CARRERA = null;
            objcarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
            objcarrera.ID_CARRERA = id_carreramod;

            listacarrera = objcarrera.SeleccionarCarreraCriterioBss();

            for (int fila = 0; fila < listacarrera.Rows.Count; fila++)
            {
                gvcarrera.Rows.Add();
                gvcarrera["carrera", fila].Value = listacarrera.Rows[fila]["carrera"];
                gvcarrera["id_carrera", fila].Value = listacarrera.Rows[fila]["id_carrera"];
                gvcarrera["id_facultad", fila].Value = listacarrera.Rows[fila]["id_facultad"];
                if (Convert.ToInt32(listacarrera.Rows[fila]["estado"]) == 1)
                {
                    gvcarrera["estado", fila].Value = "ACTIVO";
                }
                else
                {
                    gvcarrera["estado", fila].Value = "INACTIVO";
                }

            }
        }


        private void gvcarrera_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvcarrera.Rows[Colorindex].DefaultCellStyle.BackColor = Color.White;
                gvcarrera.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                Colorindex = e.RowIndex;

                txtcarreramodif.Text = listacarrera.Rows[e.RowIndex]["carrera"].ToString();
                id_carreramod = Convert.ToInt32(listacarrera.Rows[e.RowIndex]["id_carrera"].ToString());

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

       


    }
}
