using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioFoco
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllFoco - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Foco> GetAllFoco();
        
        //AddFoco//Neceistamos un retorno para verificar que funciona bien
        Foco AddFoco(Foco foco);

        //UpdateFoco
        Foco UpdateFoco(Foco foco);
        
        //DeleteFoco // no retorna nada
        void DeleteDiagnostico(int idfoco);

        //GetFoco //para buscar retorna lo que encontramos
        Foco GetFoco(int idfoco);
    }
}