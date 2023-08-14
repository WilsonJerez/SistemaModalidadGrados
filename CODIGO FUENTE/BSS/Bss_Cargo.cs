using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BSS
{
  public  class Bss_Cargo:DAL.Dal_Cargo
    {
     protected int id_cargo;
     protected string cargo;
      protected string descripcion;
     protected int estado;

     public int ID_CARGO
     {
         get { return this.id_cargo; }
         set { this.id_cargo = value; }
     }
     public string CARGO
     {
         get { return this.cargo; }
         set { this.cargo = value; }
     }
      public string DESCRIPCION
      {
          get{return this.descripcion;}
          set{this.descripcion=value;}
      }
     public int ESTADO
     {
         get { return this.estado; }
         set { this.estado = value; }
     }

     public void InsertarCargoBss()
     {
         base.InsertarCargoDal(this.CARGO,this.DESCRIPCION,this.ESTADO);
     }
     public DataTable SeleccionarCargoBss()
     {
         return base.SeleccionarCargoDal();
     }
     public DataTable SeleccionarCargoCriterioBss()
     {
         return base.SeleccionarCargoCriterioDal(this.cargo, this.estado);
     }
     public void ModificarCargoBss()
     {
         base.ModificarCargoDal(this.CARGO, this.DESCRIPCION, this.ID_CARGO,this.ESTADO);
     }
    }
}
