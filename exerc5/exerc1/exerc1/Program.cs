using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1

    {
        internal class Program
        {

            static void Main(string[] args)
            {
                int n1, n2, SOMA;

                Console.WriteLine("Digite um número: ");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro número: ");
                n2 = int.Parse(Console.ReadLine());

                SOMA = n1 + n2;

                if (SOMA > 10) 
                {
                    Console.WriteLine(SOMA + 5);
                } else
                {
                    Console.WriteLine(SOMA - 7);
                }
                Console.ReadKey(); 

            }
        }
    }


