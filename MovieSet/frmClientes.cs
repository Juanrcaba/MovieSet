using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace MovieSet
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //metodo mostrar
        private void Mostrar()
        {
            Clientes objCliente = new Clientes();
            try
            {
                dgDatos.DataSource = objCliente.Mostrar();
                dgDatos.Columns[0].Visible = false;
                dgDatos.Columns[4].Visible = false;
                dgDatos.ClearSelection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAddClients form = new frmAddClients();
            form.ShowDialog();
            Mostrar();
        }

        private void btnAgregarDivices_Click(object sender, EventArgs e)
        {
            frmAddDevices form = new frmAddDevices();
            form.ShowDialog();
            Mostrar();
        }
    }
}
