using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.CARRERA
{
    public partial class InsertarCarrera : Form
    {
        public InsertarCarrera()
        {
            InitializeComponent();
        }
        BSS.Bss_Facultad ObjFacultad = new BSS.Bss_Facultad();
        
        DataTable Facultades = new DataTable();
        int IdFacultad;
        private void InsertarCarrera_Load(object sender, EventArgs e)
        {   
            Facultades = ObjFacultad.SeleccionarFacultadBss();
            CmbFacultad.DataSource = ObjFacultad.SeleccionarFacultadBss();
            CmbFacultad.DisplayMember = "facultad";
            
        }
        private void CmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdFacultad=Convert.ToInt32(Facultades.Rows[CmbFacultad.SelectedIndex]["id_facultad"]);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BSS.Bss_Carrera ObjCarrera = new BSS.Bss_Carrera();
            if (TxtCarrera.Text != null)
            {
                ObjCarrera.ID_FACULTAD = IdFacultad;
                ObjCarrera.CARRERA = TxtCarrera.Text.ToUpper();
                ObjCarrera.ESTADO = 1;

                if (ObjCarrera.SeleccionarCarreraCriterioBss().Rows.Count > 0)// condicion para verificar si ya existe la carrera
                {
                    MessageBox.Show("La carrera que intenta registrar ya esta registrada", "ALERTA DE DUPLICIDAD");
                }
                else
                {
                    ObjCarrera.ESTADO = 0;
                    if (ObjCarrera.SeleccionarCarreraCriterioBss().Rows.Count > 0)// condicion para verificar si existe la carrera con un estado desactivado
                    {
                        MessageBox.Show("La carrera que intenta registrar ya esta registrada..Debe ponerla activa", "ALERTA DE DUPLICIDAD");
                    }
                    else
                    {
                        ObjCarrera.ESTADO = 1;
                        ObjCarrera.InsertarCarreraBss();
                        TxtCarrera.Clear();
                    }
                }
            }
            else
                MessageBox.Show(" El campo carrera no debe estar nulo..","ERROR DE DATOS" );
        }

        private void CmbFacultad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        
    }
}
