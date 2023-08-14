using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Cronograma
    {
       public void InsertarCronogramaDal(int id_modalidad_IIX, string fechaX, string descripcionX, int estadoX)
       {
           string cmdsql = "insert into Cronograma(id_modalidad_II,fecha,descripcion,estado) values (" + id_modalidad_IIX + ",'" + fechaX + "','" + descripcionX + "'," + estadoX + ")";
           Conexion.setdatos(cmdsql);
       }
       protected DataTable SeleccionarCronograma(int id_modalidad_IIX)
       {
           string cmdsql = "select * from Cronograma where id_modalidad_II>0 and";
           string ByIdModalidadII = "";      

           if (id_modalidad_IIX > 0)
               ByIdModalidadII = " id_modalidad_II=" + id_modalidad_IIX;
           return Conexion.getdatos(cmdsql  + ByIdModalidadII);
       }
       protected void ActualizarCronogramaDal(int id_cronogramaX, string fechaX, string descripcionX, int estadoX)
       {
           string cmdsql = " update Cronograma set fecha='"+fechaX+"', descripcion='"+descripcionX+"', estado="+estadoX +" where id_cronograma="+id_cronogramaX;
           Conexion.setdatos(cmdsql);
       }
       protected void ServicioCronograma()
       {
           string cmdsql = "update Cronograma set estado=0 where fecha < getdate()";
           Conexion.setdatos(cmdsql);
       }
       //funcion para generar un reporte de todos aquellos estudiantes que tienen que presentar su informe de acuerdo a su cronograma en una determinada fecha 
       protected DataTable ReportePresentacionCronogramaParaLaFechaDal(string fechaX)
       {
           string cmdsql = "  select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Persona.telefono,Persona.celular,Persona.mail from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II,Cronograma where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Cronograma.id_modalidad_II and Cronograma.fecha='"+fechaX+"'";
           return Conexion.getdatos(cmdsql);
       }
    }
}
