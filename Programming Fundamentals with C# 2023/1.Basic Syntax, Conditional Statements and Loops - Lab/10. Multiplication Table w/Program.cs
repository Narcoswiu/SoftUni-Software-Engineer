using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_w
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int number=int.Parse(Console.ReadLine());
            int product = 0;
            for (int i = 1; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
            
        }
    }
}
