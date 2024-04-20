using System.ComponentModel.DataAnnotations;
using ADSProyect.Interfaces;
using ADSProyect.Validation;
using Microsoft.EntityFrameworkCore;

namespace ADSProyect.Models
{

    [PrimaryKey(nameof(IdGrupo))]
    public class Grupo
    {
       
        public int IdGrupo { get; set; }
        [CustomRequerid(ErrorMessage = "Este campo es campo requerido y debe ser mayor a 0")]
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Anio { get; set; }
    }
}
