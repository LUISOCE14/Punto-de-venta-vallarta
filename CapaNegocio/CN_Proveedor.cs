using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor obj_Prov = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return obj_Prov.Listar();
        }

        public int RegistrarProveedores(Proveedor objProv, out string mensaje)
        {
            mensaje = string.Empty;
            if (objProv.nombreEmpresa == "")
            {
                mensaje += "Es necesario llenar el campo empresa";
            }
            if (objProv.nombreProveedor == "")
            {
                mensaje += "Es necesario el nombre  del proveedoor";
            }
            if (objProv.telefono == "" )
            {
                mensaje += "Es necesario el telefono del proveedor";
            }
            else if (objProv.telefono.All(char.IsLetter))
            {
                mensaje += "El numero telefonico no debe llevar letras";
            }
            if(objProv.correo == "")
            {
                mensaje += "Es necesario llenar el campo correo";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return obj_Prov.RegistrarProveedores(objProv, out mensaje);
            }
        }

        public int UltimoId()
        {
            return obj_Prov.ultimoId();
        }


        public bool ModificarProveedores(Proveedor objProv, out string mensaje)
        {
            mensaje = string.Empty;
            if (objProv.nombreEmpresa == "")
            {
                mensaje += "Es necesario llenar el campo empresa";
            }
            if (objProv.nombreProveedor == "")
            {
                mensaje += "Es necesario el nombre  del proveedoor";
            }
            if (objProv.telefono == "")
            {
                mensaje += "Es necesario el telefono del proveedor";
            }
            else if (objProv.telefono.All(char.IsLetter))
            {
                mensaje += "El numero telefonico no debe llevar letras";
            }
            if (objProv.correo == "")
            {
                mensaje += "Es necesario llenar el campo correo";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return obj_Prov.ModificarProveedores(objProv, out mensaje);
            }
        }
    }
}
