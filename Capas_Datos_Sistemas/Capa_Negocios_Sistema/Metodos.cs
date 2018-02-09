using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios_Sistema;
using Npgsql;

namespace Capa_Negocios_Sistema
{
    public class Metodos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conectando_Base_Datos()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "1414250816ma";
            string baseDatos = "sistema_ventas";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

    }
}



