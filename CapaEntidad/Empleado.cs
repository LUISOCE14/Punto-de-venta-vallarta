﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string nombreCompleto { get; set; }
        public Rol Cargo { get; set; }
        public string direccion { get; set; }

        public string correo { get; set; }

        public string telefono { get; set; }

        public bool Estado { get; set; }
    }
}
