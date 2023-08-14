using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
    public class Bss_Mod_III:DAL.Dal_Mod_III
    {
        int id_mod_III;
        int id_modalidad_II;
        string fecha_inscripcion;
        string presidente;
        int id_tribunal_externo;
        int nota_externa;
        int estado;

        #region PROPIEDADES
        public int ID_MOD_III
        {
            set { this.id_mod_III = value; }
            get { return this.id_mod_III; }
        }
        public int ID_MODALIDAD_II
        {
            set { this.id_modalidad_II = value; }
            get { return this.id_modalidad_II; }
        }
        public string FECHA_INSCRIPCION
        {
            set { this.fecha_inscripcion = value; }
            get { return this.fecha_inscripcion; }
        }
        public string PRESIDENTE
        {
            set { this.presidente = value; }
            get { return this.presidente; }
        }
        public int ID_TRIBUNAL_EXTERNO
        {
            set { this.id_tribunal_externo = value; }
            get { return this.id_tribunal_externo; }
        }
        public int NOTA_EXTERNA
        {
            set { this.nota_externa = value; }
            get { return this.nota_externa; }
        }
        public int ESTADO
        {
            set { this.estado= value; }
            get { return this.estado; }
        }
        #endregion
        #region COMPORTAMIENTOS 
        public int InsertarMod_IIIBss()
        {
           return base.InsertarModIIIDal(this.id_modalidad_II, this.fecha_inscripcion, this.presidente, this.id_tribunal_externo, this.estado);
        }
        public DataTable SeleccinarModIIICriterioBss(string ciX, string nombreX, string paternoX, string maternoX,int estado_defensaX)
        {
            return base.SeleccinarModIIICriterioDal(ciX, nombreX, paternoX, maternoX,estado_defensaX,this.ID_MOD_III,this.ID_MODALIDAD_II, this.FECHA_INSCRIPCION, this.PRESIDENTE, this.ID_TRIBUNAL_EXTERNO, this.ESTADO);
        }
        public void ActualizarModIIIBss()
        {
            base.ActualizarModIIIDal(this.ID_MOD_III, this.NOTA_EXTERNA, this.PRESIDENTE, this.ID_TRIBUNAL_EXTERNO);
        }
        #endregion
    }
}
