using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.TIPOMODALIDAD.ACTUALIZAR
{
    public partial class ACTUALIZAR_TIPO_DE_MODALIDAD : Form
    {
        public ACTUALIZAR_TIPO_DE_MODALIDAD()
        {
            InitializeComponent();
        }
        // objetos utilizados

        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();

        // data tables para almacenar los datos recuperados
        DataTable DtTipoModalidad = new DataTable();

        // variables para cambiar el color al momento de hacer doble click
        int ColorTipoModalidad;
        // variable para recuperar el id de la modalidad 2
        int IdTipoModalidad;
        private void ACTUALIZAR_TIPO_DE_MODALIDAD_Load(object sender, EventArgs e)
        {

            DtTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadBss();
            GridTipoModalidad = CargarTipoModalidad(GridTipoModalidad, DtTipoModalidad, "");
           

        }
         private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdTipoModalidad > 0)
            {

                if (CmbEstado.Text == "ACTIVO")
                {
                    ObjTipoModalidad.ESTADO = 1;
                }
                else
                {
                    ObjTipoModalidad.ESTADO = 0;
                }
                // PARA VALIDAR  DESCRIPCION
                if(TxtTipoModalidadX.Text!="")
                {
                    ObjTipoModalidad.TIPO_MODALIDAD = TxtTipoModalidadX.Text.ToUpper();
                }
                if (TxtDescripcionTipo.Text != "")
                {
                    ObjTipoModalidad.DESCRIPCION = TxtDescripcionTipo.Text.ToUpper();                    
                }

                if (MessageBox.Show("Seguro que desea actualizar el tipo de modalidad ", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    ObjTipoModalidad.ID_TIPO_MODALIDAD = IdTipoModalidad;
                    // actualizamos el tipo de modalidad
                    ObjTipoModalidad.ActualizarTipoModalidadBss();

                    MessageBox.Show("El tipo de modalidad fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // limpiamos los campos
                    TxtDescripcionTipo.Clear();
                    TxtTipoModalidadX.Clear();
                    CmbEstado.SelectedItem = "ACTIVO";
                    IdTipoModalidad = 0;


                    // actualizamos la lista de modalidad

                    ObjTipoModalidad.ESTADO = 1;
                    ObjTipoModalidad.DESCRIPCION = null;
                    ObjTipoModalidad.TIPO_MODALIDAD = null;
                    DtTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadBss();
                    GridTipoModalidad = CargarTipoModalidad(GridTipoModalidad, DtTipoModalidad, "");

                }
                
            }
         }
         private void GridTipoModalidad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             try
             {
                 GridTipoModalidad.Rows[ColorTipoModalidad].DefaultCellStyle.BackColor = Color.White;
                 GridTipoModalidad.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                 ColorTipoModalidad = e.RowIndex;
                 //recuperamos los datos del tipo modalidad para cargar a los contenedores para actulizar
                 IdTipoModalidad = Convert.ToInt32(GridTipoModalidad["ID_TIPO_MODALIDAD", e.RowIndex].Value);
                 TxtTipoModalidadX.Text = GridTipoModalidad["TIPO_MODALIDAD", e.RowIndex].Value.ToString();
                 TxtDescripcionTipo.Text = GridTipoModalidad["DESCRIPCION", e.RowIndex].Value.ToString();
                 CmbEstado.SelectedItem = GridTipoModalidad["ESTADO", e.RowIndex].Value.ToString();


                 if (GridTipoModalidad["ESTADO", e.RowIndex].Value.ToString() =="INACTIVO")
                 {
                     CmbEstado.SelectedItem = "INACTIVO";
                 }
                 else
                 {
                     CmbEstado.SelectedItem = "ACTIVO";
                 }

             }
             catch (Exception ee)
             {
                 ColorTipoModalidad = 0;
                 MessageBox.Show(ee.ToString());
             }

         }
        public DataGridView CargarTipoModalidad(DataGridView gridX, DataTable dtx, string cmdfiltroX)
        {
            gridX.Rows.Clear();
            if (cmdfiltroX == "")
            {
                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["TIPO_MODALIDAD", i].Value = dtx.Rows[i]["tipo_modalidad"];
                    gridX["DESCRIPCION", i].Value = dtx.Rows[i]["descripcion"];
                    if (Convert.ToInt32(gridX["ESTADO", i].Value = dtx.Rows[i]["estado"]) == 1)
                        gridX["ESTADO", i].Value = "ACTIVO";
                    else
                        gridX["ESTADO", i].Value = "INACTIVO";
                    
                    gridX["ID_TIPO_MODALIDAD", i].Value = dtx.Rows[i]["id_tipo_modalidad"];

                }
            }
            else
            {
                DataRow[] filtracion = dtx.Select(cmdfiltroX);
                for (int i = 0; i < filtracion.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["TIPO_MODALIDAD", i].Value = dtx.Rows[i]["tipo_modalidad"];
                    gridX["DESCRIPCION", i].Value = dtx.Rows[i]["descripcion"];
                    gridX["ESTADO", i].Value = dtx.Rows[i]["estado"];
                    gridX["ID_TIPO_MODALIDAD", i].Value = dtx.Rows[i]["id_tipo_modalidad"];

                }
            }
            return gridX;
            
        }

        private void CmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
       }
     }
  

  

       
    

