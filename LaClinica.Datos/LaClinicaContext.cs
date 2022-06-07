using LaClinica.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Datos
{
    public class LaClinicaContext : DbContext
    {

        public LaClinicaContext(DbContextOptions<LaClinicaContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Llamada> Llamadas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Ambulancia> Ambulancias { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }
        public DbSet<LlamadaSintoma> LlamadaSintomas { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LlamadaSintoma>().ToTable("LlamadaSintomas");
        //    modelBuilder.Entity<LlamadaSintoma>().HasKey(c => new { c.LlamadaId, c.SintomaId });
        //}

        
    }
}
