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
        static int ultimoID = 0;

        public void SalvarCliente(Cliente cliente)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            cliente.PessoaID = id;
            MeusClientes.Add(cliente);
        }
        public Cliente ProcurarCliente(string nome)
        {
            Cliente c = (from x in MeusClientes where x.Nome.ToLower().Contains(nome.Trim().ToLower()) select x).FirstOrDefault();

            return c;
            
            //versão do professor
            // var c = from x in MeusClientes where x.Nome.Equals(nome) select x;
            //if (c!= null) 
            //return c.FirstOrDefault();
            // else
            // return null;
        }

       public Cliente PesquisarPorID(int idCliente)
        {
            var c = from x in MeusClientes where x.PessoaID.Equals(idCliente) select x;

            if (c != null)
                return c.FirstOrDefault();

            else
                return null;
        }

        public void ExcluirCliente(int idCliente)
        {
            Cliente cli = PesquisarPorID(idCliente);

            if (cli == null)
                MeusClientes.Remove(cli);
        }
    }
}
