using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSS
{
   public class Bss_Grupo:DAL.Dal_Grupo
    {
       protected int id_grupo;
       protected int id_aula;
       protected int id_contrato;
       protected int id_turno;
       protected int n_grupo;
       protected int gestion;
       protected string fecha_inicio;
       protected string fecha_final;
       protected int estado;

       public int ID_GRUPO
       {
           get { return this.id_grupo; }
           set { this.id_grupo = value; }
       }
       public int ID_AULA
       {
           get { return this.id_aula; }
           set { this.id_aula = value; }
       }
       public int ID_CONTRATO
       {
           get { return this.id_contrato; }
           set { this.id_contrato = value; }
       }
       public int ID_TURNO
       {
           get { return this.id_turno; }
           set { this.id_turno = value; }
       }
       public int N_GRUPO
       {
           get { return this.n_grupo; }
           set { this.n_grupo = value; }
       }
       public int GESTION
       {
           get { return this.gestion; }
           set { this.gestion = value; }
       }
       public string FECHA_INICIO
       {
           get { return this.fecha_inicio; }
           set { this.fecha_inicio = value; }
       }
       public string FECHA_FINAL
       {
           get { return this.fecha_final; }
           set { this.fecha_final = value; }
       }
       public int ESTADO
       {
           get { return this.estado; }
           set { this.estado = value; }
       }

       public void InsertarGrupoBss()
       {
           base.InsertarGrupoDal(this.ID_AULA, this.ID_CONTRATO, this.ID_TURNO, this.N_GRUPO, this.GESTION, this.FECHA_INICIO, this.FECHA_FINAL, this.ESTADO);
       }
       public DataTable SeleccionarGrupoBss()
       {
           return base.SeleccionarGrupoDal();
       }
       public DataTable SeleccionarGrupoCriterioBss()
       {
           return base.SeleccionarGrupoCriterioDal(this.ID_GRUPO,this.ID_AULA,this.ID_CONTRATO,this.ID_TURNO,this.N_GRUPO,this.GESTION,this.FECHA_INICIO,this.FECHA_FINAL,this.ESTADO);
       }
       public DataTable ContarRegistradosEnModalidad_I_PorGruposBss()
       {
           return base.ContarRegistradosEnModalidad_I_PorGruposDal(this.GESTION);
       }
       public void ModificarGrupoBss()
       {
           base.ModificarGrupoDal(this.ID_AULA, this.ID_CONTRATO, this.ID_TURNO, this.N_GRUPO, this.FECHA_INICIO, this.FECHA_FINAL, this.ESTADO, this.ID_GRUPO);
       }
       public void ServicioGrupoBss()
       {
           base.ServicioGrupo();
       }
    }
}
