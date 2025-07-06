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
    public partial class Calculo_de_Impuestos : Form
    {
        public Calculo_de_Impuestos()
        {
            InitializeComponent();
        }

        private void Calculo_de_Impuestos_Load(object sender, EventArgs e)
        {
            cmbImpuesto.Items.Add("18% - ITBIS");
            cmbImpuesto.Items.Add("10% - Impuesto Selectivo");
            cmbImpuesto.Items.Add("25% - Renta Alta");
            cmbImpuesto.Items.Add("0% - Exento");

            cmbImpuesto.SelectedIndex = 0; // Selecciona la primera opción por defecto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                double porcentaje = 0;

                // Verifica cuál opción fue seleccionada
                string seleccion = cmbImpuesto.SelectedItem.ToString();

                if (seleccion.Contains("18%"))
                    porcentaje = 0.18;
                else if (seleccion.Contains("10%"))
                    porcentaje = 0.10;
                else if (seleccion.Contains("25%"))
                    porcentaje = 0.25;
                else if (seleccion.Contains("0%"))
                    porcentaje = 0.0;

                double total = monto + (monto * porcentaje);
                lblResultado.Text = $"Total con impuesto: {total:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un monto válido.", "Error");
            }
        }

    }
}
