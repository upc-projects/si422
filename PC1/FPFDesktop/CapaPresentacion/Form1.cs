using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FPF : Form
    {
        private JugadorNE jugadorNe;        
            
        public FPF()
        {
            InitializeComponent();
            jugadorNe = new JugadorNE();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarJugadores();
        }


        private void llenarJugadores()
        {
            dataGridViewJugadores.DataSource = jugadorNe.listarJugadores();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador();
                jugador.Nombre = textBoxnombre.Text;
                jugador.Apellido = textBoxapellido.Text;
                jugador.Edad = Int32.Parse(textBoxedad.Text);
                jugador.Talla = float.Parse(textBoxtalla.Text);
                jugador.Peso = float.Parse(textBoxpeso.Text);
                jugador.Camiseta = Int32.Parse(textBoxcamiseta.Text);

                int i = jugadorNe.registrarJugador(jugador);
                MessageBox.Show("Registro OK");
                llenarJugadores();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error " + exception.Message);
            }
        }
    }
}
