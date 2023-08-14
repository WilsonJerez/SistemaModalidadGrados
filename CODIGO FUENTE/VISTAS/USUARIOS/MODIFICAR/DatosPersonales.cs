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
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Usuario ObjUsuario = new BSS.Bss_Usuario();
        // data tables para recuperar datos usuario
        DataTable DtUsuarios = new DataTable();
        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            ObjUsuario.ID_USUARIO = DAL.Dal_Login.id_usuario;
            DtUsuarios = ObjUsuario.SeleccionarUsuarioSistemaBss();
            //cargamos los datos personales del usuario
            if (Validaciones.ci(DtUsuarios.Rows[0]["ci"].ToString()) == true)
            {
                RbtnCi.Checked = true;
            }
            else
            {
                RbtnDni.Checked = true;
            }
            Txtci.Text = DtUsuarios.Rows[0]["ci"].ToString();
            txtnombre.Text = DtUsuarios.Rows[0]["nombre"].ToString();
            txtpaterno.Text = DtUsuarios.Rows[0]["paterno"].ToString();
            txtmaterno.Text = DtUsuarios.Rows[0]["materno"].ToString();
            txttelefono.Text = DtUsuarios.Rows[0]["telefono"].ToString();
            txtcelular.Text = DtUsuarios.Rows[0]["celular"].ToString();
            txtdireccion.Text = DtUsuarios.Rows[0]["direccion"].ToString();
            txtmail.Text = DtUsuarios.Rows[0]["mail"].ToString();

        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
