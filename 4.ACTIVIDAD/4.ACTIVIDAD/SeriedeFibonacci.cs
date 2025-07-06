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
    public partial class Serie_de_Fibonacci : Form
    {
        public Serie_de_Fibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 0)
            {
                int a = 0, b = 1;
                string resultado = "0";

                while (b <= limite)
                {
                    resultado += ", " + b;
                    int temp = b;
                    b = a + b;
                    a = temp;
                }

                txtResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número entero válido y no negativo.", "Error");
            }
        }

    }
}
