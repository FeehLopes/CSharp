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
        static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            //TODO: Percistir os dados do Cliente
            MeusClientes.Add(cliente);
        }
        public Cliente ProcurarCliente(string nome)
        {
            Cliente c = (from x in MeusClientes where x.Nome.ToLower().Equals(nome.Trim().ToLower()) select x).FirstOrDefault();

            return c;

            //versão do professor
            // var c = from x in MeusClientes where x.Nome.Equals(nome) select x;
            //if (c!= null) 
            //return c.FirstOrDefault();
            // else
            // return null;
        }

       
    }
}
