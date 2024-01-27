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
    public partial class RegistrarCompras : Form
    {
        Proveedor _proveedor;
        Producto producto;
        bool ProductoExiste = false;
        private Empleado Emp;
        int folio = new CN_Compra().obtenerFolio();
        public RegistrarCompras(Empleado emp = null)
        {
            Emp = emp;
            InitializeComponent();
        }

        private void RegistrarCompras_Load(object sender, EventArgs e)
        {
            IDCOMPRA.Text = folio.ToString();
            nomEmp.Text = Emp.nombreCompleto;
            IdEmpleado.Text = Emp.IdEmpleado.ToString();
            Fecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Proveedor oProveedor = new CN_Proveedor().Listar().Where(p => p.idProveedor == Convert.ToInt32(txtIdCliente.Text)).FirstOrDefault();
                if (oProveedor != null)
                {
                    txtIdCliente.BackColor = Color.Honeydew;
                    txtIdCliente.Text = oProveedor.idProveedor.ToString();
                    nombreProvee.Text = oProveedor.nombreProveedor;
                    correoProveedor.Text = oProveedor.correo;
                    TelefonoProvee.Text = oProveedor.telefono;
                    Empresa.Text = oProveedor.nombreEmpresa;
                }
                else
                {
                    nombreP.BackColor = Color.MistyRose;
                    MessageBox.Show("No existe el id del proveedor");

                }
            }
        }

        private void CodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.idProducto == Convert.ToInt32(CodigoProducto.Text)).FirstOrDefault();
                if (oProducto != null)
                {
                    foreach (DataGridViewRow fila in Datoscompra.Rows)
                    {
                        if (fila.Cells["ID"].Value.ToString() == CodigoProducto.Text)
                        {
                            PrecioDCompra.Text = fila.Cells["Precio"].Value.ToString();
                            PrecioDCompra.Enabled = false;
                            ProductoExiste = true;
                            break;
                        }
                    }
                    CodigoProducto.BackColor = Color.Honeydew;
                    CodigoProducto.Text = oProducto.idProducto.ToString();
                    nombreP.Text = oProducto.nombre;
                    Modelo.Text = oProducto.modelo;
                    PrecioDCompra.Text = oProducto.valorCompra.ToString();

                }
                else
                {
                    CodigoProducto.BackColor = Color.MistyRose;
                    MessageBox.Show("El producto no existe");
                }


            }
        }

        private void CalcularSubtotal()
        {
            decimal total1 = 0;
            if (Datoscompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow row in Datoscompra.Rows)
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

            total.Text = total1.ToString("0.00");
        }

        private void AgProdComp_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;

            if (int.Parse(CodigoProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(PrecioDCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - forma incorrecta de la moneda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PrecioDCompra.Select();
                return;
            }



            if (!ProductoExiste)
            {
                Datoscompra.Rows.Add(new object[] {
                CodigoProducto.Text,
                nombreP.Text,
                Modelo.Text,
                precioCompra.ToString("0.00"),
                CantidadComp.Value,
                (CantidadComp.Value * Convert.ToInt32(PrecioDCompra.Text)).ToString("0.00")
                });

                CalcularSubtotal();
                limpiarProduto();
                CodigoProducto.Select();
            }
            else
            {
                foreach (DataGridViewRow fila in Datoscompra.Rows)
                {
                    if (fila.Cells["ID"].Value.ToString() == CodigoProducto.Text)
                    {
                        fila.Cells["Cantidad"].Value = Convert.ToInt32(fila.Cells["Cantidad"].Value) + CantidadComp.Value;
                        fila.Cells["Importe"].Value = Convert.ToDecimal(fila.Cells["Precio"].Value) * Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        CalcularSubtotal();
                        limpiarProduto();
                        CodigoProducto.Select();
                        break;
                    }
                }
            }
        }

        private void limpiarProduto()
        {
           
            CodigoProducto.Text = "";
            nombreP.Text = "";
            PrecioDCompra.Text = "";
            PrecioDCompra.Enabled = true;
            Modelo.Text = "";
            CantidadComp.Value = 1;
            CodigoProducto.BackColor = Color.White;
            ProductoExiste = false;
        }

        private void Datoscompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void Datoscompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Datoscompra.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    Datoscompra.Rows.RemoveAt(indice);
                    CalcularSubtotal();

                }
            }
        }

        private void RegistrarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCliente.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Datoscompra.Rows.Count < 1)
            {
                MessageBox.Show("Agrega productos para poder registrar una compra");
                return;
            }
            DataTable detalleCompra = new DataTable();
            detalleCompra.Columns.Add("IdProduto", typeof(int));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("precioDeCompra", typeof(decimal));

            foreach (DataGridViewRow row in Datoscompra.Rows)
            {
                detalleCompra.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["ID"].Value),
                    Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value)
                });

            }


            Compra ocompras = new Compra()
            {
                idProveedor = new Proveedor() { idProveedor = Convert.ToInt32(txtIdCliente.Text) },
                idempleado = new Empleado() { IdEmpleado = Emp.IdEmpleado },
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().RegistrarCompras(ocompras, detalleCompra, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra:\n" + folio.ToString());
                CodigoProducto.Text = "";
                txtIdCliente.Text = "";
                nombreProvee.Text = "";
                TelefonoProvee.Text = "";
                correoProveedor.Text = "";
                Empresa.Text = "";
                Datoscompra.Rows.Clear();
                folio = new CN_Compra().obtenerFolio();
                IDCOMPRA.Text = folio.ToString();
                Fecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtIdCliente.BackColor = Color.White;
                CalcularSubtotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
 }

