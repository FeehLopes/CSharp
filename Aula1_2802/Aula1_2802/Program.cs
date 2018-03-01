using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_2802
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();



            Console.WriteLine("Digite Seu Nome");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Olá " + p.Nome);
            Console.ReadKey();
        }
    }
}
