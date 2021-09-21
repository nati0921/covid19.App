using System;
namespace covid19.App.Dominio
{
    public class Personas
    {
        public int id {get;set;}

        public string nombre {get;set;}

        public string apellidos {get;set;}

        public int edad {get;set;}

        public EstadoCovid estado {get;set;}

        public string sede {get;set;}

        
    }
}