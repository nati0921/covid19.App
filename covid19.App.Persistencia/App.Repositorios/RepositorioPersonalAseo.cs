using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private readonly AppContext _appContext;

        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }

        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalaseo)
        {
            //var estudianteAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var personalaseoAdicionado = _appContext.personalaseo.Add(personalaseo);
            _appContext.SaveChanges();
            //return estudianteAdicionado;
            return personalaseoAdicionado.Entity;
        }

         PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalaseo)
        {
            //var estudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = profesor.id);
            var personalaseoEncontrado = _appContext.personalaseo.FirstOrDefault(p => p.id == personalaseo.id);
            if (personalaseoEncontrado != null)
            {
                personalaseoEncontrado.id = personalaseo.id;
                
                personalaseoEncontrado.nombre = personalaseo.nombre;
                personalaseoEncontrado.apellidos = personalaseo.apellidos;
                personalaseoEncontrado.edad = personalaseo.edad;
                personalaseoEncontrado.estado_covid = personalaseo.estado_covid;

                personalaseoEncontrado.turno = personalaseo.turno;
                
                _appContext.SaveChanges();
            }
            return personalaseoEncontrado;
        }

        void IRepositorioPersonalAseo.DeletePersonalAseo (int idpersonalaseo)
        {
            //var EstudianteEncontrado = _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var personalaseoEncontrado = _appContext.personalaseo.FirstOrDefault(p => p.id == idpersonalaseo);
            if (personalaseoEncontrado == null)
                return;
            _appContext.personalaseo.Remove(personalaseoEncontrado);
            _appContext.SaveChanges();
        }

         PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int idpersonalaseo)
        {
            //var EstudianteEncontrado= _appContext.Estudiante.FirstOrDefault(p => p.id = idEstudiante);
            var personalaseoEncontrado= _appContext.personalaseo.FirstOrDefault(p => p.id == idpersonalaseo);
            return personalaseoEncontrado;
        }

        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonalAseo()
        {
            return _appContext.personalaseo;
        }
    }
}