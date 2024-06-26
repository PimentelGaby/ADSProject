﻿using ADSProyect.Models;
using ADSProyect.Interfaces;
using ADSProyect.DB;
using ADSProyect.Migrations;
namespace ADSProyect.Repositories
{
    public class EstudianteRepository :IEstudiante
    {
        /*private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiante = "JUAN CARLOS",
            ApellidosEstudiante = "PEREZ SOSA", CodigoEstudiante = "PS24I04002",
            CorreoEstudiante = "PS24I04002@usonsonate.edu.sv" }
        };*/

        private readonly ApplicationDbContext applicationDbContext;
      public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
               
                /*int index = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

           
                lstEstudiantes[index] = estudiante;

                return idEstudiante;*/

                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);
                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);
                applicationDbContext.SaveChanges(); 
               return idEstudiante;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                // Validar si existen datos en la lista, de ser así, tomaremos el último ID
                // y lo incrementamos en una unidad
                /*if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }

                lstEstudiantes.Add(estudiante);*/
                applicationDbContext.Estudiantes.Add(estudiante);
                applicationDbContext.SaveChanges();

                return estudiante.IdEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                // Obtenemos el indice el objeto a eliminar
                /*int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                // Procedemos a eliminar el registro
                lstEstudiantes.RemoveAt(indice);*/

                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);
                applicationDbContext.Estudiantes.Remove(item);
                applicationDbContext.SaveChanges();
             

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                // Obtenemos el indice del objeto a eliminar
                /*Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);*/
                var estudiante = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                return estudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try
            {
                return applicationDbContext.Estudiantes.ToList();
            }
            catch (Exception) {
                throw;
            }
        }
    
}
}
