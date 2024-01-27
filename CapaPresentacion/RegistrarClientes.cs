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
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
        }

       

        private void limpiar()
        {
            //LIMPIAR TEXTBOXES
            nombreClient.Text = " ";
            telCliente.Text = " ";
            CorreoClien.Text = " ";
            dirCliente.Text = "";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
             string mensaje = string.Empty;
            
            Cliente objCli = new Cliente()
            {
                idCliente = Convert.ToInt32(idFoli.Text),
                nombre = nombreClient.Text,
                telefono = telCliente.Text,
                correo = CorreoClien.Text,
                direccion = dirCliente.Text,
                estado = true
            };

            int resuesta = new CN_Cliente().RegistrarClientes(objCli, out mensaje);
            if (resuesta == 0)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                limpiar();
                MessageBox.Show("Numero identificador: "+ resuesta);
            }
        }

        private void RegistrarClientes_Load(object sender, EventArgs e)
        {
            int id = new CN_Cliente().UltimoId() + 1;
            idFoli.Text = Convert.ToString(id); 
        }
    }
}
