using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Grupo
    {
        protected void InsertarGrupoDal(int id_aulaX, int id_contratoX, int id_turnoX, int n_grupoX,int gestionX,string fecha_inicioX,string fecha_finalX, int estadoX)
        {
            string cmdsql = "insert into Grupo(id_aula,id_contrato,id_turno,n_grupo,gestion,fecha_inicio,fecha_final,estado) values (" + id_aulaX + "," + id_contratoX + "," + id_turnoX + "," + n_grupoX + ","+gestionX+",'"+fecha_inicioX+"','"+fecha_finalX+"'," + estadoX + ")";
            Conexion.setdatos(cmdsql);
        }
        protected DataTable SeleccionarGrupoDal()
        {
            int gestion = Convert.ToInt32(DateTime.Now.Year);
            string cmdsql = "select Grupo.id_grupo,Aula.n_aula, Turno.turno,Persona.nombre, Persona.ci,Persona.paterno, Persona.materno,Grupo.id_aula,Grupo.id_contrato,Grupo.id_turno,Grupo.n_grupo,Grupo.gestion,Grupo.fecha_inicio,Grupo.fecha_final,Grupo.estado,Aula.capacidad,Turno.turno from Grupo,Aula,Turno,Contrato,Persona where Grupo.id_aula=Aula.id_aula and Grupo.id_turno=Turno.id_turno and Grupo.id_contrato=Contrato.id_contrato and Persona.id_persona= Contrato.id_persona and gestion=" + gestion;
            return Conexion.getdatos(cmdsql);
        }
        protected DataTable SeleccionarGrupoCriterioDal(int id_grupoX,int id_aulaX, int id_contratoX, int id_turnoX, int n_grupoX, int gestionX, string fecha_inicioX, string fecha_finalX, int estadoX)
        {
            string cmdsql = "Select Grupo.id_grupo,Aula.n_aula, Turno.turno,Persona.nombre, Persona.ci,Persona.paterno, Persona.materno,Grupo.id_aula,Grupo.id_contrato,Grupo.id_turno,Grupo.n_grupo,Grupo.gestion,Grupo.fecha_inicio,Grupo.fecha_final,Grupo.estado,Aula.capacidad,Turno.turno from Grupo,Aula,Turno,Contrato,Persona where Grupo.id_aula=Aula.id_aula and Grupo.id_turno=Turno.id_turno and Grupo.id_contrato=Contrato.id_contrato and Persona.id_persona= Contrato.id_persona and ";

            string ByIdGrupo = "";
            string ByIdAula = "";
            string ByIdContrato = "";
            string ByIdTurno = "";
            string ByNgrupo = "";
            string ByGestion = "";
            string ByFechaInicio = "";
            string ByFechaFinal = "";
            string ByEstado = "";

            if (id_grupoX > 0)
            {
                ByIdGrupo = " and Grupo.id_grupo=" + id_grupoX;
            }
            

            if (estadoX == 0)
                ByEstado = " Grupo.estado=0 ";
            else
                ByEstado = " Grupo.estado=1 ";
            if (id_aulaX != 0)
                ByIdAula = " and Grupo.id_aula=" + id_aulaX;
            if (id_contratoX != 0)
                ByIdContrato = " and Grupo.id_contrato=" + id_contratoX;
            if (id_turnoX != 0)
                ByIdTurno = " and Grupo.id_turno=" + id_turnoX;
            if (n_grupoX != 0)
                ByNgrupo = " and Grupo.n_grupo=" + n_grupoX;
            if (gestionX != 0)
                ByGestion = " and Grupo.gestion=" + gestionX;
            if (fecha_inicioX != null & fecha_inicioX != "")
                ByFechaInicio = " and Grupo.fecha_inicio='" + fecha_inicioX + "'";
            if (fecha_finalX != null & fecha_finalX != "")
                ByFechaFinal = " and Grupo.fecha_final='" + fecha_finalX + "'";


            return Conexion.getdatos(cmdsql + ByEstado + ByIdAula + ByIdContrato + ByIdTurno + ByNgrupo + ByGestion + ByFechaInicio + ByFechaFinal+ByIdGrupo);
        }
        protected DataTable ContarRegistradosEnModalidad_I_PorGruposDal(int GestionX)
        {
            string cmdsql = "select count(*) as n,Grupo.n_grupo from Modalidad_I,Grupo where Modalidad_I.id_grupo=Grupo.id_grupo and Grupo.estado=1 and Grupo.gestion="+GestionX+" group by Grupo.n_grupo";
            return Conexion.getdatos(cmdsql);
        }
      protected void ModificarGrupoDal(int id_aulaX, int id_contratoX, int id_turnoX, int n_grupoX, string fecha_inicioX, string fecha_finalX, int estadoX, int id_grupoX)
        {

          string cmdsql = "update Grupo set";
          string UpIdaula="";
          string UpIdcontrato="";
          string UpIdturno="";
          string UpNgrupo="";
          string UpFechainicio="";
          string UpFechafinal="";
          string UpEstado="";

          if (estadoX == 0)
              UpEstado = " estado=0";
          else
              UpEstado = " estado=1";

          if(id_aulaX>0)
              UpIdaula=" ,id_aula="+id_aulaX;
          if(id_contratoX>0)
              UpIdcontrato=" ,id_contrato="+id_contratoX;
          if (id_turnoX > 0)
              UpIdturno = " ,id_turno=" + id_turnoX;
          if (n_grupoX > 0)
              UpNgrupo = " ,n_grupo=" + n_grupoX;
          if (fecha_inicioX != null & fecha_inicioX != "")
              UpFechainicio = " ,fecha_inicio='" + fecha_inicioX + "'";
          if (fecha_finalX != null & fecha_finalX != "")
              UpFechafinal = " ,fecha_final='" + fecha_finalX + "'";




          Conexion.setdatos(cmdsql + UpEstado + UpIdaula + UpIdcontrato + UpIdturno + UpNgrupo + UpFechainicio + UpFechafinal + " where id_grupo=" + id_grupoX);

        }

      protected void ServicioGrupo()
      {
          string cmdsql = "update Grupo set estado=0 where fecha_final<getdate()";
          Conexion.setdatos(cmdsql);
      }
    }
}
