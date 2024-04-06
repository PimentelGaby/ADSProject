using ADSProyect.Models;
using System.Text.RegularExpressions;

namespace ADSProyect.Interfaces
{
    public interface IGrupo
    {
        public int AgregarGrupo(Grupo grupo);

        public int ActualizarGrupo(int idGrupo, Grupo grupo);

        public bool EliminarGrupo(int idGrupo);

        public List<Grupo> ObtenerTodosLosGrupos();

        public Grupo ObtenerGrupoPorId(int idGrupo);
    }
}
