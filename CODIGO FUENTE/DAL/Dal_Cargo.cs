using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Cargo
    {
        protected void InsertarCargoDal(string cargoX, string descripcionX, int estadoX)
        {
            string cmdsql = "insert into Cargo (cargo,descripcion,estado) values ('" + cargoX + "','" + descripcionX + "'," + estadoX + ")";
            Conexion.setdatos(cmdsql);
        }
        protected DataTable SeleccionarCargoDal()
        {
            string cmdsql = "select * from Cargo where estado=1";
            return Conexion.getdatos(cmdsql);
        }
        protected DataTable SeleccionarCargoCriterioDal(string cargoX, int estadoX)
        {
            string cmdsql = "select * from Cargo where";
            string ByEstado = "";
            string ByCargo = "";

            if (estadoX == 0)
                ByEstado = " estado=0";
            else
                ByEstado = " estado=1";
            if (cargoX != null & cargoX !="")
                ByCargo = " and cargo='" + cargoX + "'";

            return Conexion.getdatos(cmdsql + ByEstado + ByCargo);


        }
        public void ModificarCargoDal(string cargoX, string descripcionX, int id_cargoX,int estadoX)
        {
            string cmdsql = "update Cargo set cargo='" + cargoX + "' ,descripcion='" + descripcionX +"' ,estado='"+estadoX+ "' where id_cargo= '" + id_cargoX + "'";
            Conexion.setdatos(cmdsql);
        }
        
    }
}
