using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        private EquipoNE equipoNE;

        public Form2()
        {
            
            InitializeComponent();
            equipoNE = new EquipoNE();
        }

        public void LlenarTipos()
        {
            cboTipoEquipo.DataSource = equipoNE.ListarTipoEquipo();
            cboTipoEquipo.DisplayMember = "TIPO";
            cboTipoEquipo.ValueMember = "CODIGO";
        }

        public void LlenarEstados()
        {
            cboEstadoEquipo.DataSource = equipoNE.ListarEstadoEquipo();
            cboEstadoEquipo.DisplayMember = "ESTADO";
            cboEstadoEquipo.ValueMember = "CODIGO";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarTipos();
            LlenarEstados();
            LlenarEquipos();
        }

        void LlenarEquipos()
        {
            dgEquipos.DataSource = equipoNE.ListaEquipos();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                var objEqui = new Equipo();

                objEqui.Descripcion = txtDescripcion.Text;
                objEqui.Precio = double.Parse(txtPrecio.Text);
                objEqui.EstadoEquipo = cboEstadoEquipo.SelectedValue.ToString();
                objEqui.TipoEquipo = cboTipoEquipo.SelectedValue.ToString();

                int i = equipoNE.NuevoEquipo(objEqui);
                MessageBox.Show("Registro OK");

                LlenarEquipos();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error " + exception.Message);
            }
        }
    }
}
