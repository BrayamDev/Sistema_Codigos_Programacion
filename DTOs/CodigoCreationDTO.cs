using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaCodigoProgramacionBack.DTOs
{
    public class CodigoCreationDTO
    {
        [Required]
        public string tituloCodigo { get; set; }
        [Required]
        public string descripcionCorta { get; set; }
        [Required]
        public string imagenPortada { get; set; }
        [Required]
        public DateTime fechaCreacion { get; set; }
        [Required]
        public string linkCodigo { get; set; }

    }
}
