using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.USUARIOS.MODIFICAR
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }
        BSS.Bss_Usuario ObjUsuario = new BSS.Bss_Usuario();
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtContra1.Text == TxtContra2.Text)
            {
                ObjUsuario.ID_USUARIO = DAL.Dal_Login.id_usuario;
                ObjUsuario.CONTRASEÑA = TxtContra1.Text;
                if (MessageBox.Show("Seguro que desea modificar su contraseña", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ObjUsuario.ModificarContraseñaUsuarioSistemaBss();
                    MessageBox.Show("Su contraseña fue modificada correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La contraseñas no coinciden, ambas deben ser iguales", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
