﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());  
            int times=int.Parse(Console.ReadLine());
            int i = 1;
            
            do
            {
                Console.WriteLine($"{number} X {times} = {number*times}");
                times++;
            } while (times <= 10);

        }
       
    }
}
