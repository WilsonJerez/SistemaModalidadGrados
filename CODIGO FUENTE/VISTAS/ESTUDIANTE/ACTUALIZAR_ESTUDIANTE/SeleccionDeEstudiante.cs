using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE
{
    public partial class SeleccionDeEstudiante : Form
    {
        public SeleccionDeEstudiante()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        //data tables para recuperar datos
        DataTable DtEstudiantes = new DataTable();
        //formularios de vinculacion
        VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.DatosCarrra FrmDatoCarrera=new DatosCarrra();        
        VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.DatosModalidad FrmDatosModalidad=new DatosModalidad();
        VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE.DatosPersonales FrmDatosPersonales=new DatosPersonales();
        //otras variables
        int ColorEstudiante = 0;
        private void SeleccionDeEstudiante_Load(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtci.Text != "")
                ObjEstudiante.CI = txtci.Text.ToUpper();
            else
                ObjEstudiante.CI = null;
            if (txtnombre.Text != "")
                ObjEstudiante.NOMBRE = txtnombre.Text.ToUpper();
            else
                ObjEstudiante.NOMBRE = null;
            if (txtpaterno.Text != "")
                ObjEstudiante.PATERNO = txtpaterno.Text.ToUpper();
            else
                ObjEstudiante.PATERNO = null;
            if (txtmaterno.Text != "")
                ObjEstudiante.MATERNO = txtmaterno.Text.ToUpper();
            else
                ObjEstudiante.MATERNO = null;
            
                ObjEstudiante.ESTADO = 1;
            
            DtEstudiantes = ObjEstudiante.SeleccionarEstudiantexCriterios2Bss();
            gvestudiante = CargarEstudiante(gvestudiante, DtEstudiantes);
            ColorEstudiante = 0;
        }
        public DataGridView CargarEstudiante(DataGridView GvEstudianteX, DataTable DtEstudianteX)
        {
            GvEstudianteX.Rows.Clear();
            for (int i = 0; i < DtEstudianteX.Rows.Count; i++)
            {
                GvEstudianteX.Rows.Add();
                GvEstudianteX["ID_ESTUDIANTE", i].Value = DtEstudianteX.Rows[i]["id_estudiante"];
                GvEstudianteX["CI", i].Value = DtEstudianteX.Rows[i]["ci"];
                GvEstudianteX["NOMBRE", i].Value = DtEstudianteX.Rows[i]["nombre"];
                GvEstudianteX["PATERNO", i].Value = DtEstudianteX.Rows[i]["paterno"];
                GvEstudianteX["MATERNO", i].Value = DtEstudianteX.Rows[i]["materno"];
                GvEstudianteX["CARRERA", i].Value = DtEstudianteX.Rows[i]["carrera"];
                GvEstudianteX["ID_PERSONA", i].Value = DtEstudianteX.Rows[i]["id_persona"];
                GvEstudianteX["ID_CARRERA", i].Value = DtEstudianteX.Rows[i]["id_carrera"];
            }
            return GvEstudianteX;
        }
        private void gvestudiante_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvestudiante.Rows[ColorEstudiante].DefaultCellStyle.BackColor = Color.White;
                gvestudiante.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorEstudiante = e.RowIndex;
                BtnModificar.Enabled = true;
                
            }
            catch (Exception ex)
            {
                ColorEstudiante = 0;
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (RdbDatosCarrera.Checked == true)
            {
                FrmDatoCarrera.IdEstudiante = Convert.ToInt32(gvestudiante["ID_ESTUDIANTE", ColorEstudiante].Value.ToString());
                FrmDatoCarrera.IdPersona = Convert.ToInt32(gvestudiante["ID_PERSONA", ColorEstudiante].Value.ToString());
                FrmDatoCarrera.IdCarrera = Convert.ToInt32(gvestudiante["ID_CARRERA", ColorEstudiante].Value.ToString());
                FrmDatoCarrera.NombreCompleto = gvestudiante["NOMBRE", ColorEstudiante].Value + " " + gvestudiante["PATERNO", ColorEstudiante].Value + " "+gvestudiante["MATERNO", ColorEstudiante].Value.ToString();
                FrmDatoCarrera.Carrera = gvestudiante["CARRERA", ColorEstudiante].Value.ToString();
                FrmDatoCarrera.ci = gvestudiante["CI", ColorEstudiante].Value.ToString();
                FrmDatoCarrera.ShowDialog();
            }            
            if (RdbDatosPersonales.Checked == true)
            {
                FrmDatosPersonales.IdPersona = Convert.ToInt32(gvestudiante["ID_PERSONA", ColorEstudiante].Value.ToString());
                FrmDatosPersonales.ShowDialog();
            }
            if (RdbDatosModalidad.Checked == true)
            {
                FrmDatosModalidad = new DatosModalidad();
                FrmDatosModalidad.IdEstudianteRecibido = Convert.ToInt32(gvestudiante["ID_ESTUDIANTE", ColorEstudiante].Value.ToString());
                FrmDatosModalidad.ci = gvestudiante["CI", ColorEstudiante].Value.ToString();
                FrmDatosModalidad.nombre = gvestudiante["NOMBRE", ColorEstudiante].Value.ToString() + " " + gvestudiante["PATERNO", ColorEstudiante].Value.ToString() + " " + gvestudiante["MATERNO", ColorEstudiante].Value.ToString();
                FrmDatosModalidad.carrera = gvestudiante["CARRERA", ColorEstudiante].Value.ToString();
                FrmDatosModalidad.ShowDialog();
            }

            DtEstudiantes = ObjEstudiante.SeleccionarEstudiantexCriterios2Bss();
            gvestudiante = CargarEstudiante(gvestudiante, DtEstudiantes);
            BtnModificar.Enabled = false;
            ColorEstudiante = 0;
        }

        

        


    }
}
