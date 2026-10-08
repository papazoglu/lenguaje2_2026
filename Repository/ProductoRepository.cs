using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProductoRepository
    {

        public Producto BuscarPorCodigo(string codigo)
        {
            var conSQL = new MySqlConnection();
            Producto producto = null;

            string sql = """
                 SELECT id_producto, descripcion, precio_venta
                 FROM producto
                 WHERE id_producto = @codigo
                 """;



            

            conSQL = Conexion.getInstancia("root", "root").CrearConexion();
           
            
                conSQL.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conSQL))
                {
                    comando.Parameters.AddWithValue("@codigo", codigo);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new Producto
                            {
                                Codigo = reader.GetInt32("id_producto"),
                                Descripcion = reader.GetString("descripcion"),
                                PrecioVenta = reader.GetDecimal("precio_venta")
                            };
                        }
                    }
                }
            

            return producto;
        }
    }
}
