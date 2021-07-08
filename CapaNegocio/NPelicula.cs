using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;

namespace CapaNegocio
{
    public class NPelicula
    {
        public DataTable Mostrar()
        {
            CPelicula obj = new CPelicula();
            return obj.Mostrar();
           
        }

        public void Insertar_pelicula(string titulo,string urlminiatura,string urlportada,string urlvideo,string resenia,int pprincipal,int accion,
            int aventura,int comedia,int drama,int terror,int suspenso,int fantasia,int animados)
        {
            CPelicula obj = new CPelicula();
            obj.Titulo = titulo;
            obj.urlMiniatura = urlminiatura;
            obj.urlPortada = urlportada;
            obj.urlPelicula = urlvideo;
            obj.Review = resenia;
            obj.pPrincipal = pprincipal;
            obj.Accion = accion;
            obj.Aventura = aventura;
            obj.Comedia = comedia;
            obj.Drama = drama;
            obj.Terror = terror;
            obj.Suspenso = suspenso;
            obj.Fantasia = fantasia;
            obj.Animados = animados;
            obj.Insertar_pelicula(obj);
        }

        public void Actualizar_pelicula(int id,string titulo, string urlminiatura, string urlportada, string urlvideo, string resenia, int pprincipal, int accion,
           int aventura, int comedia, int drama, int terror, int suspenso, int fantasia, int animados)
        {
            CPelicula obj = new CPelicula();
            obj.Id = id;
            obj.Titulo = titulo;
            obj.urlMiniatura = urlminiatura;
            obj.urlPortada = urlportada;
            obj.urlPelicula = urlvideo;
            obj.Review = resenia;
            obj.pPrincipal = pprincipal;
            obj.Accion = accion;
            obj.Aventura = aventura;
            obj.Comedia = comedia;
            obj.Drama = drama;
            obj.Terror = terror;
            obj.Suspenso = suspenso;
            obj.Fantasia = fantasia;
            obj.Animados = animados;
            obj.Actualizar_pelicula(obj);
        }
    }
}
