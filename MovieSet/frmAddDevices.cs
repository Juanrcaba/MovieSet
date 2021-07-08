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
    public partial class frmAddDevices : Form
    {
        public frmAddDevices()
        {
            InitializeComponent();
        }
        int id = 0;

        private void frmAddDevices_Load(object sender, EventArgs e)
        {
            Mostrar_usuarios();
        }


        private void Mostrar_usuarios()
        {
            Clientes objCliente = new Clientes();
            try
            {
                dgDatos_Usuarios.DataSource = objCliente.Mostrar();
                dgDatos_Usuarios.Columns[0].Visible = false;
                dgDatos_Usuarios.Columns[3].Visible = false;
                dgDatos_Usuarios.Columns[4].Visible = false;
                dgDatos_Usuarios.Columns[5].Visible = false;
                dgDatos_Usuarios.Columns[6].Visible = false;
                dgDatos_Usuarios.Columns[7].Visible = false;
                dgDatos_Usuarios.Columns[8].Visible = false;
                dgDatos_Usuarios.ClearSelection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void Mostrar_macAddres(int id)
        {
            Clientes objCliente = new Clientes();
            try
            {
                dgDatos_MacAddress.DataSource = objCliente.Mostrar_mac(id);
                dgDatos_MacAddress.Columns[0].Visible = false;
                dgDatos_MacAddress.Columns[1].Visible = false;
                dgDatos_MacAddress.Columns[3].Visible = false;

                dgDatos_MacAddress.ClearSelection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CapaNegocio.Clientes objClientes = new Clientes();
            if ( id != 0)
            {
                objClientes.Insertar_MacAddress(id,txt_macaddress.Text);
                txt_macaddress.Clear();
                Mostrar_macAddres(id);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un usuario");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgDatos_Usuarios_DoubleClick(object sender, EventArgs e)
        {
            if (dgDatos_Usuarios.SelectedRows.Count>0)
            {
                id = Convert.ToInt32(dgDatos_Usuarios.CurrentRow.Cells[0].Value);
                Mostrar_macAddres(id);
            }
        }
    }
}
