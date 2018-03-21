using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EnderecoController
    {
        static List<Endereco> EnderecoCadastrado = new List<Endereco>();
        static int ultimoID = 0;

        public void SalvarEndereco(Endereco endereco)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            endereco.EnderecoID = id;
            EnderecoCadastrado.Add(endereco);
        }
        public Endereco ProcurarEnderecoID(int IdEndereco)
        {
            var e = from x in EnderecoCadastrado where x.EnderecoID.Equals(IdEndereco) select x;

            if (e != null)
                return e.FirstOrDefault();

            else
                return null;
        }

        public List<Endereco> ListarEndereco()
        {
            return EnderecoCadastrado;
        }

        public void ExcluirEndereco(int IdEndereco)
        {
            Endereco end = ProcurarEnderecoID(IdEndereco);

            if (end == null)
                EnderecoCadastrado.Remove(end);
        }
    }
}
