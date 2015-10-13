using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.Dominio;
using System.Data.SqlClient;

namespace RESTServices.Persistencia
{
    public class SolicitudDAO
    {
        public Solicitud Crear(Solicitud solicitudACrear)
        {
            Solicitud solicitudCreada = new Solicitud();
            //string sql = "INSERT INTO Solicitud (cod_cliente, desc_solicitud, estado_solicitud, cod_producto) values (@cli, @desc, @est, @prod)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Sp_InsertarSolicitud", con))
                {
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    //com.Parameters.Add(new SqlParameter("@cod", solicitudACrear.Codigo));
                    com.Parameters.Add(new SqlParameter("@cli", solicitudACrear.Cliente));
                    com.Parameters.Add(new SqlParameter("@desc", solicitudACrear.Descripcion));
                    //com.Parameters.Add(new SqlParameter("@fec", solicitudACrear.Fecha));
                    //com.Parameters.Add(new SqlParameter("@est", solicitudACrear.Estado));
                    com.Parameters.Add(new SqlParameter("@prod", solicitudACrear.Producto));
                    com.ExecuteNonQuery();
                }
                solicitudCreada = Buscar(solicitudACrear);
                //solicitudCreada = Obtener(solicitudACrear.Codigo);
                return solicitudCreada;
            }
        }

        public Solicitud Obtener(int codigo)
        {
            Solicitud solicitudEncontrada = null;
            //string sql = "SELECT * from Solicitud where cod_solicitud= @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Sp_ObtenerSolicitud", con))
                {
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            solicitudEncontrada = new Solicitud()
                            {
                                Codigo = (int)resultado["cod_Solicitud"],
                                Cliente = (string)resultado["cod_Cliente"],
                                Descripcion = (string)resultado["desc_Solicitud"],
                                Fecha = (DateTime)resultado["fecha_Solicitud"],
                                Estado = (String)resultado["estado_Solicitud"],
                                Producto = (int)resultado["cod_Producto"]
                            };
                        }
                    }
                }
            }
            return solicitudEncontrada;
        }

        public Solicitud Modificar(Solicitud solicitudAModificar)
        {
            //string sql = "UPDATE Solicitud SET estado_solicitud=@est where cod_Solicitud=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Sp_ActualizarSolicitud", con))
                {
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@cod", solicitudAModificar.Codigo));
                    com.Parameters.Add(new SqlParameter("@est", solicitudAModificar.Estado));
                    com.ExecuteNonQuery();
                }
                return solicitudAModificar;
            }
        }

        public List<Solicitud> ListarTodos()
        {
            Solicitud solicitud = null;
            List<Solicitud> listaSolicitud = null;
            listaSolicitud = new List<Solicitud>();
            string sql = "SELECT * FROM Solicitud";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using(SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                solicitud = new Solicitud()
                                {
                                    Codigo = (int)resultado["cod_Solicitud"],
                                    Cliente = (string)resultado["cod_Cliente"],
                                    Descripcion = (string)resultado["desc_Solicitud"],
                                    Fecha = (DateTime)resultado["fecha_Solicitud"],
                                    Estado = (String)resultado["estado_Solicitud"],
                                    Producto = (int)resultado["cod_Producto"]
                                };
                                listaSolicitud.Add(solicitud);
                            }
                        }
                    }
                }
            }
            return listaSolicitud;
        }

        public List<Solicitud> ListarSolicitudesPorEstado(string estado)
        {
            Solicitud solicitud = null;
            List<Solicitud> listaSolicitud = null;
            listaSolicitud = new List<Solicitud>();
            //string sql = "SELECT * FROM Solicitud";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Sp_ListarSolicitudesPorEstado", con))
                {
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@est", estado));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                solicitud = new Solicitud()
                                {
                                    Codigo = (int)resultado["cod_Solicitud"],
                                    Cliente = (string)resultado["cod_Cliente"],
                                    Descripcion = (string)resultado["desc_Solicitud"],
                                    Fecha = (DateTime)resultado["fecha_Solicitud"],
                                    Estado = (String)resultado["estado_Solicitud"],
                                    Producto = (int)resultado["cod_Producto"]
                                };
                                listaSolicitud.Add(solicitud);
                            }
                        }
                    }
                }
            }
            return listaSolicitud;
        }


        private Solicitud Buscar(Solicitud solicitud)
        {
            Solicitud solicitudEncontrada = null;
            string sql = "SELECT top(1) * from Solicitud where cod_cliente=@cli and cod_producto=@prod order by cod_solicitud desc";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cli", solicitud.Cliente));
                    com.Parameters.Add(new SqlParameter("@prod", solicitud.Producto));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            solicitudEncontrada = new Solicitud()
                            {
                                Codigo = (int)resultado["cod_Solicitud"],
                                Cliente = (string)resultado["cod_Cliente"],
                                Descripcion = (string)resultado["desc_Solicitud"],
                                Fecha = (DateTime)resultado["fecha_Solicitud"],
                                Estado = (String)resultado["estado_Solicitud"],
                                Producto = (int)resultado["cod_Producto"]
                            };
                        }
                    }
                }
            }
            return solicitudEncontrada;
        }
    }
}