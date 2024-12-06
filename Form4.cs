using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static contactos2.ListaContactos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace contactos2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Telefono = textBox1.Text.Trim(); 
            string TelefonoNuevo = textBox2.Text.Trim(); 

            if (string.IsNullOrEmpty(Telefono) || string.IsNullOrEmpty(TelefonoNuevo))
            {
                MessageBox.Show("Por favor, ingresa el número de teléfono actual y el nuevo número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkPhone(TelefonoNuevo))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono válido (11 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact contactToUpdate = ListaContactos.listaContactos.FirstOrDefault(c => c.Telefono == Telefono);

            if (contactToUpdate != null)
            {
                contactToUpdate.Telefono = TelefonoNuevo;

                MessageBox.Show("Número de teléfono actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox1.Clear();
            textBox2.Clear();
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

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
