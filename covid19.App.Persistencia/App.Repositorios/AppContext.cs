using Microsoft.EntityFrameworkCore;
using covid19.App.Dominio;
using covid19.App.Persistencia;

namespace covid19.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Personas> Personas {get;set;}
        public DbSet<Profesor> Profesor {get;set;}
        public DbSet<Estudiante> Estudiante {get;set;}
        public DbSet<PersonalAseo> personasaseo {get;set;}
        public DbSet<Directivo> directivos {get;set;}
        public DbSet<Diagnostico> diagnosticos {get;set;}
        public DbSet<HistoriaClinica> historias {get;set;}
        public DbSet<Salones> salones {get;set;}
        public DbSet<Sede> sedes {get;set;}
        public DbSet<Foco> focos {get;set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog = Covid19Data");

            }
        }

    }
}