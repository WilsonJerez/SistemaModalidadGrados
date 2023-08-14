using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Asigna
    {
        public void InsertarAsignaDal(int id_grupoX, int id_modalidad_IX, int estadoX)
        {
            string cmdsql = "isert into Asigna (id_grupo,id_modalidad_I,estado) values (" + id_grupoX + "," + id_modalidad_IX + "," + estadoX + ")";
            Conexion.setdatos(cmdsql);
        }
    }
}
