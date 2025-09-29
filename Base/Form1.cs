using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void siguiente_button_Click(object sender, EventArgs e)
        {
            Continuar Continuar = new Continuar();
            Continuar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = Nombre_txt.Text;
            String apellidop = ApellidoP.Text;
            String apellidom = ApellidoM.Text;
            String correo = correo_txt.Text;
            String contraseña = contraseña_txt.Text;    
            String telefono = telefono_txt.Text;    
            String trabajo = Trabajo_txt.Text;
            String direccion = Direccion_txt.Text; 
            String Tarjeta = Tarjeta_txt.Text;
            String CVV = cvv_txt.Text;
            String CI = CI_txt.Text;   
            String RFC = RFC_txt.Text;
            
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidop) || string.IsNullOrEmpty(apellidom) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(trabajo) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(Tarjeta) || string.IsNullOrEmpty(CVV) || string.IsNullOrEmpty(CI) || string.IsNullOrEmpty(RFC))
            {
                //Si no se llenan todos los campos, mostrar un mensaje de error
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                //Aqui se hace el registro de el tipo excel
                dataGridView1.Rows.Add(nombre, apellidop, apellidom, correo, contraseña, telefono, trabajo, direccion, Tarjeta, CVV, CI, RFC);
                Nombre_txt.Text = "";
                ApellidoP.Text = "";
                ApellidoM.Text = "";
                correo_txt.Text = "";
                contraseña_txt.Text = "";
                telefono_txt.Text = "";
                Trabajo_txt.Text = "";
                Direccion_txt.Text = "";
                Tarjeta_txt.Text = "";
                cvv_txt.Text = "";
                CI_txt.Text = "";
                RFC_txt.Text="";
            }

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            String nombre = Nombre_txt.Text;
            String apellidop = ApellidoP.Text;
            String apellidom = ApellidoM.Text;
            String correo = correo_txt.Text;
            String contraseña = contraseña_txt.Text;
            String telefono = telefono_txt.Text;
            String trabajo = Trabajo_txt.Text;
            String direccion = Direccion_txt.Text;
            String Tarjeta = Tarjeta_txt.Text;
            String CVV = cvv_txt.Text;
            String CI = CI_txt.Text;
            String RFC = RFC_txt.Text;

            dataGridView1.Rows.Clear();

        }

        private void Ap_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            String nombre = Nombre_txt.Text.ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower() == nombre)
                {
                    row.Selected = true;
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("No se encontró el nombre especificado.");
            }

        }
    }
}
