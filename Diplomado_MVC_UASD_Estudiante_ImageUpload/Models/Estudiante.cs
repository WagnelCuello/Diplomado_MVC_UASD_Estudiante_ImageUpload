using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_UASD_Estudiante_ImageUpload.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El Nombre del estudiante debe tener al menos 3 caracteres")]
        [MaxLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [MinLength(3, ErrorMessage = "El Apellido del estudiante debe tener al menos 3 caracteres")]
        [MaxLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La Direccion es obligatoria")]
        [MinLength(5, ErrorMessage = "La Direccion del estudiante debe tener al menos 5 caracteres")]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [MinLength(10, ErrorMessage = "El Telefono del estudiante debe tener al menos 10 caracteres")]
        [MaxLength(50)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La Cedula es obligatoria")]
        [MinLength(11, ErrorMessage = "La Cedula del estudiante debe tener al menos 11 caracteres")]
        [MaxLength(50)]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "La Imagen es obligatoria")]
        public string ImageUrl { get; set; }
    }
}