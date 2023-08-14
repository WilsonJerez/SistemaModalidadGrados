using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Turno:DAL.Dal_Turno
    {
      protected int id_turno;
      protected string turno;
      protected string hora_inicio;
      protected string hora_final;
      protected int estado;

      public int ID_TURNO
      {
          get { return this.id_turno; }
          set { this.id_turno = value; }
      }
      public string TURNO
      {
          get { return this.turno; }
          set { this.turno = value; }
      }
      public string HORA_INICIO
      {
          get { return this.hora_inicio; }
          set { this.hora_inicio = value; }
      }
      public string HORA_FINAL
      {
          get { return this.hora_final; }
          set { this.hora_final = value; }
      }
      public int ESTADO
      {
          get { return this.estado; }
          set { this.estado = value; }
      }

      public void InsertarTurnoBss()
      {
          base.InsertarTurnoDal(this.TURNO, this.HORA_INICIO, this.HORA_FINAL, this.ESTADO);
      }
      public DataTable SeleccionarTurnoBss()
      {
          return base.SeleccionarTurnoDal();
      }
      public DataTable SeleccionarTurnoCriterioBss()
      {
          return base.SeleccinarTurnoCriterioDal(this.TURNO, this.HORA_INICIO, this.HORA_FINAL, this.ESTADO);
      }
      public void ActualizarTurnoBss()
      {
         base.ActualizarTurnoDal(this.ID_TURNO, this.TURNO, this.HORA_INICIO, this.HORA_FINAL, this.ESTADO);
      }
    }
}
