using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.AMPLIACION
{
    public partial class Retrazar : Form
    {
        public Retrazar()
        {
            InitializeComponent();
        }

        BSS.Bss_Modalidad_II objmodalidad = new BSS.Bss_Modalidad_II();
        BSS.Bss_Cronograma ObjCronograma = new BSS.Bss_Cronograma();
        DataTable Dtmodalidad = new DataTable();
        DataTable DtCronograma = new DataTable();
        DataTable DtModalidadII = new DataTable();

        int ColorModalidad;
        int IdModalidadII;
        DateTime FechaFinal;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //Cargar Modalidad II
        public DataGridView CargarModalidadesII(DataGridView GridModaliadIIX, DataTable DtModalidadX)
        {
            GridModaliadIIX.Rows.Clear();
           
           
            for (int fila = 0; fila < DtModalidadX.Rows.Count; fila++)
            {
                GridModaliadIIX.Rows.Add();
                GridModaliadIIX["ID_MODALIDAD_II", fila].Value = DtModalidadX.Rows[fila]["id_modalidad_II"];
                GridModaliadIIX["NOMBRE", fila].Value = DtModalidadX.Rows[fila]["nombre"];
                GridModaliadIIX["PATERNO", fila].Value = DtModalidadX.Rows[fila]["paterno"];
                GridModaliadIIX["MATERNO", fila].Value = DtModalidadX.Rows[fila]["materno"];
                GridModaliadIIX["CI", fila].Value = DtModalidadX.Rows[fila]["ci"];

                GridModaliadIIX["FECHA_INICIO", fila].Value = Convert.ToDateTime(DtModalidadX.Rows[fila]["fecha_inscripcion"].ToString()).ToShortDateString();

                
            }
            
            return GridModaliadIIX;
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            ColorModalidad = 0;
            DtGridModalidadII.Rows.Clear();

            string ConNombre = "";
            string ConPaterno = "";
            string ConMaterno = "";
            string ConCi = "";


            if (TxtNombre.Text != "")
                ConNombre = TxtNombre.Text.ToUpper();
            if (TxtPaterno.Text != "")
                ConPaterno = TxtPaterno.Text.ToUpper();
            if (TxtMaterno.Text != "")
                ConMaterno = TxtMaterno.Text.ToUpper();
            if (TxtCi.Text != "")
                ConCi = TxtCi.Text.ToUpper();

            
            Dtmodalidad = objmodalidad.SeleccionarModalidad_IICriterioSinDefenzaBss(ConNombre, ConPaterno, ConMaterno, ConCi);
            
            DtGridModalidadII = CargarModalidadesII(DtGridModalidadII, Dtmodalidad);
        }

        private void DtGridModalidadII_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DtGridModalidadII.Rows[ColorModalidad].DefaultCellStyle.BackColor = Color.White;
                DtGridModalidadII.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                ColorModalidad = e.RowIndex;

                IdModalidadII = Convert.ToInt32(DtGridModalidadII["ID_MODALIDAD_II", e.RowIndex].Value);

                // PARA SACAR LA FECHA MAS ALTA DEL CRONOGRAMA
                ObjCronograma.ID_MODALIDAD_II = IdModalidadII;
                DtCronograma = ObjCronograma.SeleccionarCronogramaCriterioBss();
                if (DtCronograma.Rows.Count > 0)
                {
                    for (int i = 0; i < DtCronograma.Rows.Count; i++)
                    {
                        if (i == 0)
                            FechaFinal = Convert.ToDateTime(DtCronograma.Rows[i]["fecha"]);
                        else
                        {
                            if (FechaFinal < Convert.ToDateTime(DtCronograma.Rows[i]["fecha"]))
                                FechaFinal = Convert.ToDateTime(DtCronograma.Rows[i]["fecha"]);
                        }

                    }

                    TxtFechaFin.Text = FechaFinal.ToString("dd/MM/yyyy");
                    groupBox3.Enabled = true;
                    BtnActualizar.Enabled =true;
                }
                else
                {
                    MessageBox.Show("EL ESTUDIANTE NO TIENE CRONOGRAMA REGISTRADO, PARA REALIZAR UNA AMPLIACION PREVIAMENTE DEBE REGISTRAR CRONOGRAMA", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    groupBox3.Enabled = false;
                    BtnActualizar.Enabled = false;
                       
                    
                }


            }
            catch (Exception ee)
            {
                ColorModalidad = 0;
                MessageBox.Show(ee.ToString());
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(TxtFechaFin.Text) < Convert.ToDateTime(dtfecha.Value.ToString("dd/MM/yyyy")))
            {
                if (dtfecha.Value > DateTime.Now)
                {
                    ObjCronograma.DESCRIPCION = txtdescripcion.Text;
                    ObjCronograma.ESTADO = 1;
                    ObjCronograma.ID_MODALIDAD_II = IdModalidadII;

                    ObjCronograma.FECHA = dtfecha.Value.ToString("MM/dd/yyyy");
                    ObjCronograma.InsertarCronogramaBss();
                    //MODIFICAR ESTADO DE MOD II
                    objmodalidad.ESTADO = 1;
                    objmodalidad.ActualizarModalidadIIBss();
                    MessageBox.Show("La fecha de finalizacion de la Modalidad de Graduación II fue reprogramada con éxito", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdescripcion.Clear();
                    TxtFechaFin.Clear();

                    CargarModalidadesII(DtGridModalidadII, objmodalidad.SeleccionarModalidad_IICriterioSinDefenzaBss(TxtNombre.Text.ToUpper(),TxtPaterno.Text.ToUpper(),TxtMaterno.Text.ToUpper(),TxtCi.Text.ToUpper()));
                }
                else
                {
                    MessageBox.Show("LA NUEVA FECHA DE FINALIZACION DEBE SER MAYOR A LA DE HOY", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            
            }
            else
            {
                MessageBox.Show("PARA EXTENDER LA FECHA DE FINALIZACION DE LA MODALIDAD II, LA NUEVA FECHA DE FINALIZACION DEBER SER MAYOR A LA FECHA DE FINALIZACION", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        

       
    }
}
