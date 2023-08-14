using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.CARGO
{
    public partial class ModificarCargo : Form
    {
        public ModificarCargo()
        {
            InitializeComponent();
        }
        BSS.Bss_Cargo objcargo = new BSS.Bss_Cargo();
        DataTable listacargo = new DataTable();
        int estadordb;
        int id_cargobuscar;
        int colorIndex;

        private void ModificarCargo_Load(object sender, EventArgs e)
        {
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            listacargo = objcargo.SeleccionarCargoCriterioBss();
        }

        private void gvcargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listacargo = objcargo.SeleccionarCargoBss();
            TxtCargo.Text = listacargo.Rows[e.RowIndex]["cargo"].ToString();
            TxtDescripcion.Text = listacargo.Rows[e.RowIndex]["descripcion"].ToString();
            lblid.Text = listacargo.Rows[e.RowIndex]["id_cargo"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones.texto(TxtCargo.Text) == true & TxtCargo.Text != "")
            {
                TxtCargo.BackColor = Color.White;
                objcargo.CARGO = TxtCargo.Text.ToUpper();

                if (rdbactivomod.Checked == true)
                {
                    estadordb = 1;
                }
                else
                {
                    estadordb = 0;
                }
                    objcargo.DESCRIPCION = TxtDescripcion.Text.ToUpper();
                    objcargo.ID_CARGO = Convert.ToInt32(lblid.Text);
                    objcargo.ESTADO =Convert.ToInt32(estadordb);
                    objcargo.ModificarCargoBss();
                    MessageBox.Show("El Cargo fue modificado correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtDescripcion.Clear();
                    TxtCargo.Clear();
                    rdbactivomod.Checked = true;
                    rdbactivo.Checked = true;
                    objcargo.ID_CARGO = 0;
                    objcargo.CARGO = "";
                    objcargo.DESCRIPCION = "";
                    //gvcargo.DataSource = objcargo.SeleccionarCargoBss();                  
                
            }
            else
            {
                MessageBox.Show("El campo Cargo esta vacio o esta mal llenado", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCargo.BackColor = Color.Red;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            gvcargo.Rows.Clear();
            objcargo.CARGO = "";
            objcargo.DESCRIPCION = "";
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            objcargo.ESTADO = Convert.ToInt32(estadordb);
            listacargo = objcargo.SeleccionarCargoCriterioBss();
            for (int fila = 0; fila < listacargo.Rows.Count; fila++)
            {
                gvcargo.Rows.Add();
                gvcargo["cargo", fila].Value = listacargo.Rows[fila]["cargo"];
                gvcargo["id_cargo", fila].Value = listacargo.Rows[fila]["id_cargo"];
                gvcargo["descripcion", fila].Value = listacargo.Rows[fila]["descripcion"];

                if (Convert.ToInt32(listacargo.Rows[fila]["estado"]) == 1)
                {
                    gvcargo["estado", fila].Value = "ACTIVO";
                }
                else
                {
                    gvcargo["estado", fila].Value = "INACTIVO";
                }

            }
        }

        private void gvcargo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvcargo.Rows[colorIndex].DefaultCellStyle.BackColor = Color.White;
                gvcargo.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                colorIndex = e.RowIndex;

                listacargo = objcargo.SeleccionarCargoCriterioBss();
                TxtCargo.Text = listacargo.Rows[e.RowIndex]["cargo"].ToString();
                TxtDescripcion.Text = listacargo.Rows[e.RowIndex]["descripcion"].ToString();
                if (rdbactivo.Checked)
                {
                    rdbactivomod.Checked = true;
                }
                else
                {
                    rdbinactivomod.Checked = true;
                }
                id_cargobuscar = Convert.ToInt32(listacargo.Rows[e.RowIndex]["id_cargo"].ToString());
            
            }
            catch (Exception ee)
            {
                colorIndex = 0;
                MessageBox.Show(ee.ToString());
            }
               

        }

    }
}
