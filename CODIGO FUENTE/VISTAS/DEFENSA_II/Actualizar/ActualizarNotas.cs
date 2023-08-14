using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_II.Actualizar
{
    public partial class ActualizarNotas : Form
    {
        public ActualizarNotas()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        // datatables
        DataTable DtDefensas = new DataTable();
        DataTable DtTribunal = new DataTable();
        // variables para el color
        int ColorDefensas;
        //int ColorTribunal=0;
        // variables para recuperar los ids
        int IdDefensa;
        //int IdTribunal=0;

       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtCi.Text != "" & Validaciones.ci(TxtCi.Text) == true)
            {
                //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), Convert.ToInt32(TxtCi.Text), 0,0);
            }
            else
            {
                if (TxtCi.Text != "")
                {
                    MessageBox.Show("El ci es incorrecto, se mostraran todas las defensas ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 0, 0,0);
            }
            GridDefensa = CargarDefensas(GridDefensa, DtDefensas);
            ObjDefensa.FECHA = null;
            ColorDefensas = 0;
            IdDefensa = 0;
        }
        private void GridDefensa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridDefensa.Rows[ColorDefensas].DefaultCellStyle.BackColor = Color.White;
                GridDefensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IdDefensa = Convert.ToInt32(GridDefensa["ID_DEFENSA", e.RowIndex].Value);
                ColorDefensas = e.RowIndex;
                // cargamos el grid de tribunales segun la defensa
                ObjTribunal.ID_DEFENSA = IdDefensa;
                DtTribunal = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                GridTribunal = CargarTribunal(GridTribunal, DtTribunal);

                // recuperamos el promedio de la defensa y el estado
                TxtPromedio.Text = GridDefensa["NOTA", e.RowIndex].Value.ToString();
                if (GridDefensa["ESTADO", e.RowIndex].Value.ToString() == "0")
                    TxtEstado.Text = "INACTIVO";
                else
                    TxtEstado.Text = "ACTIVO";
                //recuperamos el nro de acta y si ya tiene un nro de acta, lo cargamos y  no permitimos la modificacion
                if (GridDefensa["NRO_ACTA", e.RowIndex].Value.ToString() != "")
                {
                    TxtActa.Text = GridDefensa["NRO_ACTA", e.RowIndex].Value.ToString();
                    TxtActa.ReadOnly = true;
                    CkbNroActa.Checked = false;
                    CkbNotas.Checked = true;
                    CkbNotas.Enabled = false;
                }
                else
                {
                    TxtActa.Clear();
                    TxtActa.ReadOnly = false;
                    CkbNotas.Checked = true;
                    CkbNroActa.Checked = true;
                    CkbNroActa.Enabled = false;
                    CkbNotas.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ColorDefensas = 0;
                MessageBox.Show(ex.ToString());
            }


        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
            bool BanActualizar = true;
            int SumatoriaNotas = 0;
            int PromedioNotas = 0;
            if (IdDefensa > 0)
            {
                if (TxtActa.Text!="")
                {
                    //si ya tiene un nro de acta verificamos la opcion de cambio de acta esta activa o desactiva
                    if (CkbNroActa.Checked == true)
                    {
                        TxtActa.BackColor = Color.White;
                        ObjDefensa.NRO_ACTA = TxtActa.Text;
                        //if (ObjDefensa.VerificarNroActaBss().Rows.Count == 0)
                        //{
                            TxtActa.BackColor = Color.White;
                            // para verificar si las notas de los tribunales todas son diferentes de cero
                            for (int i = 0; i < GridTribunal.Rows.Count; i++)
                            {
                                if (Validaciones.Decimales(GridTribunal["NOTAT", i].Value.ToString()) == true)
                                {
                                    if (Convert.ToDecimal(GridTribunal["NOTAT", i].Value) < 0 || Convert.ToDecimal(GridTribunal["NOTAT", i].Value) > 100)
                                    {
                                        BanActualizar = false;
                                    }
                                }
                                else
                                {
                                    BanActualizar = false;
                                }
                            }

                            // para validar que todas las notas hayan cumplido 
                            if (BanActualizar == true)
                            {
                                for (int i = 0; i < GridTribunal.Rows.Count; i++)
                                {
                                    ObjTribunal.ID_TRIBUNAL = Convert.ToInt32(GridTribunal["ID_TRIBUNAL", i].Value);
                                    ObjTribunal.NOTA = Convert.ToInt32(Convert.ToDecimal(GridTribunal["NOTAT", i].Value));
                                    SumatoriaNotas = SumatoriaNotas + Convert.ToInt32(Convert.ToDecimal(GridTribunal["NOTAT", i].Value));
                                    ObjTribunal.ActrualizarTribunalBss();
                                }

                                // calculamos el promedio de las notas para actualizar en la defensa
                                PromedioNotas = SumatoriaNotas / 3;
                                ObjDefensa.ID_DEFENSA = IdDefensa;
                                ObjDefensa.NOTA = PromedioNotas;
                                ObjDefensa.NRO_ACTA = TxtActa.Text;
                                ObjDefensa.ActualizarDefensaBss();

                                MessageBox.Show("Las notas de los tribunales fueron actualizadas exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                // ACTUALIZAMOS EL GRID DE TRIBUNALES CON LAS NUEVAS NOTAS
                                ObjTribunal.ID_DEFENSA = IdDefensa;
                                DtTribunal = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                                GridTribunal = CargarTribunal(GridTribunal, DtTribunal);
                                // limpiamos los contenedores involucrados en la actualizacion
                                TxtPromedio.Text = PromedioNotas.ToString();
                                TxtActa.Clear();
                                IdDefensa = 0;

                                //actualizamos la lista de defensas si hay parametros buscamos por parametros o sino sacamos todas
                                //***************************************************************
                                if (TxtCi.Text != "" & Validaciones.ci(TxtCi.Text) == true)
                                {
                                    //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                                    DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), Convert.ToInt32(TxtCi.Text), 0, 0);
                                }
                                else
                                {
                                    if (TxtCi.Text != "")
                                    {
                                        MessageBox.Show("El ci es incorrecto, se mostraran todas las defensas ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                                    DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 0, 0, 0);
                                }
                                GridDefensa = CargarDefensas(GridDefensa, DtDefensas);
                                //***************************************************
                                ColorDefensas = 0;

                            }
                            else
                            {
                                MessageBox.Show("No todas las notas cumplen el formato adeucuado, no se cumplir con la actualizacion, recuerde las notas deben ser mayor >=0 y <=100", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("El´número de acta que intenta introducir ya fue asignado a una defensa anterio, el número de acta debe ser único", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //    TxtActa.BackColor = Color.Red;
                        //}
                    }
                    else
                    {
                        TxtActa.BackColor = Color.White;
                        // para verificar si las notas de los tribunales todas son diferentes de cero
                        for (int i = 0; i < GridTribunal.Rows.Count; i++)
                        {
                            if (Validaciones.Decimales(GridTribunal["NOTAT", i].Value.ToString()) == true)
                            {
                                if (Convert.ToDecimal(GridTribunal["NOTAT", i].Value) < 0 || Convert.ToDecimal(GridTribunal["NOTAT", i].Value) > 100)
                                {
                                    BanActualizar = false;
                                }
                            }
                            else
                            {
                                BanActualizar = false;
                            }
                        }

                        // para validar que todas las notas hayan cumplido 
                        if (BanActualizar == true)
                        {
                            for (int i = 0; i < GridTribunal.Rows.Count; i++)
                            {
                                ObjTribunal.ID_TRIBUNAL = Convert.ToInt32(GridTribunal["ID_TRIBUNAL", i].Value);
                                ObjTribunal.NOTA = Convert.ToInt32(Convert.ToDecimal(GridTribunal["NOTAT", i].Value));
                                SumatoriaNotas = SumatoriaNotas + Convert.ToInt32(Convert.ToDecimal(GridTribunal["NOTAT", i].Value));
                                ObjTribunal.ActrualizarTribunalBss();
                            }

                            // calculamos el promedio de las notas para actualizar en la defensa
                            PromedioNotas = SumatoriaNotas / 3;
                            ObjDefensa.ID_DEFENSA = IdDefensa;
                            ObjDefensa.NOTA = PromedioNotas;
                            //ObjDefensa.NRO_ACTA = TxtActa.Text;
                            ObjDefensa.ActualizarDefensaBss();

                            MessageBox.Show("Las notas de los tribunales fueron actualizadas exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // ACTUALIZAMOS EL GRID DE TRIBUNALES CON LAS NUEVAS NOTAS
                            ObjTribunal.ID_DEFENSA = IdDefensa;
                            DtTribunal = ObjTribunal.SeleccionarTribunalCriterioPorDefensaBss();
                            GridTribunal = CargarTribunal(GridTribunal, DtTribunal);
                            // limpiamos los contenedores involucrados en la actualizacion
                            TxtPromedio.Text = PromedioNotas.ToString();
                            TxtActa.Clear();
                            IdDefensa = 0;

                            //actualizamos la lista de defensas si hay parametros buscamos por parametros o sino sacamos todas
                            //***************************************************************
                            if (TxtCi.Text != "" & Validaciones.ci(TxtCi.Text) == true)
                            {
                                //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), Convert.ToInt32(TxtCi.Text), 0, 0);
                            }
                            else
                            {
                                if (TxtCi.Text != "")
                                {
                                    MessageBox.Show("El ci es incorrecto, se mostraran todas las defensas ", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                //ObjDefensa.FECHA =Validaciones.ConvertirFechaSql2005_MMDDAA( DAL.Dal_Login.fecha.ToShortDateString());
                                DtDefensas = ObjDefensa.SeleccionarDefensaCriterioBss(TxtNombre.Text.ToUpper(), TxtPaterno.Text.ToUpper(), TxtMaterno.Text.ToUpper(), 0, 0, 0);
                            }
                            GridDefensa = CargarDefensas(GridDefensa, DtDefensas);
                            //***************************************************
                            ColorDefensas = 0;

                        }
                        else
                        {
                            MessageBox.Show("No todas las notas cumplen el formato adeucuado, no se cumplir con la actualizacion, recuerde las notas deben ser mayor >=0 y <=100", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("El campo número de acta solo puede aceptar datos de tipo numérico", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtActa.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        //funcion para cargar el grid de defensas
        public DataGridView CargarDefensas(DataGridView gridX,DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRE", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNO", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNO", i].Value = dtX.Rows[i]["materno"];
                gridX["CI", i].Value = dtX.Rows[i]["ci"];
                gridX["FECHA_DEFENSA", i].Value =Convert.ToDateTime(dtX.Rows[i]["fecha"]).ToShortDateString();
                gridX["ID_DEFENSA", i].Value = dtX.Rows[i]["id_defensa"];
                gridX["ESTADO", i].Value = dtX.Rows[i]["estado"];
                gridX["NOTA", i].Value = dtX.Rows[i]["nota"];
                gridX["NRO_ACTA", i].Value = dtX.Rows[i]["nro_acta"];
            }
            return gridX;
        }
        public DataGridView CargarTribunal(DataGridView gridX, DataTable dtX)
        {
            gridX.Rows.Clear();
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                gridX.Rows.Add();
                gridX["NOMBRET", i].Value = dtX.Rows[i]["nombre"];
                gridX["PATERNOT", i].Value = dtX.Rows[i]["paterno"];
                gridX["MATERNOT", i].Value = dtX.Rows[i]["materno"];
                gridX["CIT", i].Value = dtX.Rows[i]["ci"];               
                gridX["NOTAT", i].Value = dtX.Rows[i]["nota"];
                gridX["ID_TRIBUNAL", i].Value = dtX.Rows[i]["id_tribunal"];
                
            }
            if (gridX.Rows.Count > 0)
                BtnActualizar.Enabled = true;
            else
                BtnActualizar.Enabled = false;
            return gridX;
        }

        private void CkbNroActa_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbNroActa.Checked == true)
            {
                if (TxtActa.Text != "")
                {
                    if (MessageBox.Show("¿Seguro que desea modificar el número de acta de esta defensa?, si no esta seguro del cambio deseleccione la opcion (ACTUALIZAR NRO DE ACTA)", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        TxtActa.ReadOnly = false;
                    }
                    else
                    {
                        TxtActa.ReadOnly = true;
                        CkbNroActa.Checked = false;
                        TxtActa.BackColor = Color.White;
                    }
                }
            }
            else
            {
                TxtActa.ReadOnly = true;
                TxtActa.BackColor = Color.White;
            }
        }

        


    }
}
