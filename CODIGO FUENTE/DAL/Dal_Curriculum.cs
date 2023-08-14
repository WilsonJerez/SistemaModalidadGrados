using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
  public  class Dal_Curriculum
    {
      protected void InsertarCurriculumDal(int id_personaX, string curriculumX, string profesionX, string especialidadX)
      {
          string cmdsql = "insert into Curriculum(id_persona,curriculum,profesion,especialidad) values (" + id_personaX + ",'" + curriculumX + "','" + profesionX + "','" + especialidadX + "')";
          Conexion.setdatos(cmdsql);
      }
      protected DataTable SeleccionarCurriculumDal()
      {
          string cmdsql = "select * from curriculum where estado=1";
         return Conexion.getdatos(cmdsql);
      }
      public void ModificarCurriculumDal(int id_personaX, string curriculumX, string profesionX, string especialidadX)
      {
          string cmdsql = "update Curriculum set curriculum='" + curriculumX + "', profesion='" + profesionX + "',especialidad='" + especialidadX + "' where id_persona= '" + id_personaX + "'";
          Conexion.setdatos(cmdsql);

      }
    }
}
