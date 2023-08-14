using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Modalidad_II
    {
     protected void InsertarModalidad_IIDal(int id_modalidad_IX, int id_contratoX,string fecha_inscripcionX, int estadoX)
       {
           string cmdsql = "insert into Modalidad_II (id_modalidad_I,id_contrato,fecha_inscripcion,estado) values (" + id_modalidad_IX + "," + id_contratoX + ",'" +fecha_inscripcionX+"',"+ estadoX + ")";
           Conexion.setdatos(cmdsql);
       }
     protected DataTable SeleccionarModalidad_IIDal()
       {
           string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_II.estado,Modalidad_II.id_modalidad_II,Modalidad_II.fecha_inscripcion,Modalidad_I.id_modalidad_I,Modalidad_I.tema,Tipo_Modalidad.tipo_modalidad from Modalidad_II,Modalidad_I,Estudiante,Persona,Tipo_Modalidad,Carrera where Modalidad_II.id_modalidad_I=Modalidad_I.id_modalidad_I and Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_II.estado=1 and Modalidad_II.id_modalidad_II  not in(select id_modalidad_II from Cronograma where estado=1) and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
           return Conexion.getdatos(cmdsql);
       }
       // procedimiento que devuelve todas las modalidades que no tienen informes del cronograma pendiente y que ademas tienen el resultado de su informe 
     protected DataTable SeleccionarModalidadIICulminoCronogramaDal()
     {
         string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Modalidad_I.tema,Tipo_Modalidad.tipo_modalidad,Modalidad_II.id_modalidad_II,Modalidad_II.estado from Persona,Estudiante,Tipo_Modalidad,Modalidad_I,Modalidad_II,Carrera where Modalidad_II.estado=0 and Modalidad_II.id_modalidad_I=Modalidad_I.id_modalidad_I and Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_II.id_modalidad_II not in (select id_modalidad_II from Cronograma where estado=1) and Modalidad_II.id_modalidad_II not in(select id_modalidad_II from Defensa where id_modalidad_II>0) and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad;
         return Conexion.getdatos(cmdsql); 
     }
   // para devolver todas las modalidades defendidas reprovadas habilitadas para la segunda y ultima defensa permitida
     protected DataTable SeleccionarModalidad_IIRepitentesDal()
     {
         string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Modalidad_I.tema,Tipo_Modalidad.tipo_modalidad,Modalidad_II.id_modalidad_II,Modalidad_II.estado ,DefeRepiMod_II.n from Persona,Estudiante,Tipo_Modalidad,Modalidad_I,Modalidad_II,DefeRepiMod_II,Carrera where Modalidad_II.estado=0 and Modalidad_II.id_modalidad_I=Modalidad_I.id_modalidad_I and Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_II.id_modalidad_II= DefeRepiMod_II.id_modalidad_II and DefeRepiMod_II.n<2 and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad; 
         return Conexion.getdatos(cmdsql);
     }
       // para devolver todas las modalidades que tienen cronogramas pendientes o mayores a la fecha actual
     protected DataTable SeleccionarModalidad_IICronogramaPendienteDal()
     {
         string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Modalidad_I.tema,Modalidad_II.id_modalidad_II,Modalidad_II.fecha_inscripcion,Modalidad_II.estado,Tipo_Modalidad.tipo_modalidad from Persona,Estudiante,Modalidad_I,Modalidad_II,Tipo_Modalidad,Carrera where Modalidad_II.id_modalidad_I=Modalidad_I.id_modalidad_I and Modalidad_I.id_estudiante=Estudiante.id_estudiante and Estudiante.id_persona=Persona.id_persona and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and id_modalidad_II not in(select id_modalidad_II from Defensa where id_modalidad_II>0 and estado=1) and Estudiante.id_carrera=Carrera.id_carrera and id_modalidad_II in(select id_modalidad_II from Cronograma) and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
         return Conexion.getdatos(cmdsql);
     }
     protected DataTable SeleccionarModaliad_IIPorCriterio(string nombreX, string paternoX, string maternoX, string ciX, int estadoX)
     {
         string cmdsql = "";
         string ByNombre = "";
         string ByPaterno = "";
         string ByMaterno = "";
         string ByCi = "";
         string ByEstado = "";

         if (estadoX == 1)
             ByEstado = " and Modalidad_II.estado=1";
         else
             ByEstado = " and Modalidad_II.estado=0";
         if (nombreX != "")
             ByNombre = " and Persona.nombre='" + nombreX + "'";
         if (paternoX != "")
             ByPaterno = " and Persona.paterno='" + paternoX + "'";
         if (maternoX != "")
             ByMaterno = " and Persona.materno='" + maternoX + "'";
         if (ciX != "")
             ByCi = " and Persona.ci='" + ciX + "'";

         cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Modalidad_II.id_modalidad_II,Modalidad_II.id_contrato,Modalidad_II.estado,Modalidad_II.fecha_inscripcion from Persona,Estudiante,Modalidad_I,Modalidad_II,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad + ByNombre + ByPaterno + ByMaterno + ByCi + ByEstado;
         return Conexion.getdatos(cmdsql);
     }

     protected DataTable SeleccionarModaliad_IIPorCriterioSinDefenza(string nombreX, string paternoX, string maternoX, string ciX, int estadoX)
     {
         string cmdsql = "";
         string ByNombre = "";
         string ByPaterno = "";
         string ByMaterno = "";
         string ByCi = "";
         string ByEstado = "";

         //if (estadoX == 1)
         //    ByEstado = " and Modalidad_II.estado=1";
         //else
         //    ByEstado = " and Modalidad_II.estado=0";
         if (nombreX != "")
             ByNombre = " and Persona.nombre='" + nombreX + "'";
         if (paternoX != "")
             ByPaterno = " and Persona.paterno='" + paternoX + "'";
         if (maternoX != "")
             ByMaterno = " and Persona.materno='" + maternoX + "'";
         if (ciX != "")
             ByCi = " and Persona.ci='" + ciX + "'";

         cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Modalidad_II.id_modalidad_II,Modalidad_II.id_contrato,Modalidad_II.estado,Modalidad_II.fecha_inscripcion from Persona,Estudiante,Modalidad_I,Modalidad_II,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II not in(select id_modalidad_II from defensa where id_modalidad_II>0) and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad + ByNombre + ByPaterno + ByMaterno + ByCi;
         return Conexion.getdatos(cmdsql);
     }

       protected DataTable SeleccionarModIIPorIdModIDal(int id_modalidadIX)
       {
           string cmdsql = "select id_modalidad_II from Modalidad_II where id_modalidad_I=" + id_modalidadIX;
           return Conexion.getdatos(cmdsql);
       }
       
     protected void ActualizarModalidadIIDal(int id_modalidad_IIX, int id_contratoX)
     {
         string cmdsql = "update Modalidad_II set id_contrato=" + id_contratoX + " where id_modalidad_II=" + id_modalidad_IIX;
         Conexion.setdatos(cmdsql);
     }
     protected void ServicioModalidadII()
     {
         string cmdsql = "  update Modalidad_II set estado=0 where Modalidad_II.id_modalidad_II not in(select id_modalidad_II from Cronograma where estado=1) and Modalidad_II.id_modalidad_II not in(select id_modalidad_II from Modalidad_II where id_modalidad_II not in(select id_modalidad_II from Cronograma where id_modalidad_II>0))";
         Conexion.setdatos(cmdsql);
     }
     protected DataTable ReporteModalidadIIPorTutor(int id_tutorX)
     {
         string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_II.id_modalidad_II,Modalidad_II.id_contrato from Persona,Estudiante,Modalidad_I,Modalidad_II where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.estado=1 and Modalidad_II.id_contrato="+id_tutorX;
         return Conexion.getdatos(cmdsql);
     }
       //funcion para generar un reporte de todos aquellos estudiantes que no hayan programado su defensa de la modalidad de grado II
     protected DataTable ReporteEtudiantesSinProgramarDefensasModIIDal()
     {
         string cmdsql = " select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.estado=0 and Modalidad_II.id_modalidad_II not in(select id_modalidad_II from defensa where id_modalidad_II>0)";
        return Conexion.getdatos(cmdsql);
     }
       //funcion para generar un reporte de todos aquellos estudiantes que se inscribieron a la modalidad II pero no presentaron su cronograma de actividades de desarrollo
     protected DataTable ReporteEstudiantesSinCronogramaDal()
     {
         string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_II.fecha_inscripcion from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_Modalidad_II not in(select id_modalidad_II from cronograma)";
         return Conexion.getdatos(cmdsql);
     }
       //funcion para seleccionar todos aquellos estudiantes que estan habilitados para postular la Mod III(defensa tribunal)
     protected DataTable SeleccionarHabilitadosModIIIDal(string ciX,string nombreX,string paternoX,string maternoX)
     {
         string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_I.tema,Tipo_Modalidad.tipo_modalidad,Carrera.Carrera,Modalidad_II.id_modalidad_II from Persona,Estudiante,Carrera,Modalidad_I,Tipo_Modalidad,Modalidad_II where Persona.id_persona=Estudiante.id_Persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad + " and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II in(select id_modalidad_II from Defensa where Nota>=65 and id_modalidad_II not in(select id_modalidad_II from MOD_III))";

         string ByCi = "";
         string ByNombre = "";
         string ByPaterno = "";
         string ByMaterno = "";

         if (ciX != "")
         {
             ByCi = " and Persona.ci='" + ciX + "'";
         }
         if (nombreX != "")
         {
             ByNombre = " and Persona.nombre='" + nombreX + "'";
         }
         if (paternoX != "")
         {
             ByPaterno = " and Persona.paterno='" + paternoX + "'";
         }
         if (maternoX != "")
         {
             ByMaterno=  "' and Persona.materno='" + maternoX + "'";
         }
         return Conexion.getdatos(cmdsql+ByCi+ByNombre+ByPaterno+ByMaterno);
     }
     
    }
}
