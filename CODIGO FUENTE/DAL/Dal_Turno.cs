using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Turno
    {
       protected void InsertarTurnoDal(string turnoX, string horaInicioX, string horaFinalX, int estadoX)
       {
           string cmdsql = "insert into Turno(turno,hora_inicio,hora_final,estado) values('" + turnoX + "','" + horaInicioX + "','" + horaFinalX + "'," + estadoX + ")";
           Conexion.setdatos(cmdsql);
       }
       protected DataTable SeleccionarTurnoDal()
       {
           string cmdsql = "select * from Turno";
           return Conexion.getdatos(cmdsql);
       }
       protected DataTable SeleccinarTurnoCriterioDal(string turnoX, string horaInicioX, string horaFinalX, int estadoX)
       {
           string cmdsql = "select * from Turno where";
           string ByEstado = "";
           string ByTurno = "";
           string ByHoraInicio = "";
           string ByHoraFinal = "";

           if (estadoX == 0)
               ByEstado = " estado=0";
           else
               ByEstado = " estado=1";
           if (turnoX != null)
               ByTurno = " and turno='" + turnoX + "'";
           if (horaInicioX != null)
           
               ByHoraInicio = " and hora_inicio='" + horaInicioX + "'";
           if (horaFinalX != null)
               ByHoraFinal = " and hora_final='" + horaFinalX + "'";

           return Conexion.getdatos(cmdsql + ByEstado + ByTurno + ByHoraInicio + ByHoraFinal);
           
       }
       protected void ActualizarTurnoDal(int id_turnoX, string turnoX, string hora_inicioX, string hora_finalX, int estado)
       {
           string cmdsql="update Turno set turno='"+turnoX+"', hora_inicio='"+hora_inicioX+"', hora_final='"+hora_finalX+"',estado="+estado+" where id_turno="+id_turnoX;
           Conexion.setdatos(cmdsql);
       }
    }
}
