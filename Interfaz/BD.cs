
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace interfazServicios
{
    public class BD
    {
        public static MySqlConnection Conexion()
        {
            String cadenaConexion = "Database = larousee; Data Source= localhost;  User Id = root; Password = Pass.123";

            try
            {
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
                return conectar;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            
        }
    }
}
