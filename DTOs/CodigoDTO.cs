using System;

namespace SistemaCodigoProgramacionBack.DTOs
{
    public class CodigoDTO
    {
        public int id { get; set; }
        public string tituloCodigo { get; set; }
        public string descripcionCorta { get; set; }
        public string imagenPortada { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string linkCodigo { get; set; }

    }
}
