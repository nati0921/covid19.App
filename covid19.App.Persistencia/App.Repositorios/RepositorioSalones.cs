using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioSalones : IRepositorioSalones
    {
        private readonly AppContext _appContext;

        public RepositorioSalones(AppContext appContext)
        {
            _appContext = appContext;
        }

        Salones IRepositorioSalones.AddSalones(Salones salones)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var salonesAdicionado = _appContext.salones.Add(salones);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return salonesAdicionado.Entity;
        }

        Salones IRepositorioSalones.UpdateSalones(Salones salones)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var salonesEncontrado = _appContext.salones.FirstOrDefault(p => p.id == salones.id);
            if (salonesEncontrado != null)
            {
                salonesEncontrado.id = salones.id;
                
                salonesEncontrado.aforo = salones.aforo;
                salonesEncontrado.hora = salones.hora;
                salonesEncontrado.numero_puesto = salones.numero_puesto;
                salonesEncontrado.sede = salones.sede;
                salonesEncontrado.unidad = salones.unidad;
                
                          
                _appContext.SaveChanges();
            }
            return salonesEncontrado;
        }

        void IRepositorioSalones.DeleteSalones (int idsalones)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var salonesEncontrado = _appContext.salones.FirstOrDefault(p => p.id == idsalones);
            if (salonesEncontrado == null)
                return;
            _appContext.salones.Remove(salonesEncontrado);
            _appContext.SaveChanges();
        }

        Salones IRepositorioSalones.GetSalones(int idsalones)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var salonesEncontrado= _appContext.salones.FirstOrDefault(p => p.id == idsalones);
            return salonesEncontrado;
        }

        IEnumerable<Salones> IRepositorioSalones.GetAllSalones()
        {
            return _appContext.salones;
        }
    }
}