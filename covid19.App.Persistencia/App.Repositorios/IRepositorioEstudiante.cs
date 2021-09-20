using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllEstudiante - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Estudiante> GetAllEstudiante();
        
        //AddEstudiante //Neceistamos un retorno para verificar que funciona bien
        Estudiante AddEstudiante(Estudiante estudiante);

        //UpdateEstudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);
        
        //DeleteEstudiante // no retorna nada
        void DeleteEstudiante(int idestudiante);

        //GetEstudiante //para buscar retorna lo que encontramos
        Estudiante GetEstudiante(int idestudiante);
    }
}