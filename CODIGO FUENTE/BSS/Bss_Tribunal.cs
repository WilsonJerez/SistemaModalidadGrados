using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Tribunal:BSS.Bss_Defensa
    {
       protected int id_tribunal;
       protected int id_contrato;
       protected int id_defensa;

       public int ID_TRIBUNAL
       {
           get { return this.id_tribunal; }
           set { this.id_tribunal = value; }
       }
       public int ID_CONTRATO
       {
           get { return this.id_contrato; }
           set { this.id_contrato = value; }
       }
       public int ID_DEFENSA
       {
           get { return this.id_defensa; }
           set { this.id_defensa = value; }
       }

       public void InsertarTribunalBss(int []Idscontratos)
       {
           base.InsertarTribunalDal(Idscontratos, base.ID_MODALIDAD_I, base.ID_MODALIDAD_II,base.ID_MOD_III, base.ID_AULA, base.FECHA, base.HORA, base.NOTA, base.NRO_ACTA, base.ESTADO);
       }
       public DataTable SeleccionarTribunalBss()
       {
           return base.SeleccionarTribunalDal();
       }
       public DataTable SeleccionarTribunalCriterioBss()
       {
           return base.SeleccionarTribunalDalCriterio(this.ID_CONTRATO, base.ID_MODALIDAD_I, base.ID_MODALIDAD_II, base.ID_AULA, base.FECHA, base.HORA, base.NOTA, base.NRO_ACTA,base.ESTADO);
       }
       public DataTable SeleccionarTribunalCriterioPorDefensaBss()
       {
           return base.SeleccionarTribunalCriterioPorDefensaDal(this.ID_DEFENSA);
       }
       public void ActrualizarTribunalBss()
       {
           base.ActualizarTribunal(this.ID_CONTRATO, this.ID_DEFENSA, this.NOTA, this.ID_TRIBUNAL);
       }
    }
}
