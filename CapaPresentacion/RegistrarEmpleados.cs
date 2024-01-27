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
    public partial class RegistrarEmpleados : Form
    {
        public RegistrarEmpleados()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            //LIMPIAR TEXTBOX
            nombreEmpleado.Text = " ";
            dirEmpleado.Text = " ";
            correoEmpleado.Text = " ";
            telEmpleado.Text = " ";
            cargoEmple.SelectedIndex = 0;
        }

        private void RegistrarEmpleados_Load(object sender, EventArgs e)
        {
            int id = new CN_Empleado().UltimoId() + 1;
            idFoli.Text = Convert.ToString(id);

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cargoEmple.Items.Add(new OpcionesCombo() { valor = item.IdRol, texto = item.descripcion });
            }
            cargoEmple.DisplayMember = "texto";
            cargoEmple.ValueMember = "valor";
            cargoEmple.SelectedIndex = 0;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //Registrar Empleados
            string mensaje = string.Empty;
            int id = new CN_Empleado().UltimoId() + 1;
            Empleado objEmp = new Empleado()
            {
                IdEmpleado = id,
                nombreCompleto = nombreEmpleado.Text,
                Cargo = new Rol() { IdRol = Convert.ToInt32(((OpcionesCombo)cargoEmple.SelectedItem).valor) },
                direccion = dirEmpleado.Text,
                telefono = telEmpleado.Text,
                correo = correoEmpleado.Text,
                Estado = true
            };

            int idUsuarioGenerado = new CN_Empleado().RegistrarEmpleado(objEmp, out mensaje);
            if (idUsuarioGenerado == 0)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Numero de identificacion:" + Convert.ToString(id));
                limpiar();
            }
        }
    }
}
