using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDoimentions_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[3, 4];
            int[,] mat2 = new int[4, 2] { { 2, 3 }, { 4, 5 }, { 1, 7 }, { 0, 9 } };
            int[,] mat3 = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.Write(mat2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    Console.WriteLine(" please enter numbers for row {0} : ", i);
            //    for (int j = 0; j < mat1.GetLength(1); j++)
                    
            //    {
            //        Console.Write("mat1[{0},{1}] \t", i, j);
            //        mat1[i,j]= Convert.ToInt32( Console.ReadLine());
                    
            //    }
                
            //}

            //Console.WriteLine("your numbers in mat1 are : ");
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.Write(mat1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("you numbers in mat3 are : ");
            //foreach(int x in mat3)
            //{
            //    Console.Write(x + "\t");

            //}
           
            
            
            // برنامه بنویسد که در برای حلقه 
            //foreach 
            // بصورت سطر به سطر چاپ کند
            int counter = 0;
                foreach( int x in mat3)
                {
                Console.Write(x + "\t");
                counter++;
                if (counter==mat3.GetLength(1))
                {
                    counter = 0;
                    Console.WriteLine("\n");
                }
                
                }

            // برنامه ای بنویسید که ماتریس را بصورت ستونی چاپ کند
            //for (int j = 0; j < mat3.GetLength(1); j++)
            //{
            //    for (int i = 0; i < mat3.GetLength(0); i++)
            //    {
            //        Console.Write(mat3[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //  برنامه ای بنویسید که ترانهاده یک ماتریس را به شما بدهد
            int[,] mat4 = new int[mat3.GetLength(1), mat3.GetLength(0)]; 
            for (int j = 0; j < mat3.GetLength(1); j++)
            {
                for (int i = 0; i < mat3.GetLength(0); i++)
                {
                    mat4[j,i]=mat3[i, j];
                }
            }
            for (int i = 0; i < mat4.GetLength(0); i++)
            {
                for (int j = 0; j < mat4.GetLength(1); j++)
                {
                    Console.Write(mat4[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        }
    }

