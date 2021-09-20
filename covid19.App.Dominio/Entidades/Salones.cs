using System;
namespace covid19.App.Dominio
{
  public class Salones 
  {
      public int id {get;set;}
      public int aforo {get;set;}
      public DateTime hora {get;set;}
      public int numero_puesto {get;set;}
      public string sede {get;set;}
      public string unidad {get;set;}
  }  
}