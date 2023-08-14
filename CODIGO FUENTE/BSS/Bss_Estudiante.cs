using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Estudiante:Bss_Persona
    {
       protected int id_estudiante;
       protected int id_persona_estudiante;
       protected int id_carrera;
       protected int estado;

       public int ID_ESTUDIANTE
       {
           get { return this.id_estudiante; }
           set { this.id_estudiante = value; }

       }
       public int ID_PERSONA_ESTUDIANTE
       {
           get { return this.id_persona_estudiante; }
           set { this.id_persona_estudiante = value; }
       }
       public int ID_CARRERA
       {
           get { return this.id_carrera; }
           set { this.id_carrera = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado= value; }
       }


       public void InsertarEstudianteBss()
       {
           base.InsertarEstudianteDal(base.CI,base.NOMBRE,base.PATERNO,base.MATERNO,base.TELEFONO,base.CELULAR,base.DIRECCION,base.MAIL,this.ID_CARRERA,this.ESTADO);
       }
       public DataTable SeleccionarEstudianteCriterioBss()
       {
           return base.SeleccionarEstudianteCriterioDal(this.ID_PERSONA, base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.MAIL, this.ID_CARRERA, this.ESTADO);
       }     
       public void ModificarEstudianteBss()
       {
           base.ModificarEstudianteDal(base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.DIRECCION, base.MAIL, this.ID_CARRERA, this.ESTADO, this.ID_PERSONA);
       }
       public DataTable SeleccionarEstudiantexCriterios2Bss()
       {
           return base.SeleccionarEstudiantexcriteriosDal(this.ID_PERSONA,base.CI, base.NOMBRE, base.PATERNO, base.MATERNO, base.TELEFONO, base.CELULAR, base.MAIL, this.ID_CARRERA, this.ESTADO);
       }
       public DataTable FiltrarEstudiantesHabilitadosParaRepetirModalidadBss()
       {
           return base.FiltrarEstudiantesHabilitadosParaRepetirModalidadDal(this.CI, this.NOMBRE, this.PATERNO, this.MAIL);
       }
       public DataTable FiltrarEstudianteSegundaCarreraBss()
       {
           return base.FiltrarEstudiantesSegundaCarreraDal(base.CI,base.NOMBRE,base.PATERNO,base.MATERNO);
       }
       public void InsertarEstudianteSegundaCarreraBss()
       {
           base.InsertarEstudianteSegundaCarreraDal(this.ID_PERSONA, this.ID_CARRERA, this.ESTADO);
       }
       public void ModificarCarreraEstudianteBss()
       {
           base.ModificarCarreraEstudianteDal(this.ID_ESTUDIANTE, this.ID_CARRERA);
       }
    }
}