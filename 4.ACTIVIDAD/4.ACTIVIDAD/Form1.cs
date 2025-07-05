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
    public partial class tabsPrincipal : Form
    {
        public tabsPrincipal()
        {
            InitializeComponent();
        }
         




        private void convertirDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversorDivisas conv = new ConversorDivisas();
            conv.MdiParent = this; // Establece el formulario actual como padre del nuevo formulario
            conv.Show();
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosDeUsuarios frm = new RegistrosDeUsuarios();
            frm.MdiParent = this; // Establece el formulario actual como padre del nuevo formulario
            frm.Show();
        }

        private void cálculoDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculo_de_Impuestos conv = new Calculo_de_Impuestos();
            conv.MdiParent = this; // Establece el formulario actual como padre del nuevo formulario
            conv.Show();
        }

        private void serieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serie_de_Fibonacci conv = new Serie_de_Fibonacci();
            conv.MdiParent = this; // Establece el formulario actual como padre del nuevo formulario
            conv.Show();
        }
    }
}
