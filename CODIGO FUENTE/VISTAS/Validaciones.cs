using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VISTAS
{
  public static class Validaciones
    {
      public static string DecimalSql2005(string X)
      {
          string aux = "";
          for (int i = 0; i < X.Length; i++)
          {
              if (X[i].ToString() == ",")
              {
                  aux = aux+".";
              }
              else
              {
                  aux = aux + X[i].ToString();
              }
          }
          return X;
      }
      public static bool Decimales(string X)
      {
          try
          {
              Convert.ToDecimal(X);
              return true;
          }
          catch
          {
              return false;
          }
      }
      public static bool ci(string X)
      {       
          
          return  Regex.IsMatch(X,@"^[1-9]{1}\d{6}$");
      }
      public static bool texto(string X)
      {
          
            return Regex.IsMatch(X, @"\w[a-zA-Z]");
         
      }
      public static bool telefono(string X)
      {
          return Regex.IsMatch(X, @"^66\d{5}$");
      }
      public static bool celular(string X)
      {
          return Regex.IsMatch(X, @"\d{8}$");
      }
      public static bool email(string email)
      {
          string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

          if (Regex.IsMatch(email, expresion))
          {
              if (Regex.Replace(email, expresion, String.Empty).Length == 0)
              { return true; }
              else
              { return false; }
          }
          else
          { return false; }
      }

      public static bool numero(string X)
      {
          return Regex.IsMatch(X, @"^\d+$");
      }
      public static bool hora(string X)
      {
          return Regex.IsMatch(X, @"\d[0-9]{2}\:\d[0-9]{2}");
      }

      public static bool fecha(string X)
      {
          bool retorno;
          string aux = "";
          string dia = "";
          string mes = "";
          string año = "";
          if (X.Length == 10)
          {
              for (int i = 0; i < X.Length; i++)
              {
                  if (X[i].ToString() == "/" || i == 9)
                  {
                      if (i == 2 & Validaciones.numero(aux) == true)
                      {
                          if (Convert.ToInt32(aux) <= 31 & Convert.ToInt32(aux) > 0)
                          {
                              dia = aux;
                              aux = "";
                          }
                      }
                      if (i == 5 & Validaciones.numero(aux) == true)
                      {
                          if (Convert.ToInt32(aux) <= 12 & Convert.ToInt32(aux) > 0)
                          {
                              mes = aux;
                              aux = "";
                          }
                      }
                      if (i > 5 & Validaciones.numero(aux) == true & aux.Length < 4)
                      {

                          año = aux + X[i].ToString();
                          aux = "";
                      }
                  }
                  else
                  {
                      aux = aux + X[i].ToString();
                  }
              }
              if (Validaciones.numero(dia)==true & Validaciones.numero(mes)==true & Validaciones.numero(año)==true)
              {
                  retorno = true;
              }
              else
              {
                  retorno = false;
              }
          }
          else
          {
              retorno = false;
          }
          

          return retorno;
      }

      // para convertir una fecha en el formato que sql permite el ingreso
      public static string ConvertirFechaSql2005_MMDDAA(string fechaX)
      {
          string auxdia = "";
          string auxmes = "";
          string auxaño = "";

          for (int i = 0; i < fechaX.Length; i++)
          {
              if (fechaX[i].ToString() != "/")
              {
                  auxdia =auxdia+ fechaX[i].ToString();
              }
              else
              {                  
                  auxmes = fechaX[i + 1].ToString() + fechaX[i + 2].ToString();
                  auxaño = fechaX[i + 4].ToString() + fechaX[i + 5].ToString() + fechaX[i + 6].ToString() + fechaX[i + 7].ToString();
                  break;
              }
           }

          return auxmes + "/" + auxdia + "/" + auxaño;
      }

      public static DateTime CalcularFechaFinalizacionModalidadII(DateTime fecha_inscripcionX)
      {
          DateTime FechaFinalizacion;
          int AñoInscripcion=fecha_inscripcionX.Year;
          int DiaInscripcion =fecha_inscripcionX.Day;
          int MesInscripcion =fecha_inscripcionX.Month;
          int MesAñosPresente = 12 - MesInscripcion;
          int MesFinalizacion=MesInscripcion+6;
          int MesesAñoSiguiente=0;

          int DiaFinalizacion=0;
          int MesFinalizacionModII=0;
          int AñoFinalizacion = 0;

          if(MesFinalizacion<=12)
          {
              if (DiaInscripcion <DateTime.DaysInMonth(AñoInscripcion, MesFinalizacion) )
              {
                  DiaFinalizacion = DiaInscripcion;
              }
              else
              {
                  DiaFinalizacion = DateTime.DaysInMonth(AñoInscripcion, MesFinalizacion);
              }
              MesFinalizacionModII = MesFinalizacion;
              AñoFinalizacion = AñoInscripcion;
          }
          else
          {
              MesesAñoSiguiente=MesFinalizacion-12;
              AñoFinalizacion=AñoInscripcion+1;

              if (DiaInscripcion <DateTime.DaysInMonth(AñoFinalizacion, MesesAñoSiguiente) )
              {
                  DiaFinalizacion = DiaInscripcion; 
              }
              else
              {
                  DiaFinalizacion = DateTime.DaysInMonth(AñoFinalizacion, MesesAñoSiguiente);              
              }
              MesFinalizacionModII = MesesAñoSiguiente;
              
          }

          return FechaFinalizacion = Convert.ToDateTime(DiaFinalizacion + "/" + MesFinalizacionModII + "/" + AñoFinalizacion);

      }
    }
}
