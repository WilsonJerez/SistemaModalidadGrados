using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
  public  class Dal_Contrato
    {
      public void InsertarContratoDal(int id_personaX, int id_cargoX, int estadoX)
      {
          string cmdsql = "insert into Contrato(id_persona,id_cargo,estado) values (" + id_personaX + "," + id_cargoX + "," + estadoX + ")";
          Conexion.setdatos(cmdsql);
      }
    }
}
