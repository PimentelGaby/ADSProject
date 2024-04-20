using ADSProyect.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProyect.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Carrera> Carreras { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Profesor> Profesors { get; set; }


    }
}
