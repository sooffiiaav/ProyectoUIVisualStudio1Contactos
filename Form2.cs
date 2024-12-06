using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.Form1;

namespace contactos2
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();

            

            ListaContactos.Contact contact = ListaContactos.listaContactos.Find(c => c.Nombre == nombre);

            if (contact != null)
            {
                textBox2.Text = $"Nombre: {contact.Nombre}\r\nTeléfono: {contact.Telefono}";
            }
            else
            {
                textBox2.Text = "No se encontró ningún contacto con ese número.";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkPhone(string telefono)
        {
            if (string.IsNullOrEmpty(telefono))
                return false;

            if (telefono.Length != 11)
                return false;

            foreach (char c in telefono)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

