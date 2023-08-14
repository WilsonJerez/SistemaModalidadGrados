using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Tribunal
    {
       protected void InsertarTribunalDal(int []id_contratoX, int id_modalidad_IX, int id_modalidad_IIX,int id_mod_IIIX, int id_aulaX, string fechaX, string horaX, int notaX, string nro_actaX, int estadoX)
       {
           int IdDefensaRecuperado = InsertarDefensaDal(id_modalidad_IX, id_modalidad_IIX,id_mod_IIIX, id_aulaX, fechaX, horaX, notaX, nro_actaX, estadoX);

           for (int i = 0; i < id_contratoX.Length; i++)
           {
               string cmdsql = "insert into Tribunal(id_contrato,id_defensa) values (" + id_contratoX[i] + "," + IdDefensaRecuperado + ")";
               Conexion.setdatos(cmdsql);
           }
       }
       protected DataTable SeleccionarTribunalDal()
       {
           string cmdsql = "select Defensa.id_modalidad_I,Defensa.id_modalidad_II,Defensa.Defensa.id_aula,Defensa.fecha,Defensa.hora,Tribunal.id_contrato,Tribunal.id_defensa from Tribunal,Defensa where Tribuna.id_defesa=Defensa.id_defensa group by Tribunal.id_defensa";
           return Conexion.getdatos(cmdsql);
       }
       protected DataTable SeleccionarTribunalDalCriterio(int id_contratoX, int id_modalidad_IX, int id_modalidad_IIX, int id_aulaX, string fechaX, string horaX, int notaX, string nro_actaX, int estadoX)
       {
           string cmdsql = "select Defensa.id_modalidad_I,Defensa.id_modalidad_II,Defensa.id_aula,Defensa.fecha,Defensa.hora,Tribunal.id_contrato,Tribunal.id_defensa from Tribunal,Defensa where Tribunal.id_defensa=Defensa.id_defensa";
           string ByEstado = "";
           string ByIdContrato = "";
           string ByIModalidadI = "";
           string ByIdModalidadII = "";
           string Byidaula = "";
           string ByFecha = "";
           string ByHora = "";


           if (estadoX == 0)
               ByEstado = " and Defensa.estado=0";
           else
               ByEstado = " and Defensa.estado=1";
           if (id_contratoX > 0)
               ByIdContrato = " and Tribunal.id_contrato=" + id_contratoX;
           if (id_modalidad_IX > 0)
               ByIModalidadI = " and Defensa.id_modalidad_I=" + id_modalidad_IX;
           if (id_modalidad_IIX > 0)
               ByIdModalidadII = " and Defensa.id_modalidad_II=" + id_modalidad_IIX;
           if (id_aulaX > 0)
               Byidaula = " and Defensa.id_aula=" + id_aulaX;
           if (fechaX != null & fechaX!="")
               ByFecha = " and Defensa.fecha='" + fechaX +"'";
           if (horaX != null & horaX!="")
               ByHora = " and Defensa.hora='" + horaX + "'";

           return Conexion.getdatos(cmdsql + ByEstado + ByIdContrato + ByIModalidadI + ByIdModalidadII + Byidaula + ByFecha + ByHora);

       }
       // funcion que devuelve los datos del  tribunal mas las notas segun el id de la defensa a la que fueron asignados
       protected DataTable SeleccionarTribunalCriterioPorDefensaDal(int id_defensaX)
       {
           string cmdsql="select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Tribunal.nota,Tribunal.id_tribunal,Tribunal.id_contrato from Persona,Tribunal,Defensa,Contrato where Persona.id_persona=Contrato.id_persona and Contrato.id_contrato=Tribunal.id_contrato and Tribunal.id_defensa=Defensa.id_defensa and Tribunal.id_defensa="+id_defensaX;
           return Conexion.getdatos(cmdsql);          

       }
       protected void ActualizarTribunal(int id_contratox,int id_defensaX,int notaX,int id_tribunalX)
       {
           string SetIdContrato = "";
           string SetIdDefensa = "";
           string SetNota = "";
           
           if (id_tribunalX > 0)
           {
               if (id_contratox > 0)
               {
                   SetIdContrato = " id_contrato=" + id_contratox;
               }

               if (id_defensaX > 0 & id_contratox == 0)
               {                  
                   SetIdDefensa = " id_defensa=" + id_defensaX;
               }
               else
               {
                   if(id_defensaX>0)
                   SetIdDefensa = ",id_defensa=" + id_defensaX;
               }
               if (notaX > 0 & id_contratox == 0 & id_defensaX == 0)
               {                  
                  
                       SetNota = " nota=" + notaX;                   
               }
               else
               {       
                   if(notaX>0)
                       SetNota = ", nota=" + notaX;                 
                   
               }               
                   
               string cmdsql = "update Tribunal set "+SetIdContrato+SetIdDefensa+SetNota+" where id_tribunal=" + id_tribunalX;
               Conexion.setdatos(cmdsql);
           }
       }


       #region DEFENSA

      protected int InsertarDefensaDal(int id_modalidad_IX, int id_modalidad_IIX,int id_mod_IIIX, int id_aulaX, string fechaX, string horaX, int notaX, string nro_actaX, int estadoX)
       {
           int IdDefensaRetorno;
           string cmdsql="";
           if (id_modalidad_IX > 0 & id_modalidad_IIX == 0 & id_mod_IIIX==0)
           {
               cmdsql = "insert into Defensa (id_modalidad_I,id_aula,fecha,hora,nota,nro_acta,estado) values (" + id_modalidad_IX + "," + id_aulaX + ",'" + fechaX.ToString() + "','" + horaX + "'," + notaX + ",'" + nro_actaX + "'," + estadoX + ")";
           }
           if(id_modalidad_IIX>0 & id_modalidad_IX==0 & id_mod_IIIX==0)
           {
                cmdsql = "insert into Defensa (id_modalidad_II,id_aula,fecha,hora,nota,nro_acta,estado) values (" + id_modalidad_IIX  + "," + id_aulaX + ",'" + fechaX + "','" + horaX + "'," + notaX + ",'" + nro_actaX + "'," + estadoX + ")";
           }
          if(id_mod_IIIX>0 & id_modalidad_IX==0 & id_modalidad_IIX==0)
          {
                cmdsql = "insert into Defensa (id_mod_III,id_aula,fecha,hora,nota,nro_acta,estado) values (" +id_mod_IIIX+ "," + id_aulaX + ",'" + fechaX + "','" + horaX + "'," + notaX + ",'" + nro_actaX + "'," + estadoX + ")";
          }
           Conexion.setdatos(cmdsql);
           if(id_modalidad_IIX==0)
                return IdDefensaRetorno =Convert.ToInt32(SeleccionarDefensaCriteriodal(id_modalidad_IX,0, id_aulaX, fechaX, horaX, estadoX).Rows[0]["id_defensa"]);
           else
                return IdDefensaRetorno = Convert.ToInt32(SeleccionarDefensaCriteriodal(0, id_modalidad_IIX, id_aulaX, fechaX, horaX, estadoX).Rows[0]["id_defensa"]);
       }
      protected DataTable SeleccionarDefensaCriteriodal(int id_modalidad_IX, int id_modalidad_IIX, int id_aulaX, string fechaX, string horaX, int estadoX)
       {
           string cmdsql = "select * from Defensa where";
           string Byestado = "";
           string ByIdModalidadI = "";
           string ByIdModalidadII = "";
           string ByIdAula = "";
           string ByFecha = "";
           string ByHora = "";

           if (estadoX == 0)
               Byestado = " estado=0";
           else
               Byestado = " estado=1";
           if (id_modalidad_IX > 0)
               ByIdModalidadI = " and id_modalidad_I=" + id_modalidad_IX;
           if (id_modalidad_IIX > 0)
               ByIdModalidadII = " and id_modalidad_II=" + id_modalidad_IIX;
           if (id_aulaX > 0)
               ByIdAula = " and id_aula=" + id_aulaX;
           if (fechaX != null)
               ByFecha = " and fecha='" + fechaX +"'";
           if (horaX != null)
               ByHora = " and hora='" + horaX + "'";
          
               return Conexion.getdatos(cmdsql + Byestado + ByIdModalidadI +ByIdModalidadII+  ByIdAula + ByFecha + ByHora);
           
       }
      protected int ContarDefensasDeModalidadIDal(int id_modalida_IX)
       {
           DataTable respuesta=new DataTable();
           string cmdsql = "select count(*) as n,Defensa.id_modalidad_I from Defensa where Defensa.id_modalidad_I=" + id_modalida_IX + " group by id_modalidad_I";
           respuesta=Conexion.getdatos(cmdsql);
           if (respuesta.Rows.Count > 0)
               return Convert.ToInt32(Conexion.getdatos(cmdsql).Rows[0]["n"]);
           else
               return 0;
       }
      protected DataTable SeleccionarDefensaCriterioDal(string nombreX, string paternoX, string maternoX, int ciX,string fechaX,int estadoX,int mod)
       {
           string cmdsql;
           string Bynombre = "";
           string ByPaterno = "";
           string ByMaterno = "";
           string ByCi = "";
           string ByFecha = "";
           string ByEstado = "";
           if (estadoX == 0)
           {
               ByEstado = "and Defensa.estado=0";
           }
           else
           {
               ByEstado = "and Defensa.estado=1";
           }
           //if(fechaX!=null & fechaX!="" & swicht==1)
           //    ByFecha=" and Defensa.fecha>'"+fechaX+"'";
           //if(fechaX!=null & fechaX!="" & swicht==0)
           //    ByFecha = " and Defensa.fecha<'" + fechaX + "'";

           if(nombreX!="")
               Bynombre=" and Persona.nombre='"+nombreX+"'";
           if(paternoX!="")
               ByPaterno=" and Persona.paterno='"+paternoX+"'";
           if(maternoX!="")
               ByMaterno=" and Persona.materno='"+maternoX+"'";
           if(ciX>0)
               ByCi=" and Persona.ci='"+ciX+"'";
           if (mod == 0)
           {
               //para seleccionar defensas de modalidad 2
               cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Defensa.fecha,Defensa.id_modalidad_II,Defensa.id_modalidad_I,Defensa.id_defensa,Defensa.estado,Defensa.nota,Defensa.hora,Defensa.id_aula,Aula.n_aula,Defensa.nro_acta from Persona,Estudiante,Modalidad_I,Modalidad_II,Defensa,Carrera,Aula where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Defensa.id_modalidad_II and Defensa.nota>=0 and Estudiante.id_carrera=Carrera.id_carrera and Defensa.id_aula=Aula.id_aula and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad + Bynombre + ByPaterno + ByMaterno + ByCi +ByEstado;
           }
           else
           {
               //para seleccionar defensas de modalidad 1
               cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Defensa.fecha,Defensa.id_modalidad_II,Defensa.id_modalidad_I,Defensa.id_defensa,Defensa.estado,Defensa.nota,Defensa.hora,Defensa.id_aula,Aula.n_aula,Defensa.nro_acta from Persona,Estudiante,Modalidad_I,Defensa,Carrera,Aula where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.nota>=0 and Estudiante.id_carrera=Carrera.id_carrera and Defensa.id_aula=Aula.id_aula and Carrera.id_facultad=" + DAL.Dal_Login.id_facultad + Bynombre + ByPaterno + ByMaterno + ByCi +ByEstado;
           }
           return Conexion.getdatos(cmdsql);
       }
      protected void ActualizarDefensaDal(int id_defensaX,int id_modalidadIX,int id_modalidad_IIX,int id_aulaX,string fechaX,string horaX,int notaX,string nro_actaX,int estadoX)
       {
           string cmdsql = "update Defensa set";
           string SetIdModalidadI = "";
           string SetIdModalidadII = "";
           string SetIdAula = "";
           string SetFechaX = "";
           string SetHoraX = "";
           string SetNotaX = "";
           string SetNroActa = "";
           string setEstado = "";
           

           if (id_defensaX >= 0)
           {
               if (estadoX == 1)
                   setEstado = " estado=1";
               else
                   setEstado = " estado=0";
               if (id_modalidadIX > 0)
                   SetIdModalidadI = ",id_modalidad_I=" + id_modalidadIX;
               if (id_modalidad_IIX > 0)
                   SetIdModalidadII = ",id_modalidad_II=" + id_modalidad_IIX;
               if (id_aulaX > 0)
                   SetIdAula = ",id_aula=" + id_aulaX;
               if (fechaX !=null & fechaX!="")
                   SetFechaX = ",fecha='" + fechaX + "'";
               if (horaX !=null & horaX!="")
                   SetHoraX = ",hora='" + horaX + "'";
               if (notaX >= 0)
                   SetNotaX = ",nota='" + notaX+"'";
               if (nro_actaX != null & nro_actaX!="")
                   SetNroActa = ",nro_acta='" + nro_actaX + "'";
              
               Conexion.setdatos(cmdsql+setEstado+SetIdModalidadI+SetIdModalidadII+SetIdAula+SetFechaX+SetHoraX+SetNotaX+SetNroActa+" where id_defensa="+id_defensaX);
           }
       }
      protected void ServicioDefensaI()
       {
           string cmdsql = "update Defensa set estado=0 where fecha<getdate()";
           Conexion.setdatos(cmdsql);
       }
      protected DataTable ReporteEstudiantesGraduadosRangoFechasDal(string fecha1X, string fecha2X)
       { 
           string cmdsql="select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Defensa.nota,Defensa.fecha from Persona,Estudiante,Modalidad_I,Modalidad_II,Defensa,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Defensa.Id_modalidad_II and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+Dal_Login.id_facultad+" and Defensa.fecha>='"+fecha1X+"' and Defensa.fecha <='"+fecha2X+"' and Defensa.nota>=65" ;
           return Conexion.getdatos(cmdsql);
       }
      protected DataTable VerificarNroActaDal(string nro_actaX)
       {
           string cmdsql = "select nro_acta from Defensa where nro_acta='" + nro_actaX + "'";
           return Conexion.getdatos(cmdsql);
       }
       //fucion utilizada para devolver el reporte de todas las defensas para hoy
      protected DataTable ReporteDefensasParaHoyDal(string fechaX)
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Aula.n_aula,Defensa.hora from Persona,Estudiante,Modalidad_I,Defensa,Carrera,Aula where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Estudiante.id_estudiante=Modalidad_I.id_estudiante  and Modalidad_I.id_modalidad_I=Defensa.id_Modalidad_I and Aula.id_aula=Defensa.id_aula and Defensa.fecha='"+fechaX+"' and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" order by Defensa.hora";
          return Conexion.getdatos(cmdsql);
      }
      protected DataTable ReporteDefensasParaHoyModalidadIIDal(string fechaX)
      {
          string cmdsql = " select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Aula.n_aula,Defensa.hora from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II,Defensa,Aula where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Defensa.id_modalidad_II and Defensa.fecha='"+fechaX+"' and Defensa.id_aula=Aula.id_aula";
          return Conexion.getdatos(cmdsql);
      }
       //funcion que devuelve un reporte de todas las defensas de la modalidad_I que fueron defendidas pero que estan pendientes de registrar sus notas en el sistema
      protected DataTable ReporteDefensasModIPendientesDeNotasDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Defensa.fecha from Persona,Estudiante,Carrera,Modalidad_I,Defensa where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.estado=0 and Defensa.nota=0 and Defensa.nro_acta=''";
          return Conexion.getdatos(cmdsql);
      }
      //funcion que devuelve un reporte de todas las defensas de la modalidad_II que fueron defendidas pero que estan pendientes de registrar sus notas en el sistema
      protected DataTable ReporteDefensaModIIPendientesDeNotasDal()
      {
          string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Defensa.fecha from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II,Defensa where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_I=Defensa.id_modalidad_II and Defensa.estado=0 and Defensa.nota=0 and Defensa.nro_acta=''";
          return Conexion.getdatos(cmdsql);
      }
      #endregion
    }
}
