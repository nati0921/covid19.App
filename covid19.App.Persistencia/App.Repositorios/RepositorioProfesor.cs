using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private readonly AppContext _appContext;

        public RepositorioProfesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var profesorAdicionado = _appContext.Profesor.Add(profesor);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return profesorAdicionado.Entity;
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var profesorEncontrado = _appContext.Profesor.FirstOrDefault(p => p.id == profesor.id);
            if (profesorEncontrado != null)
            {
                profesorEncontrado.id = profesor.id;
                
                profesorEncontrado.nombre = profesor.nombre;
                profesorEncontrado.apellidos = profesor.apellidos;
                profesorEncontrado.edad = profesor.edad;
                profesorEncontrado.estado_covid = profesor.estado_covid;

                profesorEncontrado.departamento = profesor.departamento;
                profesorEncontrado.asignatura =profesor.asignatura;
                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        }

        void IRepositorioProfesor.DeleteProfesor (int idProfesor)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var profesorEncontrado = _appContext.Profesor.FirstOrDefault(p => p.id == idProfesor);
            if (profesorEncontrado == null)
                return;
            _appContext.Profesor.Remove(profesorEncontrado);
            _appContext.SaveChanges();
        }

        Profesor IRepositorioProfesor.GetProfesor(int idProfesor)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var profesorEncontrado= _appContext.Profesor.FirstOrDefault(p => p.id == idProfesor);
            return profesorEncontrado;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesor()
        {
            return _appContext.Profesor;
        }
    }
}