using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Score;
            //int[] Score = {3,5,7,10 };
            //int[] Score =new int[4] { 3, 5, 7, 9 };
            //int[] Score;
            //Score = new int[4];

            int[] Score = new int[4];
            String[] Lessons = new string[4];
            int Sum=0;
            double Avg;
            for (int i = 0; i <Lessons.Length ; i++)
            {
                Console.WriteLine("Enter Lesson's Name");
                Lessons[i] = Console.ReadLine();
                Console.WriteLine("Enter Lesson's Score");
                Score[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Lessons.Length; i++)
            {
                Sum=Sum + Score[i];               
            }
            Avg = (double)Sum / Lessons.Length;

            Console.WriteLine("| Lessons   |   Score   |   Category|     STATE ");
            Console.WriteLine("|-----------|-----------|-----------|");
            for (int i = 0; i < Lessons.Length; i++)
            {
               
                Console.Write($"|{Lessons[i]}       |{Score[i]}         |");
                
                switch (Lessons[i])
                    {
                    case string t when t.StartsWith("prog"):
                        
                            Console.Write("PROGRAMING |");
                            break;
                    case string t when t.StartsWith("math"):

                        Console.Write("MATH       |");
                        break;
                    case string t when t.StartsWith("islam"):

                        Console.Write("GENERAL       |");
                        break;
                }


            }
            Console.WriteLine("|-----------|------------|");
            Console.WriteLine($"|Avrage     |{Avg}          |");
           // Console.WriteLine("|Avrage     |{0}          |", Avg);
            Console.ReadLine();

        }
    }
}
