using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
//Julio César Sierra López 3 P
namespace Registro_Basico_P4
{
    public partial class Form1 : Form
    {
        string conexionSQL = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();
            tbeD.TextChanged += ValidarEdad;
            tbE.TextChanged += ValidarEstatura;
            tbT.TextChanged += ValidarTelefono;
            tbN.TextChanged += ValidarNombres;
            tbA.TextChanged += ValidarApellidos;
        }
        private void InsertarRegistros(string nombres, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection connection = new MySqlConnection(conexionSQL))
            {
                connection.Open();
                string insertQuery = "INSERT INTO datos (Nombres, Apellidos, Edad, Estatura, Telefono, Genero)" + 
                                     "Values (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private void bG_Click(object sender, EventArgs e)
        {
            string nombres = tbN.Text;
            string apellidos = tbA.Text;
            string edad = tbeD.Text;
            string estatura = tbE.Text;
            string telefono = tbT.Text;

            string genero = "";
            if (rbH.Checked)
            {
                genero = "Hombre";
            }
            else if (rbM.Checked)
            {
                genero = "Mujer";
            }

            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) &&
                EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono} \r\nEstaruta: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}";

                string rutaArchivo = "E:/C354R/Documentos/Practica4/datos1.txt";
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            writer.WriteLine();
                            writer.WriteLine(datos);
                            InsertarRegistros(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos Ingresados correctamente.");
                        }
                        else
                        { 
                            writer.WriteLine(datos);
                            InsertarRegistros(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }
                    }
                }
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor,out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }
            if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Porfavor, ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.Length < 10)
            {
                return;
            }
            if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido de 10 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarNombres(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese apellidos válidos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            tbN.Clear();
            tbA.Clear();
            tbE.Clear();
            tbT.Clear();
            tbeD.Clear();
            rbH.Checked = false;
            rbM.Checked = false;
        }
    }
}
