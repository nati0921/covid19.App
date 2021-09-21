using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            //var estudianteAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var estudianteAdicionado = _appContext.estudiante.Add(estudiante);
            _appContext.SaveChanges();
            //return estudianteAdicionado;
            return estudianteAdicionado.Entity;
        }

         Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            //var estudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = profesor.id);
            var estudianteEncontrado = _appContext.estudiante.FirstOrDefault(p => p.id == estudiante.id);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.id = estudiante.id;
                
                estudianteEncontrado.nombre = estudiante.nombre;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.edad = estudiante.edad;
                estudianteEncontrado.estado_covid = estudiante.estado_covid;

                estudianteEncontrado.carrera = estudiante.carrera;
                estudianteEncontrado.semestre =estudiante.semestre;
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        void IRepositorioEstudiante.DeleteEstudiante (int idestudiante)
        {
            //var EstudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var estudianteEncontrado = _appContext.estudiante.FirstOrDefault(p => p.id == idestudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.estudiante.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

         Estudiante IRepositorioEstudiante.GetEstudiante(int idestudiante)
        {
            //var EstudianteEncontrado= _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var estudianteEncontrado= _appContext.estudiante.FirstOrDefault(p => p.id == idestudiante);
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.estudiante;
        }
    }
}