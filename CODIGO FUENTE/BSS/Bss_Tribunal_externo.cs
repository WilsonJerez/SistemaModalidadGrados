using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BSS
{
  public  class Bss_Tribunal_externo:BSS.Bss_Persona
    {
      protected  int id_tribunal_externo;
      protected  int estado;

      public int ID_TRIBUNAL_EXTERNO
      {
          get { return this.id_tribunal_externo; }
          set { this.id_tribunal_externo = value; }
      }
      public int ESTADO
      {
          get { return this.estado; }
          set { this.estado = value; }
      }
        public void InsertarTribunalExternoBss()
        {
            DAL.Dal_Tribunal_Externo ObjtribEx = new DAL.Dal_Tribunal_Externo();
            ObjtribEx.InsertarTribunalExternoDal(this.CI, this.NOMBRE, this.PATERNO, this.MATERNO, this.TELEFONO, this.CELULAR, this.DIRECCION, this.MAIL);
        }
        public DataTable SeleccionarPorCriterioTribunalExternoBss()
        {
            DAL.Dal_Tribunal_Externo ObjtribEx = new DAL.Dal_Tribunal_Externo();
            return ObjtribEx.SeleccionarTribunalExternoCriterioDal(this.CI, this.NOMBRE, this.PATERNO, this.MATERNO, this.ESTADO);
        }
        public DataTable VerificarChoqueDefensasTribunalExternoBss(string fechaX,string horaX)
        {
            DAL.Dal_Tribunal_Externo ObjtribEx = new DAL.Dal_Tribunal_Externo();
            return ObjtribEx.VerificarChoqueDefensasTribunalExternoDal(this.ID_TRIBUNAL_EXTERNO,fechaX,horaX);
        }
        public DataTable SeleccionarTribunalExternoPorIdModIIIDal(int id_mod_IIIX)
        {
            DAL.Dal_Tribunal_Externo ObjTribEx = new DAL.Dal_Tribunal_Externo();
            return ObjTribEx.SeleccionarTribunalExternoPorIdModIIIDal(id_mod_IIIX);
        }

    }
}
