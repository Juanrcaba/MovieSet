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
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            llenar_Datagrid();
        }
        NPelicula obj = new NPelicula();
        //metodos
        void llenar_Datagrid()
        {
            dgDatos_pelicula.DataSource = obj.Mostrar();
          //  dgDatos_pelicula.Columns[0].Visible = false;
            dgDatos_pelicula.ClearSelection();
            pb_image.ImageLocation = "";
            lbl_movieName.Text = "";
        }

        private void dgDatos_pelicula_Click(object sender, EventArgs e)
        {
            if (dgDatos_pelicula.SelectedRows.Count>0)
            {
                pb_image.ImageLocation = @"E:\xampp\htdocs\axm09611\uploads\"+dgDatos_pelicula.CurrentRow.Cells[2].Value.ToString()+".jpg";
                lbl_movieName.Text = dgDatos_pelicula.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                dgDatos_pelicula.ClearSelection();
                pb_image.ImageLocation = "";
                lbl_movieName.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddmovie form = new frmAddmovie();
            form.ShowDialog();
            llenar_Datagrid();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgDatos_pelicula.SelectedRows.Count>0)
            {
                frmAddmovie form = new frmAddmovie();
                form.Isnew = false;
                form.Id = Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[0].Value);
                form.txt_titulo.Text = dgDatos_pelicula.CurrentRow.Cells[1].Value.ToString();
                form.txt_miniatura.Text = dgDatos_pelicula.CurrentRow.Cells[2].Value.ToString();
                form.txt_portada.Text = dgDatos_pelicula.CurrentRow.Cells[3].Value.ToString();
                form.txt_urlpelicula.Text = dgDatos_pelicula.CurrentRow.Cells[4].Value.ToString();
                form.txt_Resenia.Text = dgDatos_pelicula.CurrentRow.Cells[5].Value.ToString();
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[6].Value) == 1)
                    form.chk_pPrincipal.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[7].Value) == 1)
                    form.chk_Accion.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[8].Value) == 1)
                    form.chk_Aventura.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[9].Value) == 1)
                    form.chk_comedia.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[10].Value) == 1)
                    form.chk_Drama.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[11].Value) == 1)
                    form.chk_Terror.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[12].Value) == 1)
                    form.chk_Suspenso.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[13].Value) == 1)
                    form.chk_Fantasia.Checked = true;
                if (Convert.ToInt32(dgDatos_pelicula.CurrentRow.Cells[14].Value) == 1)
                    form.chk_Animados.Checked = true;
                form.ShowDialog();
                form.Isnew = true;
                llenar_Datagrid();

            }
        }
    }
}
