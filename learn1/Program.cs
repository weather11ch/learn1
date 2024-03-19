using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b = " + (a+b));
            Console.ReadLine();
        }
    }
}
