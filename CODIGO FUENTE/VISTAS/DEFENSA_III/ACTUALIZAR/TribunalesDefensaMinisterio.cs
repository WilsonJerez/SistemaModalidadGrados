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
    public partial class TribunalesDefensaMinisterio : Form
    {
        public TribunalesDefensaMinisterio()
        {
            InitializeComponent();
        }
        //objetos a utilizar
        BSS.Bss_Mod_III ObjModIII = new BSS.Bss_Mod_III();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Tribunal_externo ObjTribunalExterno = new BSS.Bss_Tribunal_externo();
        //data tables para recuperar los datos
        DataTable DtDefensas = new DataTable();
        //variables para recuperar ids
        int IdModIII = 0;
        int IdDefensa = 0;
        int IdTribunal = 0;
        int IdContrato = 0;
        int IdTribunalExterno = 0;
        //indices de color
        int IndiceDefensas = 0;
        int IndiceTribunal = 0;
        int IndiceContrato = 0;
        int IndiceTribunalExterno = 0;
        //funciones para cargar datos
        private DataGridView CargarDefensas(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_DEFENSA", i].Value = DtX.Rows[i]["id_defensa"];
                DtgX["ID_MOD_III", i].Value = DtX.Rows[i]["id_mod_III"];
                DtgX["CI", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO", i].Value = DtX.Rows[i]["materno"];
                DtgX["FECHA_DEFENSA", i].Value =Convert.ToDateTime(DtX.Rows[i]["fecha"].ToString()).ToShortDateString();
                DtgX["HORA", i].Value = DtX.Rows[i]["hora"];
                DtgX["TIPO_MOD", i].Value = DtX.Rows[i]["tipo_modalidad"];
                DtgX["TEMA", i].Value = DtX.Rows[i]["tema"];
            }
            return DtgX;
        }
        private DataGridView CargarTribunales(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_TRIBUNAL", i].Value = DtX.Rows[i]["id_tribunal"];
                DtgX["ID_CONTRATO", i].Value = DtX.Rows[i]["id_contrato"];
                DtgX["CI_T", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE_T", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO_T", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO_T", i].Value = DtX.Rows[i]["materno"];
            }
            return DtgX;
        }
        private DataGridView CargarContratos(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_CONTRATO_N", i].Value = DtX.Rows[i]["id_contrato"];
                DtgX["CI_N", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE_N", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO_N", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO_N", i].Value = DtX.Rows[i]["materno"];
            }
            return DtgX;
        }
        private DataGridView CargarAgenda(DataTable DtX,DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["FECHA", i].Value =Convert.ToDateTime(DtX.Rows[i]["fecha"].ToString()).ToShortDateString();
                DtgX["HORA_P", i].Value = DtX.Rows[i]["hora"];
            }
            return DtgX;
        }
        private DataGridView CargarTribunalExterno(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_TRIBUNAL_EXTERNO", i].Value = DtX.Rows[i]["id_tribunal_externo"];
                DtgX["CI_EX", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE_EX", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO_EX", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO_EX", i].Value = DtX.Rows[i]["materno"];
            }
            return DtgX;
        }
        private DataGridView CargarTribunalExternoOpcional(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_TRIBUNAL_EXTERNO_OP", i].Value = DtX.Rows[i]["id_tribunal_externo"];
                DtgX["CI_EX_OP", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE_EX_OP", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO_EX_OP", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO_EX_OP", i].Value = DtX.Rows[i]["materno"];
            }
            return DtgX;
        }
        private DataGridView CargarAgendaTribunalExterno(DataTable DtX, DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["FECHA_OP", i].Value = Convert.ToDateTime(DtX.Rows[i]["fecha"].ToString()).ToShortDateString();
                DtgX["HORA_OP", i].Value = DtX.Rows[i]["hora"];
            }
            return DtgX;
        }


        private void BtnBuscarDefensa_Click(object sender, EventArgs e)
        {
            
            DtDefensas = ObjModIII.SeleccinarModIIICriterioBss(TxtCi.Text.ToUpper(), TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(),1);
            DtgDefensas = CargarDefensas(DtDefensas, DtgDefensas);
            DtDefensas.Rows.Clear();
                          
        }

        private void DtgDefensas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //codigo para cambio de color a la fila seleccionada
                DtgDefensas.Rows[IndiceDefensas].DefaultCellStyle.BackColor = Color.White;
                DtgDefensas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceDefensas = e.RowIndex;
                //recuperamos ids
                IdDefensa = Convert.ToInt32(DtgDefensas["ID_DEFENSA", e.RowIndex].Value);
                IdModIII = Convert.ToInt32(DtgDefensas["ID_MOD_III", e.RowIndex].Value);
                //cargamos tribunales internos
                ObjTribunal.ESTADO = 1;
                ObjTribunal.ID_DEFENSA = IdDefensa;
                DtgTribunalesActuales = CargarTribunales(ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss(), DtgTribunalesActuales);
                //cargamos los tribunales externosj
                DtgTribunalExterno = CargarTribunalExterno(ObjTribunalExterno.SeleccionarTribunalExternoPorIdModIIIDal(IdModIII), DtgTribunalExterno);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IdModIII = 0;
                IdDefensa = 0;
                IndiceDefensas = 0;
                for (int i = 0; i < DtgDefensas.Rows.Count; i++)
                {
                    DtgDefensas.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                DtgTribunalExterno.Rows.Clear();
                DtgTribunalesActuales.Rows.Clear();
                IndiceTribunal = 0;
                IndiceTribunalExterno = 0;
            }
        }

        private void DtgTribunalesActuales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //cambiamos color 
                DtgTribunalesActuales.Rows[IndiceTribunal].DefaultCellStyle.BackColor = Color.White;
                DtgTribunalesActuales.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceTribunal = e.RowIndex;
                //recuperamos id
                IdTribunal = Convert.ToInt32(DtgTribunalesActuales["ID_TRIBUNAL", e.RowIndex].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IdTribunal = 0;
                IndiceTribunal = 0;
                for (int i = 0; i < DtgTribunalesActuales.Rows.Count; i++)
                {
                    DtgTribunalesActuales.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void BtnBuscarContratos_Click(object sender, EventArgs e)
        {
            //reiniciamos indicecontrato
            IndiceContrato = 0;
            IdContrato = 0;
            //cargamos datos de busqueda
            ObjContrato.ESTADO = 1;
            ObjContrato.CI = TxtCiContrato.Text.ToUpper();
            ObjContrato.NOMBRE = TxtNombreContrato.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoContrato.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoContrato.Text.ToUpper();
            //mostramos los datos
            CargarContratos(ObjContrato.SeleccionarContratoCriterioBss(), DtgContratos);
            //desocupamos valores
            ObjContrato.ESTADO = 0;
            ObjContrato.CI = null;
            ObjContrato.NOMBRE = null;
            ObjContrato.PATERNO = null;
            ObjContrato.MATERNO = null;
        }

        private void DtgContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //cambiamos el color
                DtgContratos.Rows[IndiceContrato].DefaultCellStyle.BackColor = Color.White;
                DtgContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceContrato = e.RowIndex;
                //recuperamos id
                IdContrato = Convert.ToInt32(DtgContratos["ID_CONTRATO_N", e.RowIndex].Value);
                //recuperamos agenda
                ObjTribunal.ESTADO = 1;
                ObjTribunal.ID_CONTRATO=IdContrato;
                DtgAgenda = CargarAgenda(ObjTribunal.SeleccionarTribunalCriterioBss(), DtgAgenda);
                //liberamos atributos
                ObjTribunal.ESTADO = 0;
                ObjTribunal.ID_CONTRATO = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                IdContrato = 0;
                IndiceContrato = 0;
                for (int i = 0; i < DtgContratos.Rows.Count; i++)
                {
                    DtgContratos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (IdModIII > 0)
            {
                if (IdTribunal > 0)
                {
                    if (IdContrato > 0)
                    {
                        //cargamos datos para verificar que no exista una defensa en la misma fecha y hora para evitar choques de defensa
                        ObjTribunal.ESTADO = 1;
                        ObjTribunal.ID_CONTRATO = IdContrato;
                        ObjTribunal.FECHA = Convert.ToDateTime(DtgDefensas["FECHA_DEFENSA", IndiceDefensas].Value.ToString()).ToString("MM/dd/yyyy");
                        ObjTribunal.HORA = DtgDefensas["HORA", IndiceDefensas].Value.ToString();
                        if (ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count == 0)
                        {
                            ObjTribunal.FECHA = null;
                            ObjTribunal.HORA = null;

                            ObjTribunal.ID_TRIBUNAL = IdTribunal;
                            ObjTribunal.ID_CONTRATO = IdContrato;
                            ObjTribunal.ESTADO = 1;
                            //actualizamos los tribunales
                            ObjTribunal.ActrualizarTribunalBss();
                            MessageBox.Show("El tribunal fue reemplazado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ObjTribunal.ID_DEFENSA = IdDefensa;
                            DtgTribunalesActuales = CargarTribunales(ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss(), DtgTribunalesActuales);
                            //liberamos contrato seleccionado
                            DtgContratos.Rows[IndiceContrato].DefaultCellStyle.BackColor = Color.White;
                            //liberamos valores
                            IdTribunal = 0;
                            IdContrato = 0;

                            DtgContratos.Rows[IndiceContrato].DefaultCellStyle.BackColor = Color.White;
                        }
                        else
                        {
                            MessageBox.Show("El tribunal de reemplazo que selecciono ya tiene una defensa a la misma fecha y hora, no puede ser tribunal de reemplazo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el nuevo tribunal de la lista de tribunales de reemplazo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el tribunal que desea reemplazar de la lista de tribunales actuales", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la defensa a la cual quiere cambier los tribunales internos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnBuscarTribunalExterno_Click(object sender, EventArgs e)
        {
            ObjTribunalExterno.ESTADO = 1;
            ObjTribunalExterno.CI = TxtCiOp.Text.ToUpper();
            ObjTribunalExterno.NOMBRE = TxtNombreOp.Text.ToUpper();
            ObjTribunalExterno.PATERNO = TxtPaternoOp.Text.ToUpper();
            ObjTribunalExterno.MATERNO = TxtMaternoOp.Text.ToUpper();
            //recuperamos los tribunales externos de acuerdo a criterio de busqueda
            DtgTribunalExternoOp = CargarTribunalExternoOpcional(ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss(), DtgTribunalExternoOp);
            //liberamos parametros de tribunal externo
            ObjTribunalExterno.ESTADO = 0;
            ObjTribunalExterno.CI = null;
            ObjTribunalExterno.NOMBRE = null;
            ObjTribunalExterno.PATERNO = null;
            ObjTribunalExterno.MATERNO = null;
        }

        private void DtgTribunalExternoOp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtgTribunalExternoOp.Rows[IndiceTribunalExterno].DefaultCellStyle.BackColor = Color.White;
                DtgTribunalExternoOp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceTribunalExterno = e.RowIndex;
                //recupermos id tribunal externo
                IdTribunalExterno = Convert.ToInt32(DtgTribunalExternoOp["ID_TRIBUNAL_EXTERNO_OP", e.RowIndex].Value);
                //cargamos sus  defensas programadas si existiesen para el dia y fecha de la defensa
                ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = IdTribunalExterno;
                DtgAgendaTribunalExterno=CargarAgendaTribunalExterno( ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(Convert.ToDateTime(DtgDefensas["FECHA_DEFENSA",IndiceDefensas].Value.ToString()).ToString("MM/dd/yyyy"),""),DtgAgendaTribunalExterno);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgTribunalExternoOp.Rows.Count; i++)
                {
                    DtgTribunalExternoOp.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                IdTribunalExterno = 0;
                IndiceTribunalExterno = 0;
            }
        }

        private void BtnActualizarTribunalExterno_Click(object sender, EventArgs e)
        {
            if (IdModIII > 0)
            {
                if (IdTribunalExterno > 0)
                {
                    if (ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(Convert.ToDateTime(DtgDefensas["FECHA_DEFENSA", IndiceDefensas].Value.ToString()).ToString("MM/dd/yyyy"), DtgDefensas["HORA", IndiceDefensas].Value.ToString()).Rows.Count == 0)
                    {
                        ObjModIII.ID_MOD_III = IdModIII;
                        ObjModIII.ID_TRIBUNAL_EXTERNO = IdTribunalExterno;
                        ObjModIII.ActualizarModIIIBss();
                        //mensaje de confirmacion de modificacion
                        MessageBox.Show("Se realizo el cambio del tribunal externo para la defensa exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        DtgTribunalExterno = CargarTribunalExterno(ObjTribunalExterno.SeleccionarTribunalExternoPorIdModIIIDal(IdModIII), DtgTribunalExterno);
                        IdTribunalExterno = 0;

                        DtgTribunalExternoOp.Rows[IndiceTribunalExterno].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("El tribunal que intenta asignar como reemplazo ya tiene una defensa para la misma fecha y hora, selecione otro tribunal", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione el tribunal de reemplazo que desea asingar a esta defensa, sin un tribunal de reemplazo no se puede realizar la actualizacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
                MessageBox.Show("Selecione la Defensa a la cual quiere cambiar el tribunal externo", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VISTAS.TRIBUNALEXTERNO.InsertarTribunalExterno FrmTribunalExternoInsertar = new VISTAS.TRIBUNALEXTERNO.InsertarTribunalExterno();
            FrmTribunalExternoInsertar.ShowDialog();
            ObjTribunalExterno.ESTADO = 1;
            DtgTribunalExternoOp = CargarTribunalExternoOpcional(ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss(), DtgTribunalExternoOp);
        }
    }
}
