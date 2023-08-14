using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BSS
{
   public class Bss_Contrato:Bss_Persona
    {
       int id_contrato;
       int id_persona;
       int id_cargo;
       int estado;
       int id_facultad;

       public int ID_CONTRATO
       {
           get { return this.id_contrato; }
           set { this.id_contrato = value; }
       }
       public int ID_PERSONA
       {
           get { return this.id_persona; }
           set { this.id_persona = value; }
       }
       public int ID_CARGO
       {
           get { return this.id_cargo; }
           set { this.id_cargo = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }
       public int ID_FACULTAD
       {
           get { return this.id_facultad; }
           set { this.id_facultad = value; }
       }

       public int InsertarContratoBss()
       {
          return base.InsertarContratoDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL,this.ID_FACULTAD, this.ID_CARGO, this.ESTADO);

       }
       public DataTable SeleccionarContratoBss()
       {
           return base.SeleccionarContratoDal();
       }
       public DataTable SeleccionarContratoCriterioBss()
       {
           return base.SeleccionarContratoCriterioDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL, this.ID_CARGO, this.ESTADO);
       }
       public DataTable TutoresSinTutorias()
       {
           return base.TutoresSinTutoriasDal();
       }
       public DataTable TutoresConTutoriasBss()
       {
           return base.TutoresConTutoriasDal();
       }
       public void ModificarContratosBss()
       {
           base.ModificarContratosDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL, this.ID_FACULTAD, this.ID_CARGO, this.ESTADO, this.ID_PERSONA);
       }
       public DataTable SeleccionarContratoPorIdBss()
       {
           return base.SeleccionarContratoPorId(this.ID_CONTRATO);
       }

    }
}
