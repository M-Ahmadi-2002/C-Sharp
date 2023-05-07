using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBenifite
{
    class Program
    {
        static void Main(string[] args)
        {
            double Blc, BG, BB;
            int month_Waite=0;
            Console.WriteLine("enter blance");
            Blc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Gold");
            BG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Bank Benifite");
            BB = Convert.ToDouble(Console.ReadLine());

            while(Blc<=BG)
            {
                Blc = (Blc * (BB / 100)) + Blc;
                month_Waite++;
                Console.WriteLine("you blace after \t"+month_Waite+"\t is \t"+Blc);
            }
            //Console.WriteLine("you blance after one month: ");
            //BG = (Blc * (BB / 100)) + Blc;

            Console.WriteLine("Number of mounth thay you should waite is \t"+ month_Waite);
           
            Console.ReadLine();
        }
    }
}
