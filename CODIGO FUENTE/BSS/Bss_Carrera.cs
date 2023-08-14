using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Carrera:DAL.Dal_Carrera
    {
       protected int id_carrera;
       protected string carrera;
       protected int id_facultad;
       protected int estado;

       public string CARRERA
       {
           get { return this.carrera; }
           set { this.carrera = value; }
       }
       public int ID_FACULTAD
       {
           get { return this.id_facultad; }
           set { this.id_facultad = value; }
       }
       public int ID_CARRERA
       {
           get { return this.id_carrera; }
           set { this.id_carrera = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }
       public void InsertarCarreraBss()
       {
           base.InsertarCarreraDal(this.ID_FACULTAD, this.CARRERA, this.ESTADO);
       }
       public DataTable SeleccionarCarreraBss()
       {
           return base.SeleccionarCarreraDal();
       }
       public DataTable SeleccionarCarreraCriterioBss()
       {
           return base.SeleccionarCarreraCriterioDal(this.ID_FACULTAD, this.CARRERA, this.ESTADO);
       }
       public void ModificarCarreraBss()
       {
           base.ModificarCarreraDal(this.CARRERA, this.ID_FACULTAD, this.ESTADO, this.ID_CARRERA);
       }
    }
}
