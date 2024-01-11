using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra obj_compr = new CD_Compra();
        public int obtenerFolio()
        {
            return obj_compr.obtenerCorrelativo();

        }

        public bool RegistrarCompras(Compra objcomp, DataTable detalleCompra, out string mensaje)
        {


            return obj_compr.RegistrarCompra(objcomp, detalleCompra, out mensaje);

        }

        public Compra obtenerCompra(int idcompra)
        {
            Compra oCompra = obj_compr.obtenerCompra(idcompra);

            if (oCompra.idCompra != 0)
            {
                List<DetalleCompra> odetallecompra = obj_compr.DetallesCompra(oCompra.idCompra);
                oCompra.odetalleDCompra = odetallecompra;
            }

            return oCompra;
        }
    }
}
