using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class MateriaRepository : IMateria
    {
        /*private List<Materia> lstMateria = new List<Materia>
        {
            new Materia{IdMateria = 1, NombreMateria = "Matematicas"}
        };*/

        private readonly ApplicationDbContext applicationDbContext;
        public MateriaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                /* int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == idMateria);

                 lstMateria[indice] = materia;*/

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);
                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);
                applicationDbContext.SaveChanges();

                return idMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                /*if (lstMateria.Count > 0)
                {
                    materia.IdMateria = lstMateria.Last().IdMateria + 1;
                }
                lstMateria.Add(materia);*/

                applicationDbContext.Materias.Add(materia);
                applicationDbContext.SaveChanges();

                return materia.IdMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                /* int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == idMateria);

                 lstMateria.RemoveAt(indice);*/

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);
                applicationDbContext.Materias.Remove(item);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ObtenerMateriaPorID(int idMateria)
        {
            throw new NotImplementedException();
        }

        public Materia ObtenerMateriaPorId(int idMateria)
        {
            try
            {
                var materia = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == idMateria);

                return materia;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Materia> ObtenerTodasLasMaterias()
        {
            try
            {
                return applicationDbContext.Materias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
