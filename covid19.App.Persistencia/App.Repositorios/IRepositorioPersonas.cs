using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioPersonas
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllPersonas - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Personas> GetAllPersonas();
        
        //AddPersonas //Neceistamos un retorno para verificar que funciona bien
        Personas AddPersonas(Personas personas);

        //UpdatePersonas
        Personas UpdatePersonas(Personas personas);
        
        //DeletePersonas // no retorna nada
        void DeletePersonas(int idpersonas);

        //GetPersonas //para buscar retorna lo que encontramos
        Personas GetEPersonas(int idpersonas);
    }
}