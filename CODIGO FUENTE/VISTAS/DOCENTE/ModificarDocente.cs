using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISTAS.DOCENTE
{
    public partial class ModificarDocente : Form
    {
        public ModificarDocente()
        {
            InitializeComponent();
        }

        DataTable listaacademico = new DataTable();
        BSS.Bss_Contrato objacademico = new BSS.Bss_Contrato();
        DataTable listacargo = new DataTable();
        BSS.Bss_Cargo objcargo = new BSS.Bss_Cargo();
        BSS.Bss_Curriculum objcurriculum = new BSS.Bss_Curriculum();
        int estadordb;
        int id_contratoc;
        int id_personac;
        int Id_Cargoc;
        string cix;
        int Colorindex;
        
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            objacademico.NOMBRE = "";
            objacademico.PATERNO = "";
            objacademico.MATERNO = "";
            objacademico.CI = "";
            objacademico.ID_CARGO = 0;
            gvdocente.Rows.Clear();
            if (rdbactivo.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            if (txtci.Text != "")
            {
                objacademico.CI = txtci.Text;
            }
            else 
            {
                objacademico.CI = "";
            }
            if (txtnombre.Text != "")
            {
                objacademico.NOMBRE = txtnombre.Text;
            }
            else
            {
                objacademico.NOMBRE = "";
            }
            if (txtpaterno.Text != "")
            {
                objacademico.PATERNO = txtpaterno.Text;
            }
            else
            {
                objacademico.PATERNO = "";
            }
            if (txtmaterno.Text != "")
            {
                objacademico.MATERNO = txtmaterno.Text;
            }
            else
            {
                objacademico.MATERNO= "";
            }
            objacademico.ESTADO = Convert.ToInt32(estadordb);
            listaacademico = objacademico.SeleccionarContratoCriterioBss();


            for (int fila = 0; fila < listaacademico.Rows.Count; fila++)
            {
                gvdocente.Rows.Add();
                gvdocente["cig", fila].Value = listaacademico.Rows[fila]["ci"];
                gvdocente["nombreg", fila].Value = listaacademico.Rows[fila]["nombre"];
                gvdocente["paternog", fila].Value = listaacademico.Rows[fila]["paterno"];
                gvdocente["maternog", fila].Value = listaacademico.Rows[fila]["materno"];
                gvdocente["cargog", fila].Value = listaacademico.Rows[fila]["cargo"];
                gvdocente["telefonog", fila].Value = listaacademico.Rows[fila]["telefono"];

                gvdocente["celularg", fila].Value = listaacademico.Rows[fila]["celular"];
                gvdocente["direcciong", fila].Value = listaacademico.Rows[fila]["direccion"];
                gvdocente["mailg", fila].Value = listaacademico.Rows[fila]["mail"];
                gvdocente["curriculumg", fila].Value = listaacademico.Rows[fila]["curriculum"];
                gvdocente["profesiong", fila].Value = listaacademico.Rows[fila]["profesion"];
                gvdocente["especialidadg", fila].Value = listaacademico.Rows[fila]["especialidad"];

                gvdocente["estadog", fila].Value = listaacademico.Rows[fila]["estado"];
                gvdocente["id_personag", fila].Value = listaacademico.Rows[fila]["id_persona"];
                gvdocente["id_contratog", fila].Value = listaacademico.Rows[fila]["id_contrato"];
                
            }

        }

        private void ModificarDocente_Load(object sender, EventArgs e)
        {
            listacargo = objcargo.SeleccionarCargoBss();
            cmbcargosmod.DataSource= objcargo.SeleccionarCargoBss();
            cmbcargosmod.DisplayMember = "cargo";
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string ci="";
            if(rdbcimod.Checked==true)
            {
                if(Validaciones.ci(Txtcimod.Text)==true)
                {
                    ci=Txtcimod.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Introduzca un ci valido o dni cambiando la opcion de tipo de documento", "ERROR DE DATO");
                   Txtcimod.BackColor = Color.Red;
                }

            }
            else
            {
                ci=Txtcimod.Text.ToUpper();
            }
            if (rdbactivomod.Checked == true)
            {
                estadordb = 1;
            }
            else
            {
                estadordb = 0;
            }
            //********************************************
            if (cmbcargosmod.Text != null)
            {
                cmbcargosmod.BackColor = Color.White;

                if (Txtcimod.Text!="")
                {
                    Txtcimod.BackColor = Color.White;
                    if(Validaciones.texto(txtnombremod.Text.ToUpper())==true)
                    {
                        txtnombremod.BackColor = Color.White;
                        if (Validaciones.texto(txtpaternomod.Text.ToUpper()) == true)
                        {
                            txtpaternomod.BackColor = Color.White;
                            if (Validaciones.texto(txtmaternomod.Text.ToUpper()) == true)
                            {
                                txtmaternomod.BackColor = Color.White;
                                if (Validaciones.telefono(txttelefonomod.Text.ToUpper()) == true)
                                {
                                    txttelefonomod.BackColor = Color.White;
                                    if (Validaciones.celular(txtcelularmod.Text.ToUpper()) == true)
                                    {
                                        txtcelularmod.BackColor = Color.White;
                                        if (txtdireccionmod.Text !="")
                                        {
                                            txtdireccionmod.BackColor = Color.White;
                                            if (Validaciones.email(txtmailmod.Text) == true)
                                            {
                                                txtmailmod.BackColor = Color.White;
                                                    if (TxtCurriculummod.Text != "")
                                                    {
                                                        TxtCurriculummod.BackColor = Color.White;
                                                        if (TxtProfesionmod.Text != "")
                                                        {
                                                            TxtProfesionmod.BackColor = Color.White;


                                                            objacademico.CI = ci.ToUpper(); //cargamos el ci para la verificacion si existe pesona ya con ese ci

                                                            objacademico.ID_CARGO = 0;

                                                            objacademico.TELEFONO = 0;
                                                            objacademico.CELULAR = 0;

                                                            objacademico.ID_FACULTAD = 0;
                                                            //ObjContrato.ESTADO = 1;
                                                            if (cix != Txtcimod.Text)
                                                            {
                                                            if (objacademico.SeleccionarContratoCriterioBss().Rows.Count > 0)
                                                            {
                                                                if (MessageBox.Show("Ya existe un academico con el mismo identificador ¿Desea continuar?", "ALERTA DE DUPLICIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                                {
                                                                    objacademico.ID_CARGO = Id_Cargoc;
                                                                    objacademico.CI = Txtcimod.Text.ToUpper();
                                                                    objacademico.NOMBRE = txtnombremod.Text.ToUpper();
                                                                    objacademico.PATERNO = txtpaternomod.Text.ToUpper();
                                                                    objacademico.MATERNO = txtmaternomod.Text.ToUpper();
                                                                    objacademico.TELEFONO = Convert.ToInt32(txttelefonomod.Text);
                                                                    objacademico.CELULAR = Convert.ToInt32(txtcelularmod.Text);
                                                                    objacademico.DIRECCION = txtdireccionmod.Text.ToUpper();
                                                                    objacademico.MAIL = txtmailmod.Text;
                                                                    //modificar esto
                                                                    objacademico.ID_FACULTAD = DAL.Dal_Login.id_facultad;
                                                                    objacademico.ESTADO = estadordb;
                                                                    objacademico.ID_CONTRATO =  Convert.ToInt32(id_contratoc);


                                                                    //esta mal
                                                                    objcurriculum.CURRICULUM = TxtCurriculummod.Text.ToUpper();
                                                                    objcurriculum.PROFESION = TxtProfesionmod.Text.ToUpper();
                                                                    objcurriculum.ESPECIALIDAD = TxtEspecialidadmo.Text.ToUpper();
                                                                    objcurriculum.ID_PERSONA = id_personac;
                                                                    objcurriculum.ModificarCurriculumBss();
                                                                    objacademico.ID_PERSONA = id_personac;
                                                                    objacademico.ModificarContratosBss();

                                                                    txtci.Clear();
                                                                    txtnombre.Clear();
                                                                    txtpaterno.Clear();
                                                                    txtmaterno.Clear();
                                                                    Txtcimod.Clear();
                                                                    txtnombremod.Clear();
                                                                    txtpaternomod.Clear();
                                                                    txtmaternomod.Clear();
                                                                    txttelefonomod.Clear();
                                                                    txtcelularmod.Clear();
                                                                    txtdireccionmod.Clear();
                                                                    txtmailmod.Clear();

                                                                    TxtCurriculummod.Clear();
                                                                    TxtProfesionmod.Clear();
                                                                    TxtEspecialidadmo.Clear();

                                                                    MessageBox.Show("El personal academico fue modificado con exito", "EXITO");

                                                                }
                                                            }
                                                                
                                                            }
                                                            else
                                                            {
                                                                objacademico.ID_CARGO = Id_Cargoc;
                                                                objacademico.CI = Txtcimod.Text.ToUpper();
                                                                objacademico.NOMBRE = txtnombremod.Text.ToUpper();
                                                                objacademico.PATERNO = txtpaternomod.Text.ToUpper();
                                                                objacademico.MATERNO = txtmaternomod.Text.ToUpper();
                                                                objacademico.TELEFONO = Convert.ToInt32(txttelefonomod.Text);
                                                                objacademico.CELULAR = Convert.ToInt32(txtcelularmod.Text);
                                                                objacademico.DIRECCION = txtdireccionmod.Text.ToUpper();
                                                                objacademico.MAIL = txtmailmod.Text;
                                                                //modificar esto
                                                                objacademico.ID_FACULTAD = DAL.Dal_Login.id_facultad;
                                                                objacademico.ESTADO = estadordb;
                                                                objacademico.ID_CONTRATO = Convert.ToInt32(id_contratoc);


                                                                //esta mal
                                                                objcurriculum.CURRICULUM = TxtCurriculummod.Text.ToUpper();
                                                                objcurriculum.PROFESION = TxtProfesionmod.Text.ToUpper();
                                                                objcurriculum.ESPECIALIDAD = TxtEspecialidadmo.Text.ToUpper();
                                                                objcurriculum.ID_PERSONA = id_personac;
                                                                objcurriculum.ModificarCurriculumBss();
                                                                objacademico.ID_PERSONA = id_personac;
                                                                objacademico.ModificarContratosBss();

                                                                txtci.Clear();
                                                                txtnombre.Clear();
                                                                txtpaterno.Clear();
                                                                txtmaterno.Clear();
                                                                Txtcimod.Clear();
                                                                txtnombremod.Clear();
                                                                txtpaternomod.Clear();
                                                                txtmaternomod.Clear();
                                                                txttelefonomod.Clear();
                                                                txtcelularmod.Clear();
                                                                txtdireccionmod.Clear();
                                                                txtmailmod.Clear();

                                                                TxtCurriculummod.Clear();
                                                                TxtProfesionmod.Clear();
                                                                TxtEspecialidadmo.Clear();


                                                                MessageBox.Show("El personal academico fue modificado con exito", "EXITO");


                                                            }
                                                            
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El campo profesion esta vacio", "ERROR DE DATO");
                                                            TxtProfesionmod.BackColor = Color.Red;
                                                            
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El campo curriculum esta vacio", "ERROR DE DATO");
                                                        TxtCurriculummod.BackColor = Color.Red;
                                                    }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El campo mail no esta correctamente llenado ej. correo@servidor.com ", "ERROR DE DATO");
                                                txtmailmod.BackColor = Color.Red;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El campo direccion esta vacio", "ERROR DE DATO");
                                            txtdireccionmod.BackColor = Color.Red;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo celular esta vacio, debe contener solo numeros ej. 76180941", "ERROR DE DATO");
                                        txtcelularmod.BackColor = Color.Red;

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo telefono esta vacio, debe contener solo numeros ej. 66nnnnn", "ERROR DE DATO");
                                    txttelefonomod.BackColor = Color.Red;

                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo apellido materno esta vacio o no contiene solo texto", "ERROR DE DATO");
                                txtmaternomod.BackColor = Color.Red;

                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo apellido paterno  esta vacio o no contiene solo texto", "ERROR DE DATO");
                           txtpaternomod.BackColor = Color.Red;
 
                        }
                    }
                    else
                    {
                       MessageBox.Show("El campo nombre esta vacio o no contiene solo texto", "ERROR DE DATO");
                    txtnombremod.BackColor = Color.Red;
 
                    }
                }
                else
                {
                    MessageBox.Show("Introduzca un ci y seleccione el departamento donde fue emitido", "ERROR DE DATO");
                   Txtcimod.BackColor = Color.Red;
 
                }

            }
            else
            {
                MessageBox.Show("Seleccione un cargo", "ERROR DE DATO");
                cmbcargosmod.BackColor = Color.Red;
            }
        }

        private void cmbcargosmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_Cargoc = Convert.ToInt32(listacargo.Rows[cmbcargosmod.SelectedIndex]["id_cargo"]);
        }

        private void gvdocente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvdocente.Rows[Colorindex].DefaultCellStyle.BackColor = Color.White;
                gvdocente.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                Colorindex = e.RowIndex;

                if (rdbactivo.Checked)
                {
                    rdbactivomod.Checked = true;
                }
                else
                {
                    rdbinactivomod.Checked = true;
                }
                Txtcimod.Text = listaacademico.Rows[e.RowIndex]["ci"].ToString();
                txtnombremod.Text = listaacademico.Rows[e.RowIndex]["nombre"].ToString();
                txtpaternomod.Text = listaacademico.Rows[e.RowIndex]["paterno"].ToString();
                txtmaternomod.Text = listaacademico.Rows[e.RowIndex]["materno"].ToString();
                txttelefonomod.Text = listaacademico.Rows[e.RowIndex]["telefono"].ToString();
                txtcelularmod.Text = listaacademico.Rows[e.RowIndex]["celular"].ToString();
                txtdireccionmod.Text = listaacademico.Rows[e.RowIndex]["direccion"].ToString();
                txtmailmod.Text = listaacademico.Rows[e.RowIndex]["mail"].ToString();
                TxtEspecialidadmo.Text = listaacademico.Rows[e.RowIndex]["especialidad"].ToString();
                TxtCurriculummod.Text = listaacademico.Rows[e.RowIndex]["curriculum"].ToString();
                TxtProfesionmod.Text = listaacademico.Rows[e.RowIndex]["profesion"].ToString();
                cmbcargosmod.Text = listaacademico.Rows[e.RowIndex]["cargo"].ToString();
                id_contratoc = Convert.ToInt32(listaacademico.Rows[e.RowIndex]["id_contrato"]);
                id_personac = Convert.ToInt32(listaacademico.Rows[e.RowIndex]["id_persona"]);
                cix = listaacademico.Rows[e.RowIndex]["ci"].ToString();
            }
            catch (Exception ee)
            {
                Colorindex = 0;
                MessageBox.Show(ee.ToString());
            }
        }

       
        private void cmbcargosmod_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

    }
}
