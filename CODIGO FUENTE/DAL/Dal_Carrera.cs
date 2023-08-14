using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Carrera
    {
       protected void InsertarCarreraDal(int id_facultadX, string carrera, int estado)
       {
           string cmdsql = "insert into Carrera (id_facultad,carrera,estado) values (" + id_facultadX + ",'" + carrera + "'," + estado + ")";
           Conexion.setdatos(cmdsql);
       }
       protected DataTable SeleccionarCarreraDal()
       {
           string cmdsql = "select * from Carrera";
          return Conexion.getdatos(cmdsql);
       }
       protected DataTable SeleccionarCarreraCriterioDal(int id_facultadX, string carreraX, int estadoX)
       {
           string cmdsql = "select Carrera.id_carrera, Carrera.id_facultad,Carrera.carrera, Carrera.estado from Carrera where ";
           string ByEstado = "";
           string ByCarrera = "";
           string ByIdFacultad = "";
           if (estadoX == 1)
               ByEstado = " Carrera.estado=1 ";
           else
               ByEstado = " Carrera.estado=0";
           if (carreraX != null)
               ByCarrera = " and Carrera.carrera='" + carreraX + "'";
           if (id_facultadX != 0)
               ByIdFacultad = " and Carrera.id_facultad=" + id_facultadX;

           return Conexion.getdatos(cmdsql + ByEstado + ByCarrera + ByIdFacultad);
       }
       public void ModificarCarreraDal(string carreraX, int id_facultadX, int estadoX, int id_carreraX)
       {
           string cmdsql = "update Carrera set carrera='" + carreraX + "' ,id_facultad='" + id_facultadX + "' ,estado= '" + estadoX + "' where id_carrera= '" + id_carreraX + "'";
           Conexion.setdatos(cmdsql);
       }
    }
}
