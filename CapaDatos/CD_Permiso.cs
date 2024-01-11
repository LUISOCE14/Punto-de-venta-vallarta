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
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idEmp)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection cconexion = new SqlConnection(Conexion.cadena))
            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu from Permisos p");
                    query.AppendLine("inner join Rol r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join Empleados e on e.Cargo = r.IdRol");
                    query.AppendLine("where e.idEmpleado = @idEmp");




                    SqlCommand cmd = new SqlCommand(query.ToString(), cconexion);
                    cmd.Parameters.AddWithValue("@idEmp", idEmp);
                    cmd.CommandType = CommandType.Text;

                    cconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                idRol = new Rol { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                nombreMenu = dr["NombreMenu"].ToString(),

                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
