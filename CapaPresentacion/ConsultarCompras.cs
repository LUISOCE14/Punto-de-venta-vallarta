using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace Punto_de_venta_vallarta
{
    public partial class ConsultarCompras : Form
    {
        public ConsultarCompras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra oCompras = new CN_Compra().obtenerCompra(Convert.ToInt32(txtBuscar.Text));
            if (oCompras.idCompra != 0)
            {
                Fecha1.Text = oCompras.fechaRegistro;
                IDCOMPRA.Text = oCompras.idCompra.ToString();
                IdEmpleado.Text = oCompras.idempleado.IdEmpleado.ToString();
                nomEmp.Text = oCompras.idempleado.nombreCompleto;
                txtIdCliente.Text = oCompras.idProveedor.idProveedor.ToString();
                nombreProvee.Text = oCompras.idProveedor.nombreProveedor;
                TelefonoProvee.Text = oCompras.idProveedor.telefono;
                correoProveedor.Text = oCompras.idProveedor.correo;
                Empresa.Text = oCompras.idProveedor.nombreEmpresa;
                DatosCompra.Rows.Clear();

                foreach (DetalleCompra dc in oCompras.odetalleDCompra)
                {
                    DatosCompra.Rows.Add(new object[]
                    {
                        dc.idProducto.idProducto,dc.idProducto.nombre,dc.idProducto.modelo,dc.PrecioCompra,dc.cantidad,dc.PrecioCompra * dc.cantidad
                    });
                }
                CalcularSubtotal();

            }
            else
            {
                MessageBox.Show("No existe la compra");
                txtBuscar.Text = "";
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Fecha1.Text = "";
            IDCOMPRA.Text = "";
            nomEmp.Text = "";
            IdEmpleado.Text = "";
            txtIdCliente.Text = "";
            nombreProvee.Text = "";
            TelefonoProvee.Text = "";
            correoProveedor.Text = "";
            DatosCompra.Rows.Clear();
            Total.Text = "0.00";
            subtotal.Text = "0.00";
            Iva.Text = "0.00";
        }

        private void CalcularSubtotal()
        {
            decimal total1 = 0;
            if (DatosCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow row in DatosCompra.Rows)
                    total1 += Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
            }

            subtotal.Text = total1.ToString("0.00");
            CalcularIva();
        }

        private void CalcularIva()
        {
            decimal total = 0;
            decimal iva = 16;
            iva = iva / 100;
            total = iva * Convert.ToDecimal(subtotal.Text);

            Iva.Text = total.ToString("0.00");
            Calculartotal();
        }
        private void Calculartotal()
        {
            decimal total1 = 0;
            total1 = Convert.ToDecimal(subtotal.Text) + Convert.ToDecimal(Iva.Text);

            Total.Text = total1.ToString("0.00");
        }
    }
}
