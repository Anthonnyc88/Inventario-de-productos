using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void Cargar_Datagriewd(DataGridView agregar_datos)
        {
            try
            {
                Conectando_Base_Datos();
                conexion.Open();
                DataSet agregar = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT codigo , nombre, edad, fecha FROM producto", conexion);
                adapter.Fill(agregar, "producto");
                agregar_datos.DataSource = agregar.Tables[0];
                agregar_datos.Columns[0].HeaderCell.Value = "cedula";
                agregar_datos.Columns[1].HeaderCell.Value = "nombre";
                agregar_datos.Columns[2].HeaderCell.Value = "edad";
                agregar_datos.Columns[3].HeaderCell.Value = "fecha";
                conexion.Close();
        

            }
            catch(Exception error)
            {

            }
           
            
        }


    }
}



