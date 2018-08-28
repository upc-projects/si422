using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private EquipoNegocio equipoNegocio;
        public Form1()
        {
            InitializeComponent();
            equipoNegocio = new EquipoNegocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = equipoNegocio.ListarEquipo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Equipo eq = new Equipo();
            eq.Descripcion = textBox_desc.Text;
            eq.TipoEquipo = comboBox_tipo.Text;
            eq.EstadoEquipo = comboBox_estado.Text;

            equipoNegocio.RegistrarEquipo(eq);
            dataGridView1.DataSource = equipoNegocio.ListarEquipo();
        }
    }
}
