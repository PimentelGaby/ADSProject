﻿using ADSProyect.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{

    [PrimaryKey(nameof(IdMateria))]
    public class Materia
    {
        public int IdMateria { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "la longitud del campo no puede ser mayor  a 50 caracteres.")]
        public string NombreMateria { get; set; }
    }
}
