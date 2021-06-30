using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        private const string V = "and contraseña ='";
        static string conexionstring = "server = localhost:3306;database= PuntodeVenta;" +
            "integrated security=true";

        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, String Contrasena)
        {
            int count;
            con.Open();
            string Query = "Select count(*)from persona where usuario =  '" + Usuario + "' " +
                " and contraseña= '" + Contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }
}
