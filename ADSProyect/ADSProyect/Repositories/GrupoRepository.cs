using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class GrupoRepository : IGrupo
    {
        /* private List<Grupo> lstGrupo = new List<Grupo>
         {
             new Grupo{IdGrupo = 1, IdCarrera=1, IdMateria = 1,IdProfesor=1,Ciclo=01,Anio=2022}
         };*/

        private readonly ApplicationDbContext applicationDbContext;
        public GrupoRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int ActualizarGrupo(int idGrupo, Grupo grupo)
        {
            try
            {
                /*int indice = lstGrupo.FindIndex(tmp => tmp.IdGrupo == idGrupo);

                lstGrupo[indice] = grupo;

                return idGrupo;*/

                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.IdGrupo == idGrupo);
                applicationDbContext.Entry(item).CurrentValues.SetValues(grupo);
                applicationDbContext.SaveChanges();
                return idGrupo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarGrupo(Grupo grupo)
        {
            try
            {
                /*if (lstGrupo.Count > 0)
                {
                    grupo.IdGrupo = lstGrupo.Last().IdGrupo + 1;
                }
                lstGrupo.Add(grupo);

                return grupo.IdGrupo;*/

                applicationDbContext.Grupos.Add(grupo);
                applicationDbContext.SaveChanges();

                return grupo.IdGrupo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                /*int indice = lstGrupo.FindIndex(tmp => tmp.IdGrupo == idGrupo);

                lstGrupo.RemoveAt(indice);*/


                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.IdGrupo == idGrupo);
                applicationDbContext.Grupos.Remove(item);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        public Grupo ObtenerGrupoPorId(int idGrupo)
        {
            try
            {
                /* Grupo grupo = lstGrupo.FirstOrDefault(tmp => tmp.IdGrupo == idGrupo);*/
                var grupo = applicationDbContext.Grupos.SingleOrDefault(x => x.IdGrupo == idGrupo);
                return grupo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Grupo> ObtenerTodosLosGrupos()
        {
            try
            {
                return applicationDbContext.Grupos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
