﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_and_Litrals
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.WriteLine("\n Pi = {0} \n ", Pi);

            Console.WriteLine("\n \t Pi = {0} \n ", Pi);

            Console.WriteLine("\n \v Pi = {0} \n ", Pi);

            Console.WriteLine("\n \b\'Pi\' = {0} \n ", Pi);

            Pi = 90;

            Console.ReadLine();
        }
    }
}
