using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Facultad
    {
        protected void InsertarFacultadDal(string facultad, int estado)
        {
            string cmdsql = "insert into Facultad(facultad,estado) values('" + facultad + "'," + estado + ")";
            Conexion.setdatos(cmdsql);
        }
        protected DataTable SeleccionarFacultadDal()
        {
            string cmdsql = "select * from Facultad";
            return Conexion.getdatos(cmdsql);
        }
        protected DataTable SeleccionarFacultadCriterioDal(int estadoX, string facultadX)
        {
            string cmdsql = "select * from Facultad where ";
            string ByEstado = "";
            string ByFacultad = "";

            if (estadoX == 1)
                ByEstado = " estado=1 ";
            else
                ByEstado = " estado=0 ";
            if (facultadX != "")
                ByFacultad = " and facultad='" + facultadX + "'";

            return Conexion.getdatos(cmdsql + ByEstado + ByFacultad);

        }
        public void ModificarFacultadDal(string facultadX, int estadoX, int id_facultadX)
        {
            string cmdsql = "update Facultad set facultad='" + facultadX + "' ,estado='" + estadoX + "' where id_facultad= '" + id_facultadX + "'";
            Conexion.setdatos(cmdsql);
        }
    }
}
