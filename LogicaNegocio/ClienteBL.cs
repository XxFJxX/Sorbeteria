using AccesoADatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ClienteBL
    {
        public static int Insertar(Cliente pCliente)
        {
            return ClienteDAL.Insertar(pCliente);
        }
        public static int Borrar(Cliente pCliente)
        {
            return ClienteDAL.Borrar(pCliente);
        }
        public static Cliente BuscarPorId(Cliente pCliente)
        {
            return ClienteDAL.BuscarPorId(pCliente);
        }

        public static int Modificar(Cliente pCliente)
        {
            return ClienteDAL.Modificar(pCliente);
        }
        public static List<Cliente> RellenarGRID()
        {
            return ClienteDAL.RellenarGRID();
        }
        public static Cliente BuscarPorNombre(Cliente pCliente)
        {
            return ClienteDAL.BuscarPorNombre(pCliente);
        }
    }
}
