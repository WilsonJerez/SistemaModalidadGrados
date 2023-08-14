using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DEFENSAS
{
    public partial class InsertarDefensas : Form
    {
        public InsertarDefensas()
        {
            InitializeComponent();
        }

        BSS.Bss_Aula ObjAula = new BSS.Bss_Aula();
        BSS.Bss_Contrato ObjContrato = new BSS.Bss_Contrato();
        BSS.Bss_Modalidad_I ObjModalidadI = new BSS.Bss_Modalidad_I();
        BSS.Bss_Tribunal ObjTribunal = new BSS.Bss_Tribunal();
        BSS.Bss_Defensa ObjDefensa = new BSS.Bss_Defensa();

        DataTable Aulas = new DataTable();
        DataTable ModalidadI = new DataTable();
        DataTable Contratos = new DataTable();
        DataTable DefensasProgramadas = new DataTable();
        DataTable Repitentes = new DataTable();
        // variables utilizadas para cambiar el color a la filas seleccionadas de los grids
        int IndiceAulaColor;
        int IndiceEstudianteColor;
        int IndiceTribunalColor;
        int IndiceRepitentesColor;

        // variables para saber de que grid se escogio el estudiante si repitentes o nuevo
        bool BanderaRepitentes = false;
        bool BanderaNuevos = false;
        //variableas para capturar los ids para luego guardar la defensa
        int IdAula;
        int IdEstudiante;
        int IdModalidadI;
        

        //variables para almacenar los id de los contratos seleccionados para tribunal de defensa
        int IdContrato1;
        int IdContrato2; 
        int IdContrato3;
        
        // variable utilizada para recuperar el id la fila seleccionada del contrato para luego capturar el id del contrato seleccionado
        int IndiceFilaContrato;
        //contador para los tribunales
        int ContadorTribunales;

        int HoraActual;
        int DiaActual;

        

        private void InsertarDefensas_Load(object sender, EventArgs e)
        {
            ObjAula.ESTADO = 1;
            Aulas= ObjAula.SeleccionarAulaCriterioBss();
            GridAula = CargarGridAulas(GridAula,Aulas,"");
            
            //cargamos el grid de modalidades no defendidas
            ObjModalidadI.ESTADO = 0;
            ModalidadI = ObjModalidadI.SeleccionarModalidadICriterioBss();
            GridModalidad = CargarGridModalidad_I(GridModalidad, ModalidadI,"");

            ObjContrato.ESTADO = 1;
            Contratos = ObjContrato.SeleccionarContratoCriterioBss();
            GridTribunal = CargarGridTribunal(GridTribunal, Contratos,"");

            

            //cargarmos el grid de repitentes
            Repitentes = ObjModalidadI.SeleccionarModalidadReprovadasBss();
            GridRepitentes = CargarGridRepitentes(GridRepitentes, Repitentes, "");

            // cargamos por defecto los minutos 00

            CmbMinutos.SelectedItem = "00";

            HoraActual = Convert.ToInt32(DateTime.Now.Hour);




        }

        //funciones para cargar los datagrids aula modalidad y tribunal
        public DataGridView CargarGridRepitentes(DataGridView Xgrid, DataTable RepitentesX, string CmdSqlDataTable)
        {
            Xgrid.Rows.Clear();

            if (CmdSqlDataTable == "")
            {

                for (int i = 0; i < RepitentesX.Rows.Count; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["ID_ESTUDIANTER", i].Value = RepitentesX.Rows[i]["id_estudiante"];
                    Xgrid["CIR", i].Value = RepitentesX.Rows[i]["ci"];
                    Xgrid["NOMBRER", i].Value = RepitentesX.Rows[i]["nombre"];
                    Xgrid["PATERNOR", i].Value = RepitentesX.Rows[i]["paterno"];
                    Xgrid["MATERNOR", i].Value = RepitentesX.Rows[i]["materno"];
                    Xgrid["TIPOR", i].Value = RepitentesX.Rows[i]["tipo_modalidad"];
                    Xgrid["TEMAR", i].Value = RepitentesX.Rows[i]["tema"];
                    Xgrid["ID_MODALIDAD_IR", i].Value = RepitentesX.Rows[i]["id_modalidad_I"];
                    Xgrid["NRO_DEFENSAS", i].Value = RepitentesX.Rows[i]["n"];

                    //Xgrid["ID_MODALIDAD_II", i].Value = ModalidadIX.Rows[i]["id_modalidad_II"];
                }
            }
            else
            {


                DataRow[] encontrada = RepitentesX.Select(CmdSqlDataTable);

                for (int i = 0; i < encontrada.Length; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["ID_ESTUDIANTER", i].Value = encontrada[i]["id_estudiante"];
                    Xgrid["CIR", i].Value = encontrada[i]["ci"];
                    Xgrid["NOMBRER", i].Value = encontrada[i]["nombre"];
                    Xgrid["PATERNOR", i].Value = encontrada[i]["paterno"];
                    Xgrid["MATERNOR", i].Value = encontrada[i]["materno"];
                    Xgrid["TIPOR", i].Value = encontrada[i]["tipo_modalidad"];
                    Xgrid["TEMAR", i].Value = encontrada[i]["tema"];
                    Xgrid["ID_MODALIDAD_IR", i].Value = encontrada[i]["id_modalidad_I"];
                    Xgrid["NRO_DEFENSAS", i].Value = encontrada[i]["n"];
                    //Xgrid["ID_MODALIDAD_II", i].Value = encontrada[i]["id_modalidad_II"];
                }
            }



            return Xgrid;
        }
        public DataGridView CargarGridModalidad_I(DataGridView Xgrid, DataTable ModalidadIX, string CmdSqlDataTable)
        {

            Xgrid.Rows.Clear();

            if (CmdSqlDataTable == "")
            {

                for (int i = 0; i < ModalidadIX.Rows.Count; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["ID_ESTUDIANTE", i].Value = ModalidadIX.Rows[i]["id_estudiante"];
                    Xgrid["CI", i].Value = ModalidadIX.Rows[i]["ci"];
                    Xgrid["NOMBRE", i].Value = ModalidadIX.Rows[i]["nombre"];
                    Xgrid["PATERNO", i].Value = ModalidadIX.Rows[i]["paterno"];
                    Xgrid["MATERNO", i].Value = ModalidadIX.Rows[i]["materno"];
                    Xgrid["TIPO", i].Value = ModalidadIX.Rows[i]["tipo_modalidad"];
                    Xgrid["TEMA", i].Value = ModalidadIX.Rows[i]["tema"];
                    Xgrid["ID_MODALIDAD_I", i].Value = ModalidadIX.Rows[i]["id_modalidad_I"];
                   
                    //Xgrid["ID_MODALIDAD_II", i].Value = ModalidadIX.Rows[i]["id_modalidad_II"];
                }
            }
            else
            {


                DataRow[] encontrada = ModalidadI.Select(CmdSqlDataTable);

                for (int i = 0; i < encontrada.Length; i++)
                {
                    Xgrid.Rows.Add();
                    Xgrid["ID_ESTUDIANTE", i].Value = encontrada[i]["id_estudiante"];
                    Xgrid["CI", i].Value = encontrada[i]["ci"];
                    Xgrid["NOMBRE", i].Value = encontrada[i]["nombre"];
                    Xgrid["PATERNO", i].Value = encontrada[i]["paterno"];
                    Xgrid["MATERNO", i].Value = encontrada[i]["materno"];
                    Xgrid["TIPO", i].Value = encontrada[i]["tipo_modalidad"];
                    Xgrid["TEMA", i].Value = encontrada[i]["tema"];
                    Xgrid["ID_MODALIDAD_I", i].Value = encontrada[i]["id_modalidad_I"];
                    //Xgrid["ID_MODALIDAD_II", i].Value = encontrada[i]["id_modalidad_II"];
                }
            }



            return Xgrid;
            
        }
        public DataGridView CargarGridAulas(DataGridView Xgrid,DataTable AulasX ,string CmdSqlDataTable)
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
                DataRow []encontradas;
                encontradas=(AulasX.Select(CmdSqlDataTable));

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
        
        public DataGridView CargarGridTribunal(DataGridView Xgrid, DataTable TribunalX, string cmd)
        {
            Xgrid.Rows.Clear();

            if (cmd == "")
            {

                for (int i = 0; i < TribunalX.Rows.Count; i++)
                {
                    GridTribunal.Rows.Add();
                    GridTribunal["CI_TRIBUNAL", i].Value = TribunalX.Rows[i]["ci"];
                    GridTribunal["NOMBRE_TRIBUNAL", i].Value = TribunalX.Rows[i]["nombre"];
                    GridTribunal["PATERNO_TRIBUNAL", i].Value = TribunalX.Rows[i]["paterno"];
                    GridTribunal["MATERNO_TRIBUNAL", i].Value = TribunalX.Rows[i]["materno"];
                    GridTribunal["PROFESION", i].Value = TribunalX.Rows[i]["profesion"];
                    GridTribunal["ID_CONTRATO", i].Value = TribunalX.Rows[i]["id_contrato"];
                }
            }
            else
            {
                DataRow[] econtradas = TribunalX.Select(cmd);
                for (int i = 0; i < econtradas.Length; i++)
                {
                    GridTribunal.Rows.Add();
                    GridTribunal["CI_TRIBUNAL", i].Value = econtradas[i]["ci"];
                    GridTribunal["NOMBRE_TRIBUNAL", i].Value = econtradas[i]["nombre"];
                    GridTribunal["PATERNO_TRIBUNAL", i].Value = econtradas[i]["paterno"];
                    GridTribunal["MATERNO_TRIBUNAL", i].Value = econtradas[i]["materno"];
                    GridTribunal["PROFESION", i].Value = econtradas[i]["profesion"];
                    GridTribunal["ID_CONTRATO", i].Value = econtradas[i]["id_contrato"];
                }

            }
            return Xgrid;
        }
        

        private void BtnFiltrarAula_Click(object sender, EventArgs e)
        {
           
            if(Validaciones.numero(TxtPiso.Text)==true)
            {
                GridAula = CargarGridAulas(GridAula, Aulas, "piso=" + TxtPiso.Text);
            }
        }

        private void BtnFiltrarModalidadI_Click(object sender, EventArgs e)
        {
            string estado=" estado=0 ";
            string ci="";
            string nombre="";
            string materno="";
            string paterno="";

            if(TxtCiModalidad.Text!="")
                ci=" AND ci="+TxtCiModalidad.Text;
            if(TxtNombreModalidad.Text!="")
                nombre=" AND nombre='"+TxtNombreModalidad.Text.ToUpper()+"'";
            if(TxtPaternoModalidad.Text!="")
                paterno=" AND paterno='"+TxtPaternoModalidad.Text.ToUpper()+"'";
            if(TxtMaternoModalidad.Text!="")
                materno=" AND materno='"+TxtMaternoModalidad.Text.ToUpper()+"'";

            
                GridModalidad = CargarGridModalidad_I(GridModalidad, ModalidadI, estado + ci + nombre + paterno + materno);
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


            GridTribunal = CargarGridTribunal(GridTribunal, Contratos, estado + ci + nombre + paterno + materno);
        }

        private void GridAula_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                GridAula.Rows[IndiceAulaColor].DefaultCellStyle.BackColor = Color.White;
                GridAula.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;

                IdAula = Convert.ToInt32(GridAula["id_aula", e.RowIndex].Value);
                TxtAulaDetalle.Text = GridAula["AULA", e.RowIndex].Value.ToString();
                IndiceAulaColor = e.RowIndex;
            }
            catch (Exception ee)
            {
                IndiceAulaColor = 0;
                MessageBox.Show(ee.ToString());
            }
            

        }

        private void GridModalidad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BanderaNuevos = true;
                BanderaRepitentes = false;

                if (GridRepitentes.Rows.Count > 0)
                {
                    GridRepitentes.Rows[IndiceRepitentesColor].DefaultCellStyle.BackColor = Color.White;
                }

                IdModalidadI = Convert.ToInt32(GridModalidad["ID_MODALIDAD_I", e.RowIndex].Value);
                GridModalidad.Rows[IndiceEstudianteColor].DefaultCellStyle.BackColor = Color.White;
                GridModalidad.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IdEstudiante = Convert.ToInt32(GridModalidad["ID_ESTUDIANTE", e.RowIndex].Value);
                TxtEstudianeDetalle.Text = GridModalidad["NOMBRE", e.RowIndex].Value.ToString() + " " + GridModalidad["PATERNO", e.RowIndex].Value.ToString() + " " + GridModalidad["MATERNO", e.RowIndex].Value.ToString();
                IndiceEstudianteColor = e.RowIndex;
            }
            catch (Exception ee)
            {
                IndiceEstudianteColor = 0;
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

                
                    //cargamos datos del tribunal para buscar todas las defensas programadas para esa fecha y mostrarlas
                    ObjTribunal.ESTADO = 1;
                    ObjTribunal.FECHA = dateTimePicker1.Value.ToString("MM/dd/yyyy");
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
            catch (Exception ee)
            {
                IndiceTribunalColor = 0;
                MessageBox.Show(ee.ToString());
            }
        }

        private void BtnGuardarDefensa_Click(object sender, EventArgs e)// boton para guardar la defensa
        {
            int[] ArrayIdContrato = new int[3];

            if (IdEstudiante > 0 & IdAula>0 )
            {
                if (TxtAulaDetalle.Text != "" & IdEstudiante>0)
                {

                    if (IdContrato1 > 0 & IdContrato2 > 0 & IdContrato3 > 0)
                    {
                        
                            if (CmbHoraDefensa.Text != "" & CmbMinutos.Text!="")
                            {
                                
                                
                                //hacer el control aquisito

                                //cargamos datos para validad que no exista una defensa en la misma aula y la misma fecha
                                ObjDefensa.ESTADO = 1;
                                ObjDefensa.FECHA = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                                ObjDefensa.HORA = CmbHoraDefensa.Text+":"+CmbMinutos.Text;
                                ObjDefensa.ID_AULA = IdAula;
                                if (ObjDefensa.SeleccionarDefensaCriterioBss().Rows.Count > 0)
                                {
                                    MessageBox.Show("Ya Existe una defensa en la misma fecha,hora,aula, cambie el aula o la hora para que no exista un conflicto en la defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    ObjTribunal.ESTADO = 1;
                                    ObjTribunal.ID_AULA = IdAula;
                                    ObjTribunal.FECHA = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                                    ObjTribunal.HORA = CmbHoraDefensa.Text + ":" + CmbMinutos.Text;
                                    ObjTribunal.ID_MODALIDAD_I = IdModalidadI;

                                    // cargamos el vector de contratos

                                    ArrayIdContrato[0] = IdContrato1;
                                    ArrayIdContrato[1] = IdContrato2;
                                    ArrayIdContrato[2] = IdContrato3;

                                    //guardamos el tribunal y la defensa 
                                    ObjTribunal.InsertarTribunalBss(ArrayIdContrato);
                                    MessageBox.Show("La defensa fue programada exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    // actualizamos los datos de las modalidades por que despues de haber sido programadas ya no se podria programar nuevamente
                                    if (BanderaNuevos == true)
                                    {
                                        ObjModalidadI.ESTADO = 0;
                                        ModalidadI = ObjModalidadI.SeleccionarModalidadICriterioBss();
                                        GridModalidad = CargarGridModalidad_I(GridModalidad, ModalidadI, "");
                                    }

                                    //liberamos los atributos asignados
                                    ObjTribunal.ESTADO = 0;
                                    ObjTribunal.ID_AULA = 0;
                                    ObjTribunal.FECHA = null;
                                    ObjTribunal.HORA = null;
                                    ObjTribunal.ID_MODALIDAD_I = 0;
                                    
                                    IdContrato1=0;
                                    IdContrato2=0;
                                    IdContrato3=0;

                                    // quitamos los colores de los grids
                                    GridAula.Rows[IndiceAulaColor].DefaultCellStyle.BackColor = Color.White;
                                    GridTribunal.Rows[IndiceTribunalColor].DefaultCellStyle.BackColor = Color.White;
                                    
                                    BtnPonerTribunal.Enabled = false;

                                    // limpiamos el detalle y otros campos

                                    CmbMinutos.SelectedItem="00";
                                    CmbHoraDefensa.Text = "";
                                      TxtEstudianeDetalle.Clear();
                                      TxtAulaDetalle.Clear();
                                      TxtTribunal1.Text="NO";
                                      TxtTribunal2.Text = "NO";
                                      TxtTrinal3.Text = "NO";
                                      ContadorTribunales = 0;

                                    // refrescamos solo el grid de repitentes para que excluya por que tiene una defensa pendiente en caso que se escoja a un estudiante repitente
                                      if (BanderaRepitentes == true)
                                      {
                                          Repitentes = ObjModalidadI.SeleccionarModalidadReprovadasBss();
                                          GridRepitentes = CargarGridRepitentes(GridRepitentes, Repitentes, "");
                                      }
                                    // limpiamos los indices de colores
                                      IndiceEstudianteColor = 0;
                                      IndiceRepitentesColor = 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("La hora es incorrecta", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnPonerTribunal_Click(object sender, EventArgs e)//boton para volcar los tribunales seleccionados al detalle de defensa
        {
            //string fecha = dateTimePicker1.Value("dd/MM/yyyy");
            //string auxdia = "";
            ////bool ban = false;


            //if (Validaciones.fecha(TxtFecha.Text) == true)
            //{

            //    //para sacar el dia
            //    for (int i = 0; i < fecha.Length; i++)
            //    {
            //        if (fecha[i].ToString() != "/")
            //        {
            //            auxdia = auxdia + fecha[i].ToString();
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    // cargamos el dia de la fecha en dia actual
            //    DiaActual = Convert.ToInt32(auxdia);



                if (CmbHoraDefensa.Text != "" & Validaciones.numero(CmbHoraDefensa.Text) == true)
                {


                    if (Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy"))>DAL.Dal_Login.fecha)
                    {


                        ObjTribunal.ESTADO = 1;
                        ObjTribunal.FECHA = dateTimePicker1.Value.ToString("MM/dd/yyyy");
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
            //}
            //else
            //{
            // MessageBox.Show("La fecha no esta correctamente escrita, el formato debe ser dd/mm/aaaa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
                       
        }

        private void BtnCambTri1_Click(object sender, EventArgs e)
        {
            
            if (ContadorTribunales > 0)
            {   TxtTribunal1.Text = "NO";
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

        private void GridRepitentes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BanderaRepitentes = true;
                BanderaNuevos = false;
                if (GridModalidad.Rows.Count > 0)
                {
                    GridModalidad.Rows[IndiceEstudianteColor].DefaultCellStyle.BackColor = Color.White;
                }
                IdModalidadI = Convert.ToInt32(GridRepitentes["ID_MODALIDAD_IR", e.RowIndex].Value);
                GridRepitentes.Rows[IndiceRepitentesColor].DefaultCellStyle.BackColor = Color.White;
                GridRepitentes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                IdEstudiante = Convert.ToInt32(GridRepitentes["ID_ESTUDIANTER", e.RowIndex].Value);
                TxtEstudianeDetalle.Text = GridRepitentes["NOMBRER", e.RowIndex].Value + "  " + GridRepitentes["PATERNOR", e.RowIndex].Value + "  " + GridRepitentes["MATERNOR", e.RowIndex].Value;
                IndiceRepitentesColor = e.RowIndex;
            }
            catch (Exception ee)
            {
                IndiceRepitentesColor = 0;
                MessageBox.Show(ee.ToString());
            }

            
        }

        private void BtnFiltrarRepi_Click(object sender, EventArgs e)
        {
            string estado = " estado=0 ";
            string ci = "";
            string nombre = "";
            string materno = "";
            string paterno = "";

            if (TxtCiRepi.Text != "")
                ci = " AND ci=" + TxtCiRepi.Text.ToUpper();
            if (TxtNombreRepi.Text != "")
                nombre = " AND nombre='" + TxtNombreRepi.Text.ToUpper() + "'";
            if (TxtPaternoRepi.Text != "")
                paterno = " AND paterno='" + TxtPaternoRepi.Text.ToUpper() + "'";
            if (TxtMaternoRepi.Text != "")
                materno = " AND materno='" + TxtMaternoRepi.Text.ToUpper()+ "'";


            GridRepitentes =CargarGridRepitentes (GridRepitentes, Repitentes, estado + ci + nombre + paterno + materno);
        }

        private void CmbHoraDefensa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbHoraDefensa_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CmbMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy")) < DAL.Dal_Login.fecha)
            {
                dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("Seleccione una fecha mayor a la actual para programar una defensa", "ERROR DE DATO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 IdContrato1=0;
                 IdContrato2=0;
                 IdContrato3=0;
                 GridTribunal.Rows[IndiceTribunalColor].DefaultCellStyle.BackColor = Color.White;
                 TxtTribunal1.Clear();
                 TxtTribunal2.Clear();
                 TxtTrinal3.Clear();
            }
        }


        

        

        
    }
}
