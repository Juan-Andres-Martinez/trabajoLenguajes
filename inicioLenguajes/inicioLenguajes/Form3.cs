using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicioLenguajes
{
    public partial class Form3 : Form
    {
        private MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=lenguajes;user=juan;password=123456;");
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string usuario = textBox2.Text;
            string correo = textBox3.Text;
            string contraseña = textBox4.Text;
            try 
            { 
                conexion.Open();
                string consulta = "INSERT INTO usuarios (nombre, usuario, correo, contraseña) VALUES (@nombre, @usuario, @correo, @contraseña)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                MessageBox.Show("Registro exitoso.");
                Form1 nuevoFormulario = new Form1();
                nuevoFormulario.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
