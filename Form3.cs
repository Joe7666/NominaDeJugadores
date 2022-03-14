using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaDeJugadores
{
    public partial class Form3 : Form
    {
        public Lista lista4 = new Lista();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPares.DataSource = lista4.MetodoEdad();
        }
    }
}
