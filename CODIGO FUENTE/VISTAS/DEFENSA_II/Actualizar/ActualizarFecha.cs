using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_II.Actualizar
{
    public partial class ActualizarFecha : Form
    {
        public ActualizarFecha()
        {
            InitializeComponent();
        }
        // OBJETOS UTILIZADOS
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
       // data table para recuperar los datos
        DataTable DtDefensas = new DataTable();
        // variables para captuar el id de la defensa
        int IdDefensa;
        //variables para el color
        int ColorDefensa;
        private void BtnFiltrarDefensa_Click(object sender, EventArgs e)
        {
            IdDefensa = 0;
            if (TxtCi.Text != "" & Validaciones.ci(TxtCi.Text) == true)
            {
                // seteamos la fecha para que se realicen la busqueda de las defensas cuyas fechas sean mayor a la actual 
                // solo seteamos feha por que los demas criterios de busqueda son pasados por parametros por que no son parte de los atributos de defensa pero fecha si lo es 
                ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), Convert.ToInt32(TxtCi.Text),1,0);
            }
            else
            {
                if (TxtCi.Text != "")
                {
                    MessageBox.Show("El ci es incorrecto, se mostraran todas las defensas ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 0,1,0);
            }
            GridDefensa = CargarDefensas(GridDefensa, DtDefensas);
        }

            private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
            {
                string fecha = "";
                int  dia =monthCalendar1.SelectionStart.Day;
                int mes = monthCalendar1.SelectionStart.Month;
                int año = monthCalendar1.SelectionStart.Year;
                string dias = "";
                string mess = "";
                if (dia <= 9)
                    dias = "0" + dia.ToString();
                else
                    dias = dia.ToString();
                if (mes <= 9)
                    mess = "0" + mes.ToString();
                else
                    mess = mes.ToString();

               fecha = dias + "/" + mess + "/" + año.ToString();
               if (Convert.ToDateTime(fecha) <= Convert.ToDateTime(DAL.Dal_Login.fecha))
               {
                   TxtFecha.Clear();
                   MessageBox.Show("La fecha selecionada deber ser mayor a la fecha actual", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               }
               else
               {
                   TxtFecha.Text = fecha;
               }
            }
            private void GridDefensa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                try
                {
                    GridDefensa.Rows[ColorDefensa].DefaultCellStyle.BackColor = Color.White;
                    GridDefensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    ColorDefensa = e.RowIndex;
                    IdDefensa = Convert.ToInt32(GridDefensa["ID_DEFENSA", e.RowIndex].Value);
                    BtnActualizarFecha.Enabled = true;

                }
                catch (Exception ee)
                {
                    ColorDefensa = 0;
                    MessageBox.Show(ee.ToString());
                }
            }
            private void BtnActualizarFecha_Click(object sender, EventArgs e)
            {
                if (TxtFecha.Text != "")
                {
                    if (IdDefensa > 0)
                    {
                        VISTAS.DEFENSA_II.Actualizar.ActualizarTribunalPorCambioFechaDefensa ActTribu = new ActualizarTribunalPorCambioFechaDefensa();
                        //cargamos los valores necesarios para iniciar el formulario nuevo
                        ActTribu.FechaRecibida = TxtFecha.Text;
                        ActTribu.DefensorRecibido = GridDefensa["NOMBRE", ColorDefensa].Value.ToString() + " " + GridDefensa["PATERNO", ColorDefensa].Value.ToString() + " " + GridDefensa["MATERNO", ColorDefensa].Value.ToString();
                        ActTribu.IdDefensaRecibido = IdDefensa;
                        ActTribu.IdAulaRecibido = Convert.ToInt32(GridDefensa["ID_AULA", ColorDefensa].Value);
                        ActTribu.HoraDefensaRecibida = GridDefensa["HORA", ColorDefensa].Value.ToString();
                        ActTribu.AulaRecibido = GridDefensa["AULA", ColorDefensa].Value.ToString();
                        ActTribu.HoraRecibido = GridDefensa["HORA", ColorDefensa].Value.ToString();

                        ActTribu.ShowDialog();

                        //ACTUALIZAMOS EL GRID DE DEFENSAS

                        //ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(DAL.Dal_Login.fecha.ToString());
                        //DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss();
                        //GridDefensa = CargarDefensas(GridDefensa, DtDefensas);
                        
                    }
                    else
                    {
                        MessageBox.Show("No selecciono ninguna defensa para la actualizacion de la fecha", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        //FUNCIONES 
        public DataGridView CargarDefensas(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRE", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNO", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNO", i].Value = dtX.Rows[i]["materno"];
                gridX["CI", i].Value = dtX.Rows[i]["ci"];
                gridX["FECHA_DEFENSA", i].Value = Convert.ToDateTime(dtX.Rows[i]["fecha"]).ToShortDateString();
                gridX["ID_DEFENSA", i].Value = dtX.Rows[i]["id_defensa"];
                gridX["HORA", i].Value = dtX.Rows[i]["hora"];
                gridX["AULA", i].Value = dtX.Rows[i]["n_aula"];
                gridX["ID_AULA", i].Value = dtX.Rows[i]["id_aula"];
                if (Convert.ToInt32( dtX.Rows[i]["estado"])== 1)
                {
                    gridX["ESTADO", i].Value = "Pendiente";
                }
                else
                {
                    gridX["ESTADO", i].Value = "Defendida";
                }
                //gridX["NOTA", i].Value = dtX.Rows[i]["nota"];
            }
            return gridX;
        }

        

        

        
    }
}
