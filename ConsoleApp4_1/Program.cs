using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N больше 0: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 1; i < N+1; i++)
            {
                S = S + (2 * i - 1);
                Console.WriteLine("{0} ", S);               
            
            }
            Console.ReadKey();

        }
    }
}
