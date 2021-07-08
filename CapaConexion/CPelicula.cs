using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CapaConexion
{
   public class CPelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string urlMiniatura { get; set; }
        public string urlPortada { get; set; }
        public string urlPelicula { get; set; }
        public string Review { get; set; }
        public int pPrincipal { get; set; }
        public int Accion { get; set; }
        public int Aventura { get; set; }
        public int Comedia { get; set; }
        public int Drama { get; set; }
        public int Terror { get; set; }
        public int Suspenso { get; set; }
        public int Fantasia { get; set; }
        public int Animados { get; set; }
       
        public CPelicula() { }
        public CPelicula(int id, string titulo,string urlMiniatura,string urlPortada,string urlPelicula,string review,int pprincipal,int accion,int aventura,int comedia,int drama,int terror,int suspenso,int fantasia,int animada)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.urlMiniatura = urlMiniatura;
            this.urlPortada = urlPortada;
            this.urlPelicula = urlPelicula;
            this.Review = review;
            this.pPrincipal = pprincipal;
            this.Accion = accion;
            this.Aventura = aventura;
            this.Comedia = comedia;
            this.Drama = drama;
            this.Terror = terror;
            this.Suspenso = suspenso;
            this.Fantasia = fantasia;
            this.Animados = animada;
        }

        //metodos
        MySqlConnection con = new MySqlConnection(Conexion.CadenaConexion);

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from peliculas",con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception)
            {

                dt = null;
            }

            return dt;
        }

        public void Insertar_pelicula(CPelicula obj)
        {
            
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insertar_pelicula", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("titulo", obj.Titulo);
                cmd.Parameters.AddWithValue("urlimagen", obj.urlMiniatura);
                cmd.Parameters.AddWithValue("urlportada", obj.urlPortada);
                cmd.Parameters.AddWithValue("urlpelicula", obj.urlPelicula);
                cmd.Parameters.AddWithValue("resenia", obj.Review);
                cmd.Parameters.AddWithValue("pprincipal", obj.pPrincipal);
                cmd.Parameters.AddWithValue("accion", obj.Accion);
                cmd.Parameters.AddWithValue("aventura", obj.Aventura);
                cmd.Parameters.AddWithValue("comedia", obj.Comedia);
                cmd.Parameters.AddWithValue("drama", obj.Drama);
                cmd.Parameters.AddWithValue("terror", obj.Terror);
                cmd.Parameters.AddWithValue("suspenso", obj.Suspenso);
                cmd.Parameters.AddWithValue("fantasia", obj.Fantasia);
                cmd.Parameters.AddWithValue("animados", obj.Animados);                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
          
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_pelicula(CPelicula obj)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand($"update peliculas set titulo = '{obj.Titulo}', urlImagen='{obj.urlMiniatura}',urlPortada='{obj.urlPortada}',urlPelicula = '{obj.urlPelicula}',resenia = '{obj.Review}',Pprincipal={obj.pPrincipal},accion={obj.Accion},aventura={obj.Aventura},comedia={obj.Comedia},drama = {obj.Drama},terror = {obj.Terror},suspenso = {obj.Suspenso},fantasia = {obj.Fantasia},animados ={obj.Animados} where id = {obj.Id}", con);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
