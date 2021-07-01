﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public int InsertarUsuario(string nom, string apel,string user,string pass)
        {
            int flag = 0;
            con.Open();
            string query = "insert into persona (`nombre`, `apellido`, `usuario`, `contraseña`) values ('" + nom + "','" + apel + "','" + user + "','" + pass + "')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            flag = cmd.ExecuteNonQuery();
            con.Close(); 
            return flag;
        }

        public int ModificarUsuario(string nom, string apel, string user, string pass)
        {
            int flag = 0;
            con.Open();
            string query = "UPDATE persona SET nombre ='" + nom + "', apellido = '" + apel + "',usuario = '" + user + "' where contraseña= '"+pass+"'" ;
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int EliminarUsuario(string user)
        {
            int flag = 0;
            con.Open();
            string query = "DELETE FROM persona WHERE usuario = '"+user+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultausuariosDG()
        {
            string query = "select * from persona";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
 

        }
    }
}
