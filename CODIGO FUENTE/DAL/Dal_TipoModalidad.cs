using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAL
{
   public class Dal_TipoModalidad
    {
      protected void InsertarTipoModalidadDal(string tipo_modalidadX, string descripcionX, int estadoX)
       {
           string cmdsql = "insert into Tipo_Modalidad(tipo_modalidad,descripcion,estado) values ('" + tipo_modalidadX + "','" + descripcionX + "'," + estadoX + ")";
           Conexion.setdatos(cmdsql);
       }
       protected DataTable SeleccionarTipoModalidadDal()
       {
           string cmdsql = "select * from Tipo_Modalidad";
           return Conexion.getdatos(cmdsql);
       }
       protected DataTable SeleccionarModalidadCriterioDal(string tipo_modalidadX, string descripcionX, int estadoX)
       {
           string cmdsql = "select * from Tipo_Modalidad where ";
           string Byestado = "";
           string ByTipoModalidad = "";
           string ByDescripcion = "";

           if (estadoX == 0)
               Byestado = " estado=0 ";
           else
               Byestado = " estado=1 ";

           if (tipo_modalidadX != null)
               ByTipoModalidad = " and tipo_modalidad='" + tipo_modalidadX + "'";
           if (descripcionX != null)
               ByDescripcion = " and descripcion='" + descripcionX + "'";

           return Conexion.getdatos(cmdsql + Byestado + ByTipoModalidad + ByDescripcion);
       }
       protected void ActualizarTipoModalidadDal(int id_tipo_modalidadX, string tipo_modalidadX, string descripcionX, int estadoX)
       {
           string cmdsql = " update Tipo_Modalidad set tipo_modalidad='" + tipo_modalidadX + "', descripcion='" + descripcionX + "', estado=" + estadoX + " where id_tipo_modalidad=" + id_tipo_modalidadX;
           Conexion.setdatos(cmdsql);
       }

    }
}
