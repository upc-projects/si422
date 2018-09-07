using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private EquipoNE equipoNE;
        private ClienteNE clienteNE;
        private ContratistaNE contratistaNE;
        private FichaDevolucionNE fichaDevolucionNE;


        public Form1()
        {
            InitializeComponent();
            equipoNE = new EquipoNE();
            clienteNE = new ClienteNE();
            contratistaNE=new ContratistaNE();
            fichaDevolucionNE=new FichaDevolucionNE();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarFichas();
            LlenarContratista();
            LlenarCliente();
            LlenarEquipo();
        }

        void LlenarFichas()
        {
            dgFichas.DataSource = fichaDevolucionNE.ListarFichasDevolucion();
        }

        void LlenarContratista()
        {
            cboContratista.DataSource = contratistaNE.ListarContratista();
            cboContratista.DisplayMember = "CONTRATISTA";
            cboContratista.ValueMember = "CODIGO";

        }

        void LlenarCliente()
        {
            cboCliente.DataSource = clienteNE.ListarCliente();
            cboCliente.DisplayMember = "CLIENTE";
            cboCliente.ValueMember = "CODIGO";
        }

        void LlenarEquipo()
        {
            cboEquipo.DataSource = equipoNE.ListarEquipo();
            cboEquipo.DisplayMember = "EQUIPO";
            cboEquipo.ValueMember = "CODIGO";
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var contratista = new Contratista();
                var objCli = new Cliente();
                var objEqui = new Equipo();
                FichaDevolucion ficaDevolucion = new FichaDevolucion();

                contratista.IdContratista = int.Parse(cboContratista.SelectedValue.ToString());
                objCli.IdCliente = int.Parse(cboCliente.SelectedValue.ToString());
                objEqui.IdEquipo = int.Parse(cboEquipo.SelectedValue.ToString());


                ficaDevolucion.ObjContratista = contratista;
                ficaDevolucion.ObjCliente = objCli;
                ficaDevolucion.ObjEquipo = objEqui;
                ficaDevolucion.Fecha = DateTime.Parse(txtFecha.Text);
                ficaDevolucion.Mora = double.Parse(txtMora.Text);

                int i = fichaDevolucionNE.NuevaFicha(ficaDevolucion);
                MessageBox.Show("Registro OK");

                LlenarFichas();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error " + exception.Message);
            }
        }

        private void tstNuevo_Click(object sender, EventArgs e)
        {

        }

        private void dgFichas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblCodigo.Text = dgFichas.CurrentRow.Cells[0].Value.ToString();
            cboContratista.Text = dgFichas.CurrentRow.Cells[1].Value.ToString();
            cboCliente.Text = dgFichas.CurrentRow.Cells[2].Value.ToString();
            cboEquipo.Text = dgFichas.CurrentRow.Cells[3].Value.ToString();
            txtFecha.Text = DateTime.Parse(dgFichas.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            txtMora.Text = double.Parse(dgFichas.CurrentRow.Cells[5].Value.ToString()).ToString("0.00");
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
