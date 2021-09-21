using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioFoco : IRepositorioFoco
    {
        private readonly AppContext _appContext;

        public RepositorioFoco(AppContext appContext)
        {
            _appContext = appContext;
        }

        Foco IRepositorioFoco.AddFoco(Foco foco)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var focoAdicionado = _appContext.foco.Add(foco);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return focoAdicionado.Entity;
        }

        Foco IRepositorioFoco.UpdateFoco(Foco foco)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var focoEncontrado = _appContext.foco.FirstOrDefault(p => p.id == foco.id);
            if (focoEncontrado != null)
            {
                focoEncontrado.id = foco.id;
                
                focoEncontrado.num_contagios = foco.num_contagios;
                focoEncontrado.unidad = foco.unidad;
                                
                _appContext.SaveChanges();
            }
            return focoEncontrado;
        }

        void IRepositorioFoco.DeleteFoco (int idfoco)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var focoEncontrado = _appContext.foco.FirstOrDefault(p => p.id == idfoco);
            if (focoEncontrado == null)
                return;
            _appContext.foco.Remove(focoEncontrado);
            _appContext.SaveChanges();
        }

        Foco IRepositorioFoco.GetFoco(int idfoco)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var focoEncontrado= _appContext.foco.FirstOrDefault(p => p.id == idfoco);
            return focoEncontrado;
        }

        IEnumerable<Foco> IRepositorioFoco.GetAllFoco()
        {
            return _appContext.foco;
        }
    }
}