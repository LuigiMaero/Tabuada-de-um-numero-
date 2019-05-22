using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuadafor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numdig;

            Console.Write("Digite um número: ");
            numdig = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numdig * 10; i++)
            {
                if (i % numdig == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

            Console.ReadKey();
        }
    }
}
