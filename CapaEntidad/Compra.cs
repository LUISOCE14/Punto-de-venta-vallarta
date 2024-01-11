using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }
        public Proveedor idProveedor { get; set; }
        public Empleado idempleado { get; set; }
        public string fechaRegistro { get; set; }
        public List<DetalleCompra> odetalleDCompra { get; set; }
    }
}
