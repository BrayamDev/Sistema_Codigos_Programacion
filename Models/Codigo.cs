using System;

namespace SistemaCodigoProgramacionBack.Models
{
    public class Codigo
    {
        public int id { get; set; }
        public string tituloCodigo { get; set; }
        public string descripcionCorta { get; set; }
        public string imagenPortada { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string linkCodigo { get; set; }

    }
}
