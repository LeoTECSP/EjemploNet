using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            //acá ya trabajamos con ADO.NET, no usamos la palabra driver
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks2019;Integrated Security=True";
            //el . es para representar una instancia local
            //servidor, base de datos, usuario y contraseña, pero como no usamos con contraseña se usa la de windows

            //Crea una conexión a la base de datos
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                //Abrimos la conexión a base de datos
                connection.Open();

                //Si la conexión se realizó correctamente, muestra un mensaje al usuario
                MessageBox.Show("Conexión exitosa a la base de datos","Conexión exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Si la conexión no se pudo realizar, muestra un mensaje al usuario con el error ocurrido
                MessageBox.Show("Error: {0}", ex.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);

                throw;
            }
            finally 
            {
            //Cierra la conexión a la base de datos
            connection.Close(); 
            }
        }
    }
}
