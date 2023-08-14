using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.DEFENSA_II
{
    public partial class DefensasHoyModII : Form
    {
        public DefensasHoyModII()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        VISTAS.REPORTES.DEFENSA_II.CrDefensasHoyModII CrDef = new CrDefensasHoyModII();
        //data tables para recuperar y modelar reportes
        DataTable DtCabReporte = new DataTable();
        DataTable DtRep = new DataTable();

        private void DefensasHoyModII_Load(object sender, EventArgs e)
        {
            //recuperamos la fecha de hoy
            Txthoy.Text = Convert.ToDateTime(DAL.Dal_Login.fecha).ToShortDateString();
            //creamos columnas y una fila para la cabecera del reporte
            DtCabReporte.Columns.Add("coordinador");
            DtCabReporte.Columns.Add("facultad");
            DtCabReporte.Columns.Add("fecha");
            DtCabReporte.Columns.Add("nro_registros");
            //agregamos la fila
            DtCabReporte.Rows.Add();
        }
        private void BtnGenReporte_Click(object sender, EventArgs e)
        {
            // validamos si es para hoy u otra fecha
            if (RdbHoy.Checked == true)
            {
                ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(Txthoy.Text);
                DtRep = ObjDefensa.ReporteDefensasParaHoyModalidadIIBss();
                //modelamos la cabecera del reporte
                DtCabReporte.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                DtCabReporte.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                DtCabReporte.Rows[0]["fecha"] = Txthoy.Text;
                DtCabReporte.Rows[0]["nro_registros"] = DtRep.Rows.Count;
                //cargamos el reporte
                CrDef.Database.Tables["CAB_DEF_HOY_MOD_II"].SetDataSource(DtCabReporte);
                CrDef.Database.Tables["DEF_HOY_MOD_II"].SetDataSource(DtRep);
                //mostramos el reporte
                CrvReporte.ReportSource = CrDef;
            }
            else
            {
                if(Validaciones.fecha(TxtOtraFecha.Text)==true)
                {
                    TxtOtraFecha.BackColor = Color.White;
                    ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtOtraFecha.Text);
                    DtRep = ObjDefensa.ReporteDefensasParaHoyModalidadIIBss();
                    //modelamos la cabecera del reporte
                    DtCabReporte.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
                    DtCabReporte.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
                    DtCabReporte.Rows[0]["fecha"] = TxtOtraFecha.Text;
                    DtCabReporte.Rows[0]["nro_registros"] = DtRep.Rows.Count;
                    //cargamos el reporte
                    CrDef.Database.Tables["CAB_DEF_HOY_MOD_II"].SetDataSource(DtCabReporte);
                    CrDef.Database.Tables["DEF_HOY_MOD_II"].SetDataSource(DtRep);
                    //mostramos el reporte
                    CrvReporte.ReportSource = CrDef;
                }
                else
                {
                    MessageBox.Show("Usted seleccionó la opcion otra fecha, la fecha no cumple el formato requerido.. Ej. dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtOtraFecha.BackColor = Color.Red;
                }
            }
           
        }

        
    }
}
