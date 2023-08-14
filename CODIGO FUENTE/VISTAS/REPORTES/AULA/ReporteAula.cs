using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.AULA
{
    public partial class ReporteAula : Form
    {
        public ReporteAula()
        {
            InitializeComponent();
        }
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        DataTable DtListaAulas = new DataTable();

        VISTAS.REPORTES.AULA.CrAula CrAula = new CrAula();


        private void ReporteAula_Load(object sender, EventArgs e)
        {
            DtListaAulas.Columns.Add("piso");
            DtListaAulas.Columns.Add("capacidad");
            DtListaAulas.Columns.Add("n_aula");
            DtListaAulas.Columns.Add("estado");

            //this.reportViewer1.RefreshReport();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (TxtPiso.Text != "" & Validaciones.numero(TxtPiso.Text) == true)
            {
                ObjAula.PISO = Convert.ToInt32(TxtPiso.Text);
            }
            if(RbActivas.Checked==true)
                ObjAula.ESTADO=1;
            if(RbInactivas.Checked==true)
                ObjAula.ESTADO=0;
            if (TxtCantidad.Text != "" & Validaciones.numero(TxtCantidad.Text) == true)
            {
                ObjAula.CAPACIDAD = Convert.ToInt32(TxtCantidad.Text);
            }
            if (RbMayorQue.Checked == true)
              DtListaAulas=CargarAulas(DtListaAulas, ObjAula.ReporteAulaBss(0));
            else
              DtListaAulas=CargarAulas(DtListaAulas, ObjAula.ReporteAulaBss(1));

            // reporte
            
            CrAula.Database.Tables["AULA"].SetDataSource(DtListaAulas);
            CrvReporteAulas.ReportSource = CrAula;
        }
        public DataTable CargarAulas(DataTable DtListaAulasX, DataTable aulas)
        {
            DtListaAulasX.Rows.Clear();
            for (int fi = 0; fi < aulas.Rows.Count; fi++)
            {
                DtListaAulasX.Rows.Add();
                DtListaAulasX.Rows[fi]["piso"] = aulas.Rows[fi]["piso"];
                DtListaAulasX.Rows[fi]["n_aula"] = aulas.Rows[fi]["n_aula"];
                DtListaAulasX.Rows[fi]["capacidad"] = aulas.Rows[fi]["capacidad"];
                if (Convert.ToInt32(aulas.Rows[fi]["estado"]) == 1)
                    DtListaAulasX.Rows[fi]["estado"] = "ACTIVO";
                else
                    DtListaAulasX.Rows[fi]["estado"] = "INACTIVO";
            }
            return DtListaAulasX;
        }
    }
}
