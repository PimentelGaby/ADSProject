using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class CarreraRepository : ICarrera
    {
        /* private List<Carrera> lstCarreras = new List<Carrera>
         {
             new Carrera
             {
                 IdCarrera = 1,
                 Codigo = "i04",
                 Nombre = "Ingeniería en Sistemas Commputacionales"
             },
             new Carrera
             {
                 IdCarrera = 2,
                 Codigo = "i01",
                 Nombre = "Ingeniería Electrica"
             },
             new Carrera
             {
                 IdCarrera = 3,
                 Codigo = "i03",
                 Nombre = "Ingeniería Industrial"
             }
         };*/
        private readonly ApplicationDbContext applicationDbContext;

        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                /* indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarreras[indice] = carrera;
                return idCarrera;*/

                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.IdCarrera == idCarrera);
                applicationDbContext.Entry(item).CurrentValues.SetValues(carrera);
                applicationDbContext.SaveChanges();
                return idCarrera;
            }
            catch
            {
                throw;
            }
        }

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                /*if (lstCarreras.Count > 0)
                {
                    carrera.IdCarrera = lstCarreras.Last().IdCarrera + 1;
                }

                lstCarreras.Add(carrera);

                return carrera.IdCarrera;*/

                applicationDbContext.Carreras.Add(carrera);
                applicationDbContext.SaveChanges();

                return carrera.IdCarrera;
            }
            catch
            {
                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                /* int indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                 lstCarreras.RemoveAt(indice);
                 return true;*/

                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.IdCarrera == idCarrera);
                applicationDbContext.Carreras.Remove(item);
                applicationDbContext.SaveChanges();


                return true;

            }
            catch
            {
                throw;
            }
        }

        public Carrera ObtenerCarreraPorID(int idCarrera)
        {
            try
            {
                /* Carrera carrera = lstCarreras.FirstOrDefault(tmp => tmp.IdCarrera == idCarrera);
                 return carrera;*/

                var carrera = applicationDbContext.Carreras.SingleOrDefault(x => x.IdCarrera == idCarrera);

                return carrera;
            }
            catch
            {
                throw;
            }
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            try
            {
                return applicationDbContext.Carreras.ToList();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
