using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Modalidad_I
    {
       protected void InsertarModalidad_IDal(int id_tipo_modalidadX, int id_estudianteX,int id_grupoX,string temaX, string n_cartaX,string fecha_inscripcionX, int estadoX)
       {
           string cmdsql = "insert into Modalidad_I (id_tipo_modalidad,id_estudiante,id_grupo,tema,n_carta,fecha_inscripcion,estado) values (" + id_tipo_modalidadX + "," + id_estudianteX + "," + id_grupoX+ ",'" + temaX + "','" + n_cartaX + "','"+fecha_inscripcionX+"'," + estadoX + ")";
           Conexion.setdatos(cmdsql);
       }
       protected DataTable SeleccionarModalidadIDal()
       {
           string cmdsql = "select * from modalidad_I";
           return Conexion.getdatos(cmdsql);
       }
       protected DataTable SeleccionarModlidadICriterioDal(int id_tipo_modalidadX, int id_estudianteX, int id_grupoX, string temaX, string n_cartaX, int estadoX)
       {
           string cmdsql = "select Modalidad_I.id_tipo_modalidad,Modalidad_I.id_estudiante,Modalidad_I.id_grupo,Modalidad_I.tema,Modalidad_I.n_carta,Modalidad_I.estado,Modalidad_I.id_modalidad_I,Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Tipo_Modalidad.tipo_modalidad,Grupo.n_grupo,Grupo.fecha_inicio,Grupo.fecha_final from Modalidad_I,Persona,Tipo_Modalidad,Estudiante,Carrera,Grupo where Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_I.id_modalidad_I not in (select id_modalidad_I from Defensa where id_modalidad_I>0) and Estudiante.id_carrera=Carrera.id_carrera and Grupo.id_grupo=Modalidad_I.id_grupo and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
           string ByEstado = "";
           string ByIdTipoModalidad = "";
           string ByIdEstudiante = "";
           string ByIdGrupo = "";
           string ByTema = "";
           string ByNroCarta = "";

           if (estadoX == 0)
               ByEstado = " and Modalidad_I.estado=0 ";
           else
               ByEstado = " and Modalidad_I.estado=1 ";
           if (id_tipo_modalidadX > 0)
               ByIdTipoModalidad = " and Modalidad_I.id_tipo_modalidad=" + id_tipo_modalidadX;
           if (id_estudianteX > 0)
               ByIdEstudiante = " and Modalidad_I.id_estudiante=" + id_estudianteX;
           if (id_grupoX > 0)
               ByIdGrupo = " and Modalidad_I.id_grupo=" + id_grupoX;
           if (temaX != null)
               ByTema = " and Modalidad_I.tema='" + temaX + "'";
           if (n_cartaX !="" & n_cartaX!=null)
               ByNroCarta = " and Modalidad_I.n_carta='" + n_cartaX+"'";

           return Conexion.getdatos(cmdsql + ByEstado + ByIdTipoModalidad + ByIdEstudiante + ByIdGrupo + ByTema + ByNroCarta);
 
       }
      protected DataTable SeleccionarModalidadReprovadasDal()
       {
           string cmdsql = "select DefeRepiMod_I.n, Modalidad_I.id_tipo_modalidad,Modalidad_I.id_estudiante,Modalidad_I.id_grupo,Modalidad_I.tema,Modalidad_I.n_carta,Modalidad_I.estado,Modalidad_I.id_modalidad_I,Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Tipo_Modalidad.tipo_modalidad from Modalidad_I,Persona,Tipo_Modalidad,Estudiante,DefeRepiMod_I,Carrera where Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_I.id_modalidad_I =DefeRepiMod_I.id_modalidad_I and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from Defensa where estado=1) and DefeRepiMod_I.n<2 and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad;
           return Conexion.getdatos(cmdsql);
       }
      protected DataTable SeleccionarModalidadesAprovadasDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.Materno,Tipo_Modalidad.tipo_modalidad,Modalidad_I.id_modalidad_I,Modalidad_I.tema,Estudiante.estado from Persona,Tipo_Modalidad,Modalidad_I,Estudiante,Defensa,Carrera where Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.nota>=65 and Defensa.id_modalidad_I not in(select id_modalidad_I from Modalidad_II) and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
          return Conexion.getdatos(cmdsql);
      }
      public void ModificarModalidadIDal(int id_tipo_modalidadX, int id_estudianteX, string temaX, string n_cartaX, int id_modalidadIX, int id_grupoX)
      {
          string cmdsql = "update Modalidad_I set id_tipo_modalidad='" + id_tipo_modalidadX + "' , id_estudiante='" + id_estudianteX +"', tema='"+temaX+"', n_carta='"+n_cartaX+ "', id_grupo='"+id_grupoX+ "'where id_modalidad_I= '" + id_modalidadIX + "'";
          Conexion.setdatos(cmdsql);
      }
      protected void ServicioModalidadIDal()
      {
          string cmdsql = "update Modalidad_I set estado=0 where id_grupo in (select id_grupo from grupo where estado=0)";
          Conexion.setdatos(cmdsql);
      }
       // funcion que devuelve estudiant y tipo de modalidad, se utiliza para controlar que si repiten la modalidad de grado I y II no sigan el mismo tipo de modalidad de grado donde reprobaron
      protected DataTable SeleccionarEstudianteTipoModalidadDal(int id_estudianteX,int id_tipo_modalidadX)
      {
          string cmdsql = "select id_estudiante,id_tipo_modalidad from Modalidad_I where id_estudiante=" + id_estudianteX + " and id_tipo_modalidad=" + id_tipo_modalidadX; 
          return Conexion.getdatos(cmdsql);
      }
       //funcion para buscar nro carta existentes por parametros,utilizada para verificar que no se repitan los nros de carta
      protected DataTable SeleccionarNroCartaDal(string n_cartaX, int estadoX)
      {
          string cmdsql = "select n_carta from Modalidad_I where n_carta='" + n_cartaX + "' and estado=" + estadoX;
          return Conexion.getdatos(cmdsql);
      }
       //funcion para buscar temas y controlar que no se repitan en todas las facultades
      protected DataTable SeleccionarTemaDal(string temaX, int estadoX)
      {
          string cmdsql = "select tema from Modalidad_I where tema='" + temaX + "' and estado=" + estadoX;
          return Conexion.getdatos(cmdsql);
      }
      protected DataTable RepoteModalidadIDal(int id_grupoX,int id_carreraX,int id_tipo_modalidadX,int gestionX)
      {
          string cmdsql = " select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Persona.telefono,Persona.celular,Persona.direccion,Persona.mail,Modalidad_I.tema,Modalidad_I.n_carta,Modalidad_I.estado from Persona,Estudiante,Modalidad_I,Tipo_Modalidad,Grupo,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_grupo=Grupo.id_grupo and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Estudiante.id_Carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
          string ByIdGrupo = "";
          string ByIdCarrera = "";
          string ByIdTipoModalidad = "";
          string ByGestion = "";

          if (id_grupoX > 0)
              ByIdGrupo = " and Modalidad_I.id_grupo=" + id_grupoX;
          if (id_carreraX > 0)
              ByIdCarrera = " and Estudiante.id_carrera=" + id_carreraX;
          if (id_tipo_modalidadX > 0)
              ByIdTipoModalidad = " and Modalidad_I.id_tipo_modalidad=" + id_tipo_modalidadX;
          if (gestionX > 0)
              ByGestion = " and Grupo.gestion=" + gestionX;

          return Conexion.getdatos(cmdsql + ByIdGrupo + ByIdCarrera + ByIdTipoModalidad + ByGestion);
      }
      protected DataTable ReporteTemasDal(int id_facultadX,int id_carreraX,int id_tipo_modalidadX)
      {
          string ByFacultad="";
          string ByCarrera="";
          string ByTipoModalidad="";
          if(id_facultadX>0)
          {
              ByFacultad=" and Carrera.id_facultad="+id_facultadX;
          }
          if(id_carreraX>0)
          {
              ByCarrera=" and Estudiante.id_carrera="+id_carreraX;
          }
          if(id_tipo_modalidadX>0)
          {
              ByTipoModalidad=" and Modalidad_I.id_tipo_modalidad="+id_tipo_modalidadX;
          }
          string cmdsql = "select Modalidad_I.tema from Modalidad_I,Estudiante,Carrera where Estudiante.id_carrera=Carrera.id_carrera and Modalidad_I.id_estudiante=Estudiante.id_estudiante"+ByFacultad + ByCarrera+ByTipoModalidad+" order by Modalidad_I.tema";
          return Conexion.getdatos(cmdsql );
      }
      protected DataTable ReporteHabilitadosModalidadIIDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Defensa.nota from Persona,Estudiante,Modalidad_I,Defensa,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + Dal_Login.id_facultad + " and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.nota>=65 and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from Modalidad_II)";
          return Conexion.getdatos(cmdsql);
      }
      // funcion que devuelve solo aquellos alumnos habilitados para la segunda defesa
      protected DataTable ReporteHabilitadosDefensaSegundaInstanciaDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Defensa.nota from Persona,Estudiante,Carrera,Modalidad_I,Defensa where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Estudiante.id_carrera=Carrera.id_carrera and Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.nota<65 and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from Defensa where nota>=65) and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from DefeRepiMod_I where n=2) and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad;
          return Conexion.getdatos(cmdsql);
      }
      // funcion para generar el reporte de alertas de los alumnos de la modalidad de grado I sin programar defensas
      protected DataTable ReporteAlumnosSinPrograrmarDefensaDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno from Persona,Estudiante,Carrera,Modalidad_I where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from Defensa where id_modalidad_I>0) and Modalidad_I.estado=0";
          return Conexion.getdatos(cmdsql);
      }
      
    }
}
