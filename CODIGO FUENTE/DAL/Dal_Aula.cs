using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Aula
    {
        protected void InsertarAulaDal(string nroaulaX, int capacidadX, int pisoX, int disponibleX, int estado)
        {
            string cmdsql = "insert into Aula (n_aula,capacidad,piso,disponible,estado) values ('" + nroaulaX + "'," + capacidadX + "," + pisoX + "," + disponibleX + "," + estado + ")";
            Conexion.setdatos(cmdsql);
        }
        protected DataTable SeleccionarAulaDal()
        {
            string cmdsql = "select * from Aula where estado=1";
            return Conexion.getdatos(cmdsql);
        }
        protected DataTable SeleccionarAulaCriterioDal(string nroaulaX, int capacidadX, int pisoX, int disponibleX, int estado)
        {
            string cmdsql = "select * from Aula where ";
            string ByN_aula = "";
            string ByCapacidad = "";
            string ByPiso = "";
            string ByEstado = "";
            string ByDisponible = "";

            if (estado == 0)
                ByEstado = " estado=0 ";
            else
                ByEstado = " estado= 1";
            if (nroaulaX != "" & nroaulaX !=null)
                ByN_aula = " and n_aula='" + nroaulaX + "'";

            if (capacidadX > 0)
                ByCapacidad = " and capacidad=" + capacidadX;
            if (pisoX > 0)
                ByPiso = " and piso=" + pisoX;
            if (disponibleX > 0)
                ByDisponible = " and disponible=" + disponibleX;

            return Conexion.getdatos(cmdsql + ByEstado + ByN_aula + ByCapacidad + ByPiso + ByDisponible);
        }
        public void ModificarAulasDal(string nroaulaX, int capacidadX, int pisoX, int id_aulaX,int estadoX)
        {
            string cmdsql = "update Aula set n_aula='" + nroaulaX + "' ,capacidad='" + capacidadX + "' ,piso= '" + pisoX + "' ,estado= '" + estadoX + "' where id_aula= '" + id_aulaX + "'";
            Conexion.setdatos(cmdsql);
        }

        protected DataTable ReporteAulas(int pisoX, int capacidadX, int estadoX,int DefCapacidad)
        {
            string cmdql = "select * from Aula where";
            string ByEstado = "";
            string ByPiso = "";
            string ByCapacidad = "";

            if (estadoX == 1)
                ByEstado = " estado=" + estadoX;
            else
                ByEstado=" estado=0";

            if (pisoX > 0)
                ByPiso = " and piso=" + pisoX;
            if (DefCapacidad == 0)
                ByCapacidad = " and capacidad>" + capacidadX;
            else
                ByCapacidad = " and capacidad<" + capacidadX;

            return Conexion.getdatos(cmdql + ByEstado + ByPiso + ByCapacidad+" order by piso");

        }
    }
}
