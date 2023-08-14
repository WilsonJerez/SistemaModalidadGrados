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
    public partial class DatosCarrra : Form
    {
        public DatosCarrra()
        {
            InitializeComponent();
        }
        // datos recibidos para el formularios
        public int IdEstudiante;
        public int IdPersona;
        public int IdCarrera;
        public string ci;
        public string NombreCompleto;
        public string Carrera;
        //objetos utilizados
        BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
        BSS.Bss_Estudiante ObjEstudiante = new BSS.Bss_Estudiante();
        //data tables utilizados para recuperar datos
        DataTable DtCarreras = new DataTable();
        //variables para capturar ids
        int IdNuevaCarrera = 0;
        private void DatosCarrra_Load(object sender, EventArgs e)
        {
            //cargamos datos recibidos del estudiante
            Txtci.Text = ci;
            TxtNombreCompleto.Text = NombreCompleto;
            TxtCarrera.Text = Carrera;
            //cargamos las carreras correspondientes a la facultad
            ObjCarrera.ESTADO = 1;
            ObjCarrera.ID_FACULTAD = DAL.Dal_Login.id_facultad;
            DtCarreras = ObjCarrera.SeleccionarCarreraCriterioBss();
            CmbCarreras.DataSource = DtCarreras;
            CmbCarreras.DisplayMember = "carrera";
        }
        private void CmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdNuevaCarrera = Convert.ToInt32(DtCarreras.Rows[CmbCarreras.SelectedIndex]["id_carrera"].ToString());
        }
        private void BtnActualizarCarrera_Click(object sender, EventArgs e)
        {
            if (IdNuevaCarrera > 0)
            {
                //verificamos que el estudiante no haya cursado la misma carrera
                ObjEstudiante.ESTADO = 1;
                ObjEstudiante.ID_PERSONA = IdPersona;
                ObjEstudiante.ID_CARRERA = IdNuevaCarrera;
                if (ObjEstudiante.SeleccionarEstudiantexCriterios2Bss().Rows.Count == 0)
                {
                    CmbCarreras.BackColor = Color.White;
                    ObjEstudiante.ID_ESTUDIANTE = IdEstudiante;
                    ObjEstudiante.ModificarCarreraEstudianteBss();
                    MessageBox.Show("La carrera del estudiante fue modificada correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ObjEstudiante.ID_ESTUDIANTE = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Es estudiante ya curso esta carrera, seleccione una diferente para continuar con la modificacion de la carrera","ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CmbCarreras.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("No se selecciono una carrera,seleccione una para continuar la modificacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CmbCarreras_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

       
    }
}
