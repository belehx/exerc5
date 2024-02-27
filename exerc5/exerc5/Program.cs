using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite os valores dos lados do triângulo:");
            Console.Write("lado A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("lado B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("lado C: ");
            c = int.Parse(Console.ReadLine());


            if (a < b + c && b < a + c && c < a + b)
            {

                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo.");

            }

            Console.ReadKey();
        }
    }
}
