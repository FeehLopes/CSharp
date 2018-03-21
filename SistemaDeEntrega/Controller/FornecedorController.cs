using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public  class FornecedorController
    {
        static List<Fornecedor> FornecedoresCadastrados = new List<Fornecedor>();
        static int ultimaID = 0;

       
        public void SalvarFornecedor(Fornecedor fornecedor)
        {
            fornecedor.PessoaID = ultimaID + 1;
            FornecedoresCadastrados.Add(fornecedor);
            ultimaID++;
        }
    }
}
