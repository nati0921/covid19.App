using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllDiagnostico - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Diagnostico> GetAllDiagnostico();
        
        //AddDiagnostico//Neceistamos un retorno para verificar que funciona bien
        Diagnostico AddDiagnostico(Diagnostico diagnostico);

        //UpdateDiagnostico
        Diagnostico UpdateDiagnostico(Diagnostico diagnostico);
        
        //DeleteDiagnostico // no retorna nada
        void DeleteDiagnostico(int iddiagnostico);

        //GetDiagnostico //para buscar retorna lo que encontramos
        Diagnostico GetDiagnostico(int iddiagnostico);
    }
}