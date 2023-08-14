using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
  public class Bss_TipModalidad:DAL.Dal_TipoModalidad
    {
     protected int id_tipo_modalidad;
     protected string tipo_modalidad;
     protected  string descripcion;
     protected int estado;

     public int ID_TIPO_MODALIDAD
     {
         get { return this.id_tipo_modalidad; }
         set { this.id_tipo_modalidad = value; }
     }
     public string TIPO_MODALIDAD
     {
         get { return this.tipo_modalidad; }
         set { this.tipo_modalidad = value; }
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
     public void InsertarTipoModalidadBss()
     {
         base.InsertarTipoModalidadDal(this.TIPO_MODALIDAD, this.DESCRIPCION, this.ESTADO);
     }
     public DataTable SeleccionarTipoModalidadBss()
     {
         return base.SeleccionarTipoModalidadDal();
     }
     public DataTable SeleccionarTipoModalidadCriterioBss()
     {
         return base.SeleccionarModalidadCriterioDal(this.TIPO_MODALIDAD, this.DESCRIPCION, this.ESTADO);
     }
     public void ActualizarTipoModalidadBss()
     {
         base.ActualizarTipoModalidadDal(this.ID_TIPO_MODALIDAD, this.TIPO_MODALIDAD, this.DESCRIPCION, this.ESTADO);
     }
    }
}
