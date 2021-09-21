using covid19.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace covid19.App.Persistencia

{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext;

        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }

        HistoriaClinica IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaclinica)
        {
            //var profesorAdicionado = _appContext.Profesores.AddProfesor(profesor);
            var historiaclinicaAdicionado = _appContext.historiaclinica.Add(historiaclinica);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return historiaclinicaAdicionado.Entity;
        }

        HistoriaClinica IRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaclinica)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = profesor.id);
            var historiaclinicaEncontrado = _appContext.historiaclinica.FirstOrDefault(p => p.id == historiaclinica.id);
            if (historiaclinicaEncontrado != null)
            {
                //historiaclinicaEncontrado.id = historiaclinica.id;
                
                historiaclinicaEncontrado.fecha = historiaclinica.fecha;
                historiaclinicaEncontrado.seguimiento = historiaclinica.seguimiento;
                
                
                
                _appContext.SaveChanges();
            }
            return historiaclinicaEncontrado;
        }

        void IRepositorioHistoriaClinica.DeleteHistoriaClinica (int idhistoriaclinica)
        {
            //var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var historiaclinicaEncontrado = _appContext.historiaclinica.FirstOrDefault(p => p.id == idhistoriaclinica);
            if (historiaclinicaEncontrado == null)
                return;
            _appContext.historiaclinica.Remove(historiaclinicaEncontrado);
            _appContext.SaveChanges();
        }

        HistoriaClinica IRepositorioHistoriaClinica.GetHistoriaClinica(int idhistoriaclinica)
        {
            //var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.id = idProfesor);
            var historiaclinicaEncontrado= _appContext.historiaclinica.FirstOrDefault(p => p.id == idhistoriaclinica);
            return historiaclinicaEncontrado;
        }

        IEnumerable<HistoriaClinica> IRepositorioHistoriaClinica.GetAllHistoriaClinica()
        {
            return _appContext.historiaclinica;
        }
    }
}