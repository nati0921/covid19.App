using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioSede
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllSede - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Sede> GetAllSede();
        
        //AddSede//Neceistamos un retorno para verificar que funciona bien
        Sede AddSede(Sede sede);

        //UpdateSalones
        Sede UpdateSede(Sede sede);
        
        //DeleteSede // no retorna nada
        void DeleteSede(int idsede);

        //GetSalones //para buscar retorna lo que encontramos
        Sede GetSede(int idsede);
    }
}