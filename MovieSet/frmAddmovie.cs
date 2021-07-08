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
    public partial class frmAddmovie : Form
    {
        public frmAddmovie()
        {
            InitializeComponent();
        }
        public bool Isnew = true;
        public int Id = 0;
        int pprincipal = 0, accion = 0, aventura = 0, comedia = 0, drama = 0, terror = 0, suspenso = 0, fantasia = 0, animados = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar_pelicula();
        }

        private void frmAddmovie_Load(object sender, EventArgs e)
        {
            
        }
        
        //metodos
        void Guardar_pelicula()
        {
            NPelicula obj = new NPelicula();
            if (txt_titulo.Text != string.Empty)
                if (txt_miniatura.Text != string.Empty)
                    if (txt_portada.Text != string.Empty)
                        if (txt_urlpelicula.Text != string.Empty)
                            if (txt_Resenia.Text != string.Empty)
                            {
                                if (chk_pPrincipal.Checked)
                                    pprincipal = 1;
                                if (chk_Accion.Checked)
                                    accion = 1;
                                if (chk_Aventura.Checked)
                                    aventura = 1;
                                if (chk_comedia.Checked)
                                    comedia = 1;
                                if (chk_Drama.Checked)
                                    drama = 1;
                                if (chk_Terror.Checked)
                                    terror = 1;
                                if (chk_Suspenso.Checked)
                                    suspenso = 1;
                                if (chk_Fantasia.Checked)
                                    fantasia = 1;
                                if (chk_Animados.Checked)
                                    animados = 1;
                                if (Isnew)
                                {
                                    obj.Insertar_pelicula(txt_titulo.Text, txt_miniatura.Text, txt_portada.Text, txt_urlpelicula.Text, txt_Resenia.Text, pprincipal, accion, aventura, comedia, drama, terror, suspenso, fantasia, animados);
                                    MessageBox.Show("Datos Guardados Satisfactoriamente!!");
                                    clear();
                                }                                    
                                else
                                {
                                    obj.Actualizar_pelicula(Id,txt_titulo.Text, txt_miniatura.Text, txt_portada.Text, txt_urlpelicula.Text, txt_Resenia.Text, pprincipal, accion, aventura, comedia, drama, terror, suspenso, fantasia, animados);
                                    MessageBox.Show("Datos Actualizados Satisfactoriamente!!");
                                    this.Close();
                                }                               
                               
                            }
                            else
                                MessageBox.Show("Insertar Reseña de la pelicula");
                        else
                            MessageBox.Show("Debe insertar urlPelicula");
                    else
                        MessageBox.Show("Insertar Portada");
                else
                    MessageBox.Show("Debe insertar imagen Miniatura");
            else
                MessageBox.Show("Debe Insertar un titulo a la pelicula");



        }

        void clear()
        {
            Id = 0;
            txt_titulo.Clear();
            txt_miniatura.Clear();
            txt_portada.Clear();
            txt_urlpelicula.Clear();
            txt_Resenia.Clear();
            chk_pPrincipal.Checked = false;
            chk_Accion.Checked = false;
            chk_Aventura.Checked = false;
            chk_comedia.Checked = false;
            chk_Drama.Checked = false;
            chk_Terror.Checked = false;
            chk_Suspenso.Checked = false;
            chk_Fantasia.Checked = false;
            chk_Animados.Checked = false;

        }

    }
}
