using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.GRUPO
{
    public partial class ModificarGrupo : Form
    {
        public ModificarGrupo()
        {
            InitializeComponent();
        }
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Turno ObjTurno = new BSS.Bss_Turno();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        DataTable listaAula = new DataTable();
        DataTable listaTurnos = new DataTable();
        DataTable listaContratos = new DataTable();
        DataTable listagrupo = new DataTable();

        int IdAula, IdTurno, IdContrato;
        int IdGrupo;
        int estadordb;
        int Colorindex;
        int idaulamod;
        int idturnomod;
        int IndiceGridColor;

        private void ModificarGrupo_Load(object sender, EventArgs e)
        {
            //ObjGrupo.ESTADO = 1;          
            //listagrupo = ObjGrupo.SeleccionarGrupoCriterioBss();
            //gvgrupo = CargarGrupo(gvgrupo, listagrupo);

            ObjAula.ESTADO = 1;
            ObjTurno.ESTADO = 1;

            cmbaula.DataSource = ObjAula.SeleccionarAulaCriterioBss();
            cmbaula.DisplayMember = "n_aula";

            cmbturno.DataSource = ObjTurno.SeleccionarTurnoCriterioBss();
            cmbturno.DisplayMember = "turno";

     
            

            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ObjGrupo.N_GRUPO = 0;

            ObjGrupo.ESTADO = 1;

            

            if (txtgrupo.Text != "")
            {
                ObjGrupo.N_GRUPO = Convert.ToInt32(txtgrupo.Text);
            }
            if (CkbAula.Checked == true)
                ObjGrupo.ID_AULA = IdAula;
            else
                ObjGrupo.ID_AULA = 0;
            if (CkbTurno.Checked == true)
                ObjGrupo.ID_TURNO = IdTurno;
            else
                ObjGrupo.ID_TURNO = 0;

            listagrupo = ObjGrupo.SeleccionarGrupoCriterioBss();
            gvgrupo = CargarGrupo(gvgrupo, listagrupo);
            

            //limpiamos atributos asignados para la busqueda
            ObjGrupo.N_GRUPO = 0;
            ObjGrupo.ESTADO = 0;
            ObjGrupo.ID_AULA = 0;
            ObjGrupo.ID_TURNO = 0;
            
        }

        private void cmbturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaTurnos = ObjTurno.SeleccionarTurnoBss();
            IdTurno = Convert.ToInt32(listaTurnos.Rows[cmbturno.SelectedIndex]["id_turno"]);
            ObjGrupo.ID_TURNO = IdTurno;
        }

        private void cmbaula_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaAula = ObjAula.SeleccionarAulaBss();
            IdAula= Convert.ToInt32(listaAula.Rows[cmbaula.SelectedIndex]["id_aula"]);
            ObjGrupo.ID_AULA = IdAula;
        }

        

        

        private void gvgrupo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvgrupo.Rows[Colorindex].DefaultCellStyle.BackColor = Color.White;
                gvgrupo.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                Colorindex = e.RowIndex;           

                
                idturnomod = Convert.ToInt32(gvgrupo["id_turno",e.RowIndex].Value);
                idaulamod = Convert.ToInt32(gvgrupo["id_aula",e.RowIndex].Value);
                IdContrato = Convert.ToInt32(gvgrupo["id_contrato",e.RowIndex].Value);
                IdGrupo = Convert.ToInt32(gvgrupo["id_grupo",e.RowIndex].Value);
                
                //gvcontratos.DataSource = ObjContrato.SeleccionarContratoBss();
                
            }
            catch (Exception ee)
            {
                idturnomod = 0;
                idaulamod = 0;
                IdContrato = 0;
                IdGrupo = 0;

                MessageBox.Show(ee.ToString());
                for (int i = 0; i < gvgrupo.Rows.Count; i++)
                {
                    gvgrupo.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            
        }

      

    

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (IdGrupo > 0)
            {
                MODIFICAR.ModificarDocente FrmModDocente = new VISTAS.GRUPO.MODIFICAR.ModificarDocente();
                FrmModDocente.IdGrupoRecibido = IdGrupo;
                FrmModDocente.IdContratoRecibido = IdContrato;
                FrmModDocente.CiRecibido = gvgrupo["Cip", Colorindex].Value.ToString();
                FrmModDocente.NombreRecibido = gvgrupo["Docente", Colorindex].Value.ToString();
                FrmModDocente.PaternoRecibido = gvgrupo["PaternoP", Colorindex].Value.ToString();
                FrmModDocente.MaternoRecibido = gvgrupo["MaternoP", Colorindex].Value.ToString();
                FrmModDocente.ShowDialog();

                //realizamos la busqueda para mostrar al grupo con sus modificaciones
                ObjGrupo.ESTADO = 1;
                ObjGrupo.ID_GRUPO = IdGrupo;

                gvgrupo = CargarGrupo(gvgrupo, ObjGrupo.SeleccionarGrupoCriterioBss());
                Colorindex = 0;
                //liberamos atributos
                ObjGrupo.ESTADO = 0;
                ObjGrupo.ID_GRUPO = 0;

                IdGrupo = 0;
            }
            else
            {
                MessageBox.Show("Para realizar el cambio de docente primero debe seleccionar el grupo al cual quiere cambiar de docente", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        

        private void CkbAula_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbAula.Checked == true)
                cmbaula.Enabled = true;
            else
                cmbaula.Enabled = false;
        }

        private void CkbTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTurno.Checked == true)
                cmbturno.Enabled = true;
            else
                cmbturno.Enabled = false;
        }

        private void BtnModOtroDAtos_Click(object sender, EventArgs e)
        {
            if (IdGrupo > 0)
            {
                MODIFICAR.DatosDelGrupo FrmModDatosGrupo = new VISTAS.GRUPO.MODIFICAR.DatosDelGrupo();
                FrmModDatosGrupo.IdGrupoRecibidoRe = IdGrupo;
                FrmModDatosGrupo.IdContratoRecibido = IdContrato;
                FrmModDatosGrupo.IdAulaRecibido = idaulamod;
                FrmModDatosGrupo.IdTurnoRecibido = idturnomod;
                FrmModDatosGrupo.NroGrupoRe=gvgrupo["N_grupo",Colorindex].Value.ToString();
                FrmModDatosGrupo.FechaInicioRe = gvgrupo["Fecha_inicio", Colorindex].Value.ToString();
                FrmModDatosGrupo.FechaFinalRe = gvgrupo["Fecha_final", Colorindex].Value.ToString();
                FrmModDatosGrupo.AulaRe = gvgrupo["N_aula", Colorindex].Value.ToString();
                FrmModDatosGrupo.TurnoRe = gvgrupo["Turno", Colorindex].Value.ToString();


                FrmModDatosGrupo.ShowDialog();
                //cargamos parametros para buscar el grupo y mostrarlo con sus actualizaciones

                ObjGrupo.ESTADO=1;
                ObjGrupo.ID_GRUPO=IdGrupo;
                gvgrupo=CargarGrupo(gvgrupo,ObjGrupo.SeleccionarGrupoCriterioBss());
                Colorindex = 0;

                //liberamos atributos
                ObjGrupo.ESTADO = 0;
                ObjGrupo.ID_GRUPO = 0;
            }
            else
            {
                MessageBox.Show("Para realizar una modificacion de cualquiera de los datos del grupo usted primero tiene que seleccionar el grupo al cual quiere hacer las modificaciones", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        public DataGridView CargarGrupo(DataGridView gvgrupoX, DataTable listagrupoX)
        {
            gvgrupoX.Rows.Clear();
            for (int fila = 0; fila < listagrupoX.Rows.Count; fila++)
            {
                gvgrupoX.Rows.Add();
                gvgrupoX["N_grupo", fila].Value = listagrupoX.Rows[fila]["n_grupo"];
                gvgrupoX["N_aula", fila].Value = listagrupoX.Rows[fila]["n_aula"];
                gvgrupoX["Capacidad", fila].Value = listagrupoX.Rows[fila]["capacidad"];
                gvgrupoX["Fecha_inicio", fila].Value = Convert.ToDateTime(listagrupoX.Rows[fila]["fecha_inicio"].ToString()).ToShortDateString();
                gvgrupoX["Fecha_final", fila].Value = Convert.ToDateTime(listagrupoX.Rows[fila]["fecha_final"].ToString()).ToShortDateString();

                gvgrupoX["Cip", fila].Value = listagrupoX.Rows[fila]["ci"];
                gvgrupoX["Docente", fila].Value = listagrupoX.Rows[fila]["nombre"];
                gvgrupoX["PaternoP", fila].Value = listagrupoX.Rows[fila]["paterno"];
                gvgrupoX["MaternoP", fila].Value = listagrupoX.Rows[fila]["materno"];
                if (Convert.ToInt32(listagrupoX.Rows[fila]["estado"]) == 1)
                {

                    gvgrupoX["Estado", fila].Value = "Activo";
                }
                else
                {
                    gvgrupoX["Estado", fila].Value = "Inactivo";
                }
                gvgrupoX["Turno", fila].Value = listagrupoX.Rows[fila]["turno"];

                gvgrupoX["id_grupo", fila].Value = listagrupoX.Rows[fila]["id_grupo"];
                gvgrupoX["id_aula", fila].Value = listagrupoX.Rows[fila]["id_aula"];
                gvgrupoX["id_contrato", fila].Value = listagrupoX.Rows[fila]["id_contrato"];
                gvgrupoX["id_turno", fila].Value = listagrupoX.Rows[fila]["id_turno"];
            }

            return gvgrupoX;
        }

        private void gvgrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
