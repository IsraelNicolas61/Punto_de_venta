﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Negocios
{
    public class ConexionSQLN
    {


        ConexionSQL cn = new ConexionSQL();
        
        
        public int conSQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }

        public DataTable ConsultaDT()
        {
            return cn.ConsultausuariosDG();
        }

        public int InsertarUsuario(string nom, string apel, string user, string pass)
        {   
            return cn.InsertarUsuario(nom,apel,user,pass);
        }

        public int ModificarUsuario(string nom, string apel, string user, string pass)
        {
            return cn.InsertarUsuario(nom, apel, user, pass);
        }
        public int EliminarUsuario(string user)
        {
            int flag = 0;
            
            return flag;
        }









    }

}
