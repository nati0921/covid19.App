using System.Collections.Generic;
using covid19.App.Dominio;

namespace covid19.App.Persistencia
{
    public interface IRepositorioSalones
    {
        //Aqui hacemo unicamente las firmas de los metodos
        //GetAllSalones - Que nos retornara todos los profesores por medio de una estructura de datos.
        IEnumerable<Salones> GetAllSalones();
        
        //AddSalones//Neceistamos un retorno para verificar que funciona bien
        Salones AddSalones(Salones salones);

        //UpdateSalones
        Salones UpdateSalones(Salones salones);
        
        //DeleteSalones // no retorna nada
        void DeleteSalones(int idsalones);

        //GetSalones //para buscar retorna lo que encontramos
        Salones GetSalones(int idsalones);
    }
}