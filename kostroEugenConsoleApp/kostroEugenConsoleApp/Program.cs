using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            float x;

            Console.WriteLine("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c: ");
            c = Convert.ToInt32(Console.ReadLine());

            x = (a + b + c) / 3;
            Console.WriteLine("x= "+x);
            Console.ReadKey();




        }
    }
}
