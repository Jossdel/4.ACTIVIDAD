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
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
        }
         
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosDeUsuarios registrosDeUsuarios = new RegistrosDeUsuarios();
            registrosDeUsuarios.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void registroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistrosDeUsuarios frm = new RegistrosDeUsuarios();
            frm.MdiParent = this; // Establece el formulario actual como padre del nuevo formulario
            frm.Show();


        }

    






    }
}
