﻿using ADSProyect.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{

    [PrimaryKey(nameof(IdProfesor))]
    public class Profesor
    {
        public int IdProfesor { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "la longitud del campo no puede ser mayor  a 50 caracteres.")]
        public string NombresProfesor { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "la longitud del campo no puede ser mayor  a 50 caracteres.")]
        public string ApellidosProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "la longitud del campo no puede ser mayor  a 254 caracteres.")]
        public string Email { get; set; }
    }
}
