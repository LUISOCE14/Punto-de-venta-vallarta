using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta_vallarta.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace Punto_de_venta_vallarta
{
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            estadoCliente.Items.Add(new OpcionesCombo { valor = 1, texto = "Activo" });
            estadoCliente.Items.Add(new OpcionesCombo { valor = 0, texto = "Inactivo" });
            estadoCliente.DisplayMember = "texto";
            estadoCliente.ValueMember = "valor";
            estadoCliente.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in DatosClientes.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "Correo" || columna.HeaderText == "Nombre" || columna.HeaderText == "Estado" || columna.HeaderText == "ID")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar Clientes
            List<Cliente> listaCli = new CN_Cliente().Listar();

            foreach (Cliente item in listaCli)
            {
                DatosClientes.Rows.Add(new object[] {"", item.idCliente,item.nombre ,item.correo,item.telefono,item.direccion,
                    item.estado == true? 1:0,
                    item.estado == true? "Activo":"Inactivo"
                });

            }
        }

        private void limpiar()
        {
            txtIndi.Text = "-1";
            txtid.Text = "0";
            NombreClien.Text = " ";
            CorreoCliente.Text = " ";
            telCliente.Text = " ";
            dirCliente.Text = "";
            estadoCliente.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosClientes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBus.Text.Trim().ToUpper()))

                        row.Visible = true;

                    else

                        row.Visible = false;

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBus.Text = "";
            foreach (DataGridViewRow row in DatosClientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnEditarClien_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente objCli = new Cliente()
            {
                idCliente = Convert.ToInt32(txtid.Text),
                nombre = NombreClien.Text,
                correo = CorreoCliente.Text,
                telefono = telCliente.Text,
                direccion = dirCliente.Text,
                estado = Convert.ToInt32(((OpcionesCombo)estadoCliente.SelectedItem).valor) == 1 ? true : false
            };

            bool resultado = new CN_Cliente().ModificarClientes(objCli, out mensaje);
            if (resultado)
            {
                DataGridViewRow rows = DatosClientes.Rows[Convert.ToInt32(txtIndi.Text)];
                rows.Cells["IDCliente"].Value = txtid.Text;
                rows.Cells["Nombre"].Value = NombreClien.Text;
                rows.Cells["Correo"].Value = CorreoCliente.Text;
                rows.Cells["telCli"].Value = telCliente.Text;
                rows.Cells["Direccion"].Value = dirCliente.Text;
                rows.Cells["valorEstado"].Value = ((OpcionesCombo)estadoCliente.SelectedItem).valor.ToString(); ;
                rows.Cells["estadoCli"].Value = ((OpcionesCombo)estadoCliente.SelectedItem).texto.ToString();
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void DatosClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.seleccionar.Width;
                var h = Properties.Resources.seleccionar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.seleccionar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DatosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtIndi.Text = indice.ToString();
                txtid.Text = DatosClientes.Rows[indice].Cells["IDCliente"].Value.ToString();
                NombreClien.Text = DatosClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                CorreoCliente.Text = DatosClientes.Rows[indice].Cells["Correo"].Value.ToString();
                dirCliente.Text = DatosClientes.Rows[indice].Cells["Direccion"].Value.ToString();
                telCliente.Text = DatosClientes.Rows[indice].Cells["telCli"].Value.ToString();

                foreach (OpcionesCombo oc in estadoCliente.Items)
                {
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(DatosClientes.Rows[indice].Cells["valorEstado"].Value))
                    {
                        int indice_Combo = estadoCliente.Items.IndexOf(oc);
                        estadoCliente.SelectedIndex = indice_Combo;
                        break;
                    }
                }
            }
        }



    }
    
}
