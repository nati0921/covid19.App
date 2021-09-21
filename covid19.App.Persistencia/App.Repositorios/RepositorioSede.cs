using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioSede : IRepositorioSede
    {
        private readonly AppContext _appContext;

        public RepositorioSede(AppContext appContext)
        {
            _appContext = appContext;
        }

        Sede IRepositorioSede.AddSede(Sede sede)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var sedeAdicionado = _appContext.sede.Add(sede);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return sedeAdicionado.Entity;
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var sedeEncontrado = _appContext.sede.FirstOrDefault(p => p.id == sede.id);
            if (sedeEncontrado != null)
            {
                sedeEncontrado.id = sede.id;
                
                sedeEncontrado.nombre_sede = sede.nombre_sede;
                sedeEncontrado.cant_salones = sede.cant_salones;
                
                          
                _appContext.SaveChanges();
            }
            return sedeEncontrado;
        }

        void IRepositorioSede.DeleteSede (int idsede)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var sedeEncontrado = _appContext.sede.FirstOrDefault(p => p.id == idsede);
            if (sedeEncontrado == null)
                return;
            _appContext.sede.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

        Sede IRepositorioSede.GetSede(int idsede)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var sedeEncontrado= _appContext.sede.FirstOrDefault(p => p.id == idsede);
            return sedeEncontrado;
        }

        IEnumerable<Sede> IRepositorioSede.GetAllSede()
        {
            return _appContext.sede;
        }
    }
}