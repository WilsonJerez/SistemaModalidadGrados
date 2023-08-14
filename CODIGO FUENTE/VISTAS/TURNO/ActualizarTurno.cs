using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.TURNO
{
    public partial class ActualizarTurno : Form
    {
        public ActualizarTurno()
        {
            InitializeComponent();
        }
        BSS.Bss_Turno ObjTurno = new BSS.Bss_Turno();

        DataTable DtTurnos = new DataTable();

        int ColorTurno;
        int IdTurno;

       string hora;
        string minutos;

        string auxturno;

        private void ActualizarTurno_Load(object sender, EventArgs e)
        {

            DtTurnos = ObjTurno.SeleccionarTurnoBss();
            GridTurno = CargarTurno(GridTurno, DtTurnos);

            groupBox1.Enabled = false;
        }
        private void GridTurno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridTurno.Rows[ColorTurno].DefaultCellStyle.BackColor = Color.White;
                GridTurno.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorTurno = e.RowIndex;

                IdTurno = Convert.ToInt32(GridTurno["ID_TURNO", e.RowIndex].Value);

                TxtTurno.Text = GridTurno["TURNO", e.RowIndex].Value.ToString();
                auxturno=GridTurno["TURNO", e.RowIndex].Value.ToString();
                separarhora(GridTurno["HORA_INICIO", e.RowIndex].Value.ToString());
                TxtHoraEntrada.Text = hora;
                TxtMinutoEntrada.Text = minutos;
                hora = "";
                minutos = "";
                separarhora(GridTurno["HORA_FINAL",e.RowIndex].Value.ToString());
                TxtHoraSalida.Text = hora;
                TxtMinutoSalida.Text = minutos;
                hora = "";
                minutos = "";
                if(GridTurno["ESTADO",e.RowIndex].Value.ToString()=="Activo")
                    Activo.Checked = true;
                else
                    Inactivo.Checked =true;

                groupBox1.Enabled = true;
                
            }
            catch (Exception ee)
            {
                ColorTurno = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtTurno.Text != "")
            {
                if (TxtHoraEntrada.Text != "")
                {
                    if (TxtMinutoEntrada.Text != "")
                    {
                        if (TxtHoraSalida.Text != "")
                        {
                            if (TxtMinutoSalida.Text != "")
                            {
                                if (Validaciones.numero(TxtHoraEntrada.Text) == true & Validaciones.numero(TxtMinutoEntrada.Text) == true)
                                {
                                    if (Validaciones.numero(TxtHoraSalida.Text) == true & Validaciones.numero(TxtMinutoSalida.Text) == true)
                                    {
                                        if (Convert.ToInt32(TxtHoraEntrada.Text) < 24 & Convert.ToInt32(TxtMinutoEntrada.Text) < 60)
                                        {
                                            if (Convert.ToInt32(TxtHoraSalida.Text) < 24 & Convert.ToInt32(TxtMinutoSalida.Text) < 60)
                                            {

                                                ObjTurno.TURNO = TxtTurno.Text.ToUpper();
                                                ObjTurno.ESTADO = 1;
                                                if (TxtTurno.Text.ToUpper() != auxturno)
                                                {
                                                    if (ObjTurno.SeleccionarTurnoCriterioBss().Rows.Count == 0)
                                                    {
                                                        ObjTurno.ESTADO = 0;
                                                        if (ObjTurno.SeleccionarTurnoCriterioBss().Rows.Count == 0)
                                                        {
                                                            if (Activo.Checked == true)
                                                                ObjTurno.ESTADO = 1;
                                                            else
                                                                ObjTurno.ESTADO = 0;

                                                            ObjTurno.HORA_INICIO = TxtHoraEntrada.Text + ":" + TxtMinutoEntrada.Text;
                                                            ObjTurno.HORA_FINAL = TxtHoraSalida.Text + ":" + TxtMinutoSalida.Text;
                                                            ObjTurno.ID_TURNO = IdTurno;
                                                            ObjTurno.ActualizarTurnoBss();
                                                            DtTurnos = ObjTurno.SeleccionarTurnoBss();
                                                            GridTurno = CargarTurno(GridTurno, DtTurnos);
                                                            MessageBox.Show("El turno fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                            TxtTurno.Clear();
                                                            TxtHoraEntrada.Clear();
                                                            TxtMinutoEntrada.Clear();
                                                            TxtHoraSalida.Clear();
                                                            TxtMinutoSalida.Clear();

                                                            ObjTurno.HORA_FINAL = null;
                                                            ObjTurno.HORA_INICIO = null;
                                                            ObjTurno.ID_TURNO = 0;

                                                            groupBox1.Enabled = false;
                                                            
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El nombre de turno que desea colocar ya existe", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El nombre de turno que desea colocar ya existe", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                    }
                                                }
                                                else
                                                {

                                                    if (Activo.Checked == true)
                                                        ObjTurno.ESTADO = 1;
                                                    else
                                                        ObjTurno.ESTADO = 0;

                                                    ObjTurno.HORA_INICIO = TxtHoraEntrada.Text + ":" + TxtMinutoEntrada.Text;
                                                    ObjTurno.HORA_FINAL = TxtHoraSalida.Text + ":" + TxtMinutoSalida.Text;
                                                    ObjTurno.ID_TURNO = IdTurno;
                                                    ObjTurno.ActualizarTurnoBss();
                                                    DtTurnos = ObjTurno.SeleccionarTurnoBss();
                                                    GridTurno = CargarTurno(GridTurno, DtTurnos);
                                                    MessageBox.Show("El turno fue actualizado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                    TxtTurno.Clear();
                                                    TxtHoraEntrada.Clear();
                                                    TxtMinutoEntrada.Clear();
                                                    TxtHoraSalida.Clear();
                                                    TxtMinutoSalida.Clear();

                                                    ObjTurno.HORA_FINAL = null;
                                                    ObjTurno.HORA_INICIO = null;
                                                    ObjTurno.ID_TURNO = 0;

                                                    groupBox1.Enabled = false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("La hora de salida no cumple con el formato correcto, debe cumplir el formato de 24 horas, ej. 08:00 ,14:00", "ERROR DA DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                TxtHoraSalida.BackColor = Color.Red;
                                                TxtMinutoSalida.BackColor = Color.Red;
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("La hora de entrada no cumple el formato correcto, debe cumplir el formato de 24 horas, ej. 08:00 ,14:00", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            TxtHoraEntrada.BackColor = Color.Red;
                                            TxtMinutoEntrada.BackColor = Color.Red;
                                        }
                                    }
                                    else
                                    {

                                        MessageBox.Show("La hora de salida o los minutos de salida no cumple el formato correcto, deben contener solo numeros", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        TxtHoraEntrada.BackColor = Color.Red;
                                        TxtMinutoEntrada.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La hora de entrada o los minutos de entrada no cumple el formato correcto, deben contener solo numeros", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    TxtHoraEntrada.BackColor = Color.Red;
                                    TxtMinutoEntrada.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo minutos de salida no puede estar en blanco", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                TxtMinutoSalida.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo hora de salida no puede estar en blanco", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            TxtHoraSalida.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de minutos de entrada no puede estar en blanco", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TxtMinutoEntrada.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La hora de entrada puede que sea incorrecta o este en blanco, introduzca una hora con formato de 24 hrs", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtHoraEntrada.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("El campo turno no puede estar en blanco, debe contener un nombre de turno", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtTurno.BackColor = Color.Red;
            }
        }


        public DataGridView CargarTurno(DataGridView GridTurnoX,DataTable DtTurnoX)
        {
            GridTurnoX.Rows.Clear();
            for (int fila = 0; fila < DtTurnoX.Rows.Count; fila++)
            {
                GridTurnoX.Rows.Add();
                GridTurnoX["ID_TURNO", fila].Value = DtTurnoX.Rows[fila]["id_turno"];
                GridTurnoX["TURNO", fila].Value = DtTurnoX.Rows[fila]["turno"];
                GridTurnoX["HORA_INICIO", fila].Value = DtTurnoX.Rows[fila]["hora_inicio"];
                GridTurnoX["HORA_FINAL", fila].Value = DtTurnoX.Rows[fila]["hora_final"];
                if (Convert.ToInt32(DtTurnoX.Rows[fila]["estado"]) == 1)
                    GridTurnoX["ESTADO", fila].Value = "Activo";
                else
                    GridTurnoX["ESTADO", fila].Value = "Inactivo";
            }
            return GridTurnoX;
        }
        public void separarhora(string horaX)
        {
            bool bandHora=false;
            for (int i = 0; i < horaX.Length; i++ )
            {
                if (horaX[i].ToString() != ":"& bandHora==false)
                {
                    hora = hora + horaX[i].ToString();
                    
                }
                else
                {
                    bandHora=true;
                    if (horaX[i].ToString() != ":")
                    {
                        minutos = minutos + horaX[i].ToString();
                    }
                }
            }
        }

        


    }
}
