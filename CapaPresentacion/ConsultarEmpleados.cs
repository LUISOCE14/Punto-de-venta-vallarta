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
    public partial class ConsultarEmpleados : Form
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

      

        private void ConsultarEmpleados_Load(object sender, EventArgs e)
        {
            txtIn.Text = "-1";
            txtid.Text = "0";
            estadoEmple.Items.Add(new OpcionesCombo { valor = 1, texto = "Activo" });
            estadoEmple.Items.Add(new OpcionesCombo { valor = 0, texto = "Inactivo" });
            estadoEmple.DisplayMember = "texto";
            estadoEmple.ValueMember = "valor";
            estadoEmple.SelectedIndex = 0;
            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                RolEmplea.Items.Add(new OpcionesCombo() { valor = item.IdRol, texto = item.descripcion });
            }
            RolEmplea.DisplayMember = "texto";
            RolEmplea.ValueMember = "valor";
            RolEmplea.SelectedIndex = 0;



            foreach (DataGridViewColumn columna in DatosEmpleados.Columns)
            {
                if (columna.Visible == true)
                {
                    if (columna.HeaderText == "Correo" || columna.HeaderText == "Nombre" || columna.HeaderText == "Cargo" || columna.HeaderText == "Estado")
                    {
                        cbobusqueda.Items.Add(new OpcionesCombo() { valor = columna.Name, texto = columna.HeaderText });
                    }
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar Lista desde base de datos en tabla 
            List<Empleado> listaEmpl = new CN_Empleado().Listar();

            foreach (Empleado item in listaEmpl)
            {
                DatosEmpleados.Rows.Add(new object[] {"", item.IdEmpleado,item.nombreCompleto ,item.direccion,item.telefono,item.correo,
                    item.Cargo.IdRol,
                    item.Cargo.descripcion,
                    item.Estado == true? 1:0,
                    item.Estado == true? "Activo":"Inactivo"
                });

            }
        }

        private void DatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosEmpleados.Columns[e.ColumnIndex].Name == "btnSelecccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIn.Text = indice.ToString();
                    txtid.Text = DatosEmpleados.Rows[indice].Cells["ID"].Value.ToString();
                    NombreEmpl.Text = DatosEmpleados.Rows[indice].Cells["NombreEm"].Value.ToString();
                    DirEmpl.Text = DatosEmpleados.Rows[indice].Cells["Direccion"].Value.ToString();
                    telEmple.Text = DatosEmpleados.Rows[indice].Cells["Telefono"].Value.ToString();
                    CorreoEmple.Text = DatosEmpleados.Rows[indice].Cells["CorreoEmpleado"].Value.ToString();

                    foreach (OpcionesCombo oc in RolEmplea.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(DatosEmpleados.Rows[indice].Cells["idCargo"].Value))
                        {
                            int indice_Combo = RolEmplea.Items.IndexOf(oc);
                            RolEmplea.SelectedIndex = indice_Combo;
                            break;
                        }
                    }

                    foreach (OpcionesCombo oc in estadoEmple.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(DatosEmpleados.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_Combo = estadoEmple.Items.IndexOf(oc);
                            estadoEmple.SelectedIndex = indice_Combo;
                            break;
                        }
                    }
                }
            }
        }

        private void DatosEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbobusqueda.SelectedItem).valor.ToString();

            if (DatosEmpleados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosEmpleados.Rows)
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
            foreach (DataGridViewRow row in DatosEmpleados.Rows)
            {
                row.Visible = true;
            }
        }

        private void EditarEmpl_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Empleado objEmp = new Empleado()
            {
                IdEmpleado = Convert.ToInt32(txtid.Text),
                nombreCompleto = NombreEmpl.Text,
                Cargo = new Rol() { IdRol = Convert.ToInt32(((OpcionesCombo)RolEmplea.SelectedItem).valor) },
                direccion = DirEmpl.Text,
                telefono = telEmple.Text,
                correo = CorreoEmple.Text,
                Estado = Convert.ToInt32(((OpcionesCombo)estadoEmple.SelectedItem).valor) == 1 ? true : false
            };

            bool resultado = new CN_Empleado().EditarEmpleado(objEmp, out mensaje);
            if (resultado)
            {
                DataGridViewRow rows = DatosEmpleados.Rows[Convert.ToInt32(txtIn.Text)];
                rows.Cells["ID"].Value = txtid.Text;
                rows.Cells["NombreEm"].Value = NombreEmpl.Text;
                rows.Cells["Direccion"].Value = DirEmpl.Text;
                rows.Cells["Telefono"].Value = telEmple.Text;
                rows.Cells["idCargo"].Value = ((OpcionesCombo)RolEmplea.SelectedItem).valor.ToString();
                rows.Cells["Cargo"].Value = ((OpcionesCombo)RolEmplea.SelectedItem).texto.ToString();
                rows.Cells["CorreoEmpleado"].Value = CorreoEmple.Text;
                rows.Cells["estadoValor"].Value = ((OpcionesCombo)estadoEmple.SelectedItem).valor.ToString(); ;
                rows.Cells["Estado"].Value = ((OpcionesCombo)estadoEmple.SelectedItem).texto.ToString();
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void limpiar()
        {
            txtIn.Text = "-1";
            txtid.Text = "0";
            NombreEmpl.Text = " ";
            DirEmpl.Text = " ";
            CorreoEmple.Text = " ";
            telEmple.Text = " ";
            RolEmplea.SelectedIndex = 0;
            estadoEmple.SelectedIndex = 0;
        }

    }
}
