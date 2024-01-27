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

namespace Punto_de_venta_vallarta
{
    public partial class RegistrarProveedores : Form
    {
        public RegistrarProveedores()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            //LIMPIAR TEXTBOXES
            nombreProveedor.Text = "";
            nombreEmpresa.Text = "";
            correoProveedor.Text = "";
            telProveedor.Text = "";
          
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            //Registrar Proveedores
            string mensaje = string.Empty;
            int id = new CN_Proveedor().UltimoId() + 1;
            Proveedor objProv = new Proveedor()
            {
                idProveedor = id,
                nombreProveedor = nombreProveedor.Text,
                nombreEmpresa = nombreEmpresa.Text,
                telefono = telProveedor.Text,
                correo = correoProveedor.Text,
                estado = true
            };

            int resuesta = new CN_Proveedor().RegistrarProveedores(objProv, out mensaje);
            if (resuesta == 0)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                limpiar();
                MessageBox.Show("Numero Identificador de Porveedor  " + resuesta);
            }
        }

        private void RegistrarProveedores_Load(object sender, EventArgs e)
        {
            int id = new CN_Proveedor().UltimoId() + 1;
            idFoli.Text = Convert.ToString(id);
        }
    }
}
