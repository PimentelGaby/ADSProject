using ADSProyect.Models;
using static ADSProyect.Interfaces.IMateria;

namespace ADSProyect.Interfaces
{
    public interface IMateria
    {
        public interface IMateria
        {
            public int AgregarMateria(Materia materia);
            public int ActualizarMateria(int idMateria, Materia materia);
            public bool EliminarMateria(int idMateria);
            public List<Materia> ObtenerTodasLasMaterias();
            public Materia ObtenerMateriaPorId(int idMateria);
        }
    }
}
