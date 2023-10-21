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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Formulario_proyecto_5
{
    public partial class Form1 : Form
    {
        //Datos de conexión a MySQL (XAMPP)
        string ConexionSQL = "Server=localhost;Port=3306;Database=form;Uid=root;Pwd=Danielrivera04";
        public Form1()
        {
            InitializeComponent();
            //Agregar  controladores de eventos TextChanged a los campos
            Tb_Edad.TextChanged += ValidarEdad;
            Tb_Estatura.TextChanged += ValidarEstatura;
            Tb_Telefono.TextChanged += ValidarTelefono;
            Tb_Nombre.TextChanged += ValidarNombre;
            Tb_Apellidos.TextChanged += ValidarApellidos;

        }

        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(ConexionSQL))
            {
                conection.Open();

                String insertQuery = "INSERT INTO formulario (Nombre, Apellidos, Telefono, Estatura, Edad, Genero)" + "VALUES (@Nombre, @Apellidos, @Telefono, @Estatura, @Edad, @Genero)";
                
                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }   

                conection.Close();

            }
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

            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) 
                && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {

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
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos Ingresados corretcamente");
                        }
                        else
                        {
                            //Si el archivo no existe, crearlo y añadir el primer registro
                            writer.WriteLine(datos);
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos Ingresados corretcamente");
                        }
                        

                    }
                }

                //Mostrar un mensaje con los datos guardados
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor ingrese datos validos en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z]+$"); //Solo letras y espacios
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
               MessageBox.Show("Por favor ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
            
        }
        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string input = textbox.Text;
            //Eliminar espacios en blanco y guiones si es necesario
            //input = input.Replace(" ", "").Replace("-", "");
            if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor ingrese un apellido valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
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
