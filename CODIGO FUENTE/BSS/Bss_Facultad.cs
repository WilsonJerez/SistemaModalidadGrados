using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Facultad:DAL.Dal_Facultad
    {
       protected int id_facultad;
       protected string facultad;
       protected int estado;

       public int ID_FACULTAD
       {
           get { return this.id_facultad; }
           set { this.id_facultad = value; }
       }
       public string FACULTAD
       {
           get { return this.facultad; }
           set { this.facultad = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }

       public void InsertarFacultadBss()
       {
           base.InsertarFacultadDal(this.facultad, this.estado);
       }
       public DataTable SeleccionarFacultadBss()
       {
           return base.SeleccionarFacultadDal();
       }
       public DataTable SeleccionarFacultadCriterioBss()
       {
          return base.SeleccionarFacultadCriterioDal(this.estado,this.FACULTAD);
       }
       public void ModificarFacultadBss()
       {
           base.ModificarFacultadDal(this.FACULTAD, this.ESTADO, this.ID_FACULTAD);
       }
    }
}
