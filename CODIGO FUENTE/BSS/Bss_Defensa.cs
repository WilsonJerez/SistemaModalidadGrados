using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Defensa:DAL.Dal_Tribunal
    {
       protected int id_defensa;
       protected  int id_modalidad_I;
       protected int id_modalidad_II;
       protected int id_mod_III;
       protected int id_aula;
       protected string fecha;
       protected string hora;
       protected int nota;
       protected string nro_acta;
       protected int estado;

       public int ID_DEFENSA
       {
           get { return this.id_defensa; }
           set { this.id_defensa = value; }
       }
       public int ID_MODALIDAD_I
       {
           get { return this.id_modalidad_I; }
           set { this.id_modalidad_I = value; }
       }
       public int ID_MODALIDAD_II
       {
           get { return this.id_modalidad_II; }
           set{this.id_modalidad_II=value;}
       }
       public int ID_AULA
       {
           get { return this.id_aula; }
           set { this.id_aula = value; }
       }
       public string FECHA
       {
           get { return this.fecha; }
           set { this.fecha = value; }
       }
       public string HORA
       {
           get { return this.hora; }
           set { this.hora = value; }
       }
       public int NOTA
       {
           get { return this.nota; }
           set { this.nota = value; }
       }
       public string NRO_ACTA
       {
           get { return this.nro_acta; }
           set { this.nro_acta = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }
       public int ID_MOD_III
       {
           get { return this.id_mod_III; }
           set { this.id_mod_III = value; }
       }

       public DataTable SeleccionarDefensaCriterioBss()
       {
          return base.SeleccionarDefensaCriteriodal(this.ID_MODALIDAD_I, this.ID_MODALIDAD_II, this.ID_AULA, this.FECHA, this.HORA, this.ESTADO);
       }
       public int ContarDefensasDeModalidadIBss()
       {
           return base.ContarDefensasDeModalidadIDal(this.ID_MODALIDAD_I);
       }
       //FUNCION QUE RECIBE LOS PARAMETROS DE UNA PARTE EXTERNA YA QUE SON NECESARIOS PARA UNA FILTRACION POR DATOS PERSONALES
       public DataTable SeleccionarDefensaCriterioBss(string nombreX, string paternoX, string maternoX, int ciX,int swicht,int mod)
       {
           return base.SeleccionarDefensaCriterioDal(nombreX,paternoX,maternoX,ciX,this.FECHA,swicht,mod);
       }
       public void ActualizarDefensaBss()
       {
           base.ActualizarDefensaDal(this.ID_DEFENSA,this.ID_MODALIDAD_I,this.ID_MODALIDAD_II,this.ID_AULA,this.FECHA,this.HORA,this.NOTA,this.NRO_ACTA,this.ESTADO);
       }
       public void ServicioDefensaBss()
       {
           base.ServicioDefensaI();
       }
       public DataTable ReporteEstudiantesGraduadosRangoFechasBss(string fecha1X,string Fecha2X)
       {
           return base.ReporteEstudiantesGraduadosRangoFechasDal(fecha1X, Fecha2X);
       }
       public DataTable VerificarNroActaBss()
       {
           return base.VerificarNroActaDal(this.NRO_ACTA);
       }
       public DataTable ReporteDefensasParaHoyBss()
       {
           return base.ReporteDefensasParaHoyDal(this.FECHA);
       }
       public DataTable ReporteDefensasParaHoyModalidadIIBss()
       {
           return base.ReporteDefensasParaHoyModalidadIIDal(this.FECHA);
       }
       public DataTable ReporteDefensasModIPendientesDeNotasBss()
       {
           return base.ReporteDefensasModIPendientesDeNotasDal();
       }
       public DataTable ReporteDefensaModIIPendientesDeNotasBss()
       {
           return base.ReporteDefensaModIIPendientesDeNotasDal();
       }
       
    }
}
