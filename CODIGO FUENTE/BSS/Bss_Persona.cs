using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Persona:DAL.Dal_Persona
   {


       protected int id_persona;
       protected string ci;
       protected string nombre;
       protected string paterno;
       protected string materno;
       protected int telefono;
       protected int celular;
       protected string direccion;
       protected string mail;
    

      public int ID_PERSONA
      {
          get { return this.id_persona; }
          set { this.id_persona = value; }
      }
      public string CI
      {
          get { return this.ci; }
          set { this.ci = value; }
      }
      public string NOMBRE
      {
          get { return this.nombre; }
          set { this.nombre = value; }
      }
      public string PATERNO
      {
          get { return this.paterno; }
          set { this.paterno = value; }
      }
      public string MATERNO
      {
          get { return this.materno; }
          set { this.materno = value; }
      }
      public int TELEFONO
      {
          get { return this.telefono; }
          set { this.telefono = value; }
      }
      public int CELULAR
      {
          get { return this.celular; }
          set { this.celular = value; }
      }
      public string DIRECCION
      {
          get { return this.direccion; }
          set { this.direccion = value; }
      }
      public string MAIL
      {
          get { return this.mail; }
          set { this.mail = value; }
      }

      

      
     
   }
}
