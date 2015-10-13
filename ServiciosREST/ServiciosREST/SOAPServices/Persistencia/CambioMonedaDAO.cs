using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTServices.Persistencia
{
    public class CambioMonedaDAO
    {
        public CambioMoneda Crear(CambioMoneda cambioACrear)
        {
            CambioMoneda cambioCreado = new CambioMoneda();
            string sql = "INSERT INTO CambioMoneda (cod_producto, cod_Cliente, Tipo_MonedaOrigen, Tipo_MonedaCambio, Monto, Cuotas, Fecha_Venc, Tasa_Interes, Tipo_CambioOrigen, estado_Solicitud) " +
                "values (@prod, @cli, @ori, @cam, @mon, @cuo, @fvenc, @tasa, @tc, @est)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@prod", cambioACrear.Producto));
                    com.Parameters.Add(new SqlParameter("@cli", cambioACrear.Cliente));
                    com.Parameters.Add(new SqlParameter("@ori", cambioACrear.MonedaOrigen));
                    com.Parameters.Add(new SqlParameter("@cam", cambioACrear.MonedaCambio));
                    com.Parameters.Add(new SqlParameter("@mon", cambioACrear.Monto));
                    com.Parameters.Add(new SqlParameter("@cuo", cambioACrear.Cuotas));
                    com.Parameters.Add(new SqlParameter("@fvenc", cambioACrear.FecVenc));
                    com.Parameters.Add(new SqlParameter("@tasa", cambioACrear.TasaInteres));
                    com.Parameters.Add(new SqlParameter("@tc", cambioACrear.TipoCambio));
                    com.Parameters.Add(new SqlParameter("@est", cambioACrear.Estado));
                    com.ExecuteNonQuery();
                }
                cambioCreado = Obtener(cambioACrear.Producto);
                return cambioCreado;
            }
        }

        public CambioMoneda Crear2(CambioMoneda cambioACrear)
        {
            CambioMoneda cambioCreado = new CambioMoneda();
            string sql = "INSERT INTO CambioMoneda (cod_producto, cod_Cliente, Tipo_MonedaOrigen, Tipo_MonedaCambio, Monto, Cuotas, Fecha_Venc) " +
                "values (@prod, @cli, @ori, @cam, @mon, @cuo, @fvenc)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@prod", cambioACrear.Producto));
                    com.Parameters.Add(new SqlParameter("@cli", cambioACrear.Cliente));
                    com.Parameters.Add(new SqlParameter("@ori", cambioACrear.MonedaOrigen));
                    com.Parameters.Add(new SqlParameter("@cam", cambioACrear.MonedaCambio));
                    com.Parameters.Add(new SqlParameter("@mon", cambioACrear.Monto));
                    com.Parameters.Add(new SqlParameter("@cuo", cambioACrear.Cuotas));
                    com.Parameters.Add(new SqlParameter("@fvenc", cambioACrear.FecVenc));
                    //com.Parameters.Add(new SqlParameter("@tasa", cambioACrear.TasaInteres));
                    //com.Parameters.Add(new SqlParameter("@tc", cambioACrear.TipoCambio));
                    //com.Parameters.Add(new SqlParameter("@est", cambioACrear.Estado));
                    com.ExecuteNonQuery();
                }
                cambioCreado = Obtener2(cambioACrear.Producto);
                return cambioCreado;
            }
        }

        public CambioMoneda Obtener(int codigo)
        {
            CambioMoneda cambioEncontrado = null;
            string sql = "SELECT * FROM CambioMoneda where cod_Producto=@prod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@prod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            cambioEncontrado = new CambioMoneda()
                            {
                                Producto = (int)resultado["cod_Producto"],
                                Cliente = (string)resultado["cod_Cliente"],
                                MonedaOrigen = (string)resultado["Tipo_MonedaOrigen"],
                                MonedaCambio = (string)resultado["Tipo_MonedaCambio"],
                                Monto = (decimal)resultado["Monto"],
                                Cuotas = (int)resultado["Cuotas"],
                                FecVenc = (DateTime)resultado["Fecha_Venc"],
                                //FecCambio = (DateTime)resultado["Fecha_Cambio"],
                                TasaInteres = (decimal)resultado["Tasa_Interes"],
                                TipoCambio = (decimal)resultado["Tipo_CambioOrigen"],
                                Estado = (string)resultado["estado_solicitud"]
                            };
                        }
                    }
                }
            }
            return cambioEncontrado;
        }

        public CambioMoneda Obtener2(int codigo)
        {
            CambioMoneda cambioEncontrado = null;
            string sql = "SELECT * FROM CambioMoneda where cod_Producto=@prod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@prod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            cambioEncontrado = new CambioMoneda()
                            {
                                Producto = (int)resultado["cod_Producto"],
                                Cliente = (string)resultado["cod_Cliente"],
                                MonedaOrigen = (string)resultado["Tipo_MonedaOrigen"],
                                MonedaCambio = (string)resultado["Tipo_MonedaCambio"],
                                Monto = (decimal)resultado["Monto"],
                                Cuotas = (int)resultado["Cuotas"],
                                FecVenc = (DateTime)resultado["Fecha_Venc"],
                                //FecCambio = (DateTime)resultado["Fecha_Cambio"],
                                //TasaInteres = (decimal)resultado["Tasa_Interes"],
                                //TipoCambio = (decimal)resultado["Tipo_CambioOrigen"],
                                //Estado = (string)resultado["estado_solicitud"]
                            };
                        }
                    }
                }
            }
            return cambioEncontrado;
        }
    }
}
