
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Stock { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Precio { get; set; }
    }
}
