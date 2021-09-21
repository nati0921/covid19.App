using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly AppContext _appContext;

        public RepositorioPersonas(AppContext appContext)
        {
            _appContext = appContext;
        }

        Personas IRepositorioPersonas.AddPersonas(Personas personas)
        {
            //var estudianteAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var personasAdicionado = _appContext.personas.Add(personas);
            _appContext.SaveChanges();
            //return estudianteAdicionado;
            return personasAdicionado.Entity;
        }

         Personas IRepositorioPersonas.UpdatePersonas(Personas personas)
        {
            //var estudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = profesor.id);
            var personasEncontrado = _appContext.personas.FirstOrDefault(p => p.id == personas.id);
            if (personasEncontrado != null)
            {
                personasEncontrado.id = personas.id;
                
                personasEncontrado.nombre = personas.nombre;
                personasEncontrado.apellidos = personas.apellidos;
                personasEncontrado.edad = personas.edad;
                personasEncontrado.estado_covid = personas.estado_covid;

                
                
                _appContext.SaveChanges();
            }
            return personasEncontrado;
        }

        void IRepositorioPersonas.DeletePersonas (int idpersonas)
        {
            //var EstudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var personasEncontrado = _appContext.personas.FirstOrDefault(p => p.id == idpersonas);
            if (personasEncontrado == null)
                return;
            _appContext.personas.Remove(personasEncontrado);
            _appContext.SaveChanges();
        }

        Personas IRepositorioPersonas.GetPersonas(int idpersonas)
        {
            //var EstudianteEncontrado= _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var personasEncontrado= _appContext.personas.FirstOrDefault(p => p.id == idpersonas);
            return personasEncontrado;
        }

        IEnumerable<Personas> IRepositorioPersonas.GetAllPersonas()
        {
            return _appContext.personas;
        }
    }
}