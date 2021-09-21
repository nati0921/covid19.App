using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        private readonly AppContext _appContext;

        public RepositorioDiagnostico(AppContext appContext)
        {
            _appContext = appContext;
        }

        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico diagnostico)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var diagnosticoAdicionado = _appContext.diagnostico.Add(diagnostico);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return diagnosticoAdicionado.Entity;
        }

        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico diagnostico)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var diagnosticoEncontrado = _appContext.diagnostico.FirstOrDefault(p => p.id == diagnostico.id);
            if (diagnosticoEncontrado != null)
            {
                diagnosticoEncontrado.id = diagnostico.id;
                
                diagnosticoEncontrado.fecha = diagnostico.fecha;
                diagnosticoEncontrado.estado_covid = diagnostico.estado_covid;
                diagnosticoEncontrado.unidad = diagnostico.unidad;
                
                
                _appContext.SaveChanges();
            }
            return diagnosticoEncontrado;
        }

        void IRepositorioDiagnostico.DeleteDiagnostico (int iddiagnostico)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var diagnosticoEncontrado = _appContext.diagnostico.FirstOrDefault(p => p.id == iddiagnostico);
            if (diagnosticoEncontrado == null)
                return;
            _appContext.diagnostico.Remove(diagnosticoEncontrado);
            _appContext.SaveChanges();
        }

        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int iddiagnostico)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var diagnosticoEncontrado= _appContext.diagnostico.FirstOrDefault(p => p.id == iddiagnostico);
            return diagnosticoEncontrado;
        }

        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAllDiagnostico()
        {
            return _appContext.diagnostico;
        }
    }
}