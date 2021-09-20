using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllPersonalAseo - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<PersonalAseo> GetAllPersonalAseo();
        
        //AddPersonalAseo //Neceistamos un retorno para verificar que funciona bien
        PersonalAseo AddPersonalAseo(PersonalAseo personalaseo);

        //UpdatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalaseo);
        
        //DeletePersonalAseo // no retorna nada
        void DeletePersonalAseo(int idpersonalaseo);

        //GetPersonalAseo //para buscar retorna lo que encontramos
        PersonalAseo GetPersonalAseo(int idpersonalaseo);
    }
}