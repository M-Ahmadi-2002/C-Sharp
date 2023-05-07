using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NameSpace1
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("you are in \"NameSpace 1\" and Calss \"C1\" and Function \"F1\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameSpace1.C1 obj1 = new NameSpace1.C1();
            NameSpace2.C1 obj2 = new NameSpace2.C1();
            obj1.F1();
            obj2.F1();
            Console.ReadLine();

           // string ans;
           // Console.WriteLine("Enter your ans");
           // ans = Console.ReadLine();
           //A.print(ans);
           // Console.ReadLine();
        }
    }
}
namespace NameSpace2
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("you are in \"NameSpace 2\" and Calss \"C1\" and Function \"F1\"");
        }
    }
    //class A
    //{
    //    static public void print(string x)
    //    {
    //        Console.WriteLine(x);
    //    }
    //}
}