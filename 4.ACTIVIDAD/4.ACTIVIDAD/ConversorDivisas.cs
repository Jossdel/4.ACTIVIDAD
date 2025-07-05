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
    public partial class ConversorDivisas : Form
    {
        public ConversorDivisas()
        {
            InitializeComponent();
        }

        private Dictionary<string, double> tasasCambio = new Dictionary<string, double>()
{
    { "USD", 1.0 },
    { "EUR", 0.85 },
    { "DOP", 59.0 },
    { "JPY", 110.0 }
};
        private void ConversorDivisas_Load(object sender, EventArgs e)
        {
            cmbDe.Items.AddRange(tasasCambio.Keys.ToArray());
            cmbA.Items.AddRange(tasasCambio.Keys.ToArray());

            cmbDe.SelectedIndex = 0; 
            cmbA.SelectedIndex = 1; 
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                string monedaOrigen = cmbDe.SelectedItem.ToString();
                string monedaDestino = cmbA.SelectedItem.ToString();

                double tasaOrigen = tasasCambio[monedaOrigen];
                double tasaDestino = tasasCambio[monedaDestino];

                double resultado = (cantidad / tasaOrigen) * tasaDestino;

                lblResultado.Text = $"Resultado: {resultado:F2} {monedaDestino}";
            }
            catch
            {
                MessageBox.Show("Por favor ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
