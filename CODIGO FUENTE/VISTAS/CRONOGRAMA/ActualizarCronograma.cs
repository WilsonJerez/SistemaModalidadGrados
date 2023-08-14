using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.CRONOGRAMA
{
    public partial class ActualizarCronograma : Form
    {
        public ActualizarCronograma()
        {
            InitializeComponent();
        }
        // objetos utilizados

        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();

        // data tables para almacenar los datos recuperados
        DataTable DtModalidadII = new DataTable();
        DataTable DtCronograma = new DataTable();
        // variables para cambiar el color al momento de hacer doble click
        int ColorModalidadII;
        int ColorCronograma;

        // variable para recuperar el id de la modalidad 2
        int IdModalidadII;
        int IdCronograma;
        private void ActualizarCronograma_Load(object sender, EventArgs e)
        {
            
            DtModalidadII = ObjModalidadII.SeleccionarModalidad_IICronogramaPendienteBss();
            //GridModalidadII = CargarGridModalidadII(GridModalidadII, DtModalidadII, "");

            //GridCronograma = CargarCronograma(GridCronograma, DtCronograma, "");

            CmbEstado.SelectedItem = "ACTIVO";           

        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            

            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";
            string ByCi = "";
            string Cmdfiltro = "";
            if (RbActivo.Checked == true)
            {
                Cmdfiltro = "estado=1";
            }
            else
            {
                Cmdfiltro = "estado=0";
            }

            if (TxtCi.Text != "")
            {
                ByNombre = " AND nombre='" + TxtNombre.Text.ToUpper() + "'";

            }
            if (TxtPaterno.Text != "")
            {
                ByPaterno = " AND paterno='" + TxtPaterno.Text.ToUpper() + "'";
            }
            if (TxtMaterno.Text != "")
            {
                ByMaterno = " AND materno='" + TxtMaterno.Text.ToUpper() + "'";
            }
            if (TxtCi.Text != "")
            {
                ByCi = " AND ci='" + TxtCi.Text.ToUpper() + "'";
            }

            CargarGridModalidadII(GridModalidadII, DtModalidadII, Cmdfiltro + ByNombre + ByPaterno + ByMaterno + ByCi);
            ColorModalidadII = 0;
            IdModalidadII = 0;
            ColorCronograma = 0;
            GridCronograma.Rows.Clear();
        }

        private void GridModalidadII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridModalidadII.Rows[ColorModalidadII].DefaultCellStyle.BackColor = Color.White;
                GridModalidadII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IdModalidadII = Convert.ToInt32(GridModalidadII["ID_MODALIDAD_II", e.RowIndex].Value);
                ColorModalidadII = e.RowIndex;
                
                ObjCronograma.ID_MODALIDAD_II = IdModalidadII;
                DtCronograma = ObjCronograma.SeleccionarCronogramaCriterioBss();
                GridCronograma = CargarCronograma(GridCronograma, DtCronograma, "");

                // calculamos la fecha maxima que puede programar un cronograma el estudiante tomando en cuenta que son 6 meses para terminar la modalidad de grado 2
                TxtFechaFin.Text =Validaciones.CalcularFechaFinalizacionModalidadII(Convert.ToDateTime( GridModalidadII["FECHA_INSCRIPCION", e.RowIndex].Value.ToString())).ToShortDateString();
            }
            catch (Exception ee)
            {
                ColorModalidadII = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void GridCronograma_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GridCronograma["ESTADO", ColorCronograma].Value) == 0)
                {
                    GridCronograma.Rows[ColorCronograma].DefaultCellStyle.BackColor = Color.RosyBrown;
                }
                else
                {
                    GridCronograma.Rows[ColorCronograma].DefaultCellStyle.BackColor = Color.White;
                }

                GridCronograma.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorCronograma = e.RowIndex;
                //recuperamos los datos del cronograma para cargar a los contenedores para actulizar
                IdCronograma = Convert.ToInt32(GridCronograma["ID_CRONOGRAMA", e.RowIndex].Value);
                // para no permitir modificar fechas de eventos ya pasados y solo permitir modificar el informe
                if (Convert.ToDateTime(GridCronograma["FECHA", e.RowIndex].Value.ToString()) < Convert.ToDateTime(DAL.Dal_Login.fecha))
                {
                    TxtFecha.Text = GridCronograma["FECHA", e.RowIndex].Value.ToString();
                    TxtFecha.ReadOnly=true;
                }
                else
                {
                    TxtFecha.Text = GridCronograma["FECHA", e.RowIndex].Value.ToString();
                    TxtFecha.ReadOnly = false;
                    TxtFecha.Enabled = true;
                }
                TxtDetalle.Text = GridCronograma["DESCRIPCION", e.RowIndex].Value.ToString();
                if (Convert.ToInt32(GridCronograma["ESTADO", e.RowIndex].Value) == 0)
                {
                    CmbEstado.SelectedItem = "INACTIVO";
                }
                else
                {
                    CmbEstado.SelectedItem = "ACTIVO";
                }

                //habilitamos el resto de los controles
                TxtDetalle.Enabled = true;
                CmbEstado.Enabled = true;
                BtnActualizar.Enabled = true;
                TxtFecha.BackColor = Color.White;

            }
            catch (Exception ee)
            {
                ColorCronograma = 0;
                MessageBox.Show(ee.ToString());
            }

        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (IdCronograma > 0)
            {
                if (Validaciones.fecha(TxtFecha.Text) == true)
                {
                    //validamos que la fecha modificada no exeda los 6 meses permitidos
                    if (Convert.ToDateTime(TxtFecha.Text) <= Convert.ToDateTime(TxtFechaFin.Text))
                    {
                        TxtFecha.BackColor = Color.White;

                        ObjCronograma.ID_CRONOGRAMA = IdCronograma;
                        ObjCronograma.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                        // PARA VALIDAR ELE ESTADO
                        if (CmbEstado.Text == "ACTIVO")
                        {
                            ObjCronograma.ESTADO = 1;
                        }
                        else
                        {
                            ObjCronograma.ESTADO = 0;
                        }
                        // PARA VALIDAR EL DETALLE
                        if (TxtDetalle.Text == "")
                        {
                            if (MessageBox.Show("Seguro que desea actualizar un evento del cronograma con el detalle nulo", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                ObjCronograma.DESCRIPCION = TxtDetalle.Text.ToUpper();
                                // actualizamos el cronograma
                                ObjCronograma.ActualizarCronogramaBss();
                                MessageBox.Show("El evento del cronogrma fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                // limpiamos los campos
                                TxtFecha.Clear();
                                TxtDetalle.Clear();
                                CmbEstado.SelectedItem = "ACTIVO";
                                IdCronograma = 0;
                                // ACTUALIZAMOS LA LISTA DE EVENTOS DEL CRONOGRAMA
                                ObjCronograma.ID_MODALIDAD_II = IdModalidadII;
                                DtCronograma = ObjCronograma.SeleccionarCronogramaCriterioBss();
                                GridCronograma = CargarCronograma(GridCronograma, DtCronograma, "");
                            }
                            else
                            {
                                TxtDetalle.Focus();
                                TxtFecha.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            ObjCronograma.DESCRIPCION = TxtDetalle.Text.ToUpper();
                            //actualizamos el cronograma
                            ObjCronograma.ActualizarCronogramaBss();
                            MessageBox.Show("El evento del cronogrma fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // limpiamos los campos
                            TxtFecha.Clear();
                            TxtDetalle.Clear();
                            CmbEstado.SelectedItem = "ACTIVO";
                            IdCronograma = 0;
                            // ACTUALIZAMOS LA LISTA DE EVENTOS DEL CRONOGRAMA
                            ObjCronograma.ID_MODALIDAD_II = IdModalidadII;
                            DtCronograma = ObjCronograma.SeleccionarCronogramaCriterioBss();
                            GridCronograma = CargarCronograma(GridCronograma, DtCronograma, "");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha que modifico no debe exceder los 6 meses permitidos para terminar la modalidad de grado", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtFecha.BackColor = Color.Red;
                    }

                 
                }
                else
                {
                    MessageBox.Show("La fecha no es correcta no cumple el formato DD/MM/AAAA ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtFecha.Focus();
                    TxtFecha.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun dato especifico de la tabla cronograma", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }

        // funcion para cargar Modalidades de grado II con cronogramas pendientes 
        public DataGridView CargarGridModalidadII(DataGridView gridX,DataTable dtx,string cmdfiltroX)
        {
            gridX.Rows.Clear();
            if (cmdfiltroX == "")
            {
                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["NOMBRE", i].Value = dtx.Rows[i]["nombre"];
                    gridX["PATERNO", i].Value = dtx.Rows[i]["paterno"];
                    gridX["MATERNO", i].Value = dtx.Rows[i]["materno"];
                    gridX["CI", i].Value = dtx.Rows[i]["ci"];
                    gridX["ID_MODALIDAD_II", i].Value = dtx.Rows[i]["id_modalidad_II"];
                    gridX["TIPO_MODALIDAD", i].Value = dtx.Rows[i]["tipo_modalidad"];
                    gridX["FECHA_INSCRIPCION", i].Value =Convert.ToDateTime(dtx.Rows[i]["fecha_inscripcion"].ToString()).ToShortDateString();
                    
                }
            }
            else
            {
                DataRow[] filtracion = dtx.Select(cmdfiltroX);
                for (int i = 0; i < filtracion.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["NOMBRE", i].Value = filtracion[i]["nombre"];
                    gridX["PATERNO", i].Value = filtracion[i]["paterno"];
                    gridX["MATERNO", i].Value = filtracion[i]["materno"];
                    gridX["CI", i].Value = filtracion[i]["ci"];
                    gridX["ID_MODALIDAD_II", i].Value = filtracion[i]["id_modalidad_II"];
                    gridX["TIPO_MODALIDAD", i].Value = filtracion[i]["tipo_modalidad"];
                    gridX["FECHA_INSCRIPCION", i].Value =Convert.ToDateTime( filtracion[i]["fecha_inscripcion"].ToString()).ToShortDateString();
                }
            }
            return gridX;
        }

        public DataGridView CargarCronograma(DataGridView gridX,DataTable dtx,string cmdfiltro)
        {
            gridX.Rows.Clear();
            if (cmdfiltro == "")
            {
                for (int i = 0; i < dtx.Rows.Count; i++)                
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_IIC", i].Value = dtx.Rows[i]["id_modalidad_II"];
                    gridX["FECHA", i].Value =Convert.ToDateTime( dtx.Rows[i]["fecha"]).ToShortDateString();
                    if(Convert.ToInt32(dtx.Rows[i]["estado"])==0)
                    {
                        gridX.Rows[i].DefaultCellStyle.BackColor=Color.RosyBrown;
                        gridX["DESCRIPCION", i].Value = dtx.Rows[i]["descripcion"];
                    }
                    else
                    {
                    gridX["DESCRIPCION", i].Value = dtx.Rows[i]["descripcion"];
                    }                

                    gridX["ID_CRONOGRAMA", i].Value = dtx.Rows[i]["id_cronograma"];
                    gridX["ESTADO", i].Value = dtx.Rows[i]["estado"];
                }
            }

            return gridX;
        }

        

        

       

        

        
    }
}
