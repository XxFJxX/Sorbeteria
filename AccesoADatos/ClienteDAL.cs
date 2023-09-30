using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace AccesoADatos
{
    public class ClienteDAL
    {
        public static int Insertar(Cliente pClientes)
        {
            string consulta = string.Format("INSERT INTO Cliente(Nombre, Producto, cantidad, precio, Total) VALUES('{0}', '{1}', '{2}', '{3}','{4}')", pClientes.Nombre, pClientes.Producto, pClientes.precio, pClientes.cantidad, pClientes.Total);
            return ComunDB.EjecutarComando(consulta);
        }
        public static int Modificar(Cliente pClientes)
        {
            string consulta = string.Format("UPDATE Cliente SET Nombre='{1}', Producto = '{2}', cantidad = '{3}', precio = '{4}', Total = '{5}' WHERE IDfactura ={ 0}", pClientes.Nombre, pClientes.Producto, pClientes.precio, pClientes.cantidad, pClientes.IDfactura);
            return ComunDB.EjecutarComando(consulta);
        }

        public static int Borrar(Cliente pClientes)
        {
            string consulta = string.Format("DELETE FROM Cliente WHERE IDfactura={0}",

            pClientes.IDfactura);

            return ComunDB.EjecutarComando(consulta);
        }

        public static Cliente BuscarPorId(Cliente pCliente)
        {
            string pConsulta = string.Format("SELECT IDfactura, Nombre, Producto, cantidad, precio, Total  FROM Cliente WHERE IDfactura ={ 0} ", pCliente.IDfactura);

            IDataReader Leer = ComunDB.EjecutarComandoReader(pConsulta);
            Cliente clientess = new Cliente();
            while (Leer.Read())
            {
                clientess.IDfactura = Leer.GetInt32(0);
                clientess.Nombre = Leer.GetString(1);
                clientess.Producto = Leer.GetString(2);
                clientess.cantidad = Leer.GetString(3);
                clientess.precio = Leer.GetString(4);
                clientess.Total = Leer.GetString(5);
            }
            return clientess;
        }

        public static List<Cliente> RellenarGRID()
        {
            string consulta = string.Format("SELECT IDfactura, Nombre, Producto, cantidad, precio, Total  FROM Cliente ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Cliente> ListadoClientes = new List<Cliente>();
            while (Leer.Read())
            {
                Cliente xClientes = new Cliente();
                xClientes.IDfactura = Leer.GetInt32(0);
                xClientes.Nombre = Leer.GetString(1);
                xClientes.Producto = Leer.GetString(2);
                xClientes.cantidad = Leer.GetString(3);
                xClientes.precio = Leer.GetString(4);
                xClientes.Total = Leer.GetString(5);

                ListadoClientes.Add(xClientes);
            }
            return ListadoClientes;
        }

        public static Cliente BuscarPorNombre(Cliente pClientes)
        {
            string consulta = string.Format("SELECT IDfactura,Nombre,producto,cantidad, precio, Total FROM Cliente WHERE Nombre Like '%{0}%'", pClientes.Nombre);
            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            Cliente xClientes = new Cliente();
            while (Leer.Read())
            {
                xClientes.IDfactura = Leer.GetInt32(0);
                xClientes.Nombre = Leer.GetString(1);
                xClientes.Producto = Leer.GetString(2);
                xClientes.cantidad = Leer.GetString(3);
                xClientes.precio = Leer.GetString(4);
                xClientes.Total = Leer.GetString(5);
            }
            return xClientes;
        }
    }
}
