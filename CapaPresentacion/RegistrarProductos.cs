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
    public partial class RegistrarProductos : Form
    {
        public RegistrarProductos()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
           
                //Registrar Productos
                string mensaje = string.Empty;
                int id = new CN_Producto().obtenerID() + 1;
            Producto objProd = new Producto()
            {
                idProducto = id,
                nombre = nombreProducto.Text,
                modelo = Modelo.Text,
                descripcion = DescrProducto.Text,
                existencias = 0
            };

                int resuesta = new CN_Producto().RegistrarProductos(objProd, out mensaje);
                if (resuesta == 0)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Registro Exitoso");
                    limpiar();
                }
        }

        private void limpiar()
        {
            //LIMPIAR TEXTBOX
            nombreProducto.Text = "";
            Modelo.Text = "";
            DescrProducto.Text = "";
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
            int id = new CN_Producto().obtenerID() + 1;
            idFoli.Text = Convert.ToString(id);
        }
    }
}
