using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.ACTIVIDAD
{
    public partial class RegistrosDeUsuarios : Form
    {
        public RegistrosDeUsuarios()
        {
            InitializeComponent();
        }

        private void RegistrosDeUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 12;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Edad";
            dataGridView1.Columns[3].Name = "Dirección";
            dataGridView1.Columns[4].Name = "Teléfono";
            dataGridView1.Columns[5].Name = "Email";
            dataGridView1.Columns[6].Name = "Ciudad";
            dataGridView1.Columns[7].Name = "País";
            dataGridView1.Columns[8].Name = "Cédula";
            dataGridView1.Columns[9].Name = "Género";
            dataGridView1.Columns[10].Name = "Ocupación";
            dataGridView1.Columns[11].Name = "Estado Civil";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación básica (opcional)
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Por favor, complete al menos nombre y apellido.");
                return;
            }

            // Agrega los datos al DataGridView
            dataGridView1.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtEdad.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtEmail.Text,
                txtCiudad.Text,
                txtPais.Text,
                txtCedula.Text,
                txtGenero.Text,
                txtOcupacion.Text,
                txtEstadoCivil.Text
            );

            // Limpia los campos después de agregar
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
