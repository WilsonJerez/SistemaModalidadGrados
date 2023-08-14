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
    public partial class InsertarCargo : Form
    {
        public InsertarCargo()
        {
            InitializeComponent();
        }
        BSS.Bss_Cargo ObjCargo = new BSS.Bss_Cargo();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones.texto(TxtCargo.Text.ToUpper()) == true)
            {
                TxtCargo.BackColor = Color.White;


                ObjCargo.CARGO = TxtCargo.Text.ToUpper();
                ObjCargo.DESCRIPCION = "";
                ObjCargo.ESTADO = 1;
                if(ObjCargo.SeleccionarCargoCriterioBss().Rows.Count>0)
                {
                    MessageBox.Show("El cargo que intenta guardar ya existe", "ALERTA DE DUPLICIDAD");
                }
                else
                {
                ObjCargo.DESCRIPCION = TxtDescripcion.Text.ToUpper();
                ObjCargo.ESTADO = 1;

                ObjCargo.InsertarCargoBss();
                MessageBox.Show("El cargo se guardó correctamente", "EXITO");
                TxtCargo.Clear();
                TxtDescripcion.Clear();

                    
                }
            }
            else
            {
                TxtCargo.BackColor = Color.Red;
                MessageBox.Show("El campo cargo debe contener solo texto", "ERROR DE DATO");
            }
        }
    }
}
