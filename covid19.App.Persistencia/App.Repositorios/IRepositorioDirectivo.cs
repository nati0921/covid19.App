using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioDirectivo
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllDirectivo - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Directivo> GetAllDirectivo();
        
        //AddDirectivo //Neceistamos un retorno para verificar que funciona bien
        Directivo AddDirectivo(Directivo directivo);

        //UpdateDirectivo
        Directivo UpdateDirectivo(Directivo directivo);
        
        //DeleteDirectivo // no retorna nada
        void DeleteDirectivo(int iddirectivo);

        //GetDirectivo //para buscar retorna lo que encontramos
        Directivo GetDirectivo(int iddirectivo);
    }
}