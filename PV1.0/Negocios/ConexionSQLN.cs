using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Datos es la class que se programo para llamar las consultas SQL
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
        public DataTable ConsultaDTV()
        {
            return cn.ConsultaventasDG();
        }
        public DataTable ConsultaDTI()
        {
            return cn.ConsultainventarioDG();
        }
        //metodos de usuarios
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
           return cn.EliminarUsuario(user);
        }
       //metodo de ventas
        public int InsertarVenta(string prod, string cant, string precio, string cod)
        {
            return cn.InsertarVenta(prod,cant, precio, cod);
        }
        //metodo de inventario

        public int InsertarInventario(string producto, string categoria, string precio, string cantidad)
        {
            return cn.InsertarInventario(producto,categoria,precio,cantidad);
        }

        public int ModificarInventario(string producto, string categoria, string precio, string cantidad)
        {
            return cn.InsertarInventario(producto, categoria, precio,cantidad);
        }
        public int EliminarInventario(string producto)
        {
            return cn.EliminarInventario(producto);
        }




    }

}
