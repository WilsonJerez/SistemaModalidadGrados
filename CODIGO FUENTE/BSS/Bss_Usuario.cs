using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Usuario:Bss_Persona
    {
        protected int id_facultad;
        protected string usuario;
        protected string contraseña;
        protected int estado;
       protected int id_usuario;
       protected int id_persona;

        public int ID_FACULTAD
        {
            set { this.id_facultad = value; }
            get { return this.id_facultad; }
        }
        public string USUARIO
        {
            set { this.usuario = value; }
            get { return this.usuario; }
        }
        public string CONTRASEÑA
        {
            set { this.contraseña = value; }
            get { return this.contraseña; }
        }
        public int ESTADO
        {
            set { this.estado = value; }
            get { return this.estado; }
        }
        public int ID_USUARIO
        {
            get { return this.id_usuario; }
            set { this.id_usuario = value; }
        }
        public int ID_PERSONA
        {
            get { return this.id_persona; }
            set { this.id_persona = value; }
        }
        public DataTable SeleccionarUsuarioSistemaBss()
        {
            return base.SeleccionarUsuarioSistemaDal(this.ID_USUARIO);
        }
        public void InsertarUsuarioSistemaBss()
        {
            base.InsertarUsuarioSistemaDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL, this.ID_FACULTAD, this.USUARIO, this.CONTRASEÑA, this.ESTADO);
        }
        public void ModificarDatosPersonalesUsuarioSistemaBss()
        {
            base.ModificarDatosPersonalesUsuarioSistemaDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL);
        }
        public void ModificarContraseñaUsuarioSistemaBss()
        {
            base.ModificarContraseñaUsuarioSistemaDal(this.ID_USUARIO, this.CONTRASEÑA);
        }
    }
}
