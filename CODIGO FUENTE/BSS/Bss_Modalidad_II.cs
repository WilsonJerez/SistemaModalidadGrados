using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Modalidad_II:DAL.Dal_Modalidad_II
    {
       protected int id_modalidad_II;
       protected int id_contrato;
       protected int id_modalidad_I;
       protected string fecha_inscripcion;
       protected int estado;

       public int ID_MODALIDAD_II
       {
           get { return this.id_modalidad_II; }
           set { this.id_modalidad_II = value; }
       }
       public int ID_CONTRATO
       {
           get { return this.id_contrato; }
           set { this.id_contrato = value; }
       }
       public int ID_MODALIDAD_I
       {
           get { return this.id_modalidad_I; }
           set { this.id_modalidad_I = value; }
       }
       public string FECHA_INSCRIPCION
       {
           get { return this.fecha_inscripcion; }
           set { this.fecha_inscripcion = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }

       public void InsertarModalidadIIBss()
       {
           base.InsertarModalidad_IIDal(this.ID_MODALIDAD_I, this.ID_CONTRATO,this.FECHA_INSCRIPCION, this.ESTADO);
       }
       public DataTable SeleccionarModalidad_IIBss()
       {
           return base.SeleccionarModalidad_IIDal();
       }
       public DataTable SeleccionarModalidadIICulminoCronogramaBss()
       {
           return base.SeleccionarModalidadIICulminoCronogramaDal();
       }
       public DataTable SeleccionarModalidad_IIRepitentesBss()
       {
           return base.SeleccionarModalidad_IIRepitentesDal();
       }
       public DataTable SeleccionarModalidad_IICronogramaPendienteBss()
       {
           return base.SeleccionarModalidad_IICronogramaPendienteDal();
       }
       public DataTable SeleccionarModalidad_IICriterioBss(string nombreX, string paternoX, string maternoX, string ciX)
       {
           return base.SeleccionarModaliad_IIPorCriterio(nombreX, paternoX, maternoX, ciX, this.ESTADO);
       }
       public DataTable SeleccionarModIIPorIdModIBss()
       {
          return  base.SeleccionarModIIPorIdModIDal(this.ID_MODALIDAD_I);
       }
       public DataTable SeleccionarModalidad_IICriterioSinDefenzaBss(string nombreX, string paternoX, string maternoX, string ciX)
       {
           return base.SeleccionarModaliad_IIPorCriterioSinDefenza(nombreX, paternoX, maternoX, ciX, this.ESTADO);
       }
       public void ActualizarModalidadIIBss()
       {
           base.ActualizarModalidadIIDal(this.ID_MODALIDAD_II, this.ID_CONTRATO);

       }
       public void ServicioMOdalidadIIBss()
       {
           base.ServicioModalidadII();
       }
       public DataTable ReporteModalidadIIPortutorBss()
       {
          return  base.ReporteModalidadIIPorTutor(this.id_contrato);
       }
       public DataTable ReporteEtudiantesSinProgramarDefensasModIIBss()
       {
           return base.ReporteEtudiantesSinProgramarDefensasModIIDal();
       }
       public DataTable ReporteEstudiantesSinCronogramaBss()
       {
           return base.ReporteEstudiantesSinCronogramaDal();
       }
       public DataTable SeleccionarHabilitadosModIIIBss(string ciX, string nombreX, string paternoX, string maternoX)
       {
           return base.SeleccionarHabilitadosModIIIDal(ciX,nombreX,paternoX,maternoX);
       }
    }
}
