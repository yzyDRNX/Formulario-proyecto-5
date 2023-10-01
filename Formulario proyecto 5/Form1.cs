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

namespace Formulario_proyecto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //Obtener los datos de los textbox
            string nombres = Tb_Nombre.Text;
            string apellidos = Tb_Apellidos.Text;
            string edad = Tb_Edad.Text;
            string estatura = Tb_Estatura.Text;
            string telefono = Tb_Telefono.Text;

            //Obtener el género
            string genero = "";
            if (Rbt_Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (Rbt_Mujer.Checked)
            {
                genero = "Mujer";
            }

            //Crear una cadena con los datos
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono}\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero} ";
            //Guardar los datos en un archivo de texto
            string rutaarchivo = "C:/Users/edani/Downloads/.txt";
            //File.WriteAllText(rutaarchivo, datos);
            //Verificar si el archivo ya existe
            bool archivoExiste = File.Exists(rutaarchivo);
            Console.WriteLine(archivoExiste);

            if (archivoExiste == false)
            {
                File.WriteAllText(rutaarchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaarchivo, true))
                {
                    if (archivoExiste)
                    {
                        //Si el archivo existe añadir un separador antes del nuevo registro
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);

                }
            }
            
            //Mostrar un mensaje con los datos guardados
            MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Tb_Nombre.Clear();
            Tb_Apellidos.Clear();
            Tb_Edad.Clear();
            Tb_Estatura.Clear();
            Tb_Telefono.Clear();
            Rbt_Hombre.Checked = false;
            Rbt_Mujer.Checked = false;
        }
    }
}
