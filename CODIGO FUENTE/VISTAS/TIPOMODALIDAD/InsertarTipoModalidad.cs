using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.TIPOMODALIDAD
{
    public partial class InsertarTipoModalidad : Form
    {
        public InsertarTipoModalidad()
        {
            InitializeComponent();
        }
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        
        
        private void BtnGuardarx_Click(object sender, EventArgs e)
        {
            if (Validaciones.texto(TxtTipoModalidadX.Text.ToUpper()) == true)
            {
                TxtTipoModalidadX.BackColor = Color.White;

                ObjTipoModalidad.TIPO_MODALIDAD = TxtTipoModalidadX.Text.ToUpper();

                if (Validaciones.texto(TxtDescripcionX.Text.ToUpper()) == true)
                {
                    TxtDescripcionX.BackColor = Color.White;

                    ObjTipoModalidad.ESTADO = 1;

                    if (ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss().Rows.Count > 0)// Verificamos si ya existe la modalidad
                    {

                        MessageBox.Show("El tipo de modalidad que usted intenta registrar ya existe", "ALERTA DE DUPLICIDAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ObjTipoModalidad.DESCRIPCION = TxtDescripcionX.Text.ToUpper();


                        ObjTipoModalidad.InsertarTipoModalidadBss();

                        TxtTipoModalidadX.Clear();
                        TxtDescripcionX.Clear();

                        MessageBox.Show("Se guardo exitosamente el tipo de modalidad", "EXITO");
                        
                    }
                }
                else
                {
                    MessageBox.Show("El campo de descripcion debe contener solo texto o algun texto", "ERROR DE DATO");
                    TxtDescripcionX.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("El campo TIPO MODALIDAD debe contener solo texto", "ERROR DE DATO");
                TxtTipoModalidadX.BackColor= Color.Red;
            }
        }
    }
}
