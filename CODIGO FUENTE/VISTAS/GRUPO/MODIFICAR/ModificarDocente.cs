using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.GRUPO.MODIFICAR
{
    public partial class ModificarDocente : Form
    {
        public ModificarDocente()
        {
            InitializeComponent();
        }
        //variables que reciben datos
        public int IdGrupoRecibido;
        public int IdContratoRecibido;
        public string CiRecibido;
        public string NombreRecibido;
        public string PaternoRecibido;
        public string MaternoRecibido;

        //FUNCIONES
        private DataGridView CargarContratos(DataGridView DtgX, DataTable DtX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["CID", i].Value = DtX.Rows[i]["ci"].ToString();
                DtgX["NOMBRED", i].Value = DtX.Rows[i]["nombre"].ToString();
                DtgX["AP_PATERNOD", i].Value = DtX.Rows[i]["paterno"].ToString();
                DtgX["AP_MATERNOD", i].Value = DtX.Rows[i]["materno"].ToString();
                DtgX["ID_CONTRATOD", i].Value = DtX.Rows[i]["id_contrato"].ToString();
            }
            return DtgX;
        }
        //OBJETOS UTILIZADOS
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        //indices
        int IndiceColorContratos = 0;
        //ids
        int IdContrato = 0;

        private void ModificarDocente_Load(object sender, EventArgs e)
        {
            TxtCiRe.Text = CiRecibido;
            TxtNombreRe.Text = NombreRecibido;
            TxtPaternoRe.Text = PaternoRecibido;
            TxtMaternoRe.Text = MaternoRecibido;
        }
    

        private void BtnFiltrarDocente_Click(object sender, EventArgs e)
        {
            IdContrato = 0;
            //cargamos datos para filtra grupo
            ObjContrato.ESTADO = 1;
            if (TxtCi.Text != "")
                ObjContrato.CI = TxtCi.Text.ToUpper();
            else
                ObjContrato.CI = null;

            if (TxtNombre.Text != "")
                ObjContrato.NOMBRE = TxtNombre.Text.ToUpper();
            else
                ObjContrato.NOMBRE = null;

            if (TxtPaterno.Text != "")
                ObjContrato.PATERNO = TxtPaterno.Text.ToUpper();
            else
                ObjContrato.PATERNO = null;

            if (TxtMaterno.Text != "")
                ObjContrato.MATERNO = TxtMaterno.Text.ToUpper();
            else
                ObjContrato.MATERNO = null;

            //realizamos la busqueda y mostramos

            DtgvContratos = CargarContratos(DtgvContratos, ObjContrato.SeleccionarContratoCriterioBss());
        }

        private void DtgvContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtgvContratos.Rows[IndiceColorContratos].DefaultCellStyle.BackColor = Color.White;
                DtgvContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorContratos = e.RowIndex;
                //capturamos id del contrato
                IdContrato = Convert.ToInt32(DtgvContratos["ID_CONTRATOD",e.RowIndex].Value.ToString());

            }
            catch(Exception ex)
            {
                IdContrato = 0;
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgvContratos.Rows.Count; i++)
                {
                    DtgvContratos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void BtnModificarDocente_Click(object sender, EventArgs e)
        {
            if (IdContrato > 0)
            {
                ObjGrupo.ESTADO = 1;
                ObjGrupo.ID_GRUPO = IdGrupoRecibido;
                ObjGrupo.ID_CONTRATO = IdContrato;
                
                //realizamos modificacion
                if (MessageBox.Show("¿Esta seguro de realizar el cambio?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ObjGrupo.ModificarGrupoBss();
                    MessageBox.Show("Se ha realizado la modificacion de docente para el grupo exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el docente de reemplazo para realizar el cambio, si desea cancelar cierre el formulario en la esquina superior derecha presionando (X)", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
