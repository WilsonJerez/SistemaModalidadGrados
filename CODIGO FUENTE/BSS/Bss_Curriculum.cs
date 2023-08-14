using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
  public  class Bss_Curriculum:DAL.Dal_Curriculum
    {
      int id_curriculm;
      int id_persona;
      string curriculum;
      string profesion;
      string especialidad;

      public int ID_CURRICULUM
      {
          get { return this.id_curriculm; }
          set { this.id_curriculm = value; }
      }
      public int ID_PERSONA
      {
          get { return this.id_persona; }
          set { this.id_persona = value; }
      }
      public string CURRICULUM
      {
          get { return this.curriculum; }
          set { this.curriculum = value; }
      }
      public string PROFESION
      {
          get { return this.profesion; }
          set { this.profesion = value; }
      }
      public string ESPECIALIDAD
      {
          get { return this.especialidad; }
          set { this.especialidad = value; }
      }
      public void InsertarCurriculumBss()
      {
          base.InsertarCurriculumDal(this.ID_PERSONA, this.CURRICULUM, this.PROFESION, this.ESPECIALIDAD);
      }
      public void ModificarCurriculumBss()
      {
          base.ModificarCurriculumDal(this.ID_PERSONA, this.CURRICULUM, this.PROFESION, this.ESPECIALIDAD);
      }
      
    }
}
