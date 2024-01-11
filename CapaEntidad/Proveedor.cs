using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }

        public string nombreEmpresa { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
    }
}
