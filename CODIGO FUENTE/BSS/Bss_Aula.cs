using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
  public  class Bss_Aula:DAL.Dal_Aula
    {
        protected string n_aula;
      protected int capacidad;
      protected int piso;
      protected int disponible;
      protected int estado;
      protected int id_aula;

      public int ID_AULA
      {
          get { return id_aula; }
          set { id_aula = value; }
      }

      public string N_AULA
      {
          get { return this.n_aula; }
          set { this.n_aula = value; }
      }
      public int CAPACIDAD
      {
          get { return this.capacidad; }
          set { this.capacidad = value; }
 
      }
      public int PISO
      {
          get { return this.piso; }
          set { this.piso = value; }
      }
      public int DISPONIBLE
      {
          get { return this.disponible; }
          set { this.disponible = value; }
      }
      public int ESTADO
      {
          get { return this.estado; }
          set { this.estado = value; }
      }
      public void InsertarAulaBss()
      {
          base.InsertarAulaDal(this.N_AULA, this.CAPACIDAD, this.PISO, this.DISPONIBLE, this.ESTADO);
      }
      public DataTable SeleccionarAulaBss()
      {
          return base.SeleccionarAulaDal();
      }
      public DataTable SeleccionarAulaCriterioBss()
      {
          return base.SeleccionarAulaCriterioDal(this.N_AULA, this.CAPACIDAD, this.PISO, this.DISPONIBLE, this.ESTADO);
      }
      public void ModificarAulasBss()
      {
          base.ModificarAulasDal(this.N_AULA, this.CAPACIDAD, this.PISO, this.ID_AULA,this.ESTADO);
      }
      public DataTable ReporteAulaBss(int DefCapacidad)
      {
          return base.ReporteAulas(this.PISO, this.CAPACIDAD, this.ESTADO, DefCapacidad);
      }

    }
}
