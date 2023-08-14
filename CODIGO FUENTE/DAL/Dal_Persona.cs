using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
  public  class Dal_Persona
    {
        protected int InsertarPersonaDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX)
        {
            int idpersonaRecuperado;
            string cmdsql = "insert into Persona(ci,nombre,paterno,materno,telefono,celular,direccion,mail) values ('" + ciX + "','" + nombreX + "','" + paternoX + "','" + maternoX + "'," + telefonoX + "," + celularX + ",'" + direccionX + "','" + mailX + "')";
            Conexion.setdatos(cmdsql);
            return idpersonaRecuperado = Convert.ToInt32(SeleccionarPersonaCriterioDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX).Rows[0]["id_persona"]);
        }

        protected DataTable SeleccionarPersonaCriterioDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX)
        {
            string cmdsql = "select * from Persona where ";
            string aci = "";
            string anombre = "";
            string apaterno = "";
            string amaterno = "";
            string atelefono = "";
            string acelular = "";



            if (ciX != "" &ciX!=null)
                aci = "ci='" + ciX + "'";
            if (nombreX != ""&nombreX!=null)
                anombre = " and nombre='" + nombreX + "'";
            if (paternoX != "" & paternoX!=null)
                apaterno = " and paterno='" + paternoX + "'";
            if (maternoX != "" & maternoX!=null)
                amaterno = " and materno='" + maternoX + "'";
            if (telefonoX != 0)
                atelefono = " and telefono=" + telefonoX;
            if (celularX != 0)
                acelular = " and celular=" + celularX;

            return Conexion.getdatos(cmdsql + aci + anombre + apaterno + amaterno + atelefono + acelular);

        }
        protected void ModificarPersonaDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_personaX)
        {
            string cmdsql = "update Persona set ci='" + ciX + "',nombre='" + nombreX + "',paterno='" + paternoX + "',materno='" + maternoX + "',telefono='" + telefonoX + "',celular='" + celularX + "',direccion='" + direccionX + "',mail='" + mailX + "'where id_persona ='" + id_personaX + "'";
            Conexion.setdatos(cmdsql);

        }

      

        #region ESTUDIANTE //----------------------------------------------------------------

        protected void InsertarEstudianteDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_carreraX, int estadoX)
        {
            int id_personaX = InsertarPersonaDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX, direccionX, mailX);
            string cmdsql = "insert into Estudiante (id_persona,id_carrera,estado) values (" + id_personaX + "," + id_carreraX + "," + 1 + ")";
            Conexion.setdatos(cmdsql);
        }
        protected void InsertarEstudianteSegundaCarreraDal(int id_personaX,int id_carreraX,int estadoX)
        {
            string cmdsql = "insert into Estudiante (id_persona,id_carrera,estado) values (" + id_personaX + "," + id_carreraX + "," + 1 + ")";
            Conexion.setdatos(cmdsql);
        }

        protected DataTable SeleccionarEstudianteCriterioDal(int id_personaX,string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string mailX, int id_carreraX, int estadoX)
        {
            string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Persona.telefono,Persona.direccion,Persona.celular,Persona.mail,Persona.id_persona,Carrera.carrera,Carrera.id_carrera,Facultad.facultad,Facultad.id_facultad,Estudiante.estado,Estudiante.id_estudiante, Tipo_Modalidad.tipo_modalidad,Modalidad_I.id_modalidad_I,Modalidad_I.n_carta, Modalidad_I.tema, Tipo_Modalidad.id_tipo_modalidad, Grupo.n_grupo, Grupo.id_grupo from Estudiante,Persona,Carrera,Facultad,Tipo_Modalidad, Modalidad_I,Grupo where Estudiante.id_persona=Persona.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+Dal_Login.id_facultad+ "and Modalidad_I.id_estudiante=Estudiante.id_estudiante and Modalidad_I.id_tipo_modalidad=Tipo_Modalidad.id_tipo_modalidad and Modalidad_I.id_grupo=Grupo.id_grupo and Carrera.id_facultad=Facultad.id_facultad ";

            string ByIdPersona = "";
            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";
            string ByTelefono = "";
            string ByCelular = "";
            string ByMail = "";
            string ByIdCarrera = "";
            string ByEstado = "";

            if (estadoX == 0)
                ByEstado = " and Estudiante.estado=0";
            else
                ByEstado = " and Estudiante.estado=1";
            if (ciX != null & ciX !="")
                ByCi = " and Persona.ci='" + ciX + "'";
            if (nombreX != null & nombreX != "")
                ByNombre = " and Persona.nombre='" + nombreX + "'";
            if (paternoX != null & paternoX != "")
                ByPaterno = " and Persona.paterno='" + paternoX + "'";
            if (maternoX != null & maternoX != "")
                ByMaterno = " and Persona.materno='" + maternoX + "'";
            if (telefonoX > 0)
                ByTelefono = " and Persona.telefono=" + telefonoX;
            if (celularX > 0)
                ByCelular = " and Persona.celular=" + celularX;
            if (mailX != null & mailX != "")
                ByMail = " and Persona.mail='" + mailX + "'";
            if (id_carreraX > 0)
                ByIdCarrera = " and Estudiante.id_carrera=" + id_carreraX;
            if (id_personaX > 0)
                ByIdPersona = " and Estudiante.id_persona=" + id_personaX;

            return Conexion.getdatos(cmdsql + ByEstado + ByCi + ByNombre + ByPaterno + ByMaterno + ByTelefono + ByCelular + ByMail + ByIdCarrera+ByIdPersona);
        }

        protected DataTable SeleccionarEstudiantexcriteriosDal(int id_personaX,string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string mailX, int id_carreraX, int estadoX)
        {
            
            string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Persona.telefono,Persona.direccion,Persona.celular,Persona.mail,Persona.id_persona,Estudiante.id_estudiante,Carrera.carrera,Carrera.id_carrera,Estudiante.estado from Estudiante,Persona,Carrera where Estudiante.id_persona=Persona.id_persona and Estudiante.id_carrera=Carrera.id_carrera ";
            string ByIdPersona = "";
            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";
            string ByTelefono = "";
            string ByCelular = "";
            string ByMail = "";
            string ByIdCarrera = "";
            string ByEstado = "";

            if (estadoX == 0)
                ByEstado = " and Estudiante.estado=0";
            else
                ByEstado = " and Estudiante.estado=1";
            if (ciX != null & ciX != "")
                ByCi = " and Persona.ci='" + ciX + "'";
            if (nombreX != null & nombreX != "")
                ByNombre = " and Persona.nombre='" + nombreX + "'";
            if (paternoX != null & paternoX != "")
                ByPaterno = " and Persona.paterno='" + paternoX + "'";
            if (maternoX != null & maternoX != "")
                ByMaterno = " and Persona.materno='" + maternoX + "'";
            if (telefonoX > 0)
                ByTelefono = " and Persona.telefono=" + telefonoX;
            if (celularX > 0)
                ByCelular = " and Persona.celular=" + celularX;
            if (mailX != null & mailX != "")
                ByMail = " and Persona.mail='" + mailX + "'";
            if (id_carreraX > 0)
                ByIdCarrera = " and Estudiante.id_carrera=" + id_carreraX;
            if (id_personaX > 0)
                ByIdPersona = " and Estudiante.id_persona=" + id_personaX;

            return Conexion.getdatos(cmdsql + ByEstado + ByCi + ByNombre + ByPaterno + ByMaterno + ByTelefono + ByCelular + ByMail + ByIdCarrera+ByIdPersona);
        }
        
        protected void ModificarEstudianteDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_carreraX, int estadoX, int id_personaX)
        {
            ModificarPersonaDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX, direccionX, mailX, id_personaX);
            string cmdsql;
            if (id_carreraX > 0)
                
            {
                 cmdsql = "update Estudiante set id_carrera='" + id_carreraX + "',estado='" + estadoX + "' where id_persona= '" + id_personaX + "'";
            }
            else
            {
                cmdsql = "update Estudiante set estado='" + estadoX + "' where id_persona= '" + id_personaX + "'"; 
            }
            Conexion.setdatos(cmdsql);
        }

        protected DataTable FiltrarEstudiantesHabilitadosParaRepetirModalidadDal(string ciX,string nombreX,string paternoX,string maternoX)
        {
            DataTable DtRetorno= new DataTable();
            DataTable DtReprovadosModI = new DataTable();
            DataRow dr;
            int indice = 0;
            int limite = 0;
            string cmdsql="";

            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";

            if (ciX != "" & ciX != null)
                ByCi = " and Persona.ci='" + ciX + "'"; 
            if (nombreX != "" & nombreX != null)
                ByNombre = " and Persona.nombre='"+nombreX+"'";
            if (paternoX != "" & paternoX != null)
                ByPaterno = " and Persona.paterno='"+paternoX+"'";
            if (maternoX != "" & maternoX != null)
                ByMaterno = " and Persona.materno='" + maternoX + "'";
            //sentencia para buscar los que reprobados de la modalidad II y habilitados para repetir desde la modalidad I 
            cmdsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Estudiante.id_estudiante,Carrera.carrera from Persona,Estudiante,Carrera,Modalidad_I,Modalidad_II,DefeRepiMod_II where Persona.id_persona=Estudiante.id_persona and Estudiante.id_Carrera=Carrera.id_carrera and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I  and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+ " and Estudiante.id_estudiante not in(select id_estudiante from Modalidad_I where estado=1) and Estudiante.id_estudiante not in(select Modalidad_I.id_estudiante from Modalidad_I,Modalidad_II where Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.estado=1) and Estudiante.id_estudiante not in(select Modalidad_I.id_estudiante from Modalidad_I,Modalidad_II,Defensa where Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Defensa.id_modalidad_II and Defensa.estado=1)and Estudiante.id_estudiante not in(select Modalidad_I.id_estudiante from Modalidad_I,Modalidad_II,Defensa where Modalidad_I.id_modalidad_I=Modalidad_II.id_modalidad_I and Modalidad_II.id_modalidad_II=Defensa.id_modalidad_II and Defensa.estado=0 and Defensa.nro_acta='') and Modalidad_II.id_modalidad_II=DefeRepiMod_II.id_modalidad_II and DefeRepiMod_II.n=2 ";
            DtRetorno=Conexion.getdatos(cmdsql+ByCi+ByNombre+ByPaterno+ByMaterno);
            //sentencia para recuperar los que reprovaron en la modalidad I
            cmdsql="select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Estudiante.id_estudiante,Carrera.carrera from Persona,Estudiante,Carrera,Modalidad_I,DefeRepiMod_I where Persona.id_persona=Estudiante.id_persona and Estudiante.id_Carrera=Carrera.id_carrera and Estudiante.id_estudiante=Modalidad_I.id_estudiante and Modalidad_I.id_modalidad_I not in(select id_modalidad_I from modalidad_II) and Modalidad_I.id_modalidad_I=DefeRepiMod_I.id_modalidad_I and DefeRepiMod_I.n=2 and Carrera.id_facultad="+DAL.Dal_Login.id_facultad+" and Estudiante.id_estudiante not in(select id_estudiante from Modalidad_I where estado=1) and Estudiante.id_estudiante not in(select modalidad_I.id_estudiante from Modalidad_I,Defensa where Modalidad_I.id_modalidad_I=Defensa.id_modalidad_I and Defensa.estado=1)";
            DtReprovadosModI = Conexion.getdatos(cmdsql + ByCi + ByNombre + ByPaterno + ByMaterno);
            // ciclo para unir los reprovados
            limite = DtRetorno.Rows.Count + DtReprovadosModI.Rows.Count;
            for (int i = DtRetorno.Rows.Count; i < limite; i++)
            {
                DtRetorno.Rows.Add();
                DtRetorno.Rows[i]["ci"] = DtReprovadosModI.Rows[indice]["ci"];
                DtRetorno.Rows[i]["nombre"] = DtReprovadosModI.Rows[indice]["nombre"];
                DtRetorno.Rows[i]["paterno"] = DtReprovadosModI.Rows[indice]["paterno"];
                DtRetorno.Rows[i]["materno"] = DtReprovadosModI.Rows[indice]["materno"];
                DtRetorno.Rows[i]["id_estudiante"] = DtReprovadosModI.Rows[indice]["id_estudiante"];
                DtRetorno.Rows[i]["carrera"] = DtReprovadosModI.Rows[indice]["carrera"];
                indice++;
            }

            return DtRetorno;
        }

        // funcion para retornar estudiantes que esten por graduarse de una segunda carrera, la funcion dvolvera todos los estudiantes que ya hayan cursado una carra si el estudiante no cumple esto es por que nunca se registro
        protected DataTable FiltrarEstudiantesSegundaCarreraDal(string ciX, string nombreX, string paternoX, string maternoX)
        {
            string cmdsql="select Persona.id_persona,Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Persona.direccion,Persona.telefono,Persona.celular,Carrera.carrera from Persona,Estudiante,Carrera where Persona.id_persona=Estudiante.id_persona and Estudiante.id_carrera=Carrera.id_carrera and Carrera.id_facultad="+DAL.Dal_Login.id_facultad;
            string ByCi="";
            string ByNombre="";
            string ByPaterno="";
            string ByMaterno="";
            if(ciX!="" & ciX !=null)
            {
                ByCi=" and Persona.ci='"+ciX+"'";
            }
            if(nombreX!="" & nombreX!=null)
            {
                ByNombre=" and Persona.nombre='"+nombreX+"'";
            }
            if(paternoX!="" & paternoX!=null)
            {
                ByPaterno=" and Persona.paterno='"+paternoX+"'";
            }
            if(maternoX!="" & maternoX!=null)
            {
                ByMaterno=" and Persona.materno='"+maternoX+"'";
            }
            return Conexion.getdatos(cmdsql+ByCi+ByNombre+ByPaterno+ByMaterno);
        }
      //funcion creada para modificar solamente la carrera del estudiante independientemente de sus datos personales
       protected void ModificarCarreraEstudianteDal(int id_estudianteX,int id_carreraX)
        {
            string cmdsql = "";
            cmdsql = "update Estudiante set id_carrera=" + id_carreraX + "where id_estudiante="+id_estudianteX;
            Conexion.setdatos(cmdsql);            
        }
        #endregion

        #region ACADEMICOS
        protected int InsertarContratoDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_facultadX, int id_cargoX, int estadoX)
        {
            int id_personaX = Convert.ToInt32(InsertarPersonaDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX, direccionX, mailX));
            string cmdsql = "insert into Contrato(id_persona,id_cargo,id_facultad,estado) values(" + id_personaX + "," + id_cargoX + "," + id_facultadX + "," + estadoX + ")";
            Conexion.setdatos(cmdsql);
            return id_personaX;

        }
        protected DataTable SeleccionarContratoDal()
        {
            string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Cargo.cargo from Contrato,Persona,Cargo where Contrato.id_persona=Persona.id_persona and Contrato.id_cargo=Cargo.id_cargo";
            return Conexion.getdatos(cmdsql);
        }
        protected DataTable SeleccionarContratoCriterioDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_cargoX, int estadoX)
        {
            string cmdsql = "select Persona.id_persona, Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Persona.telefono, Persona.celular, Persona.direccion, Persona.mail,Cargo.cargo,Contrato.id_contrato,Contrato.estado,Curriculum.profesion,Curriculum.especialidad, Curriculum.curriculum from Contrato,Persona,Cargo,Curriculum where Contrato.id_persona=Persona.id_persona and Contrato.id_cargo=Cargo.id_cargo and Persona.id_persona=Curriculum.id_persona";
            string ByEstado = "";
            string ByCi = "";
            string ByNombre = "";
            string ByPaterno = "";
            string ByMaterno = "";
            string ByCargo = "";

            if (estadoX == 0)
                ByEstado = " and Contrato.estado=0";
            else
                ByEstado = " and Contrato.estado=1";
            if (ciX != "" & ciX != null)
                ByCi = " and Persona.ci='" + ciX + "'";
            if (nombreX != "" & nombreX != null)
                ByNombre = " and Persona.nombre='" + nombreX + "'";
            if (paternoX != "" & paternoX != null)
                ByPaterno = " and Persona.paterno='" + paternoX + "'";
            if (maternoX != "" & maternoX != null)
                ByMaterno = " and Persona.materno='" + maternoX + "'";
            if (id_cargoX != 0)
                ByCargo = " and Cargo.id_cargo=" + id_cargoX;


            return Conexion.getdatos(cmdsql + ByEstado + ByNombre + ByPaterno + ByMaterno + ByCargo + ByCi);
        }
        protected DataTable TutoresSinTutoriasDal()
        {
            string cmdsql = "select Persona.id_persona, Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Cargo.cargo,Contrato.id_contrato,Contrato.estado,Curriculum.profesion from Contrato,Persona,Cargo,Curriculum where Contrato.estado=1 and Contrato.id_persona=Persona.id_persona and Contrato.id_cargo=Cargo.id_cargo and Persona.id_persona=Curriculum.id_persona and Contrato.id_contrato  not in(select id_contrato from Modalidad_II where Modalidad_II.estado=1)";
            return Conexion.getdatos(cmdsql);
        }

        protected DataTable TutoresConTutoriasDal()
        {
            string cmdsql = "select TutoresHabilitados.n,Persona.id_persona, Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Cargo.cargo,Contrato.id_contrato,Contrato.estado,Curriculum.profesion from Contrato,Persona,Cargo,Curriculum,TutoresHabilitados where Contrato.estado=1 and Contrato.id_persona=Persona.id_persona and Contrato.id_cargo=Cargo.id_cargo and Persona.id_persona=Curriculum.id_persona and Contrato.id_contrato =TutoresHabilitados.id_contrato ";
            return Conexion.getdatos(cmdsql);
        }
        public void ModificarContratosDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX, int id_facultadX, int id_cargoX, int estadoX, int id_personaX)
        {
            ModificarPersonaDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX, direccionX, mailX, id_personaX);
            string cmdsql = "update Contrato set id_cargo='" + id_cargoX + "',id_facultad='" + id_facultadX + "',estado='" + estadoX + "' where id_persona= '" + id_personaX + "'";
            Conexion.setdatos(cmdsql);

        }
        protected DataTable SeleccionarContratoPorId(int id_contratoX)
        {
            string cmdsql = "select Persona.nombre,Persona.paterno,Persona.materno,Persona.ci,Contrato.id_contrato from Persona,Contrato where Persona.id_persona=Contrato.id_persona and Contrato.id_contrato=" + id_contratoX;
            return Conexion.getdatos(cmdsql);
        }



        #endregion
        #region USUARIOS SISTEMA
      //funcion para registrar usuarios para el sistema
        protected void InsertarUsuarioSistemaDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX,int id_facultadX,string usuarioX,string contraseñaX,int estadoX)
        {
            //guardamos los datos personales y recuperamos el id 
            int IdPersona = InsertarPersonaDal(ciX, nombreX, paternoX,maternoX, telefonoX, celularX, direccionX, mailX);
            string cmdsql = "insert into Usuarios(id_facultad,usuario,contraseña,estado,id_persona) values(" + id_facultadX + ",'" + usuarioX + "','" + contraseñaX + "'," + estadoX + ","+IdPersona+")";
            Conexion.setdatos(cmdsql);
        }
        protected void ModificarDatosPersonalesUsuarioSistemaDal(string ciX, string nombreX, string paternoX, string maternoX, int telefonoX, int celularX, string direccionX, string mailX)
        {
            ModificarPersonaDal(ciX, nombreX, paternoX, maternoX, telefonoX, celularX, direccionX, mailX, Dal_Login.id_persona);
        }
        protected void ModificarContraseñaUsuarioSistemaDal(int id_usuarioX,string contraseñaX)
        {
            string cmdsql = "update Usuarios set contraseña='" + contraseñaX + "' where id_usuario=" + id_usuarioX;
            Conexion.setdatos(cmdsql);
        }
        protected DataTable SeleccionarUsuarioSistemaDal(int id_usuarioX)
        {
            string cdmsql = "select Persona.ci,Persona.nombre,Persona.paterno,Persona.materno,Persona.telefono,Persona.celular,Persona.direccion,Persona.mail from Persona,Usuarios where Persona.id_persona=Usuarios.id_persona and Usuarios.id_usuario=" + id_usuarioX;
            return Conexion.getdatos(cdmsql);
        }
       
        #endregion



    }
}
