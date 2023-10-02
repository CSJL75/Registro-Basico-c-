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

namespace Registro_Basico_P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono} \r\nEstaruta: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}";
            string rutaArchivo = "E:/C354R/Documentos/Practica4/datos1.txt";
            File.WriteAllText(rutaArchivo, datos);
            bool archivoExiste = File.Exists(rutaArchivo);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
