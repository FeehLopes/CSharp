﻿using Controller;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal

        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            LimparTela = 5,
            Sair = 6
        }





        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4- Excluir Cliente");

            Console.WriteLine(" - Geral -");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6-  Sair");

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

            // ... Endereco
            Endereco end = new Endereco();

            Console.Write("Digite o nome da rua: ");
            end.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o numero: ");
            end.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o complemento: ");
            end.Complemento = Console.ReadLine();

            cli._Endereco = end;

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


            Console.WriteLine("--- Endereço ---");
            Console.WriteLine("Rua:" + cliente._Endereco.Rua);
            Console.WriteLine("Num:" + cliente._Endereco.Numero);
            Console.WriteLine("Complemento:" + cliente._Endereco.Complemento);
            Console.WriteLine("-----------------");
            Console.WriteLine();
            
        }

        private static void ExcluirCliente()

        {
            Console.WriteLine("Digite o id do Cliente que deseja excluir: ");
            int idCliente = int.Parse(Console.ReadLine());


            
        }
    }
}
