using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class Dal_Tribunal_Externo:Dal_Persona
    {
        public void InsertarTribunalExternoDal(string ciX,string nombreX,string PaternoX,string MaternoX,int telefonoX,int celularX,string direccionX,string mailX)
        {
            int id_persona=base.InsertarPersonaDal(ciX, nombreX, PaternoX, MaternoX, telefonoX, celularX, direccionX, mailX);
            string cmdsql = "insert into Tribunal_externo (id_persona,estado) values(" + id_persona + ",1)";
            Conexion.setdatos(cmdsql);
        }
        public DataTable  SeleccionarTribunalExternoCriterioDal(string ciX,string nombreX,string PaternoX,string MaternoX,int estadoX)
        {
            string cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Tribunal_externo.id_tribunal_externo from Persona,Tribunal_externo where Persona.id_persona=Tribunal_externo.id_persona ";

            string ByEstado = "";
            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";

            if (estadoX == 0)
                ByEstado = " and Tribunal_externo.estado=0";
            else
                ByEstado = " and Tribunal_externo.estado=1";
            if (ciX != "" & ciX != null)
                ByCi = " and Persona.ci='" + ciX + "'";
            if (nombreX != "" & nombreX != null)
                ByNombre = " and Persona.nombre='" + nombreX + "'";
            if (PaternoX != "" & PaternoX != null)
                ByPaterno = " and Persona.paterno='" + PaternoX + "'";
            if (MaternoX != "" & MaternoX != null)
                ByMaterno = " and Persona.materno='" + MaternoX + "'";

            return Conexion.getdatos(cmdsql + ByEstado + ByCi + ByNombre + ByPaterno + ByMaterno);
        }
        public DataTable VerificarChoqueDefensasTribunalExternoDal(int id_tribunal_externoX,string fechaX,string horaX)
        {
            string cmdsql = "select MOD_III.id_tribunal_externo,Defensa.hora,Defensa.fecha,Defensa.id_defensa from MOD_III,Defensa where MOD_III.id_mod_III=Defensa.id_mod_III and Defensa.estado=1  and MOD_III.id_tribunal_externo=" + id_tribunal_externoX;
            string Byhora = "";
            string ByFecha = "";
            if (horaX != "")
            {
                Byhora = " and Defensa.hora='" + horaX + "'";
            }
            if (fechaX != "")
                ByFecha = " and Defensa.fecha='" + fechaX + "'";
            return Conexion.getdatos(cmdsql+Byhora + ByFecha);
        }
        public DataTable SeleccionarTribunalExternoPorIdModIIIDal(int id_mod_IIIX)
        {
            string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,MOD_III.id_tribunal_externo from Persona,Tribunal_externo,MOD_III,Defensa where Persona.id_persona=Tribunal_externo.id_persona and Tribunal_externo.id_tribunal_externo=MOD_III.id_tribunal_externo and MOD_III.id_mod_III=" + id_mod_IIIX+" and Defensa.id_mod_III=MOD_III.id_mod_III and Defensa.estado=1";
            return Conexion.getdatos(cmdsql);
        }
    }
}
