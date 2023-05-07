using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabels
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            int Age;
            string Age2;
            string Name, Message;
            Name = Console.ReadLine();
            Age = int.Parse(Console.ReadLine());
            A = (double)Age;
            A = Convert.ToDouble(Age);
            Age2 = Convert.ToString(Age);
            A = double.Parse(Age2);
            Age = Convert.ToInt32(Console.ReadLine());
            //A = (int)Age;
            Message = "your name is " + Name + " and you are " + Age + " years old";
            Console.Write("Print text by type 1 :");
            Console.WriteLine(Message);
            Console.Write("Print text by type 2 :");
            Console.WriteLine("your name is " + Name + " and you are " + Age + " years old");
            Console.Write("Print text by type 3 :");
            Console.WriteLine("your name is {0} and you are {1} years old", Name, Age);
            Console.Write("Print text by type 4 :");
            Console.WriteLine($"your name is {Name} and you are {Age} years old");
            Console.ReadLine();

        }
    }
}
