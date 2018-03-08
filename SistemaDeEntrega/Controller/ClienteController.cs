using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClienteController

    {
        public List<Cliente> MeusClientes { get; set; }

        public ClienteController()
        {
            MeusClientes = new List<Cliente>();
        }

        public void SalvarCliente(Cliente cliente)
        {
            //TODO: Percistir os dados do Cliente
            MeusClientes.Add(cliente);
        }
    }
}
