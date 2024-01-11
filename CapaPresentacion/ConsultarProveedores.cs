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
    public partial class ConsultarProveedores : Form
    {
        public ConsultarProveedores()
        {
            InitializeComponent();
        }

        private void ConsultarProveedores_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionesCombo { valor = 1, texto = "Activo" });
            cboEstado.Items.Add(new OpcionesCombo { valor = 0, texto = "Inactivo" });
            cboEstado.DisplayMember = "texto";
            cboEstado.ValueMember = "valor";
            cboEstado.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in DatosProveedores.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "Codigo" || columna.HeaderText == "Nombre" || columna.HeaderText == "Estado")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;


            //Mostrar Proveedores
            List<Proveedor> listaCli = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaCli)
            {
                DatosProveedores.Rows.Add(new object[] {"",item.idProveedor,item.nombreProveedor,item.nombreEmpresa ,item.telefono,item.correo,
                    item.estado == true? 1:0,
                    item.estado == true? "Activo":"Inactivo"
                });

            }
        }

        private void DatosProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtIndi.Text = indice.ToString();
                txtid.Text = DatosProveedores.Rows[indice].Cells["Codigo"].Value.ToString();
                NombreProved.Text = DatosProveedores.Rows[indice].Cells["Nombre"].Value.ToString();
                NomEmpresa.Text = DatosProveedores.Rows[indice].Cells["Empresa"].Value.ToString();
                CorrPro.Text = DatosProveedores.Rows[indice].Cells["Correo"].Value.ToString();
                TelProv.Text = DatosProveedores.Rows[indice].Cells["Telefono"].Value.ToString();
                foreach (OpcionesCombo oc in cboEstado.Items)
                {
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(DatosProveedores.Rows[indice].Cells["estadovalor"].Value))
                    {
                        int indice_Combo = cboEstado.Items.IndexOf(oc);
                        cboEstado.SelectedIndex = indice_Combo;
                        break;
                    }
                }
            }
        }

        private void DatosProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        private void limpiar()
        {
            txtIndi.Text = "-1";
            txtid.Text = "0";
            NomEmpresa.Text = " ";
            NombreProved.Text = "";
            CorrPro.Text = " ";
            TelProv.Text = " ";
            cboEstado.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosProveedores.Rows)
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
            foreach (DataGridViewRow row in DatosProveedores.Rows)
            {
                row.Visible = true;
            }
        }

        private void EditPro_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Proveedor objCli = new Proveedor()
            {
                idProveedor = Convert.ToInt32(txtid.Text),
                nombreProveedor = NombreProved.Text,
                nombreEmpresa = NomEmpresa.Text,
                correo = CorrPro.Text,
                telefono = TelProv.Text,
                estado = Convert.ToInt32(((OpcionesCombo)cboEstado.SelectedItem).valor) == 1 ? true : false
            };

            bool resultado = new CN_Proveedor().ModificarProveedores(objCli, out mensaje);
            if (resultado)
            {
                DataGridViewRow rows = DatosProveedores.Rows[Convert.ToInt32(txtIndi.Text)];
                rows.Cells["Codigo"].Value = txtid.Text;
                rows.Cells["Nombre"].Value = NombreProved.Text;
                rows.Cells["Empresa"].Value = NomEmpresa.Text;
                rows.Cells["Correo"].Value = CorrPro.Text;
                rows.Cells["Telefono"].Value = TelProv.Text;
                rows.Cells["estadoValor"].Value = ((OpcionesCombo)cboEstado.SelectedItem).valor.ToString(); ;
                rows.Cells["Estado"].Value = ((OpcionesCombo)cboEstado.SelectedItem).texto.ToString();
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
