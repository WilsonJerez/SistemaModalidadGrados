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
    public partial class InsertarFacultad : Form
    {
        public InsertarFacultad()
        {
            InitializeComponent();
        }
        BSS.Bss_Facultad ObjFacultad = new BSS.Bss_Facultad();
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Validaciones.texto(txtFacultad.Text)==true)
            {               
                ObjFacultad.FACULTAD = txtFacultad.Text.ToUpper();
                ObjFacultad.ESTADO = 1;

                if (ObjFacultad.SeleccionarFacultadCriterioBss().Rows.Count >0)// condicion para verificar si existe una facultad
                    MessageBox.Show(" La facultad que esta intentando registrar ya esta registrada...","ALERTA DE DUPLICIDAD" );
                else
                {
                    ObjFacultad.InsertarFacultadBss();
                    MessageBox.Show(" El registro de la facultad fue exitosa","EXITO" );
                    txtFacultad.Clear();
                }
            }
            else
                MessageBox.Show("No ha escrito el nombre de la facultad","ERROR DE DATOS" );

        }
    }
}
