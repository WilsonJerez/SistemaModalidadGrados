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
    public partial class InsertarCronograma : Form
    {
        public InsertarCronograma()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();

        // data tables para almacenar los datos recuperados desde la base de datos
        DataTable DtModalidadII = new DataTable();

        //indice para dar color y quitar del grid de modalidades 2 en el evento doble click de una fila
        int IndiceColorModalidadII;

        // para capturar el id de la modalidad 2 al hacer doble click en un a fila
        int IdModalidadII;

        // Otras
        int contadorfechas;
        // para recuperar la fecha de inscripcion y calcular la fecha de finalizacion
        DateTime FechaInscripcion;
        private void InsertarCronograma_Load(object sender, EventArgs e)
        {
            DtModalidadII = ObjModalidadII.SeleccionarModalidad_IIBss();
            GridModalidadII = CargarGridModalidadII(GridModalidadII, DtModalidadII, "");           
        }

        // boton para filtrar desde el data table
        private void BtnFiltrarModalidadII_Click(object sender, EventArgs e)
        {
            string cmdfiltrar = "estado=1 ";
            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";

            if (TxtCiB.Text != "")
                ByCi = "AND ci=" + TxtCiB.Text.ToUpper();
            if (TxtNombreB.Text != "")
                ByNombre = " AND nombre='" + TxtNombreB.Text.ToUpper() + "'";
            if (TxtPaternoB.Text != "")
                ByPaterno = " AND paterno='" + TxtPaternoB.Text.ToUpper() + "'";
            if (TxtMaternoB.Text != "")
                ByMaterno = " AND materno='" + TxtMaternoB.Text.ToUpper() + "'";

            GridModalidadII = CargarGridModalidadII(GridModalidadII, DtModalidadII, cmdfiltrar + ByCi + ByNombre + ByPaterno + ByMaterno);
        }
        // evento doble click en una fila del grid de modalidades
        private void GridModalidadII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // para cambiar el color de una fila al  hacer doble click
                GridModalidadII.Rows[IndiceColorModalidadII].DefaultCellStyle.BackColor = Color.White;
                GridModalidadII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                //recuperamos la fecha
                FechaInscripcion = Convert.ToDateTime(GridModalidadII["FECHA_INSCRIPCION", e.RowIndex].Value.ToString());
                //recuperamos el id de la modaliad 2
                IdModalidadII = Convert.ToInt32(GridModalidadII["ID_MODALIDAD_II", e.RowIndex].Value);
                IndiceColorModalidadII = e.RowIndex;

                //para calcular la fecha de finalizacion de la modalidad tomando en cuenta que tiene como maximo 6 meses
                TxtFechFin.Text = Validaciones.CalcularFechaFinalizacionModalidadII(FechaInscripcion).ToShortDateString();

                // HABILITAMOS LOS CONTROLES PARA ELAGREGADO DE FECHAS
                GridFechas.Enabled = true;
                BtnAgregarFecha.Enabled = true;
                BtnQuitarFecha.Enabled = true;
                BtnGuardarCronograma.Enabled = true;
            }
            catch (Exception ee)
            {
                IndiceColorModalidadII = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        // boton para agregar una fecha
        private void BtnAgregarFecha_Click(object sender, EventArgs e)
        {
            
            GridFechas.Rows.Add();
            GridFechas["NRO", contadorfechas].Value = contadorfechas + 1;
            contadorfechas++;
            BtnAgregarFecha.Enabled = false;

        }
        //
        private void BtnGuardarCronograma_Click(object sender, EventArgs e)
        {
            //bandera para controlar no existan campos de fechas nulas
            bool band = false;
            if (IdModalidadII > 0)
            {
                if (GridFechas.Rows.Count > 0)
                {
                    //ciclo para verificar que no existan campos de fechas nulos
                    for (int i = 0; i < GridFechas.Rows.Count; i++)
                    {
                        if (GridFechas["FECHA", i].Value == null || GridFechas["FECHA", i].Value.ToString() == "")
                        {
                            band = true;
                        }
                    }
                    //para verificar que todas los campos de fechas esten llenados
                    if (band == false)
                    {
                        // ciclo para guardar el cronograma
                        for (int i = 0; i < GridFechas.Rows.Count; i++)
                        {
                            ObjCronograma.ESTADO = 1;
                            ObjCronograma.ID_MODALIDAD_II = IdModalidadII;
                            ObjCronograma.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(GridFechas["FECHA", i].Value.ToString());
                            ObjCronograma.InsertarCronogramaBss();
                        }

                        MessageBox.Show("El cronograma fue guardado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        // refrescamos el data table de modalidades
                        DtModalidadII = ObjModalidadII.SeleccionarModalidad_IIBss();
                        GridModalidadII = CargarGridModalidadII(GridModalidadII, DtModalidadII, "");
                        GridFechas.Rows.Clear();
                        contadorfechas = 0;
                        IdModalidadII = 0;
                    }
                    else
                    {                        
                        MessageBox.Show("Existen campos de fechas en blanco, no se podra continuar con el registro hasta que quite ese campo o lo asigne una fecha", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("No se han insertado fechas para el cronograma", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("No selecciono al estudiante para asignarle el cronograma", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        //fuciones para cargar el grid modalidades de grado de grado II
        public DataGridView CargarGridModalidadII(DataGridView GridX,DataTable dtX,string cmdsqlX)
        {
            GridX.Rows.Clear();
            if (cmdsqlX == "")
            {
                for (int i = 0; i < dtX.Rows.Count; i++)
                {
                    GridX.Rows.Add();
                    GridX["CI", i].Value = dtX.Rows[i]["ci"];
                    GridX["NOMBRE", i].Value = dtX.Rows[i]["nombre"];
                    GridX["PATERNO", i].Value = dtX.Rows[i]["paterno"];
                    GridX["MATERNO", i].Value = dtX.Rows[i]["materno"];
                    GridX["TEMA", i].Value = dtX.Rows[i]["tema"];
                    GridX["TIPO_MODALIDAD", i].Value = dtX.Rows[i]["tipo_modalidad"];
                    GridX["ID_MODALIDAD_II", i].Value = dtX.Rows[i]["id_modalidad_II"];
                    GridX["FECHA_INSCRIPCION", i].Value = dtX.Rows[i]["fecha_inscripcion"];
                }
            }
            else
            {
                DataRow [] filtracion = dtX.Select(cmdsqlX);
                for (int i = 0; i < filtracion.Length; i++)
                {
                    GridX.Rows.Add();
                    GridX["CI", i].Value = filtracion[i]["ci"];
                    GridX["NOMBRE", i].Value = filtracion[i]["nombre"];
                    GridX["PATERNO", i].Value = filtracion[i]["paterno"];
                    GridX["MATERNO", i].Value = filtracion[i]["materno"];
                    GridX["TEMA", i].Value = filtracion[i]["tema"];
                    GridX["TIPO_MODALIDAD", i].Value = filtracion[i]["tipo_modalidad"];
                    GridX["ID_MODALIDAD_II", i].Value = filtracion[i]["id_modalidad_II"];
                    GridX["FECHA_INSCRIPCION", i].Value = filtracion[i]["fecha_inscripcion"];
                }
            }
            return GridX;
        }

        private void BtnQuitarFecha_Click(object sender, EventArgs e)
        {
            if (GridFechas.Rows.Count > 0)
            {
                GridFechas.Rows.RemoveAt(contadorfechas - 1);
                contadorfechas--;

                if (GridFechas.Rows.Count == 0)
                    BtnAgregarFecha.Enabled = true;
            }
            
                
        }

        private void GridFechas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Para validar que cumpla el formato fecha 
                if (Validaciones.fecha(GridFechas["FECHA", e.RowIndex].Value.ToString()) == true)
                {
                    // para validar que la fecha introducida sea mayor a la fecha actual
                    if (Convert.ToDateTime(DAL.Dal_Login.fecha) < Convert.ToDateTime(GridFechas["FECHA", e.RowIndex].Value.ToString()))
                    {
                        // para validar que la fecha sea mayor a la fecha anterior introducida dentro del cronograma
                        if (GridFechas.Rows.Count > 0)
                        {
                            if (GridFechas.Rows.Count > 1)
                            {
                                if (Convert.ToDateTime(GridFechas["FECHA", e.RowIndex].Value.ToString()) > Convert.ToDateTime(GridFechas["FECHA", e.RowIndex - 1].Value.ToString()))
                                {
                                    BtnAgregarFecha.Enabled = true;
                                    ////para validar que la fecha introducida sea menor o igual a la fecha limite de 6 meses despues de haberse inscrito en la modalidad 2
                                    //if (Convert.ToDateTime(GridFechas["FECHA", e.RowIndex].Value.ToString()) <= Convert.ToDateTime(TxtFechFin.Text))
                                    //{
                                        
                                    //    GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                                    //}
                                    //else
                                    //{
                                    //    BtnAgregarFecha.Enabled = false;
                                    //    GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                    //    MessageBox.Show("La fecha introducida execede el tiempo limite que tiene un estudiante para terminar la modalidad de grado II (6 meses)", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    //}
                                }
                                else
                                {
                                    BtnAgregarFecha.Enabled = false;
                                    GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                    MessageBox.Show("La fecha deber ser mayor a la fecha inmediata anterior", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                ////para validar que la fecha introducida sea menor o igual a la fecha limite de 6 meses despues de haberse inscrito en la modalidad 2
                                //if (Convert.ToDateTime(GridFechas["FECHA", e.RowIndex].Value.ToString()) <= Convert.ToDateTime(TxtFechFin.Text))
                                //{
                                BtnAgregarFecha.Enabled = true;
                                GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                                //}
                                //else
                                //{
                                //    BtnAgregarFecha.Enabled = false;
                                //    GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                                //    MessageBox.Show("La fecha introducida execede el tiempo limite que tiene un estudiante para terminar la modalidad de grado II (6 meses)", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                //}
                            }
                        }
                        else
                        {
                            BtnAgregarFecha.Enabled = true;
                            GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                            MessageBox.Show("No hay fechas para realizar el registro de cronograma", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        BtnAgregarFecha.Enabled = false;
                        GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        MessageBox.Show("La fecha para el cronograma debe ser mayor a la fecha actual", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    BtnAgregarFecha.Enabled = false;
                    GridFechas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    MessageBox.Show("formato de fecha incorrecto, debe corresponder al formato dd/mm/aaaa ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        

        

        
    }
}
