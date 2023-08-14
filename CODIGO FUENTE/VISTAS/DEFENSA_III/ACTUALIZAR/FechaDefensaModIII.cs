using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_III.ACTUALIZAR
{
    public partial class FechaDefensaModIII : Form
    {
        public FechaDefensaModIII()
        {
            InitializeComponent();
        }
        //objetos a utilizar
        BSS.Bss_Mod_III ObjModIII = new BSS.Bss_Mod_III();
        //indiceces
        int IndiceDefensas = 0;
        DEFENSA_III.ACTUALIZAR.FinalizarCambioFecha FrmFinCamFe = new FinalizarCambioFecha();
        //FUNCIONES PARA CARGAR DATOs
        private DataGridView CargarDefensas(DataTable Dtx,DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < Dtx.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_DEFENSA", i].Value = Dtx.Rows[i]["id_defensa"];
                DtgX["ID_MOD_III", i].Value = Dtx.Rows[i]["id_mod_III"];
                DtgX["CI", i].Value = Dtx.Rows[i]["ci"];
                DtgX["NOMBRE", i].Value = Dtx.Rows[i]["nombre"];
                DtgX["PATERNO", i].Value = Dtx.Rows[i]["paterno"];
                DtgX["MATERNO", i].Value = Dtx.Rows[i]["materno"];
                DtgX["FECHA_DEFENSA", i].Value =Convert.ToDateTime(Dtx.Rows[i]["fecha"].ToString()).ToString("dd/MM/yyyy");
                DtgX["HORA", i].Value = Dtx.Rows[i]["hora"];
                DtgX["AULA", i].Value = Dtx.Rows[i]["n_aula"];
                DtgX["TIPO_MODALIDAD", i].Value = Dtx.Rows[i]["tipo_modalidad"];
                DtgX["TEMA", i].Value = Dtx.Rows[i]["tema"];
                DtgX["ID_AULA", i].Value = Dtx.Rows[i]["id_aula"];

            }
            return DtgX;
        }

        private void FechaDefensaModIII_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrarDefensa_Click(object sender, EventArgs e)
        {
            CargarDefensas(ObjModIII.SeleccinarModIIICriterioBss(TxtCi.Text.ToUpper(), TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 1), DtgDefensas);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (Convert.ToDateTime(monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyy")) > DAL.Dal_Login.fecha)
            {
                TxtFecha.Text = monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("La nueva fecha debe ser mayor a la de hoy", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtFecha.Clear();
            }
        }

        private void DtgDefensas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //para cambiar color a la fila
                DtgDefensas.Rows[IndiceDefensas].DefaultCellStyle.BackColor = Color.White;
                DtgDefensas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceDefensas = e.RowIndex;
                //cargamos los datos para el siguiente formulario


                
                FrmFinCamFe.IdDefensaRecibido = Convert.ToInt32(DtgDefensas["ID_DEFENSA", e.RowIndex].Value);
                FrmFinCamFe.IdAulaRecibido = Convert.ToInt32(DtgDefensas["ID_AULA", e.RowIndex].Value);
                FrmFinCamFe.AulaRecibido = DtgDefensas["AULA", e.RowIndex].Value.ToString();
                FrmFinCamFe.HoraRecibido = DtgDefensas["HORA", e.RowIndex].Value.ToString();
                FrmFinCamFe.DefensorRecibido = DtgDefensas["NOMBRE", e.RowIndex].Value + " " + DtgDefensas["PATERNO", e.RowIndex].Value + " " + DtgDefensas["MATERNO", e.RowIndex].Value;
                FrmFinCamFe.IdModIIIRecibido =Convert.ToInt32(DtgDefensas["id_mod_III", e.RowIndex].Value);
                
                //habilitamos el boton de actualizar
                BtnActualizarFecha.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgDefensas.Rows.Count; i++)
                {
                    DtgDefensas.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                BtnActualizarFecha.Enabled = false;
            }
        }

        private void BtnActualizarFecha_Click(object sender, EventArgs e)
        {
            if (TxtFecha.Text != "")
            {
                if (monthCalendar1.SelectionStart.Date > DAL.Dal_Login.fecha)
                {
                    if (Convert.ToDateTime( Convert.ToDateTime(DtgDefensas["FECHA_DEFENSA", IndiceDefensas].Value).ToString("dd/MM/yyyy")) !=Convert.ToDateTime(monthCalendar1.SelectionStart.Date.ToString("dd/MM/yyyy")))
                    {
                        FrmFinCamFe.FechaRecibida = TxtFecha.Text;
                        FrmFinCamFe.ShowDialog();

                        DtgDefensas = CargarDefensas(ObjModIII.SeleccinarModIIICriterioBss(TxtCi.Text.ToUpper(), TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 1), DtgDefensas);
                    }
                    else
                    {
                        MessageBox.Show("Para reprogramar la defensa seleccione una fecha diferente a la que ya tiene la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("No puede reprogramar una defensa para una fecha ya pasada", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
