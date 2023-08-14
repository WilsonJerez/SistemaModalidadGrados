using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Dal_Mod_III
    {
        // procedimiento para insertar los datos de la Tercera Defensa(Mod_III) de la modalidad
        protected int InsertarModIIIDal(int id_modalidad_IIX, string fecha_inscripcionX, string presidenteX, int id_tribunal_externoX, int estadoX)
        {
            string cmdsql = "insert into Mod_III (id_modalidad_II,fecha_inscripcion,presidente,id_tribunal_externo,estado) values (" + id_modalidad_IIX + ",'" + fecha_inscripcionX + "','" + presidenteX + "'," + id_tribunal_externoX + "," + estadoX + ")";
            Conexion.setdatos(cmdsql);
            return Convert.ToInt32(SeleccinarModIIICriterioDal("","","","",0,0,id_modalidad_IIX, fecha_inscripcionX, presidenteX, id_tribunal_externoX, estadoX).Rows[0]["id_mod_III"].ToString());
        }
        protected DataTable SeleccinarModIIICriterioDal(string ciX,string nombreX,string paternoX,string maternoX,int estado_defensaX, int id_mod_IIIX,int id_modalidad_IIX, string fecha_inscripcionX, string presidenteX, int id_tribunal_externoX, int estadoX)
        {
            //cadena que se utilizara solo en caso de insertar
            string cmdsql = "";

            string ByCi = "";
            string ByNombre="";
            string ByPaterno = "";
            string ByMaterno = "";
            string ByIdModalidadII = "";
            string ByFechaInscripcion = "";
            string ByPresidente = "";
            string ByTribunalExterno = "";
            string ByIdModIII = "";
            string ByEstadoDefensa = "";
            string ByEstado = "";


            if (estadoX == 0)
                ByEstado = " and MOD_III.estado=0";
            else
                ByEstado = " and MOD_III.estado=1";

            if (estado_defensaX == 0)
                ByEstadoDefensa = " and Defensa.estado=0";
            else
                ByEstadoDefensa= " and Defensa.estado=1";

            if (ciX != "")
                ByCi = " and Persona.ci='" + ciX + "'";
            if (nombreX != "")
                ByNombre = " and Persona.nombre='" + nombreX + "'";
            if (paternoX != "")
                ByPaterno = " and Persona.paterno='" + paternoX + "'";
            if (maternoX != "")
                ByMaterno = " and Persona.materno='" + maternoX + "'";

            if (id_modalidad_IIX > 0)
                ByIdModalidadII = " and MOD_III.id_modalidad_II=" + id_modalidad_IIX;
            if (fecha_inscripcionX != "" & fecha_inscripcionX!=null)
                ByFechaInscripcion = " and MOD_III.fecha_inscripcion='" + fecha_inscripcionX + "'";
            if (presidenteX != "" & presidenteX!=null)
                ByPresidente = " and MOD_III.presidente='" + presidenteX + "'";
            if (id_tribunal_externoX >0)
                ByTribunalExterno = " and MOD_III.id_tribunal_externo=" + id_tribunal_externoX ;
            if (id_mod_IIIX > 0)
                ByIdModIII = " and MOD_III.id_mod_III=" + id_mod_IIIX;

            if (id_modalidad_IIX>0 & fecha_inscripcionX!="" & presidenteX!="" & id_tribunal_externoX>0)
            {
                //para filtrar los datos y recuperar el id al momento de guardar
                cmdsql= "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_I.tema,Tipo_modalidad.tipo_modalidad,Carrera.carrera,MOD_III.id_mod_III from Persona,Estudiante,Modalidad_I,Carrera,Tipo_Modalidad,Modalidad_II,MOD_III where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_tipo_modalidad=Tipo_modalidad.id_tipo_modalidad and Modalidad_I.id_Modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=MOD_III.id_modalidad_II";
                return Conexion.getdatos(cmdsql + ByIdModalidadII + ByFechaInscripcion + ByPresidente + ByTribunalExterno + ByEstado);
            }
            else
            {
                //para filtrar la modalidad por su id solamente si el id_mod_III mayor a 0
                if (id_mod_IIIX > 0)
                {
                    cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_I.tema,Tipo_modalidad.tipo_modalidad,Carrera.carrera,MOD_III.id_mod_III,MOD_III.tribunal_externo,MOD_III.nota_externa,Defensa.id_defensa,Defensa.fecha from Persona,Estudiante,Modalidad_I,Carrera,Tipo_Modalidad,Modalidad_II,MOD_III,Defensa where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_tipo_modalidad=Tipo_modalidad.id_tipo_modalidad and Modalidad_I.id_Modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=MOD_III.id_modalidad_II and Mod_III.id_mod_III=Defensa.id_mod_III and Defensa.estado=0";
                    return Conexion.getdatos(cmdsql + ByCi + ByNombre + ByPaterno + ByMaterno);
                }
                else
                {
                    //para filtrar por datos personales
                    cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Modalidad_I.tema,Tipo_modalidad.tipo_modalidad,Carrera.carrera,MOD_III.id_mod_III,Defensa.id_defensa,Defensa.fecha,Defensa.nro_acta,Defensa.nota,Defensa.hora,Defensa.id_aula,Aula.n_aula from Persona,Estudiante,Modalidad_I,Carrera,Tipo_Modalidad,Modalidad_II,MOD_III,Defensa,Aula where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_tipo_modalidad=Tipo_modalidad.id_tipo_modalidad and Modalidad_I.id_Modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=MOD_III.id_modalidad_II and Mod_III.id_mod_III=Defensa.id_mod_III"+ByEstadoDefensa+" and Defensa.id_aula=Aula.id_aula";
                    return Conexion.getdatos(cmdsql + ByCi + ByNombre + ByPaterno + ByMaterno);
                }
            }
        }

        protected void ActualizarModIIIDal(int id_mod_IIIX,int notaX, string presidenteX, int id_tribunal_externoX)
        {
            string cmdsql = "update MOD_III set ";

            string UpNota="";
            string UpPresidente="";
            string UpTribunalExterno="";
            string UpId="";

            if(id_mod_IIIX>0)
                UpId=" where id_mod_III="+id_mod_IIIX;
            if (notaX > 0)
                UpNota = " nota_externa=" + notaX;
            if(presidenteX!="" & presidenteX!=null)
                UpPresidente=" presidente='"+presidenteX+"'";
            if (id_tribunal_externoX >0)
                UpTribunalExterno = " id_tribunal_externo=" + id_tribunal_externoX ;

            if (id_mod_IIIX > 0)
                Conexion.setdatos(cmdsql + UpNota + UpPresidente + UpTribunalExterno + UpId);
        }
        
    }
}