using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        public int idDetalleCompra { get; set; }
        public Compra idCompras { get; set; }
        public Producto idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal PrecioCompra { get; set; }

    }
}
