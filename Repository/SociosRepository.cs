using MySql.Data.MySqlClient;
using Model;

namespace Repository
{
    public class SociosRepository
    {

        public List<Socios> listarSocios()
        {
            List<Socios> resultado = new List<Socios>();
            MySqlDataReader reader = null;
            var conSQL = new MySqlConnection();
            string consulta;

            conSQL = Conexion.getInstancia("root", "root").CrearConexion();
            conSQL.Open();
            consulta = @"SELECT 
                         id_socio,
                         dni,
                         nombre,
                         apellido,
                         email,
                         direccion,
                         nombre_localidad,
                         localidad.id_localidad
                         FROM socios
                         INNER JOIN localidad
                         ON socios.id_localidad=localidad.id_localidad
                         ORDER BY id_socio";

            var comando = new MySqlCommand(consulta, conSQL);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado.Add(new Socios
                {
                    IdSocio = Convert.ToInt32(reader["id_socio"]),
                    Dni = Convert.ToInt32(reader["dni"]),
                    Nombre = reader["nombre"] == DBNull.Value ? null : Convert.ToString(reader["nombre"]),
                    Apellido = reader["apellido"] == DBNull.Value ? null : Convert.ToString(reader["apellido"]),
                    Email = reader["email"] == DBNull.Value ? null : Convert.ToString(reader["email"]),
                    Direccion = reader["direccion"] == DBNull.Value ? null : Convert.ToString(reader["direccion"]),
                    NombreLocalidad = reader["nombre_localidad"] == DBNull.Value ? null : Convert.ToString(reader["nombre_localidad"]),
                    IdLocalidad = Convert.ToInt32(reader["id_localidad"])
                });

            }

            return resultado;

        }

        public List<Localidad> CargarComboLocalidades()
        {

            MySqlDataReader dataReader;
            var sqlCon = new MySqlConnection();
            var lista = new List<Localidad>();
            string consulta;

            sqlCon = Conexion.getInstancia("root", "root").CrearConexion();
            sqlCon.Open();
            consulta = @"SELECT
                           id_localidad, 
                           nombre_localidad
                         FROM localidad 
                         order by id_localidad";
            var comando = new MySqlCommand(consulta, sqlCon);
            dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                lista.Add(new Localidad
                {
                    Id_localidad = dataReader.GetInt32(0),
                    NombreLocalidad = dataReader.GetString(1)
                });
            }

            return lista;

        }


        public bool updateSocio(Socios socio, int _accion)
        {
            //var sqlConn = new MySqlConnection();
            //var infiere que sqlConn es de tipo MySqlConnection()
            using (var sqlConn = Conexion.getInstancia("root", "root").CrearConexion())
            {
                sqlConn.Open();
                string query = @"update socios set
                                dni=@dni,
                                nombre=@nombre,
                                apellido=@apellido,
                                email=@email,
                                direccion=@direccion,
                                id_localidad=@id_localidad                               
                                where id_socio=@id_socio";
                MySqlCommand comando = new MySqlCommand(query, sqlConn);
                comando.Parameters.AddWithValue("@id_socio", socio.IdSocio);
                comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                comando.Parameters.AddWithValue("@email", socio.Email);
                comando.Parameters.AddWithValue("@direccion", socio.Direccion);
                comando.Parameters.AddWithValue("@dni", socio.Dni);
                comando.Parameters.AddWithValue("@id_localidad", socio.IdLocalidad);
                int resul = comando.ExecuteNonQuery();
                MessageBox.Show($"La consulta devolvio: {resul}");
                return true;
               
            }
            return false;
        }


        public bool insertSocio(Socios socio, int _accion)
        {
            //var sqlConn = new MySqlConnection();
            //var infiere que sqlConn es de tipo MySqlConnection()
            using (var sqlConn = Conexion.getInstancia("root", "root").CrearConexion())
            {
                sqlConn.Open();


                if (_accion == 2)
                {
                    string query = @"insert into socios(
                                dni,
                                nombre,
                                apellido,
                                email,
                                direccion,
                                id_localidad)
                                values(
                                    @dni,
                                    @nombre,
                                    @apellido,
                                    @email,
                                    @direccion,
                                    @id_localidad);";
                    MySqlCommand comando = new MySqlCommand(query, sqlConn);
                    comando.Parameters.AddWithValue("@dni", socio.Dni);
                    comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@email", socio.Email);
                    comando.Parameters.AddWithValue("@direccion", socio.Direccion);
                    comando.Parameters.AddWithValue("@id_localidad", socio.IdLocalidad);
                    int resul = comando.ExecuteNonQuery();


                    return true;
                }
                else
                {
                    //string query = "update alumnos set nombre=@nombre, dni=@dni, id_localidad=@id_localidad where id=@id";
                    //MySqlCommand comando = new MySqlCommand(query, sqlConn);
                    //comando.Parameters.AddWithValue("@id", alumno.Id);
                    //comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    //comando.Parameters.AddWithValue("@dni", alumno.Dni);
                    //comando.Parameters.AddWithValue("@id_localidad", alumno.IdLocalidad);
                    //int resul = comando.ExecuteNonQuery();
                    ////MessageBox.Show($"La consulta devolvio: {resul}");
                    //return true;
                }


            }
            return false;
        }

    }
}
