using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAL
{
    public static class Conexion
    {
       public static string ip;       

        
        public static void setdatos(string cmdsqlX)
       {
           string cadenaconexion = @"Data Source=" + ip + ",1433;Network Library=DBMSSOCN;Initial Catalog=Modalidades;User ID=coordinador;Password=coordinador123";
           SqlHelper.ExecuteNonQuery(cadenaconexion, CommandType.Text, cmdsqlX);           
        }
        public static DataTable getdatos(string cmdsqlX)
        {
            
            string cadenaconexion = @"Data Source="+ip+",1433;Network Library=DBMSSOCN;Initial Catalog=Modalidades;User ID=coordinador;Password=coordinador123";
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(cadenaconexion, CommandType.Text, cmdsqlX);
            return ds.Tables[0];
        }
    }
}