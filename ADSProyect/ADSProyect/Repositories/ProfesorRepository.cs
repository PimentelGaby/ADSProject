using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        /*private List<Profesor> lstProfesor = new List<Profesor>
        {
            new Profesor{IdProfesor = 1, NombresProfesor="Maria", ApellidosProfesor = "Zaragoza", Email="mZaragoza1001@gmail.com"}
        };*/

        private readonly ApplicationDbContext applicationDbContext;
        public ProfesorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                /*int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                lstProfesor[indice] = profesor;*/

                var item = applicationDbContext.Profesors.SingleOrDefault(x => x.IdProfesor == idProfesor);
                applicationDbContext.Entry(item).CurrentValues.SetValues(profesor);
                applicationDbContext.SaveChanges();


                return idProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                /*if (lstProfesor.Count > 0)
                {
                    profesor.IdProfesor = lstProfesor.Last().IdProfesor + 1;
                }
                lstProfesor.Add(profesor);*/

                applicationDbContext.Profesors.Add(profesor);
                applicationDbContext.SaveChanges();

                return profesor.IdProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                var item = applicationDbContext.Profesors.SingleOrDefault(x => x.IdProfesor == idProfesor);
                applicationDbContext.Profesors.Remove(item);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

     

        public Profesor ObtenerProfesorPorId(int idProfesor)
        {
            try
            {
                var profesor = applicationDbContext.Profesors.SingleOrDefault(x => x.IdProfesor == idProfesor);

                return profesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

     
        public List<Profesor> ObtenerTodosLosProfesores()
        {
            try
            {
                return applicationDbContext.Profesors.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
