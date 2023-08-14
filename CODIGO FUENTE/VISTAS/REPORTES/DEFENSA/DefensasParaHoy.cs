using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.DEFENSA
{
    public partial class DefensasParaHoy : Form
    {
        public DefensasParaHoy()
        {
            InitializeComponent();
        }
        VISTAS.REPORTES.DEFENSA.CrDefensasParaHoy CrDefHoy = new CrDefensasParaHoy();
        //objetos utilizados
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        //data tables para el modelado del reporte
        DataTable DtCabecera = new DataTable();
        DataTable DtListaDeDefensas = new DataTable();
        private void DefensasParaHoy_Load(object sender, EventArgs e)
        {
            //cargamos la fecha de hoy
            TxtFechaHoy.Text = DAL.Dal_Login.fecha.ToShortDateString();
            // iniciamos seleccionada la opcion de hoy
            RbtnParaHoy.Checked = true;
            //agregamos columnas para la cabecera
            DtCabecera.Columns.Add("coordinador");
            DtCabecera.Columns.Add("facultad");
            DtCabecera.Columns.Add("nro_registros");
            DtCabecera.Columns.Add("fecha");
            //agregamos la fila para los datos
            DtCabecera.Rows.Add();            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RbtnParaHoy.Checked == true)
            {
                ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFechaHoy.Text);
                DtListaDeDefensas = ObjDefensa.ReporteDefensasParaHoyBss();
                //cargamos la cabecera
                DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                DtCabecera.Rows[0]["nro_registros"] = DtListaDeDefensas.Rows.Count.ToString();
                DtCabecera.Rows[0]["fecha"] = TxtFechaHoy.Text;

                //cargamos el reporte
                CrDefHoy.Database.Tables["DEFENSAS_HOY"].SetDataSource(DtListaDeDefensas);
                CrDefHoy.Database.Tables["CABEZA_DEFENSAS_HOY"].SetDataSource(DtCabecera);

                // cargamos la vista del reporte
                CrvDefHoy.ReportSource = CrDefHoy;

            }
            else
            {
                if (Validaciones.fecha(TxtFechaOtra.Text) == true)
                {
                    if (Convert.ToDateTime(TxtFechaOtra.Text) >= DAL.Dal_Login.fecha)
                    {
                        TxtFechaOtra.BackColor = Color.White;
                        ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFechaOtra.Text);
                        DtListaDeDefensas = ObjDefensa.ReporteDefensasParaHoyBss();
                        //cargamos la cabecera
                        DtCabecera.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                        DtCabecera.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                        DtCabecera.Rows[0]["nro_registros"] = DtListaDeDefensas.Rows.Count.ToString();
                        DtCabecera.Rows[0]["fecha"] = TxtFechaOtra.Text;
                        //cargamos el reporte
                        CrDefHoy.Database.Tables["DEFENSAS_HOY"].SetDataSource(DtListaDeDefensas);
                        CrDefHoy.Database.Tables["CABEZA_DEFENSAS_HOY"].SetDataSource(DtCabecera);

                        // cargamos la vista del reporte
                        CrvDefHoy.ReportSource = CrDefHoy;
                        
                    }
                    else
                    {
                        MessageBox.Show("La fecha introducida minimamente debe ser igual a la actual", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtFechaOtra.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("El campo fecha no fue llenado o La fecha no cumple el formato correcto ej... dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtFechaOtra.BackColor = Color.Red;
                }
            }

          


        }

        private void RbtnOtraFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnOtraFecha.Checked == true)
            {
                TxtFechaOtra.ReadOnly = false;
            }
            else
            {
                TxtFechaOtra.ReadOnly = true;
            }
        }
    }
}
