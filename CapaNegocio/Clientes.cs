using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;

namespace CapaNegocio
{
    public class Clientes
    {
      
        //metodo mostrar
        public DataTable Mostrar()
        {
            CapaConexion.Clientes objCliente = new CapaConexion.Clientes();
            return objCliente.Mostrar();
        }
        public DataTable Mostrar_mac(int id)
        {
            CapaConexion.Clientes objCliente = new CapaConexion.Clientes();
            objCliente.Id = id;
            return objCliente.Mostrar_mac(objCliente);
        }
        public string Insertar_cliente(string nombre,string apellido,string usuario,string password,string estado,string rol)
        {
            CapaConexion.Clientes objCliente = new CapaConexion.Clientes();
            objCliente.Nombre = nombre;
            objCliente.Apellido = apellido;
            objCliente.Usuario = usuario;
            objCliente.Password = password;
            objCliente.Estado = estado;
            objCliente.Rol = rol;
           
            return objCliente.Insertar_Cliente(objCliente);
        }

        public void Insertar_MacAddress(int id,string macAddress)
        {
            CapaConexion.Clientes objCliente = new CapaConexion.Clientes();
            objCliente.Id = id;
            objCliente.MacAddress = macAddress;

            objCliente.Insertar_MacAddress(objCliente);
        }
    }
}
