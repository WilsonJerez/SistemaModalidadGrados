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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }
        //objetos a utilizar
        BSS.Bss_Mod_III ObjModIII = new BSS.Bss_Mod_III();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        //data tables para recuperar datos 
        DataTable DtEstudiantes = new DataTable();
        DataTable DtTribunales = new DataTable();
        DataTable DtTribunalExterno = new DataTable();
        //indices para color
        int IndiceEstudiantes = 0;
        //vMicrosoft Sans Serifbles para recuperar los ids necesarios
        int IdDefensa = 0;
        int IdModIII = 0;
        int Promedio = 0;
        int nota1 = 0;
        int nota2 =0;
        int nota3 = 0;
        //banderas
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //recuperamos los datos del estudiante
            DtEstudiantes = ObjModIII.SeleccinarModIIICriterioBss(TxtCi.Text.ToUpper(), TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(),0);
            DtgEstudiantes = CargarEstudiantes(DtEstudiantes, DtgEstudiantes);
            IndiceEstudiantes = 0;
        }
        private void DtgEstudiantes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //resaltamos y recuperamos ids
                DtgEstudiantes.Rows[IndiceEstudiantes].DefaultCellStyle.BackColor = Color.White;
                DtgEstudiantes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceEstudiantes = e.RowIndex;
                IdDefensa = Convert.ToInt32(DtgEstudiantes["ID_DEFENSA", e.RowIndex].Value);
                IdModIII = Convert.ToInt32(DtgEstudiantes["ID_MOD_III", e.RowIndex].Value);
                //recuperamos el nro de acta si existiese
                if (DtgEstudiantes["NRO_ACTA", e.RowIndex].Value.ToString() != "")
                {
                    TxtNroActa.ReadOnly = true;
                    TxtNroActa.Text = DtgEstudiantes["NRO_ACTA", e.RowIndex].Value.ToString();
                    CkbActualizarNroActa.Checked = false;
                    
                }
                else
                {
                    TxtNroActa.ReadOnly = false;
                    CkbActualizarNroActa.Checked = true;
                    CkbActualizarNroActa.Enabled = false;
                }
                //cargamos la lista de tribunales internos
                ObjTribunal.ESTADO = 0;
                ObjTribunal.ID_DEFENSA = IdDefensa;
                DtTribunales=ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                DtgTribunalesInternos = CargarTribunales(DtTribunales, DtgTribunalesInternos);
                //cargamos el tribunal externo
                ObjModIII.ID_MOD_III = IdModIII;
                DtTribunalExterno = ObjModIII.SeleccinarModIIICriterioBss("", "", "", "",0);
                TxtTribunalExterno.Text = DtTribunalExterno.Rows[0]["tribunal_externo"].ToString();
                TxtNotaExterna.Text = DtTribunalExterno.Rows[0]["nota_externa"].ToString();
                ObjModIII.ID_MOD_III = 0;

                //recuperamos el promedio de la defensa
                TxtPromedio.Text = DtgEstudiantes["NOTA_DEFENSA", e.RowIndex].Value.ToString();
                //habilitamos el boton
                BtnActualizarNotas.Enabled = true;
            }
            catch(Exception ex)
            {
                IdDefensa = 0;
                IdModIII = 0;
                IndiceEstudiantes = 0;
                for (int i = 0; i < DtgEstudiantes.Rows.Count; i++)
                {
                    DtgEstudiantes.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                MessageBox.Show(ex.ToString());
            }
        }
        //funciones
        private DataGridView CargarEstudiantes(DataTable DtEstudiantesX, DataGridView DtgEstudiantesX)
        {
           DtgEstudiantesX.Rows.Clear();
           for (int i = 0; i < DtEstudiantesX.Rows.Count; i++)
           {
               DtgEstudiantesX.Rows.Add();
               DtgEstudiantesX["ID_MOD_III", i].Value = DtEstudiantesX.Rows[i]["id_mod_III"];
               DtgEstudiantesX["ID_DEFENSA", i].Value = DtEstudiantesX.Rows[i]["id_defensa"];
               DtgEstudiantesX["CI", i].Value = DtEstudiantesX.Rows[i]["ci"];
               DtgEstudiantesX["NOMBRE", i].Value = DtEstudiantesX.Rows[i]["nombre"];
               DtgEstudiantesX["PATERNO", i].Value = DtEstudiantesX.Rows[i]["paterno"];
               DtgEstudiantesX["MATERNO", i].Value = DtEstudiantesX.Rows[i]["materno"];
               DtgEstudiantesX["CARRERA", i].Value = DtEstudiantesX.Rows[i]["carrera"];
               DtgEstudiantesX["FECHA_DEFENSA", i].Value = Convert.ToDateTime(DtEstudiantesX.Rows[i]["fecha"].ToString()).ToShortDateString();
               DtgEstudiantesX["NRO_ACTA", i].Value = DtEstudiantesX.Rows[i]["nro_acta"].ToString();
               DtgEstudiantesX["NOTA_DEFENSA", i].Value = DtEstudiantesX.Rows[i]["nota"].ToString();
           }
           return DtgEstudiantesX;
        }
        private DataGridView CargarTribunales(DataTable DtTribunalesX, DataGridView DtgTribunalesX)
        {
            DtgTribunalesX.Rows.Clear();
            for (int i = 0; i < DtTribunalesX.Rows.Count; i++)
            {
                DtgTribunalesX.Rows.Add();
                DtgTribunalesX["ID_TRIBUNAL", i].Value = DtTribunalesX.Rows[i]["id_tribunal"];
                DtgTribunalesX["CIT", i].Value = DtTribunalesX.Rows[i]["ci"];
                DtgTribunalesX["NOMBRET", i].Value = DtTribunalesX.Rows[i]["nombre"];
                DtgTribunalesX["AP_PATERNOT", i].Value = DtTribunalesX.Rows[i]["paterno"];
                DtgTribunalesX["AP_MATERNOT", i].Value = DtTribunalesX.Rows[i]["materno"];
                DtgTribunalesX["NOTA", i].Value = DtTribunalesX.Rows[i]["nota"];
            }
            return DtgTribunalesX;
        }

        private void DtgTribunalesInternos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Validaciones.Decimales(DtgTribunalesInternos["NOTA", e.RowIndex].Value.ToString()) == true)
            {
                if (Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", e.RowIndex].Value)) <= 0 || Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", e.RowIndex].Value)) > 100)
                {
                    MessageBox.Show("La nota ingresada para el tribunal deber ser mayor a '0' y menor o igual a '100'", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    DtgTribunalesInternos["NOTA", e.RowIndex].Value = "";
                }
            }
            else
            {
                   MessageBox.Show("El campo nota solo puede aceptar numeros enteros y decimales, el separador de decimales es coma ','", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   DtgTribunalesInternos["NOTA", e.RowIndex].Value = "";
            }
        }
        private void TxtNotaExterna_TextChanged(object sender, EventArgs e)
        {
            if (Validaciones.Decimales(TxtNotaExterna.Text) == true)
            {
                if (Convert.ToInt32(Convert.ToDouble(TxtNotaExterna.Text)) <= 0 || Convert.ToInt32(Convert.ToDouble(TxtNotaExterna.Text)) > 100)
                    MessageBox.Show("La nota ingresada para el tribunal deber ser mayor a '0' y menor o igual a '100'", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("El campo nota solo puede aceptar numeros enteros y decimales, el separador de decimales es coma ','", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnActualizarNotas_Click(object sender, EventArgs e)
        {
            if (Validaciones.Decimales(DtgTribunalesInternos["NOTA", 0].Value.ToString()) == true & Validaciones.Decimales(DtgTribunalesInternos["NOTA", 1].Value.ToString()) == true & Validaciones.Decimales(TxtNotaExterna.Text) == true)
            {
                if (Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 0].Value)) > 0 & Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 1].Value)) > 0 & Convert.ToInt32(Convert.ToDouble(TxtNotaExterna.Text)) > 0 & Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 0].Value)) <= 100 & Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 1].Value)) <= 100 & Convert.ToInt32(Convert.ToDouble(TxtNotaExterna.Text)) <= 100)
                {
                    if (TxtNroActa.Text != "")
                    {
                        //Cargamos el nro de acta para verificar si y solo si la opcion modificar nro acta esta seleccionada
                        if (CkbActualizarNroActa.Checked == true)
                        {
                            ObjDefensa.NRO_ACTA = TxtNroActa.Text.ToUpper();
                        }
                        else
                        {
                            ObjDefensa.NRO_ACTA = "-----***///";
                        }
                        //if (ObjDefensa.VerificarNroActaBss().Rows.Count == 0)
                        //{
                            nota1 = Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 0].Value));
                            nota2 = Convert.ToInt32(Convert.ToDouble(DtgTribunalesInternos["NOTA", 1].Value));
                            nota3 = Convert.ToInt32(Convert.ToDouble(TxtNotaExterna.Text));
                            Promedio = (nota1 + nota2 + nota3) / 3;
                            TxtPromedio.Text = Promedio.ToString();
                            //actualizamos nro de acta y nota
                            ObjDefensa.ID_DEFENSA = IdDefensa;
                            ObjDefensa.NRO_ACTA = TxtNroActa.Text.ToUpper();
                            ObjDefensa.NOTA = Promedio;
                            ObjDefensa.ActualizarDefensaBss();
                            //actualizamos notas
                            for (int i = 0; i < DtgTribunalesInternos.Rows.Count; i++)
                            {
                                ObjTribunal.ID_TRIBUNAL = Convert.ToInt32(DtgTribunalesInternos["ID_TRIBUNAL", i].Value.ToString());
                                if (i == 0)
                                    ObjTribunal.NOTA = nota1;
                                else
                                    ObjTribunal.NOTA = nota2;
                                ObjTribunal.ActrualizarTribunalBss();
                            }
                            //actualizamos nota tribunal externo
                            ObjModIII.ID_MOD_III = IdModIII;
                            ObjModIII.NOTA_EXTERNA = nota3;
                            ObjModIII.ActualizarModIIIBss();

                            MessageBox.Show("Las modificaciones se realizaron correcamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //LIMPIAMOS TODOS LOS CAMPOS
                            //DtgEstudiantes.Rows[IndiceEstudiantes].DefaultCellStyle.BackColor = Color.White;
                            //DtgTribunalesInternos.Rows.Clear();
                            //TxtTribunalExterno.Clear();
                            //TxtNotaExterna.Clear();
                            //TxtNroActa.Clear();
                            BtnActualizarNotas.Enabled = false;

                        //}
                        //else
                        //{
                        //    MessageBox.Show("El Nro de acta que intenta asignar a la defensa ya existe, el numero de acta deber ser unico", "ERROR DE DATO", MessageBoxButtons.OK);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("El nro de acta es requisito indispensable para realizar una modificacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("No todas las notas son mayor  a '0' y menor o igual a '100' ,revise las notas", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Una de las notas ingresadas no cumple el formato, recuerde que el separador de decimales es coma ',' revise las notas", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CkbActualizarNroActa_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbActualizarNroActa.Checked == true)
            {
                
                TxtNroActa.ReadOnly = false;
                TxtNroActa.Clear();
            }
            else
            {
                
                TxtNroActa.ReadOnly = true;
                TxtNroActa.Text = DtgEstudiantes["NRO_ACTA", IndiceEstudiantes].Value.ToString();
            }
        }

    }
}
