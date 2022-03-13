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
    public partial class From3 : Form
    {
        public Lista lista3 = new Lista();
        public From3()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvPosicion.DataSource = lista3.CadenaPo(mtxtPosicion.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            mtxtPosicion.Text = " ";
        }
    }
}
