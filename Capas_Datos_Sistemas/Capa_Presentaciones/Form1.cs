using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas_Datos_Sistemas;
using Capa_Negocios_Sistema;

namespace Capa_Presentaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexiones_Bases_Datos_Sistema conectando_capa_datos = new Conexiones_Bases_Datos_Sistema();
        Metodos conectando_capa_negocios = new Metodos();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Variables donde almacenaremos los datos capturados del sistema
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            string proveedor = txtProveedor.Text;
            string fecha_registros = Fecha_Registro.Text;

            //Metodo que guarda los datos capturados hacia la base de datos de productos
            conectando_capa_datos.InsertarDatosProducto(codigo, nombre, cantidad, proveedor, fecha_registros);
            MessageBox.Show("Registrado al sistema");

            //Metodo para actualizar la tabla productos del sistema
            conectando_capa_negocios.Cargar_Datagriewd(Tabla_Productos);

            //Limpiando campos del sistema
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtProveedor.Clear();




        }

        private void ventana_Load(object sender, EventArgs e)
        {
            conectando_capa_negocios.Cargar_Datagriewd(Tabla_Productos);
        }
    }
}
