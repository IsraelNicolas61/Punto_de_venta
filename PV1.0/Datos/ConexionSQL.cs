using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class ConexionSQL
    {
        private const string V = "and contraseña ='";
        static string conexion = "SERVER = 127.0.0.1;PORT=3306;DATABASE = PuntodeVenta;UID=root;PASSWORD=;";

        MySqlConnection con = new MySqlConnection(conexion);

        public int consultalogin(string Usuario, String Contrasena)
        {
            int count;
            con.Open();
            string Query = "Select count(*)from persona where usuario =  '" + Usuario + "' " +
                " and contraseña= '" + Contrasena + "'";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }
}
