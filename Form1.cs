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
    public partial class Form1 : Form
    {
        Lista Lista1 = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Nombre = mtxtNombre.Text;
            jugador.Apellidos = mtxtApellido.Text;
            jugador.Posicion = mtxtPosicion.Text;
            jugador.Precio = Convert.ToInt32(txtPrecio.Text);
            Lista1.Agregar(jugador);
            MessageBox.Show("Datos Guardados correctamente!!");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtNombre.Text = " ";
            mtxtApellido.Text = " ";
            mtxtPosicion.Text = " ";
            txtPrecio.Text = " ";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Lista2 = Lista1;
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            From3 form3 = new From3();
            form3.Show();
            form3.lista3 = Lista1;
        }
    }
}
