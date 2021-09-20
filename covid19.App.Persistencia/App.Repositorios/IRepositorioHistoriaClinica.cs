using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllHistoriaClinica - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();
        
        //AddHistoriaClinica//Neceistamos un retorno para verificar que funciona bien
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaclinica);

        //UpdateHistoriaClinica
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaclinica);
        
        //DeleteHistoriaClinica // no retorna nada
        void DeleteHistoriaClinica(int idhistoriaclinica);

        //GetDiagnostico //para buscar retorna lo que encontramos
        HistoriaClinica GetHistoriaClinica(int idhistoriaclinica);
    }
}