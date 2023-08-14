using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Modalidad_I:DAL.Dal_Modalidad_I
    {
       protected int id_modalidad_I;
       protected int id_tipo_modalidad;
       protected int id_estudiante;
       protected int id_grupo;
       protected string tema;
       protected string n_carta;
       protected string fecha_inscripcion;
       protected int estado;

       public int ID_MODALIDAD_I
       {
           get { return this.id_modalidad_I; }
           set { this.id_modalidad_I = value; }
       }
       public int ID_TIPO_MODALIDAD
       {
           get { return this.id_tipo_modalidad; }
           set { this.id_tipo_modalidad = value; }
       }
       public int ID_ESTUDIANTE
       {
           get { return this.id_estudiante; }
           set { this.id_estudiante = value; }
       }
       public int ID_GRUPO
       {
           get { return this.id_grupo; }
           set { this.id_grupo = value; }
       }
       public string TEMA
       {
           get { return this.tema; }
           set { this.tema = value; }
       }
       public string N_CARTA
       {
           get { return this.n_carta; }
           set { this.n_carta = value; }
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


       public void InsertarModalidadIBss()
       {
           base.InsertarModalidad_IDal(this.ID_TIPO_MODALIDAD, this.ID_ESTUDIANTE,this.ID_GRUPO, this.TEMA, this.N_CARTA,this.FECHA_INSCRIPCION, this.ESTADO);
       }
       public DataTable SeleccionarModalidadICriterioBss()
       {
           return base.SeleccionarModlidadICriterioDal(this.ID_TIPO_MODALIDAD, this.ID_ESTUDIANTE, this.ID_GRUPO, this.TEMA,this.N_CARTA,this.ESTADO);
       }
       public DataTable SeleccionarModalidadReprovadasBss()
       {
           return base.SeleccionarModalidadReprovadasDal();
       }
       public DataTable SeleccionarModalidadesAprovadasBss()
       {
           return base.SeleccionarModalidadesAprovadasDal();
       }
       public void ModificarModalidadIBss()
       {
           base.ModificarModalidadIDal(this.ID_TIPO_MODALIDAD, this.ID_ESTUDIANTE, this.TEMA, this.N_CARTA, this.ID_MODALIDAD_I,this.ID_GRUPO);
       }
       public void ServicioModalidadIBss()
       {
           base.ServicioModalidadIDal();
       }
       public DataTable ReporteModalidadIBss(int id_grupoX, int id_carreraX, int id_tipo_modalidadX, int gestionX)
       {
           return base.RepoteModalidadIDal(id_grupoX, id_carreraX, id_tipo_modalidadX, gestionX);
       }
       public DataTable SeleccionarEstudianteTipoModalidadBss()
       {
           return base.SeleccionarEstudianteTipoModalidadDal(this.ID_ESTUDIANTE, this.ID_TIPO_MODALIDAD);
       }
       public DataTable SeleccionarNroCartaBss()
       {
           return base.SeleccionarNroCartaDal(this.N_CARTA,this.ESTADO);
       }
       public DataTable SeleccionarTemaBss()
       {
           return base.SeleccionarTemaDal(this.TEMA, this.ESTADO);
       }
       public DataTable ReporteTemasBss(int id_carreraX,int id_facultadX)
       {
           return base.ReporteTemasDal(id_facultadX, id_carreraX,this.ID_TIPO_MODALIDAD);
       }
       public DataTable ReporteHabilitadosModalidadIIBss()
       {
           return base.ReporteHabilitadosModalidadIIDal();
       }
       public DataTable ReporteHabilitadosDefensaSegundaInstanciaBss()
       {
           return base.ReporteHabilitadosDefensaSegundaInstanciaDal();
       }
       public DataTable ReporteAlumnosSinPrograrmarDefensaBss()
       {
           return base.ReporteAlumnosSinPrograrmarDefensaDal();
       }
    }
}
