using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
            string codigo = "";
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string apellidos = txtApellidos.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecnac = dtpNac.Text;
            int index = cbDepart.SelectedIndex;
            string departamento = cbDepart.Items[index].ToString();
            int index2 = cbCargo.SelectedIndex;
            string cargo = cbCargo.Items[index2].ToString();
            dgvUsuarios.Rows.Add(codigo, nombre, dni, apellidos, direccion, telefono, email, fecnac, departamento, cargo);

        }
    }
}
