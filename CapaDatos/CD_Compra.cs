using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int obtenerCorrelativo()
        {
            int folio = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "select count(*) +1 from Compras";

                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();
                    folio = (int)cmd.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    folio = 0;
                }
            }
            return folio;
        }

        public bool RegistrarCompra(Compra obj, DataTable DetalleCompra, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "SP_REGISTRARCOMPRA";
                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.idProveedor.idProveedor);
                    cmd.Parameters.AddWithValue("IdEmpleado", obj.idempleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("Detalle_Compra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();



                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }


        public Compra obtenerCompra(int idCompra)
        {
            Compra obj = new Compra();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.idCompra,");
                    query.AppendLine("e.idEmpleado,e.Nombre,");
                    query.AppendLine("pr.idProveedor,pr.Nombre,pr.Empresa,pr.Telefono,pr.Correo,");
                    query.AppendLine("convert(char(10),c.fechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from Compras c");
                    query.AppendLine("inner join Empleados e on e.idEmpleado = c.IdEmpleado");
                    query.AppendLine("inner join Proveedores pr on pr.idProveedor = c.IdProveedor");
                    query.AppendLine("where c.idCompra = @idCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {

                            obj = new Compra()
                            {
                                idCompra = Convert.ToInt32(dr["idCompra"]),
                                idempleado = new Empleado() { IdEmpleado = Convert.ToInt32(dr["idEmpleado"]), nombreCompleto = dr.GetString(2) },
                                idProveedor = new Proveedor()
                                {
                                    idProveedor = dr.GetInt32(3),
                                    nombreProveedor = dr.GetString(4),
                                    nombreEmpresa = dr["Empresa"].ToString(),
                                    telefono = dr["Telefono"].ToString(),
                                    correo = dr["Correo"].ToString()
                                },
                                fechaRegistro = dr["FechaRegistro"].ToString(),

                            };
                        }

                    }
                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }

            return obj;
        }



        public List<DetalleCompra> DetallesCompra(int idcompra)
        {
            List<DetalleCompra> olista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {
                    cconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idProducto,p.NombreProducto,p.Modelo,dc.Cantidad,dc.precioDeCompra");
                    query.AppendLine("from Detalle_Compra dc ");
                    query.AppendLine("inner join Productos p on p.idProducto = dc.IdProducto");
                    query.AppendLine("where dc.IdCompra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            olista.Add(new DetalleCompra()
                            {
                                idProducto = new Producto()
                                {
                                    idProducto = Convert.ToInt32(dr["idProducto"].ToString()),
                                    nombre = dr["NombreProducto"].ToString(),
                                    modelo=dr["Modelo"].ToString()
                                },
                                cantidad = Convert.ToInt32(dr["Cantidad"]),
                                PrecioCompra = Convert.ToDecimal(dr["precioDeCompra"])
                            });
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                olista = new List<DetalleCompra>();
            }
            return olista;

        }
    }
}
