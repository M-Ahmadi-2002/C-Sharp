using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char op;
            //string req;
            //Console.WriteLine("enter your request");
            //req = Console.ReadLine();
            //req.Split('+', '-', '/' ,'*');
            //Console.WriteLine("enter first number");
            //a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter second number");
            //b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter an operator");
            //op = Convert.ToChar(Console.ReadLine());
            //if (op == '+')
            //    Console.WriteLine(a + b);
            //else if (op == '-')
            //    Console.WriteLine(a - b);
            //else if (op == '*')
            //    Console.WriteLine(a * b);
            //else if (op == '/')
            //    Console.WriteLine(a / b);
            //else
            //    Console.WriteLine("ERRORE");
            switch(op)
            {
                case '+':
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case '/':
                    {
                        if (b == 0)
                            Console.WriteLine("ERRORE");
                        else
                        Console.WriteLine(a / b);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ERRORE");
                        break;
                    }
            }
            Console.ReadLine();
            
        }
    }
}
