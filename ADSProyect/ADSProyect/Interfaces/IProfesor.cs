﻿using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface IProfesor
    {
        public int AgregarProfesor(Profesor profesor);

        public int ActualizarProfesor(int idProfesor, Profesor profesor);

        public bool EliminarProfesor(int idProfesor);

        public List<Profesor> ObtenerTodosLosProfesores();

        public Profesor ObtenerProfesorPorId(int idProfesor);
    }
}
