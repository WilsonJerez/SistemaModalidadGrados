using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Cronograma:DAL.Dal_Cronograma
    {
      protected  int id_cronograma;
      protected int id_modalidad_II;
      protected string fecha;
      protected string descripcion;
      protected int estado;

      public int ID_CRONOGRAMA
      {
          get { return this.id_cronograma; }
          set { this.id_cronograma = value; }
      }
      public int ID_MODALIDAD_II
      {
          get { return this.id_modalidad_II; }
          set { this.id_modalidad_II = value; }
      }
      public string FECHA
      {
          get { return this.fecha; }
          set { this.fecha = value; }
      }
      public string DESCRIPCION
      {
          get { return this.descripcion; }
          set { this.descripcion = value; }
      }
      public int ESTADO
      {
          get { return this.estado; }
          set { this.estado = value; }
      }

      public void InsertarCronogramaBss()
      {
          base.InsertarCronogramaDal(this.ID_MODALIDAD_II, this.FECHA, this.DESCRIPCION, this.ESTADO);
      }
      public DataTable SeleccionarCronogramaCriterioBss()
      {
          return base.SeleccionarCronograma(this.ID_MODALIDAD_II);
      }
      public void ActualizarCronogramaBss()
      {
          base.ActualizarCronogramaDal(this.ID_CRONOGRAMA, this.FECHA, this.DESCRIPCION, this.ESTADO);
      }
      public void ServicioCronogramaBss()
      {
          base.ServicioCronograma();
      }
      public DataTable ReportePresentacionCronogramaParaLaFechaBss()
      {
          return base.ReportePresentacionCronogramaParaLaFechaDal(this.FECHA);
      }

    }
}
