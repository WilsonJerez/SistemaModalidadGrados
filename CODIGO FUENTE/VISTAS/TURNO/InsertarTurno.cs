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
    public partial class InsertarTurno : Form
    {
        public InsertarTurno()
        {
            InitializeComponent();
        }
        BSS.Bss_Turno ObjTurno = new BSS.Bss_Turno();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtTurno.Text != null)
            {
                TxtTurno.BackColor = Color.White;
                if (Validaciones.numero(TxtHoraEntrada.Text) == true & Validaciones.numero(TxtMinutoEntrada.Text)==true)
                {
                    if (Convert.ToInt32(TxtHoraEntrada.Text) < 24 & Convert.ToInt32(TxtMinutoEntrada.Text) < 60)
                        TxtHoraEntrada.BackColor = Color.White;
                    else
                    {
                        MessageBox.Show("La hora no puede ser mayor a 24 y los minutos mayores a 60","ERROR DE DATOS");
                    }
                    if (Validaciones.numero(TxtHoraSalida.Text) == true & Validaciones.numero(TxtMinutoSalida.Text)==true)
                    {
                        if(Convert.ToInt32(TxtHoraSalida.Text)<24 & Convert.ToInt32(TxtMinutoSalida.Text)<60 & Convert.ToInt32(TxtHoraSalida.Text)>Convert.ToInt32(TxtHoraEntrada.Text))
                        {
                            TxtHoraSalida.BackColor = Color.White;
                            ObjTurno.TURNO = TxtTurno.Text;
                            ObjTurno.HORA_INICIO = "";
                            ObjTurno.HORA_FINAL = "";
                            ObjTurno.ESTADO = 1;
                            if (ObjTurno.SeleccionarTurnoCriterioBss().Rows.Count > 0)
                            {
                                MessageBox.Show("El turno que intenta registrar ya existe", "ALERTA DE DUPLICIDAD");
                            }
                            else
                            {
                                ObjTurno.HORA_INICIO = TxtHoraEntrada.Text;
                                ObjTurno.HORA_FINAL = TxtHoraSalida.Text;
                                ObjTurno.ESTADO = 1;
                                ObjTurno.InsertarTurnoBss();

                                MessageBox.Show("El turno fue guardado correctamente", "EXITO");
                                TxtTurno.Clear();
                                TxtHoraEntrada.Text = "hh";
                                TxtMinutoEntrada.Text = "mm";

                                TxtHoraSalida.Text = "hh";
                                TxtMinutoSalida.Text = "mm";
                            }


                        }
                        
                        else
                        {
                            MessageBox.Show("La hora no puede ser mayor a 24 y los minutos mayores a 60 y la hora de salida debe ser mayor a la hora de entrada", "ERROR DE DATOS");
                        }

                        


                    }
                    else
                    {
                        MessageBox.Show("La hora no es correcta debe cumplir el formato hh:mm y debe ser menor o igual a 24", "ERROR DE DATO");
                        TxtHoraSalida.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("La hora no es correcta debe cumplir el formato hh:mm y debe ser menor o igual a 24", "ERROR DE DATO");
                    TxtHoraEntrada.BackColor = Color.Red;
                }
            }
            else
            {
                TxtTurno.BackColor = Color.Red;
                MessageBox.Show("Error de dato, el campo turno debe contener algun dato", "ERROR DE DATO");
            }
        }

        
        

        

        

        
    }
}
