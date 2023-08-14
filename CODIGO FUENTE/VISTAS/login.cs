using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Net.NetworkInformation;



namespace VISTAS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        VISTAS.CONFIGURACION.AgregarDireccion agre = new VISTAS.CONFIGURACION.AgregarDireccion();
       

        string ip;
        Ping prueba = new Ping();
        IPStatus status;
        string cadena = @"d:\ModalidadesConfi.txt";

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(cadena);
                ip = sr.ReadToEnd();
                sr.Close();
                if (ip != "")
                {
                    DAL.Conexion.ip = ip;
                    TxtIp.Text = DAL.Conexion.ip;
                    if (prueba.Send(TxtIp.Text, 30).Status == IPStatus.Success)
                    {
                        status = prueba.Send(TxtIp.Text, 30).Status;
                        LblMensaje.Text = "OK";
                        // HABILITAMOS LOS TEXTOS DE ATENTICACION
                        TxtUsusario.ReadOnly = false;
                        TxtPassword.ReadOnly = false;
                    }
                    else
                    {
                        LblMensaje.Text = "ERROR";
                        if (MessageBox.Show("No se puede encontrar el servidor con ip " + TxtIp.Text + " ¿Desea cambiar ip?", "SERVIDOR NO ENCONTRADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            agre.ShowDialog();
                            sr = new StreamReader(cadena);
                            ip = sr.ReadToEnd();
                            sr.Close();
                            DAL.Conexion.ip = ip;
                            // aqui hacer ping y luego mostrar
                            TxtIp.Text = DAL.Conexion.ip;
                            login lo = new login();
                            lo.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            TxtUsusario.Enabled = false;
                            TxtPassword.Enabled = false;
                            button1.Enabled = false;
                        }
                    }
                }
                else
                {
                    agre.ShowDialog();
                    sr = new StreamReader(cadena);
                    ip = sr.ReadToEnd();
                    sr.Close();
                    DAL.Conexion.ip = ip;
                    // aqui hacer ping y luego mostrar
                    TxtIp.Text = DAL.Conexion.ip;

                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("No se pudo encontrar el archivo ModalidadesConfi.txt en la unidad C"+ee.ToString(),"ERROR DE DATO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            agre.ShowDialog();


            StreamReader sr = new StreamReader(cadena);
            ip = sr.ReadToEnd();
            DAL.Conexion.ip = ip;
            sr.Close();

            DAL.Conexion.ip = ip;
            // aqui hacer ping y luego mostrar

            TxtIp.Text = DAL.Conexion.ip;

            //******************************************


            if (ip != "")
            {
                DAL.Conexion.ip = ip;
                TxtIp.Text = DAL.Conexion.ip;
                if (prueba.Send(TxtIp.Text, 30).Status == IPStatus.Success)
                {
                    status = prueba.Send(TxtIp.Text, 30).Status;
                    LblMensaje.Text = "OK";
                    // HABILITAMOS LOS TEXTOS DE ATENTICACION
                    TxtUsusario.ReadOnly = false;
                    TxtPassword.ReadOnly = false;
                }
                else
                {
                    LblMensaje.Text = "ERROR";
                    if (MessageBox.Show("No se puede encontrar el servidor con ip " + TxtIp.Text + " ¿Desea cambiar ip?", "SERVIDOR NO ENCONTRADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        agre.ShowDialog();
                        sr = new StreamReader(cadena);
                        ip = sr.ReadToEnd();
                        sr.Close();
                        DAL.Conexion.ip = ip;
                        // aqui hacer ping y luego mostrar
                        TxtIp.Text = DAL.Conexion.ip;
                        login lo = new login();
                        lo.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        TxtUsusario.ReadOnly = false;
                        TxtPassword.ReadOnly = false;
                        button1.Enabled = false;
                        
                    }
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtusuario = new DataTable();
            string cmdsql = "select Facultad.facultad,Facultad.id_facultad,Usuarios.usuario,Persona.nombre,Persona.paterno,Persona.materno,Persona.id_persona,Usuarios.id_usuario from Usuarios,Facultad,Persona where Usuarios.usuario='" + TxtUsusario.Text.ToUpper() + "' and Usuarios.contraseña='" + TxtPassword.Text.ToUpper() + "' and Usuarios.estado=1 and Persona.id_persona=Usuarios.id_persona and Facultad.id_facultad=Usuarios.id_facultad";
            dtusuario = DAL.Conexion.getdatos(cmdsql);
            
            if (dtusuario.Rows.Count > 0)
            {

                if (TxtUsusario.Text.ToUpper() == TxtPassword.Text.ToUpper())
                {
                    MessageBox.Show("Se recomienda cambiar la contraseña por seguridad", "SUGERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Form1 sis = new Form1();
                sis.Text ="SIS ADM MODALIDADES  COORDINADOR:"+ dtusuario.Rows[0]["nombre"] + "  " + dtusuario.Rows[0]["paterno"] + "  " + dtusuario.Rows[0]["materno"]+"  FACULTAD: "+dtusuario.Rows[0]["facultad"];
                DAL.Dal_Login.id_facultad =Convert.ToInt32(dtusuario.Rows[0]["id_facultad"]);
                DAL.Dal_Login.facultad = dtusuario.Rows[0]["facultad"].ToString();
                DAL.Dal_Login.coordinador = dtusuario.Rows[0]["nombre"].ToString() + " " + dtusuario.Rows[0]["paterno"].ToString() + " " + dtusuario.Rows[0]["materno"].ToString();
                DAL.Dal_Login.id_persona =Convert.ToInt32(dtusuario.Rows[0]["id_persona"].ToString());
                DAL.Dal_Login.id_usuario = Convert.ToInt32(dtusuario.Rows[0]["id_usuario"].ToString());
                this.Visible = false;
                sis.ShowDialog();
                this.Close();
                
                
                
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no son correctos", "ERROR DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
       
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                

                DataTable dtusuario = new DataTable();
                string cmdsql = "select Facultad.facultad,Facultad.id_facultad,Usuarios.usuario,Persona.nombre,Persona.paterno,Persona.materno,Persona.id_persona,Usuarios.id_usuario from Usuarios,Facultad,Persona where Usuarios.usuario='" + TxtUsusario.Text.ToUpper() + "' and Usuarios.contraseña='" + TxtPassword.Text.ToUpper() + "' and Usuarios.estado=1 and Persona.id_persona=Usuarios.id_persona and Facultad.id_facultad=Usuarios.id_facultad";
                dtusuario = DAL.Conexion.getdatos(cmdsql);

                if (dtusuario.Rows.Count > 0)
                {
                    if (TxtUsusario.Text.ToUpper() == TxtPassword.Text.ToUpper())
                    {
                        MessageBox.Show("Se recomienda cambiar la contraseña por seguridad", "SUGERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Form1 sis = new Form1();
                    sis.Text = "SIS ADM MODALIDADES  COORDINADOR:" + dtusuario.Rows[0]["nombre"] + "  " + dtusuario.Rows[0]["paterno"] + "  " + dtusuario.Rows[0]["materno"] + "  FACULTAD: " + dtusuario.Rows[0]["facultad"];
                    DAL.Dal_Login.id_facultad = Convert.ToInt32(dtusuario.Rows[0]["id_facultad"]);
                    DAL.Dal_Login.facultad = dtusuario.Rows[0]["facultad"].ToString();
                    DAL.Dal_Login.coordinador = dtusuario.Rows[0]["nombre"].ToString() + " " + dtusuario.Rows[0]["paterno"].ToString() + " " + dtusuario.Rows[0]["materno"].ToString();
                    DAL.Dal_Login.id_persona = Convert.ToInt32(dtusuario.Rows[0]["id_persona"].ToString());
                    DAL.Dal_Login.id_usuario = Convert.ToInt32(dtusuario.Rows[0]["id_usuario"].ToString());
                    this.Visible = false;
                    sis.ShowDialog();
                    this.Close();



                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no son correctos", "ERROR DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }

        }

      

        

        
    }
}
