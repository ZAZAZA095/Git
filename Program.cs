using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdusca un numero para repetir la frase: Hello world");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + ".-" + " " + "hello wordl");
            }

            Console.ReadLine();
        }
    }
}
