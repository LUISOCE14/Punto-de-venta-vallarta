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
    public class CD_Proveedor
    {
        public int ultimoId()
        {
            //Metodo que retorna el ultimo id registrado
            int idUltEmp = 0;

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    cconexion.Open();
                    string query = "select max(idProveedor) from Proveedores";

                    SqlCommand cmd = new SqlCommand(query, cconexion);

                    if (cmd.ExecuteScalar() != null)
                    {
                        idUltEmp = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    else
                    {
                        idUltEmp = 0;
                    }
                }
                catch (Exception ex)
                {
                    idUltEmp = 0;
                }
            }

            return idUltEmp;

        }

        public List<Proveedor> Listar()
        {
            //Metodo que lista todos los registros que se encunetran en la base de datos

            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    string query = "select * from Proveedores";

                    SqlCommand cmd = new SqlCommand(query, cconexion);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(dr["idProveedor"]),
                                nombreProveedor = dr["Nombre"].ToString(),
                                nombreEmpresa = dr["Empresa"].ToString(),
                                telefono = dr["Telefono"].ToString(),
                                correo = dr["Correo"].ToString(),
                                estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }


        public int RegistrarProveedores(Proveedor obj, out string mensaje)
        {
            int respuesta = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPROVEEDOR", cconexion);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.idProveedor);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.nombreProveedor);
                    cmd.Parameters.AddWithValue("NombreEmpresa", obj.nombreEmpresa);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.correo);
                    cmd.Parameters.AddWithValue("Estado", obj.estado);
                    cmd.Parameters.Add("idProveedorResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["idProveedorResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;

        }


        public bool ModificarProveedores(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_MODIFICARPROVEEDOR", cconexion);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.idProveedor);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.nombreProveedor);
                    cmd.Parameters.AddWithValue("Empresa", obj.nombreEmpresa);
                    cmd.Parameters.AddWithValue("Telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.correo);
                    cmd.Parameters.AddWithValue("Estado", obj.estado);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    cconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }
    }
}
