using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioProfesor
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllProfesor - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Profesor> GetAllProfesor();
        
        //AddProfesor //Neceistamos un retorno para verificar que funciona bien
        Profesor AddProfesor(Profesor profesor);

        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        
        //DeleteProfesor // no retorna nada
        void DeleteProfesor(int idProfesor);

        //GetProfesor //para buscar retorna lo que encontramos
        Profesor GetProfesor(int idProfesor);
    }
}