using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_III
{
    public partial class InsertarDefensaIII : Form
    {
        public InsertarDefensaIII()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Mod_III ObjModIII = new BSS.Bss_Mod_III();
        BSS.Bss_Tribunal_externo ObjTribunalExterno = new BSS.Bss_Tribunal_externo();
        //data tables para recuperar datos
        DataTable DtContratos = new DataTable();
        DataTable DtHabilitadoModIII=new DataTable();
        DataTable DtAulas = new DataTable();
        DataTable DefensasProgramadas = new DataTable();
        DataTable DtDefensasPrrogramasTribunalExterno = new DataTable();
        //variables para los indices
        int IndiceHabiIII = 0;
        int IndiceAula = 0;
        int IndiceTrib = 0;
        int IndiceTribExterno = 0;
        //variables para recupera los ids 
        int IdModII = 0;
        int IdTrib1 = 0;
        int IdTrib2 = 0;
        int IdAula = 0;
        int IdTribunalExterno = 0;
        //
       

        private void InsertarDefensaIII_Load(object sender, EventArgs e)
        {
            //TxtPresidente.Text = DateTime.Now.ToString("MM/dd/yyyy");
            //cargamos la lista de docentes para tribunales
            ObjContrato.ESTADO = 1;
            DtContratos = ObjContrato.SeleccionarContratoCriterioBss();
            DtgContratos = CargarContratos(DtContratos, DtgContratos);
            
            //para cargar la lista de estudiantes habilitados para la defensa con tribunal externo (mod III)
            DtHabilitadoModIII = ObjModalidadII.SeleccionarHabilitadosModIIIBss("","","","");
            DtgHabilitadosModIII = CargarEstudiantes(DtHabilitadoModIII, DtgHabilitadosModIII);
        
            //para cargar la lista de aulas
            ObjAula.ESTADO = 1;
            DtAulas = ObjAula.SeleccionarAulaCriterioBss();
            DtgAulas = CargarAulas(DtAulas, DtgAulas);
            
            //para seleccionar los minutos en 00
            CmbMinutos.SelectedItem = "00";


        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            IndiceHabiIII = 0;
            IdModII = 0;
            DtHabilitadoModIII = ObjModalidadII.SeleccionarHabilitadosModIIIBss(TxtCi.Text.ToUpper(), TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper());
            DtgHabilitadosModIII = CargarEstudiantes(DtHabilitadoModIII, DtgHabilitadosModIII);
        }
        private void DtgHabilitadosModIII_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //para asignar color a la fila seleccionada
                DtgHabilitadosModIII.Rows[IndiceHabiIII].DefaultCellStyle.BackColor = Color.White;
                DtgHabilitadosModIII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceHabiIII = e.RowIndex;
                //recuperamos el id  de la modalidad II
                IdModII = Convert.ToInt32(DtgHabilitadosModIII["ID_MODALIDAD_II",e.RowIndex].Value.ToString());
            }
            catch (Exception ex)
            {
                IndiceHabiIII = 0;
                IdModII = 0;           
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnBuscarTribunal_Click(object sender, EventArgs e)
        {
            ObjContrato.ESTADO = 1;
            ObjContrato.NOMBRE = TxtNombreT.Text.ToUpper();
            ObjContrato.PATERNO = TxtPaternoT.Text.ToUpper();
            ObjContrato.MATERNO = TxtMaternoT.Text.ToUpper();
            DtContratos = ObjContrato.SeleccionarContratoCriterioBss();
            DtgContratos = CargarContratos(DtContratos, DtgContratos);
        }
        private void DtgContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //verificamos que la fecha de la defensa a programar sea al menos un dia antes 
                if (DtpFecha.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Las defensas deben ser programadas por los menos con un dia de anticipacion cambie la fecha a una fecha mayor a la de hoy", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //para asignar el color al tribunal seleccionado
                    DtgContratos.Rows[IndiceTrib].DefaultCellStyle.BackColor = Color.White;
                    DtgContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                    IndiceTrib = e.RowIndex;
                    BtnPonerTribunal.Enabled = true;
                    //recuperamos las defensas que tiene programada para el dia

                    //cargamos datos del tribunal para buscar todas las defensas programadas para esa fecha y mostrarlas
                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.FECHA = DtpFecha.Value.ToString("MM/dd/yyyy");
                    ObjTribunal.ID_CONTRATO = Convert.ToInt32(DtgContratos["ID_CONTRATO", e.RowIndex].Value);
                    DefensasProgramadas = ObjTribunal.SeleccionarTribunalCriterioBss();
                    DtgDefProgra.Rows.Clear();
                    for (int i = 0; i < DefensasProgramadas.Rows.Count; i++)
                    {
                        DtgDefProgra.Rows.Add();
                        DtgDefProgra["FECHA", i].Value = Convert.ToDateTime(DefensasProgramadas.Rows[i]["fecha"]).ToShortDateString();
                        DtgDefProgra["HORA", i].Value = DefensasProgramadas.Rows[i]["hora"];
                    }

                    //LIBERAMOS LOS ATRIBUTOS ASIGNADOS
                    ObjTribunal.ESTADO = 0;
                    ObjTribunal.FECHA = null;
                    ObjTribunal.ID_CONTRATO = 0;

                }
            }
            catch (Exception ex)
            {
                IndiceTrib = 0;                
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnPonerTribunal_Click(object sender, EventArgs e)
        {
            string hora = "";
            bool bandera = false;
           
                if (CmbHoraDefensa.Text != "")
                {
                    //validamos que no exista ya una defensa para la misma hora y fecha 
                    hora = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                    for (int i = 0; i < DtgDefProgra.Rows.Count;i++ )
                    {
                        if (hora == DtgDefProgra["HORA", i].Value.ToString())
                        {
                            bandera = true;
                        }
                    }
                    if (bandera == false)
                    {
                        //codigo para colocar al tribunal recuperando su id
                        if (TxtTribunal1.Text == "" || TxtTribunal2.Text == "")
                        {
                            BtnPonerTribunal.Enabled = false;

                            if (IdTrib1 == 0 & TxtTribunal1.Text == "")
                            {
                                IdTrib1 = Convert.ToInt32(DtgContratos["ID_CONTRATO", IndiceTrib].Value);
                                if (IdTrib1 != IdTrib2)
                                {
                                    TxtTribunal1.Text = DtgContratos["NOMBRET", IndiceTrib].Value.ToString() + " " + DtgContratos["PATERNOT", IndiceTrib].Value.ToString() + " " + DtgContratos["MATERNOT", IndiceTrib].Value.ToString();
                                }
                                else
                                {
                                    IdTrib1 = 0;
                                    MessageBox.Show("El tribunal que intenta seleccionar ya fue seleccionado, seleccione otro docente para tribunal", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                IdTrib2 = Convert.ToInt32(DtgContratos["ID_CONTRATO", IndiceTrib].Value);
                                if (IdTrib1 != IdTrib2)
                                {
                                    TxtTribunal2.Text = DtgContratos["NOMBRET", IndiceTrib].Value.ToString() + " " + DtgContratos["PATERNOT", IndiceTrib].Value.ToString() + " " + DtgContratos["MATERNOT", IndiceTrib].Value.ToString();
                                }
                                else
                                {
                                    IdTrib2 = 0;
                                    MessageBox.Show("El tribunal que intenta seleccionar ya fue seleccionado, seleccione otro docente para tribunal", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Ya fueron seleccionados los 2 tribunales internos", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tribunal que selecciono ya tiene una defensa programada para la misma fecha y hora, seleccione otro tribunal o cambie la hora de la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una hora para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            
        }
        private void BtnCambiar1_Click(object sender, EventArgs e)
        {
            TxtTribunal1.Clear();
            IdTrib1 = 0;
        }
        private void BtnCambiar2_Click(object sender, EventArgs e)
        {
            TxtTribunal2.Clear();
            IdTrib2 = 0;
        }
        private void DtgAulas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(DtpFecha.Value.ToString("dd/MM/yyyy")) > DAL.Dal_Login.fecha)
                {
                    if (CmbHoraDefensa.Text != "")
                    {
                        //cargamos datos para validad que no exista una defensa en la misma aula y la misma fecha
                        ObjDefensa.ESTADO = 1;
                        ObjDefensa.FECHA = DtpFecha.Value.ToString("MM/dd/yyy");
                        ObjDefensa.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                        ObjDefensa.ID_AULA = Convert.ToInt32(DtgAulas["ID_AULA", e.RowIndex].Value);
                        if (ObjDefensa.SeleccionarDefensaCriterioBss().Rows.Count > 0)
                        {
                            MessageBox.Show("Ya Existe una defensa en la misma fecha,hora,aula, cambie el aula o la hora para que no exista un conflicto en la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DtgAulas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                            IdAula = 0;
                        }
                        else
                        {
                            //recuperamos el id del aula y lo resaltamos
                            DtgAulas.Rows[IndiceAula].DefaultCellStyle.BackColor = Color.White;
                            DtgAulas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                            IndiceAula = e.RowIndex;
                            //recuperamos el id del aula
                            IdAula = Convert.ToInt32(DtgAulas["ID_AULA", e.RowIndex].Value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una hora para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha mayora a la actual para la defensa, las defensas deben ser programadas con un dia de anticipacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                IndiceAula = 0;
                IdAula = 0;
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            //array para los contratos
            int[] idcontratos = new int[2];

            if (TxtPresidente.Text != "" & IdTribunalExterno >0)
            {
                if (IdModII > 0)
                {
                    if (IdTrib1 > 0 & IdTrib2 > 0)
                    {
                        if (IdAula > 0)
                        {
                            if (IdTribunalExterno > 0)
                            {
                                //guardamos los datos de la modalidad III
                                ObjModIII.ESTADO = 1;
                                ObjModIII.ID_MODALIDAD_II = IdModII;
                                ObjModIII.FECHA_INSCRIPCION = DateTime.Now.ToString("MM/dd/yyyy");
                                ObjModIII.PRESIDENTE = TxtPresidente.Text.ToUpper();
                                ObjModIII.ID_TRIBUNAL_EXTERNO = IdTribunalExterno;
                                //guardamos la modalidad III y recuperamos su id para luego guardar la defensa
                                ObjTribunal.ESTADO = 1;
                                ObjTribunal.ID_MOD_III = ObjModIII.InsertarMod_IIIBss();
                                ObjTribunal.ID_AULA = IdAula;
                                ObjTribunal.FECHA = DtpFecha.Value.ToString("MM/dd/yyyy");
                                ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                //cargamos el array de ids de contratos para los tribunales
                                idcontratos[0] = IdTrib1;
                                idcontratos[1] = IdTrib2;
                                ObjTribunal.InsertarTribunalBss(idcontratos);
                                MessageBox.Show("Se realizo la programacion de la defensa con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //limpiamos y resfrescamos los campos
                                TxtPresidente.Clear();

                                IdModII = 0;
                                IdAula = 0;
                                IdTrib1 = 0;
                                IdTrib2 = 0;
                                IdTribunalExterno = 0;

                                IndiceHabiIII = 0;
                                DtHabilitadoModIII = ObjModalidadII.SeleccionarHabilitadosModIIIBss("", "", "", TxtMaterno.Text.ToUpper());
                                DtgHabilitadosModIII = CargarEstudiantes(DtHabilitadoModIII, DtgHabilitadosModIII);

                                DtgTribunalExterno.Rows[IndiceTribExterno].DefaultCellStyle.BackColor = Color.White;
                                DtgContratos.Rows[IndiceTrib].DefaultCellStyle.BackColor = Color.White;
                                TxtTribunal1.Clear();
                                TxtTribunal2.Clear();
                                DtgAulas.Rows[IndiceAula].DefaultCellStyle.BackColor = Color.White;
                                

                            }
                            else
                                MessageBox.Show("Seleccionar un tribunal externo, es necesario para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            

                        }
                        else
                        {
                            MessageBox.Show("Seleccione un aula para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione los 2 tribunales internos para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un alumno para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("El nombre del presidente y del tribunal externo deben ser llenados", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        

        //funciones
        private DataGridView CargarContratos(DataTable DtContratosX,DataGridView DtgContratosX)
        {
            DtgContratosX.Rows.Clear();
            for (int i = 0; i < DtContratosX.Rows.Count; i++)
            {
                DtgContratosX.Rows.Add();
                DtgContratosX["ID_CONTRATO", i].Value = DtContratos.Rows[i]["id_contrato"];
                DtgContratosX["CIT", i].Value = DtContratos.Rows[i]["ci"];
                DtgContratosX["NOMBRET", i].Value = DtContratos.Rows[i]["nombre"];
                DtgContratosX["PATERNOT", i].Value = DtContratos.Rows[i]["paterno"];
                DtgContratosX["MATERNOT", i].Value = DtContratos.Rows[i]["materno"];
            }
            return DtgContratosX;
        }
        private DataGridView CargarEstudiantes(DataTable DtHabilitadosModIIIX, DataGridView DtgHabilitadosModIIIX)
        {
            DtgHabilitadosModIIIX.Rows.Clear();
            for (int i = 0; i < DtHabilitadosModIIIX.Rows.Count; i++)
            {
                DtgHabilitadosModIIIX.Rows.Add();
                DtgHabilitadosModIIIX["CI", i].Value = DtHabilitadosModIIIX.Rows[i]["ci"];
                DtgHabilitadosModIIIX["NOMBRE", i].Value = DtHabilitadosModIIIX.Rows[i]["nombre"];
                DtgHabilitadosModIIIX["PATERNO", i].Value = DtHabilitadosModIIIX.Rows[i]["paterno"];
                DtgHabilitadosModIIIX["MATERNO", i].Value = DtHabilitadosModIIIX.Rows[i]["materno"];
                DtgHabilitadosModIIIX["TEMA", i].Value = DtHabilitadosModIIIX.Rows[i]["tema"];
                DtgHabilitadosModIIIX["TIPO_MODALIDAD", i].Value = DtHabilitadosModIIIX.Rows[i]["tipo_modalidad"];
                DtgHabilitadosModIIIX["CARRERA", i].Value = DtHabilitadosModIIIX.Rows[i]["carrera"];
                DtgHabilitadosModIIIX["ID_MODALIDAD_II", i].Value = DtHabilitadosModIIIX.Rows[i]["id_modalidad_II"];
            }
            return DtgHabilitadosModIIIX;
        }
        private DataGridView CargarAulas(DataTable DtAulasX,DataGridView DtgAulasX)
        {
            DtgAulasX.Rows.Clear();
            for (int i = 0; i < DtAulasX.Rows.Count; i++)
            {
                DtgAulasX.Rows.Add();
                DtgAulasX["ID_AULA", i].Value = DtAulasX.Rows[0]["id_aula"];
                DtgAulasX["AULA", i].Value = DtAulasX.Rows[0]["n_aula"];
                DtgAulasX["PISO", i].Value = DtAulasX.Rows[0]["piso"];
                DtgAulasX["CAPACIDAD", i].Value = DtAulasX.Rows[0]["capacidad"];
            }
            return DtgAulasX;
        }
        private DataGridView CargarTribunalExterno(DataTable DtX,DataGridView DtgX)
        {
            DtgX.Rows.Clear();
            for (int i = 0; i < DtX.Rows.Count; i++)
            {
                DtgX.Rows.Add();
                DtgX["ID_TRIBUNAL_EX", i].Value = DtX.Rows[i]["id_tribunal_externo"];
                DtgX["CI_EX", i].Value = DtX.Rows[i]["ci"];
                DtgX["NOMBRE_EX", i].Value = DtX.Rows[i]["nombre"];
                DtgX["AP_PATERNO_EX", i].Value = DtX.Rows[i]["paterno"];
                DtgX["AP_MATERNO_EX", i].Value = DtX.Rows[i]["materno"];
            }
            return DtgX;
        }

        private void LklNuevoExterno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TRIBUNALEXTERNO.InsertarTribunalExterno FrmInser = new VISTAS.TRIBUNALEXTERNO.InsertarTribunalExterno();
            FrmInser.ShowDialog();
            ObjTribunalExterno.ESTADO=1;
            DtgTribunalExterno = CargarTribunalExterno(ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss(), DtgTribunalExterno);            
        }

        private void DtgTribunalExterno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(DtpFecha.Value.ToString("dd/MM/yyyy")) > DAL.Dal_Login.fecha)
                {
                    if (CmbHoraDefensa.Text != "")
                    {
                        DtgTribunalExterno.Rows[IndiceTribExterno].DefaultCellStyle.BackColor = Color.White;
                        DtgTribunalExterno.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                        IndiceTribExterno = e.RowIndex;
                        IdTribunalExterno = Convert.ToInt32(DtgTribunalExterno["ID_TRIBUNAL_EX", e.RowIndex].Value.ToString());
                        //verificamos si ya existe una defensa
                        ObjTribunalExterno.ID_TRIBUNAL_EXTERNO = IdTribunalExterno;
                        DtDefensasPrrogramasTribunalExterno = ObjTribunalExterno.VerificarChoqueDefensasTribunalExternoBss(DtpFecha.Value.ToString("MM/dd/yyyy"), CmbHoraDefensa.Text + ":" + CmbMinutos.Text);
                        DtgDefProgEx.Rows.Clear();
                        for (int i = 0; i < DtDefensasPrrogramasTribunalExterno.Rows.Count; i++)
                        {
                            DtgDefProgEx.Rows.Add();
                            DtgDefProgEx["FECHA_EX", i].Value = Convert.ToDateTime(DtDefensasPrrogramasTribunalExterno.Rows[i]["fecha"].ToString()).ToShortDateString();
                            DtgDefProgEx["HORA_EX", i].Value = DtDefensasPrrogramasTribunalExterno.Rows[i]["hora"];
                        }
                        if (DtDefensasPrrogramasTribunalExterno.Rows.Count > 0)
                        {
                            MessageBox.Show("El tribunal externo que intenta asignar a la defensa ya tiene programada una defensa para la misma fecha y hora, seleccione otro tribunal o cambie la fecha o hora", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            IdTribunalExterno = 0;
                            DtgTribunalExterno.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione una hora para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha mayor a la actual para la defensa, recuerde que las defensas deben programarse minimamente con un dia de anticipacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                for (int i = 0; i < DtgTribunalExterno.Rows.Count; i++)
                {
                    DtgTribunalExterno.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                IdTribunalExterno = 0;
                IndiceTribExterno = 0;
            }
        }

        private void BtnBuscarTribunalExterno_Click(object sender, EventArgs e)
        {
            ObjTribunalExterno.ESTADO = 1;
            ObjTribunalExterno.CI = TxtCiEx.Text.ToUpper();
            ObjTribunalExterno.NOMBRE = TxtNombreEx.Text.ToUpper();
            ObjTribunalExterno.PATERNO = TxtPaternoEx.Text.ToUpper();
            ObjTribunalExterno.MATERNO = TxtMaternoEx.Text.ToUpper();

            //cargamos los buscados
            //DtgTribunalExterno.Enabled = true;
            DtgTribunalExterno = CargarTribunalExterno(ObjTribunalExterno.SeleccionarPorCriterioTribunalExternoBss(), DtgTribunalExterno);
            //DtgTribunalExterno.Enabled = false;
            IdTribunalExterno = 0;
            IndiceTribExterno = 0;
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(DtpFecha.Value.ToString("dd/MM/yyyy")) < Convert.ToDateTime(DAL.Dal_Login.fecha.ToString("dd/MM/yyyy")))
            {
               
                MessageBox.Show("La fecha para la defensa debe ser mayor a la actual", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                DtpFecha.Value = DateTime.Now;

                //DtgTribunalExterno.Enabled = false;


            }
                IdTribunalExterno = 0;
                IdTrib1 = 0;
                IdTrib2 = 0;
                if (DtgTribunalExterno.Rows.Count > 0)
                    DtgTribunalExterno.Rows[IndiceTribExterno].DefaultCellStyle.BackColor = Color.White;
                DtgContratos.Rows[IndiceTrib].DefaultCellStyle.BackColor = Color.White;
                TxtTribunal1.Clear();
                TxtTribunal2.Clear();
            if(DtgTribunalExterno.Rows.Count>0)
                DtgTribunalExterno.Rows[IndiceTribExterno].DefaultCellStyle.BackColor = Color.White;
            
            //else
            //{
            //    DtgTribunalExterno.Enabled = true;
            //}
        }

        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        
      

        

        

        

        

        
       

        

       
        
    }
}
