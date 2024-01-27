using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace Punto_de_venta_vallarta
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public static Empleado empleadoAct;
        public Inicio(Empleado objEmpleado)
        {
            empleadoAct = objEmpleado;
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
            

        }

        private void RegistrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(RegistrarClientes, new RegistrarClientes());
         
        }

        private void registrarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarProducto, new RegistrarProductos());
        }

        private void registrarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarEmpleados, new RegistrarEmpleados());
        }

        private void registrarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarProveedores, new RegistrarProveedores());
        }

        private void consultarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarClientes, new ConsultarClientes());
        }

        private void ConsultarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ConsultarProductos, new ConsultarProductos());
        }

        private void consultarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarEmpleados, new ConsultarEmpleados());
        }

        private void consultarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarProveedores, new ConsultarProveedores());
        }

        private void registrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarVenta, new RegistrarVenta(empleadoAct));
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(registrarCompra, new RegistrarCompras(empleadoAct));
        }

        private void consultarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarVenta, new ConsultarVentas());
        }

        private void consultarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(consultarCompra, new ConsultarCompras());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Contenedor.Controls.Clear();
            menuActivo.BackColor = Color.White;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(empleadoAct.IdEmpleado);
            foreach (IconMenuItem iconMenu in MenuPrincipal.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.nombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            NombreUsuario.Text = empleadoAct.nombreCompleto;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    
}
