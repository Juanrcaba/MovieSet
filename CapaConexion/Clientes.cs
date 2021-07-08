using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CapaConexion
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string MacAddress { get; set; }
        public string Rol { get; set; }
        public string Buscar { get; set; }

        public Clientes(){}

        public Clientes(int id,string nombre,string apellido,string usuario,string password,string buscar,string rol,string mac,string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Usuario = usuario;
            this.Password = password;
            this.MacAddress = mac;
            this.Estado = estado;
            this.Rol = rol;
            this.Buscar = buscar;
        }

        MySqlConnection con = new MySqlConnection(Conexion.CadenaConexion);

        //metodo mostrar
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Clientes where id <> 1",con);
                MySqlDataAdapter Da = new MySqlDataAdapter(cmd);
                
                Da.Fill(dt);
                con.Close();

            }
            catch (Exception)
            {

                dt = null;
            }

            return dt;
        }
        public DataTable Mostrar_mac(Clientes obj)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"select * from validaciones where idUsuario = {obj.Id}", con);
                MySqlDataAdapter Da = new MySqlDataAdapter(cmd);

                Da.Fill(dt);
                con.Close();

            }
            catch (Exception)
            {

                dt = null;
            }

            return dt;
        }
        //insertar Cliente
        public string Insertar_Cliente(Clientes obj)
        {
            string rpta = "";
            try
            {
                
                MySqlCommand cmd = new MySqlCommand("Insertar_Cliente",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre",obj.Nombre);
                cmd.Parameters.AddWithValue("apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("password", obj.Password);
                cmd.Parameters.AddWithValue("estado", obj.Estado);
                cmd.Parameters.AddWithValue("rol", obj.Rol);
                cmd.Parameters.Add("id",MySqlDbType.Int32).Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();                
                con.Close();
                rpta = "Datos Insertados Satisfactoriamente!!";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally { con.Close(); }
            return rpta;
        }

        public void Insertar_MacAddress(Clientes obj)
        {
            try
            {
                
                    MySqlCommand cmd = new MySqlCommand($"insert into validaciones(idusuario,macaddress) values({obj.Id},'{obj.MacAddress}')",con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

              
            }
            catch (Exception)
            {

                
            }
            finally
            {
                con.Close();
            }
        }
    }
}
