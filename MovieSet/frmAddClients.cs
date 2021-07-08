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
    public partial class frmAddClients : Form
    {
        public frmAddClients()
        {
            InitializeComponent();
        }

        private void frmAddClients_Load(object sender, EventArgs e)
        {
          
        }
        public int id = 0;
        public string nombre = "", apellido = "", usuario = "", password = "", estado = "Activo", rol = "";
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            usuario = txt_usuario.Text;
            password = txt_password.Text;
            rol = cmb_Rol.Text;
         
            if (IsNew)
            {
                Insertar_cliente(nombre,apellido,usuario,password,estado,rol,macAddress);
            }
            clear();
        }

        public List<string> macAddress;

       

        public bool IsNew = true;

        private void Insertar_cliente(string nombre,string apellido,string usuario,string password,string estado,string rol,List<string> macAddress)
        {
            CapaNegocio.Clientes objCliente = new Clientes();
            string rpta = objCliente.Insertar_cliente(nombre,apellido,usuario,password,estado,rol);
            MessageBox.Show(rpta);
        }

        private void Actualizar_cliente(int id,string nombre, string apellido, string usuario, string password, string estado, string rol, List<string> macAddress)
        {
            CapaNegocio.Clientes objCliente = new Clientes();
            string rpta = objCliente.Insertar_cliente(nombre, apellido, usuario, password, estado, rol);//esto hay que arreglar
            MessageBox.Show(rpta);
        }

        


        void clear()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_usuario.Clear();
            txt_password.Clear();
            rol = "";
            
        }

    }
}
