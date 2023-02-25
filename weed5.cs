using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite el valor inicial: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("digite el valor final: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números denominados pares ubicados entre {0} y {1} seran:", num1, num2);
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}