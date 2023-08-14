using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.REPORTES.MODALIDAD_I
{
    public partial class ReporteModalidad_I_I : Form
    {
        public ReporteModalidad_I_I()
        {
            InitializeComponent();
        }

        VISTAS.REPORTES.MODALIDAD_I.ReporteCortoModI CrModI = new ReporteCortoModI();

        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_TipModalidad ObjTipoModalidad = new BSS.Bss_TipModalidad();
        BSS.Bss_Modalidad_I ObjModalidad_I = new BSS.Bss_Modalidad_I();

        DataTable DtListaGrupos = new DataTable();
        DataTable DtLIstaCarreras = new DataTable();
        DataTable DtListaTipoModalidad = new DataTable();

        DataTable DtListaMod = new DataTable();
        DataTable CabezaModI = new DataTable();
        
        int idgrupo;
        int idcarrera;
        int idtipomodalidad;
        int gestion;

        private void ReporteModalidad_I_I_Load(object sender, EventArgs e)
        {
            CabezaModI.Columns.Add("facultad");
            CabezaModI.Columns.Add("coordinador");
            CabezaModI.Columns.Add("gestion");
            CabezaModI.Columns.Add("n_grupo");
            CabezaModI.Columns.Add("carrera");
            CabezaModI.Columns.Add("tipo_modalidad");
            CabezaModI.Columns.Add("nro_registros");


            TxtGestion.Text = DateTime.Now.Year.ToString();
            gestion = Convert.ToInt32(TxtGestion.Text);
        }
        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            

            CabezaModI.Rows.Clear();
            CabezaModI.Rows.Add();
            CabezaModI.Rows[0]["facultad"] = DAL.Dal_Login.facultad;
            CabezaModI.Rows[0]["coordinador"] = DAL.Dal_Login.coordinador;
            CabezaModI.Rows[0]["gestion"] = TxtGestion.Text;
            if (CmbGrupos.Enabled == true)
                CabezaModI.Rows[0]["n_grupo"] = CmbGrupos.Text;
            else
                CabezaModI.Rows[0]["n_grupo"] = "----";
            if (CmbCarreras.Enabled == true)
                CabezaModI.Rows[0]["carrera"] = CmbCarreras.Text;
            else
                CabezaModI.Rows[0]["carrera"] = "----";
            if (CmbTipoModalidad.Enabled == true)
                CabezaModI.Rows[0]["tipo_modalidad"] = CmbTipoModalidad.Text;
            else
                CabezaModI.Rows[0]["tipo_modalidad"] = "----";


            DtListaMod = ObjModalidad_I.ReporteModalidadIBss(idgrupo, idcarrera, idtipomodalidad, gestion);
            CrModI.Database.Tables["MODALIDAD_I"].SetDataSource(DtListaMod);
            CrvReporteModalidad_I_I.ReportSource = CrModI;

            CabezaModI.Rows[0]["nro_registros"] = DtListaMod.Rows.Count.ToString();//contamos la cantidad de registros para agregar al encabezado del reporte ya que despues de haber cargado la lista de modalidad 1 

            CrModI.Database.Tables["CABEZA_MOD_I"].SetDataSource(CabezaModI);
            
            

            

        }

        private void CkbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbGrupo.Checked == true)
            {
                if (TxtGestion.Text != "" & Validaciones.numero(TxtGestion.Text) == true)
                {
                    if (RbActivo.Checked == true)
                        ObjGrupo.ESTADO = 1;
                    else
                        ObjGrupo.ESTADO = 0;
                    ObjGrupo.GESTION = Convert.ToInt32(TxtGestion.Text);
                    DtListaGrupos = ObjGrupo.SeleccionarGrupoCriterioBss();
                    CmbGrupos.DataSource = DtListaGrupos;
                    CmbGrupos.DisplayMember = "n_grupo";

                    CmbGrupos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Es necesario el dato de la gestion para filtrar los grupos o cualquier otro dato que siva de criterio para generar el reporte", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                CmbGrupos.Enabled = false;
                idgrupo = 0;
            }
        }

        private void CmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idgrupo = Convert.ToInt32(DtListaGrupos.Rows[CmbGrupos.SelectedIndex]["id_grupo"]);
        }

        private void CkbCarrera_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCarrera.Checked == true)
            {
                ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
                ObjCarrera.ESTADO = 1;
                DtLIstaCarreras = ObjCarrera.SeleccionarCarreraCriterioBss();
                CmbCarreras.DataSource = DtLIstaCarreras;
                CmbCarreras.DisplayMember = "carrera";
                CmbCarreras.Enabled = true;
            }
            else
            {
                CmbCarreras.Enabled = false;
                idcarrera = 0;
            }
        }

        private void CmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcarrera = Convert.ToInt32(DtLIstaCarreras.Rows[CmbCarreras.SelectedIndex]["id_carrera"]);
        }

        private void CkbTipoModalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTipoModalidad.Checked == true)
            {
                ObjTipoModalidad.ESTADO = 1;
                DtListaTipoModalidad = ObjTipoModalidad.SeleccionarTipoModalidadCriterioBss();
                CmbTipoModalidad.DataSource = DtListaTipoModalidad;
                CmbTipoModalidad.DisplayMember = "tipo_modalidad";
                CmbTipoModalidad.Enabled = true;
            }
            else
            {
                CmbTipoModalidad.Enabled = false;
                idtipomodalidad = 0;
            }
        }

        private void CmbTipoModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtipomodalidad=Convert.ToInt32(DtListaTipoModalidad.Rows[CmbTipoModalidad.SelectedIndex]["id_tipo_modalidad"]);
        }

        private void CmbGrupos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbCarreras_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbTipoModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        

        

        
    }
}
