using Controller;
using Modelos;
using System;
using System.Collections.Generic;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal

        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ListarClientes = 4,
            ExcluirCliente = 5,
            LimparTela = 6,
            Sair = 7
        }





        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4- Listar Clientes");
            Console.WriteLine("5- Excluir Cliente");

            Console.WriteLine(" - Geral -");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("7-  Sair");

            //return Convert.ToInt32(Console.ReadLine());
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada =
                OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        Cliente c = CadastrarCliente();


                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);
                        ExibirDadosCliente(c);

                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        EditarCliente();
                        break;

                    case OpcoesMenuPrincipal.ListarClientes:
                        ListarClientes();

                        break;

                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.LimparTela:

                        break;



                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);
        }



        // Metodos Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();

            Console.Write("Digite o nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o cpf: ");
            cli.Cpf = Console.ReadLine();

            Endereco end = CadastrarEndereco();

            cli.EnderecoID = end.EnderecoID;


            return cli;
        }

        private static void PesquisarCliente()
        {
            Console.WriteLine("Digite o nome do Cliente: ");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cli = cc.ProcurarCliente(nomeCliente);

            if (cli != null)
                ExibirDadosCliente(cli);
            else
                Console.WriteLine("* Cliente não encotrado");
        }


        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.WriteLine("--- Dados Cliente ---");
            Console.WriteLine("Id:" + cliente.PessoaID);
            Console.WriteLine("Nome:" + cliente.Nome);
            Console.WriteLine("Cpf:" + cliente.Cpf);
            Console.WriteLine("ID endereço: " + cliente.EnderecoID);

            ExibirDadosEndereco(cliente.EnderecoID);


        }

        private static void ExcluirCliente()

        {
            Console.WriteLine("Digite o id do Cliente que deseja excluir: ");
            int idCliente = int.Parse(Console.ReadLine());

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(idCliente);


        }
        public static void ListarClientes()
        {
            ClienteController cc = new ClienteController();
            List<Cliente> ListarClientes = cc.ListarClientes();

            foreach (Cliente c in ListarClientes)
            {

                Console.WriteLine("--- Dados Cliente ---");
                Console.WriteLine("Id:" + c.PessoaID);
                Console.WriteLine("Nome:" + c.Nome);
                Console.WriteLine("Cpf:" + c.Cpf);

                

                //versão do profº 
                //List<Cliente> lista = cc.ListarClientes();
                //foreach(Cliente cli in Lista)
                //{
                // ExibirDadosCliente(cli);
                //}
                //{
                // Console.WriteLine();
                //}
            }
        }

        public static void EditarCliente()
        {
            ClienteController cc = new ClienteController();

            Cliente cliente;

            Console.WriteLine("Digite a Id do cadastro que deseja alterar: ");
            cliente = cc.PesquisarPorID(int.Parse(Console.ReadLine()));

            ExibirDadosCliente(cliente);


            Console.Write("Digite novo nome........: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite novo cpf.........: ");
            cliente.Cpf = Console.ReadLine();

            // ... Endereco
            EnderecoController ee = new EnderecoController();

            EditarEndereco(cliente.EnderecoID);
        }

        // ENDEREÇO----
        public static Endereco CadastrarEndereco()
        {

            Endereco end = new Endereco();

            Console.Write("Digite o nome da rua: ");
            end.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o numero: ");
            end.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o complemento: ");
            end.Complemento = Console.ReadLine();

            EnderecoController ee = new EnderecoController();
            ee.SalvarEndereco(end);

            return end;

        }
        //Exibir Endereço
        public static void ExibirDadosEndereco(int ID)
        {
            EnderecoController ee = new EnderecoController();
            Endereco e = ee.ProcurarEnderecoID(ID);

            Console.WriteLine("--- Endereço ---");
            Console.WriteLine("Rua:" + e.Rua);
            Console.WriteLine("Num:" + e.Numero);
            Console.WriteLine("Complemento:" + e.Complemento);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }

        // Listar Endereços
        public static void ListarEndereco()
        {
            EnderecoController ee = new EnderecoController();
            List<Endereco> ListarEndereco = ee.ListarEndereco();

            foreach (Endereco e in ListarEndereco)
            {

                Console.WriteLine("--- Endereço ---");
                Console.WriteLine("Rua:" + e.Rua);
                Console.WriteLine("Num:" + e.Numero);
                Console.WriteLine("Complemento:" + e.Complemento);
                Console.WriteLine("-----------------");
                Console.WriteLine();

            }

        }

        public static void ExcluirEndereco()
        {
            Console.WriteLine("Digite o id do Endereco que deseja excluir: ");
            int idEndereco = int.Parse(Console.ReadLine());

            EnderecoController ee = new EnderecoController();
            ee.ExcluirEndereco(idEndereco);
        }

        public static void EditarEndereco(int EnderecoID)
        {
            EnderecoController ee = new EnderecoController();
            Endereco endereco;
            endereco = ee.ProcurarEnderecoID(EnderecoID);

            Console.WriteLine("Digite a Id do endereço que deseja alterar: ");
            int idPesquisa = int.Parse(Console.ReadLine());
            EditarEndereco(idPesquisa);

            Console.Write("Digite o nome da rua....: ");
            endereco.Rua = Console.ReadLine();

            Console.Write("Digite o numero.........: ");
            endereco.Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o complemento....: ");
            endereco.Complemento = Console.ReadLine();
        }
    }

}

