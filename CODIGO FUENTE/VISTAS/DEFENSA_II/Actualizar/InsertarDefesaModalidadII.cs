using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSA_II
{
    public partial class InsertarDefesaModalidadII : Form
    {
        public InsertarDefesaModalidadII()
        {
            InitializeComponent();
        }
        //objetos utilizados
        BSS.Bss_Modalidad_II ObjModalidadII = new BSS.Bss_Modalidad_II();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();


        // datat tables para alamacenar los datos recuperados
        DataTable DtModalidadIIPrimeraDefensa = new DataTable();
        DataTable DtModalidadIISegundaDefensa = new DataTable();
        DataTable DtTribunales = new DataTable();
        DataTable DtAulas = new DataTable();
        DataTable DefensasProgramadas = new DataTable();

        // indices para cambiar el color de la defensa
        int IndiceColorModalidadPrimera;
        int IndiceColorModalidadSegunda;
        int IndiceColorAula;
        int IndiceTribunalColor;
        int IndiceFilaContrato;

        // variables para capturar los ids requeridos para la defensa
        int IdModalidadII;
        int IdAula;

        // banderas para saber de cual grid de modalidades para la defensa fureron selecionados
        bool BandPrimeraVez = false;
        bool BandSegundaVez = false;

        int DiaActual;
        int ContadorTribunales;

        int IdContrato1;
        int IdContrato2;
        int IdContrato3;

        private void InsertarDefesaModalidadII_Load(object sender, EventArgs e)
        {
            // cargamos el dt table para las modalidades de grado 2 habilitadas para la primera defensa
            DtModalidadIIPrimeraDefensa = ObjModalidadII.SeleccionarModalidadIICulminoCronogramaBss();
            // para cargar el grid de modalidades para la primera defensa
            GridModalidadIIPrimeraDefensa = CargarGridModalidadIIPrimeraDefensa(GridModalidadIIPrimeraDefensa, DtModalidadIIPrimeraDefensa, "");

            // cargamos el data table de la modalidades habilitadas pra la segunda defensa 
            DtModalidadIISegundaDefensa = ObjModalidadII.SeleccionarModalidad_IIRepitentesBss();
            // para cargar el grid de modalidades para la segunda defensa
            GridModalidadIIRepitentes = CargarGriModalidadesRepitentes(GridModalidadIIRepitentes, DtModalidadIISegundaDefensa, "");
            

            // para cargar el grid de tribunales
            ObjContrato.ESTADO = 1;
            DtTribunales = ObjContrato.SeleccionarContratoCriterioBss();
            GridTribunal = CargarGridTribunales(GridTribunal, DtTribunales, "");

            // para cargar el aula
            ObjAula.ESTADO = 1;
            DtAulas = ObjAula.SeleccionarAulaCriterioBss();
            GridAula = CargarGridAulas(GridAula, DtAulas, "");

            TxtFecha.Text = DateTime.Now.ToShortDateString();
            CmbMinutos.SelectedItem = "00";

        }
        private void GridModalidadIIPrimeraDefensa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridModalidadIIPrimeraDefensa.Rows[IndiceColorModalidadPrimera].DefaultCellStyle.BackColor = Color.White;
                GridModalidadIIPrimeraDefensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorModalidadPrimera = e.RowIndex;
                IdModalidadII = Convert.ToInt32(GridModalidadIIPrimeraDefensa["ID_MODALIDAD_II", e.RowIndex].Value);
                TxtEstudianeDetalle.Text = GridModalidadIIPrimeraDefensa["NOMBRE", e.RowIndex].Value.ToString() + "  " + GridModalidadIIPrimeraDefensa["PATERNO", e.RowIndex].Value.ToString() + "  " + GridModalidadIIPrimeraDefensa["MATERNO", e.RowIndex].Value.ToString();
                BandPrimeraVez = true;
                BandSegundaVez = false;
                if(GridModalidadIIRepitentes.Rows.Count>0)
                GridModalidadIIRepitentes.Rows[IndiceColorModalidadSegunda].DefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ee)
            {
                IndiceColorModalidadPrimera = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void GridModalidadIIRepitentes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridModalidadIIRepitentes.Rows[IndiceColorModalidadSegunda].DefaultCellStyle.BackColor = Color.White;
                GridModalidadIIRepitentes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorModalidadSegunda = e.RowIndex;
                IdModalidadII=Convert.ToInt32(GridModalidadIIRepitentes["ID_MODALIDAD_IIR",e.RowIndex].Value);
                TxtEstudianeDetalle.Text = GridModalidadIIRepitentes["NOMBRER", e.RowIndex].Value.ToString() + "  " + GridModalidadIIRepitentes["PATERNOR", e.RowIndex].Value.ToString() + "  " + GridModalidadIIRepitentes["MATERNOR", e.RowIndex].Value.ToString();
                BandSegundaVez = true;
                BandPrimeraVez = false;
                if(GridModalidadIIPrimeraDefensa.Rows.Count>0)
                GridModalidadIIPrimeraDefensa.Rows[IndiceColorModalidadPrimera].DefaultCellStyle.BackColor = Color.White;

            }
            catch(Exception ee)
            {
                IndiceColorModalidadSegunda = 0;
                MessageBox.Show(ee.ToString());
            }

        }
        private void GridAula_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                GridAula.Rows[IndiceColorAula].DefaultCellStyle.BackColor = Color.White;
                GridAula.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceColorAula = e.RowIndex;
                IdAula = Convert.ToInt32(GridAula["id_aula", e.RowIndex].Value);
                TxtAulaDetalle.Text = GridAula["AULA", e.RowIndex].Value.ToString();
            }
            catch (Exception ee)
            {
                IndiceColorAula = 0;
                MessageBox.Show(ee.ToString());
            }
        }
        private void GridTribunal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                //codigo para cambiar el color a la fila seleccionada
                GridTribunal.Rows[IndiceTribunalColor].DefaultCellStyle.BackColor = Color.White;
                GridTribunal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IndiceTribunalColor = e.RowIndex;

                //habilitamos el boton poner tribunal
                BtnPonerTribunal.Enabled = true;

                GridDefeProgra.Rows.Clear();
                IndiceFilaContrato = e.RowIndex; //recuperamos el indice de la fila para pasar el tribunal

                if (Validaciones.fecha(TxtFecha.Text) == true)// validamos que la fecha introducida sea correcta 
                {

                    //cargamos datos del tribunal para buscar todas las defensas programadas para esa fecha y mostrarlas
                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                    //ObjTribunal.HORA = TxtHora.Text;
                    ObjTribunal.ID_CONTRATO = Convert.ToInt32(GridTribunal["ID_CONTRATO", e.RowIndex].Value);
                    DefensasProgramadas = ObjTribunal.SeleccionarTribunalCriterioBss();
                    for (int i = 0; i < DefensasProgramadas.Rows.Count; i++)
                    {
                        GridDefeProgra.Rows.Add();
                        GridDefeProgra["FECHA", i].Value = DefensasProgramadas.Rows[i]["fecha"];
                        GridDefeProgra["HORA", i].Value = DefensasProgramadas.Rows[i]["hora"];
                    }

                    //LIBERAMOS LOS ATRIBUTOS ASIGNADOS
                    ObjTribunal.ESTADO = 0;
                    ObjTribunal.FECHA = null;
                    ObjTribunal.ID_CONTRATO = 0;

                }
                else
                {
                    MessageBox.Show("Es necesario que la fecha esta llenada correctamente (dd/mm/yyyy)", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ee)
            {
                IndiceTribunalColor = 0;
                MessageBox.Show(ee.ToString());
            }
        }


        // funciones...........................................................................................................
        //funcion para cargar el grid de ModalidadII Primera defensa
        public DataGridView CargarGridModalidadIIPrimeraDefensa(DataGridView gridX,DataTable dtx,string filtracionX)
        {
            gridX.Rows.Clear();
            
            if (filtracionX == "")
            {
                for (int i = 0; i < dtx.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_II", i].Value = dtx.Rows[i]["id_modalidad_II"];
                    gridX["CI", i].Value = dtx.Rows[i]["ci"];
                    gridX["NOMBRE", i].Value = dtx.Rows[i]["nombre"];
                    gridX["PATERNO", i].Value = dtx.Rows[i]["paterno"];
                    gridX["MATERNO", i].Value = dtx.Rows[i]["materno"];
                    gridX["TIPO", i].Value = dtx.Rows[i]["tipo_modalidad"];
                    gridX["TEMA",i].Value=dtx.Rows[i]["tema"];
                }
            }
            else
            {
                DataRow[] filtradas = dtx.Select(filtracionX);
                for (int i = 0; i < filtradas.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_II", i].Value = filtradas[i]["id_modalidad_II"];
                    gridX["CI", i].Value = filtradas[i]["ci"];
                    gridX["NOMBRE", i].Value = filtradas[i]["nombre"];
                    gridX["PATERNO", i].Value = filtradas[i]["paterno"];
                    gridX["MATERNO", i].Value = filtradas[i]["materno"];
                    gridX["TIPO", i].Value = filtradas[i]["tipo_modalidad"];
                    gridX["TEMA", i].Value = filtradas[i]["tema"];
                }
            }

            return gridX;
        }
        // para cargar el grid de modalidades  habilitadas pra la segunda defensa

        public DataGridView CargarGriModalidadesRepitentes(DataGridView gridX,DataTable dtrepitentesX,string filtracion)
        {
            gridX.Rows.Clear();
            if (filtracion == "")
            {
                for (int i = 0; i < dtrepitentesX.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_IIR", i].Value = dtrepitentesX.Rows[i]["id_modalidad_II"];
                    gridX["NRO_DEFENSAS", i].Value = dtrepitentesX.Rows[i]["n"];
                    gridX["CIR", i].Value = dtrepitentesX.Rows[i]["ci"];
                    gridX["NOMBRER", i].Value = dtrepitentesX.Rows[i]["nombre"];
                    gridX["PATERNOR",i].Value=dtrepitentesX.Rows[i]["paterno"];
                    gridX["MATERNOR", i].Value = dtrepitentesX.Rows[i]["materno"];
                    gridX["TIPOR", i].Value = dtrepitentesX.Rows[i]["tipo_modalidad"];
                    gridX["TEMAR", i].Value = dtrepitentesX.Rows[i]["tema"];
                }
            }
            else
            {
                DataRow[] filtro = dtrepitentesX.Select(filtracion);
                for (int i = 0; i < filtro.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["ID_MODALIDAD_IIR", i].Value = filtro[i]["id_modalidad_II"];
                    gridX["NRO_DEFENSAS", i].Value = filtro[i]["n"];
                    gridX["CIR", i].Value = filtro[i]["ci"];
                    gridX["NOMBRER", i].Value = filtro[i]["nombre"];
                    gridX["PATERNOR", i].Value = filtro[i]["paterno"];
                    gridX["MATERNOR", i].Value = filtro[i]["materno"];
                    gridX["TIPOR", i].Value = filtro[i]["tipo_modalidad"];
                    gridX["TEMAR", i].Value = filtro[i]["tema"];
                }
            }
            return gridX;
        }
        // para cargar el grid de tribunales
        public DataGridView CargarGridTribunales(DataGridView gridX, DataTable dttribunales, string filtracion)
        {
            gridX.Rows.Clear();
            if (filtracion == "")
            {

                for (int i = 0; i < dttribunales.Rows.Count; i++)
                {
                    gridX.Rows.Add();
                    gridX["CI_TRIBUNAL", i].Value = dttribunales.Rows[i]["ci"];
                    gridX["NOMBRE_TRIBUNAL", i].Value = dttribunales.Rows[i]["nombre"];
                    gridX["PATERNO_TRIBUNAL", i].Value = dttribunales.Rows[i]["paterno"];
                    gridX["MATERNO_TRIBUNAL", i].Value = dttribunales.Rows[i]["materno"];
                    gridX["PROFESION", i].Value = dttribunales.Rows[i]["profesion"];
                    gridX["ID_CONTRATO", i].Value = dttribunales.Rows[i]["id_contrato"];
                }
            }
            else
            {
                DataRow[] econtradas = dttribunales.Select(filtracion);
                for (int i = 0; i < econtradas.Length; i++)
                {
                    gridX.Rows.Add();
                    gridX["CI_TRIBUNAL", i].Value = econtradas[i]["ci"];
                    gridX["NOMBRE_TRIBUNAL", i].Value = econtradas[i]["nombre"];
                    gridX["PATERNO_TRIBUNAL", i].Value = econtradas[i]["paterno"];
                    gridX["MATERNO_TRIBUNAL", i].Value = econtradas[i]["materno"];
                    gridX["PROFESION", i].Value = econtradas[i]["profesion"];
                    gridX["ID_CONTRATO", i].Value = econtradas[i]["id_contrato"];
                }

            }
            return gridX;
        }

        public DataGridView CargarGridAulas(DataGridView Xgrid, DataTable AulasX, string CmdSqlDataTable)
        {

            Xgrid.Rows.Clear();//limpiamos el grid entrante              
            if (CmdSqlDataTable == "")
            {

                for (int i = 0; i < AulasX.Rows.Count; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["id_aula", i].Value = AulasX.Rows[i]["id_aula"];
                    Xgrid["AULA", i].Value = AulasX.Rows[i]["n_aula"];
                    Xgrid["PISO", i].Value = AulasX.Rows[i]["piso"];
                    Xgrid["CAPACIDAD", i].Value = AulasX.Rows[i]["capacidad"];
                }
            }
            else
            {
                DataRow[] encontradas;
                encontradas = (AulasX.Select(CmdSqlDataTable));

                for (int i = 0; i < encontradas.Length; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["id_aula", i].Value = encontradas[i]["id_aula"];
                    Xgrid["AULA", i].Value = encontradas[i]["n_aula"];
                    Xgrid["PISO", i].Value = encontradas[i]["piso"];
                    Xgrid["CAPACIDAD", i].Value = encontradas[i]["capacidad"];
                }
            }

            return Xgrid;
        }

        private void BtnPonerTribunal_Click(object sender, EventArgs e)
        {
            string fecha = TxtFecha.Text;
            string auxdia = "";
            //bool ban = false;


            if (Validaciones.fecha(TxtFecha.Text) == true)
            {

                //para sacar el dia
                for (int i = 0; i < fecha.Length; i++)
                {
                    if (fecha[i].ToString() != "/")
                    {
                        auxdia = auxdia + fecha[i].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
                // cargamos el dia de la fecha en dia actual
                DiaActual = Convert.ToInt32(auxdia);



                if (CmbHoraDefensa.Text != "" & Validaciones.numero(CmbHoraDefensa.Text) == true)
                {


                    if (DiaActual > 0 & DiaActual > DateTime.Now.Day)
                    {


                        ObjTribunal.ESTADO = 1;
                        ObjTribunal.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                        ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                        ObjTribunal.ID_CONTRATO = Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value);
                        if (CmbHoraDefensa.Text != "")
                        {
                            if (ObjTribunal.SeleccionarTribunalCriterioBss().Rows.Count > 0)
                            {
                                MessageBox.Show("El tribunal que desea asignar ya tiene una defensa programada para la misma fecha y hora", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (ContadorTribunales <= 2)
                                {
                                    for (int i = 0; i <= 2; i++)
                                    {
                                        if (TxtTribunal1.Text == "NO")
                                        {

                                            if (Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato2 & Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato3)
                                            {
                                                ContadorTribunales++;
                                                IdContrato1 = Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value);
                                                TxtTribunal1.Text = GridTribunal["NOMBRE_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["PATERNO_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["MATERNO_TRIBUNAL", IndiceFilaContrato].Value;
                                                break;
                                            }
                                            else
                                            {
                                                MessageBox.Show("El tribunal que intenta asignar ya fue asignado", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            }
                                        }
                                        if (TxtTribunal2.Text == "NO")
                                        {

                                            if (Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato1 & Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato3)
                                            {
                                                ContadorTribunales++;
                                                IdContrato2 = Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value);
                                                TxtTribunal2.Text = GridTribunal["NOMBRE_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["PATERNO_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["MATERNO_TRIBUNAL", IndiceFilaContrato].Value;
                                                break;
                                            }
                                            else
                                            {
                                                MessageBox.Show("El tribunal que intenta asignar ya fue asignado", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            }
                                        }
                                        if (TxtTrinal3.Text == "NO")
                                        {

                                            if (Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato1 & Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value) != IdContrato2)
                                            {
                                                ContadorTribunales++;
                                                IdContrato3 = Convert.ToInt32(GridTribunal["ID_CONTRATO", IndiceFilaContrato].Value);
                                                TxtTrinal3.Text = GridTribunal["NOMBRE_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["PATERNO_TRIBUNAL", IndiceFilaContrato].Value + "  " + GridTribunal["MATERNO_TRIBUNAL", IndiceFilaContrato].Value;
                                                break;
                                            }
                                            else
                                            {
                                                MessageBox.Show("El tribunal que intenta asignar ya fue asignado", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            }
                                        }
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("Solo se pueden seleccionar 3 tribunales para una defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduzca la hora es importante para la asignacion de un tribunal", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // LIBERAMOS ATRIBUTOS ASIGNADOS

                        ObjTribunal.ESTADO = 0;
                        ObjTribunal.FECHA = null;
                        ObjTribunal.HORA = null;
                        ObjTribunal.ID_CONTRATO = 0;


                    }
                    else
                    {
                        MessageBox.Show("No se permite programar defensas en el mismo dia de la defensa, debe ser minimamente con un dia de anticipacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }


                }
                else
                {
                    MessageBox.Show("Seleccione una hora para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("La fecha no esta correctamente escrita, el formato debe ser dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       

        private void BtnGuardarDefensa_Click(object sender, EventArgs e)// boton para guardar la defensa
        {
            int[] ArrayIdContrato = new int[3];

            if ( IdAula > 0)
            {
                if (TxtAulaDetalle.Text != "" )
                {

                    if (IdContrato1 > 0 & IdContrato2 > 0 & IdContrato3 > 0)
                    {
                        if (TxtFecha.Text != "")
                        {
                            if (CmbHoraDefensa.Text != "" & CmbMinutos.Text != "")
                            {


                                //hacer el control aquisito

                                //cargamos datos para validad que no exista una defensa en la misma aula y la misma fecha
                                ObjDefensa.ESTADO = 1;
                                ObjDefensa.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                                ObjDefensa.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                ObjDefensa.ID_AULA = IdAula;
                                if (ObjDefensa.SeleccionarDefensaCriterioBss().Rows.Count > 0)
                                {
                                    MessageBox.Show("Ya Existe una defensa en la misma fecha,hora,aula, cambie el aula o la hora para que no exista un conflicto en la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    ObjTribunal.ESTADO = 1;
                                    ObjTribunal.ID_AULA = IdAula;
                                    ObjTribunal.FECHA = Validaciones.ConvertirFechaSql2005_MMDDAA(TxtFecha.Text);
                                    ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                    ObjTribunal.ID_MODALIDAD_II =IdModalidadII;

                                    // cargamos el vector de contratos

                                    ArrayIdContrato[0] = IdContrato1;
                                    ArrayIdContrato[1] = IdContrato2;
                                    ArrayIdContrato[2] = IdContrato3;

                                    //guardamos el tribunal y la defensa 
                                    ObjTribunal.InsertarTribunalBss(ArrayIdContrato);
                                    MessageBox.Show("La defensa fue programada exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    // actualizamos los datos de las modalidades por que despues de haber sido programadas ya no se podria programar nuevamente
                                    if (BandPrimeraVez == true)
                                    {
                                        DtModalidadIIPrimeraDefensa = ObjModalidadII.SeleccionarModalidadIICulminoCronogramaBss();
                                        GridModalidadIIPrimeraDefensa =CargarGridModalidadIIPrimeraDefensa(GridModalidadIIPrimeraDefensa,DtModalidadIIPrimeraDefensa, "");
                                    }

                                    //liberamos los atributos asignados
                                    ObjTribunal.ESTADO = 0;
                                    ObjTribunal.ID_AULA = 0;
                                    ObjTribunal.FECHA = null;
                                    ObjTribunal.HORA = null;
                                    ObjTribunal.ID_MODALIDAD_II = 0;

                                    IdContrato1 = 0;
                                    IdContrato2 = 0;
                                    IdContrato3 = 0;

                                    // quitamos los colores de los grids
                                    GridAula.Rows[IndiceColorAula].DefaultCellStyle.BackColor = Color.White;
                                    GridTribunal.Rows[IndiceTribunalColor].DefaultCellStyle.BackColor = Color.White;

                                    BtnPonerTribunal.Enabled = false;

                                    // limpiamos el detalle y otros campos

                                    CmbMinutos.SelectedItem="00";
                                    CmbHoraDefensa.Text = "";
                                    TxtEstudianeDetalle.Clear();
                                    TxtAulaDetalle.Clear();
                                    TxtTribunal1.Text = "NO";
                                    TxtTribunal2.Text = "NO";
                                    TxtTrinal3.Text = "NO";
                                    ContadorTribunales = 0;

                                    // refrescamos solo el grid de repitentes para que excluya por que tiene una defensa pendiente en caso que se escoja a un estudiante repitente
                                    if (BandSegundaVez == true)
                                    {
                                        DtModalidadIISegundaDefensa = ObjModalidadII.SeleccionarModalidad_IIRepitentesBss();
                                        GridModalidadIIRepitentes = CargarGriModalidadesRepitentes(GridModalidadIIRepitentes,DtModalidadIISegundaDefensa, "");
                                    }
                                    // limpiamos los indices de colores
                                    IndiceColorModalidadPrimera = 0;
                                    IndiceColorModalidadSegunda = 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("La hora es incorrecta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha es incorrecta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se asignaron los 3 tribunales,complete la asignacion", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("No selecciono un aula para la defensa, ¿Dónde defenderan?", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("falta seleccionar el estudiante o el aula para la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFiltrarMoIIPrimera_Click(object sender, EventArgs e)
        {
            string estado = " estado=0 ";
            string ci = "";
            string nombre = "";
            string materno = "";
            string paterno = "";

            if (TxtCiModalidad.Text != "")
                ci = " AND ci=" + TxtCiModalidad.Text;
            if (TxtNombreModalidad.Text != "")
                nombre = " AND nombre='" + TxtNombreModalidad.Text.ToUpper() + "'";
            if (TxtPaternoModalidad.Text != "")
                paterno = " AND paterno='" + TxtPaternoModalidad.Text.ToUpper() + "'";
            if (TxtMaternoModalidad.Text != "")
                materno = " AND materno='" + TxtMaternoModalidad.Text.ToUpper() + "'";


            GridModalidadIIPrimeraDefensa = CargarGridModalidadIIPrimeraDefensa(GridModalidadIIPrimeraDefensa,DtModalidadIIPrimeraDefensa, estado + ci + nombre + paterno + materno);
        }

        private void BtnFiltrarAula_Click(object sender, EventArgs e)
        {
            if (Validaciones.numero(TxtPiso.Text) == true)
            {
                GridAula = CargarGridAulas(GridAula,DtAulas, "piso=" + TxtPiso.Text);
            }
        }

        private void BtnFiltrarModIIRepi_Click(object sender, EventArgs e)
        {
            string estado = " estado=0 ";
            string ci = "";
            string nombre = "";
            string materno = "";
            string paterno = "";

            if (TxtCiModalidad.Text != "")
                ci = " AND ci=" + TxtCiRepi.Text.ToUpper();
            if (TxtNombreModalidad.Text != "")
                nombre = " AND nombre='" + TxtNombreRepi.Text.ToUpper() + "'";
            if (TxtPaternoModalidad.Text != "")
                paterno = " AND paterno='" + TxtPaternoRepi.Text.ToUpper() + "'";
            if (TxtMaternoModalidad.Text != "")
                materno = " AND materno='" + TxtMaternoRepi.Text.ToUpper() + "'";


            GridModalidadIIRepitentes = CargarGriModalidadesRepitentes(GridModalidadIIRepitentes,DtModalidadIISegundaDefensa, estado + ci + nombre + paterno + materno);
        }

        private void BtrnFiltrarTribunal_Click(object sender, EventArgs e)
        {
            string estado = " estado=1 ";
            string ci = "";
            string nombre = "";
            string materno = "";
            string paterno = "";

            if (TxtCiTribunal.Text != "")
                ci = " AND ci=" + TxtCiTribunal.Text;
            if (TxtNombreTribunal.Text != "")
                nombre = " AND nombre='" + TxtNombreTribunal.Text.ToUpper() + "'";
            if (TxtPaternoTribunal.Text != "")
                paterno = " AND paterno='" + TxtPaternoTribunal.Text.ToUpper() + "'";
            if (TxtMaternoTribunal.Text != "")
                materno = " AND materno='" + TxtMaternoTribunal.Text.ToUpper() + "'";


            GridTribunal =CargarGridTribunales(GridTribunal, DtTribunales, estado + ci + nombre + paterno + materno);
        }

        private void BtnCambTri1_Click(object sender, EventArgs e)
        {
            if (ContadorTribunales > 0)
            {
                TxtTribunal1.Text = "NO";
                ContadorTribunales--;
                IdContrato1 = 0;
            }
        }

        private void BtnCambTri2_Click(object sender, EventArgs e)
        {
            if (ContadorTribunales > 0)
            {
                TxtTribunal2.Text = "NO";
                ContadorTribunales--;
                IdContrato2 = 0;
            }
        }

        private void BtnCambTri3_Click(object sender, EventArgs e)
        {
            if (ContadorTribunales > 0)
            {
                TxtTrinal3.Text = "NO";
                ContadorTribunales--;
                IdContrato3 = 0;
            }
        }

        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void GridModalidadIIRepitentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        

        

        
    }
}
