using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace pokedex2
{
    internal class Program//em caso de sobrecrga (aula 9)
    {
        static void Main(string[] args)
        {
            pokedex pk = new pokedex();
            int resp = 100;
            while(resp != 0)
            {
                resp = Menu();
                if(resp == 1)
                {
                    pk.ListarPokemons();
                }
            }

            Console.ReadLine();
            Console.Clear();
        }
        static int Menu()
        {
            Console.WriteLine("agenda pokemon");
            Console.WriteLine("0 sair");
            Console.WriteLine("1 listar");
            Console.WriteLine("o que deseja fazer: ");
            int resp = int.Parse(Console.ReadLine());
            return resp;
        }
    }
}
