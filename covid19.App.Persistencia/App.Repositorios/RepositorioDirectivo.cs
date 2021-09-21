using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AppContext _appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Directivo IRepositorioDirectivo.AddDirectivo(Directivo directivo)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var directivoAdicionado = _appContext.directivo.Add(directivo);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return directivoAdicionado.Entity;
        }

        Directivo IRepositorioDirectivo.UpdateDirectivo(Directivo directivo)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var directivoEncontrado = _appContext.directivo.FirstOrDefault(p => p.id == directivo.id);
            if (directivoEncontrado != null)
            {
                directivoEncontrado.id = directivo.id;
                
                directivoEncontrado.nombre = directivo.nombre;
                directivoEncontrado.apellidos = directivo.apellidos;
                directivoEncontrado.edad = directivo.edad;
                directivoEncontrado.estado_covid = directivo.estado_covid;

                directivoEncontrado.unidad = directivo.unidad;
                
                _appContext.SaveChanges();
            }
            return directivoEncontrado;
        }

        void IRepositorioDirectivo.DeleteDirectivo (int iddirectivo)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var directivoEncontrado = _appContext.directivo.FirstOrDefault(p => p.id == iddirectivo);
            if (directivoEncontrado == null)
                return;
            _appContext.directivo.Remove(directivoEncontrado);
            _appContext.SaveChanges();
        }

        Directivo IRepositorioDirectivo.GetDirectivo(int iddirectivo)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var directivoEncontrado= _appContext.directivo.FirstOrDefault(p => p.id == iddirectivo);
            return directivoEncontrado;
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivo()
        {
            return _appContext.directivo;
        }
    }
}