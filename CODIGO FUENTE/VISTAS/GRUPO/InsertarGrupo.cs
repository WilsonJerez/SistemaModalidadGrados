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
    public partial class InsertarGrupo : Form
    {
        public InsertarGrupo()
        {
            InitializeComponent();
        }

        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Turno ObjTurno = new BSS.Bss_Turno();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Grupo ObjGrupo = new BSS.Bss_Grupo();
        DataTable Aula=new DataTable();
        DataTable Turnos = new DataTable();
        DataTable Contratos = new DataTable();

        int IdAula, IdTurno, IdContrato;


        int IndiceGridColor;


        private void InsertarGrupo_Load(object sender, EventArgs e)
        {
            Aula = ObjAula.SeleccionarAulaBss();
            Turnos = ObjTurno.SeleccionarTurnoBss();
            Contratos = ObjContrato.SeleccionarContratoBss();

            CmbAula.DataSource = ObjAula.SeleccionarAulaBss();
            CmbAula.DisplayMember = "n_aula";
            CmbTurno.DataSource = ObjTurno.SeleccionarTurnoBss();
            CmbTurno.DisplayMember = "turno";


        }

        private void BtnFiltrarDocente_Click(object sender, EventArgs e)
        {
            ObjContrato.ESTADO = 1;
            IdContrato = 0;
            GridContratos.Rows.Clear();

            ObjContrato.CI = null;
            ObjContrato.NOMBRE = null;
            ObjContrato.PATERNO = null;
            ObjContrato.MATERNO = null;

            if (TxtCi.Text != "")
            { 
                ObjContrato.CI = TxtCi.Text.ToUpper();
                
            }
            if (TxtNombre.Text != "")
            {
                ObjContrato.NOMBRE = TxtNombre.Text.ToUpper();
                
            }
            if (TxtPaterno.Text != "")
            {
                ObjContrato.PATERNO = TxtPaterno.Text.ToUpper();
                
            }
            if (TxtMaterno.Text != "")
            {
                ObjContrato.MATERNO = TxtMaterno.Text.ToUpper();
            }

           
            Contratos = ObjContrato.SeleccionarContratoCriterioBss();
            IndiceGridColor = 0;

            for (int fila= 0; fila < Contratos.Rows.Count; fila++)
            {
                GridContratos.Rows.Add();
                GridContratos["NOMBRE",fila].Value = Contratos.Rows[fila]["nombre"];
                GridContratos["ApPaterno", fila].Value = Contratos.Rows[fila]["paterno"];
                GridContratos["ApMaterno", fila].Value = Contratos.Rows[fila]["materno"];
                GridContratos["Ci", fila].Value = Contratos.Rows[fila]["ci"];

            }
            
            
            
            
            

        }

        private void CmbAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdAula=Convert.ToInt32(Aula.Rows[CmbAula.SelectedIndex]["id_aula"]);
        }

        private void CmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTurno=Convert.ToInt32(Turnos.Rows[CmbTurno.SelectedIndex]["id_turno"]);
        }

        

        private void BtnGuardarGrupo_Click(object sender, EventArgs e)
        {
           
            if (IdAula > 0)
            {
                CmbAula.BackColor=Color.White;
                if (IdTurno > 0)
                {
                    CmbTurno.BackColor = Color.White;
                    if (Validaciones.numero(TxtGrupo.Text) == true)
                    {
                        TxtGrupo.BackColor = Color.White;
                        if (Convert.ToDateTime(DtpFechaInicio.Value.ToString("dd/MM/yyyy"))> DAL.Dal_Login.fecha)
                        {
                            
                            if (Convert.ToDateTime(DtpFechaFinal.Value.ToString("dd/MM/yyyy"))> Convert.ToDateTime(DtpFechaInicio.Value.ToString("dd/MM/yyyy")))
                            {
                                
                                if (IdContrato > 0)
                                {   
                                    //cargamos la gestion y estado primeramente para poder realizar las busquedas
                                    ObjGrupo.GESTION = DAL.Dal_Login.fecha.Year;
                                    ObjGrupo.ESTADO = 1;
                                    
                                    // cargamos los valores para id_aula y id_turno para verificar si existe ya un grupo asignado al aula en el turno
                                    ObjGrupo.ID_AULA = IdAula;
                                    ObjGrupo.ID_TURNO = IdTurno;

                                    //validamos que no exista un grupo en la misma aula y en el mismo turno
                                    if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                                    {
                                        MessageBox.Show("Ya existe un grupo asignado al aula " + CmbAula.Text.ToUpper() + " y al turno " + CmbTurno.Text.ToUpper() + " debe cambiar el tuno o el aula", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        CmbAula.BackColor = Color.Red;
                                        CmbTurno.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        // quitamos el color de alerta si paso la primera verificacion
                                        CmbAula.BackColor = Color.White;
                                        CmbTurno.BackColor = Color.White;

                                        // eliminamos el id_aula para verificar si el docente ya dicta materia en el mismo turno y cargamos el id_contrato para buscarlo con su id en el turno
                                        ObjGrupo.ID_AULA = 0;
                                        ObjGrupo.ID_CONTRATO = IdContrato;

                                        //verificamos si existe el docente en el turno
                                        if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                                        {
                                            MessageBox.Show("El docente que selecciono para dirigir el grupo ya tiene un grupo en el mismo turno", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                        else
                                        {
                                            // quitamos los valores para los siguientes atributos por que perjudicarian en nuestra siguiente validacion
                                            ObjGrupo.ID_AULA = 0;
                                            ObjGrupo.ID_TURNO = 0;
                                            ObjGrupo.ID_CONTRATO = 0;
                                            
                                            //cargamos el nro de grupo para validar que no se repitan en la gestion
                                            ObjGrupo.N_GRUPO = Convert.ToInt32(TxtGrupo.Text);
                                            ObjGrupo.GESTION = DAL.Dal_Login.fecha.Year;
                                            
                                            //verificamos si existe el numero de grupo
                                            if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                                            {
                                                MessageBox.Show("El numero de grupo que intenta abrir ya existe en esta gestion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                TxtGrupo.BackColor = Color.Red;
                                            }
                                            else
                                            {
                                                ObjGrupo.ESTADO = 0;
                                                if (ObjGrupo.SeleccionarGrupoCriterioBss().Rows.Count > 0)
                                                {
                                                    MessageBox.Show("El numero de grupo que intenta abrir ya existe en esta gestion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                                else
                                                {
                                                    // cargamos los valores eliminados en la validacion para el guardado del grupo
                                                    ObjGrupo.ESTADO = 1;
                                                    ObjGrupo.ID_AULA = IdAula;
                                                    ObjGrupo.ID_TURNO = IdTurno;
                                                    ObjGrupo.ID_CONTRATO = IdContrato;
                                                    ObjGrupo.FECHA_INICIO = DtpFechaInicio.Value.ToString("MM/dd/yyyy");
                                                    ObjGrupo.FECHA_FINAL = DtpFechaFinal.Value.ToString("MM/dd/yyyy");



                                                    // guardamos el grupo
                                                    ObjGrupo.InsertarGrupoBss();
                                                    MessageBox.Show("Se guardo el grupo con existo", "EXITO");

                                                    // limpiarmos los campos 
                                                    IdContrato = 0;
                                                    TxtGrupo.Clear();
                                                    
                                                    
                                                    GridContratos.Rows[IndiceGridColor].DefaultCellStyle.BackColor = Color.White;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Haga Clik sobre la lista de docentes en el docente que desea asignar", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("La fecha final seleccionada no puede ser menor a la fecha de inicio, seleccione una fecha mayor", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                              
                            }
                        }
                        else
                        {                        
                              MessageBox.Show("La fecha de inicio seleccionada deber ser mayor a la actual", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                              
                           
                        }

                    }
                    else 
                    {
                            MessageBox.Show("El campo Numero de grupo debe contener solo numeros", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxtGrupo.BackColor = Color.Red;

                    }
                }
                else
                {
                    MessageBox.Show("El campo Turno esta vacio", "ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    CmbTurno.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("El Numero de aula esta vacio", "ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                CmbAula.BackColor = Color.Red;
            }
            

            
        }

        private void GridContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                if (GridContratos[0, e.RowIndex].Value != null)
                {


                    GridContratos.Rows[IndiceGridColor].DefaultCellStyle.BackColor = Color.White;
                    GridContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;

                    IdContrato = Convert.ToInt32(Contratos.Rows[e.RowIndex]["id_contrato"]);
                    IndiceGridColor = e.RowIndex;
                }
                else
                {
                    MessageBox.Show("Para Seleccionar filtre, un docente previamente", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                IdContrato = 0;
                for (int i = 0; i < GridContratos.Rows.Count; i++)
                {
                    GridContratos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void CmbAula_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbTurno_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }







    }
}
