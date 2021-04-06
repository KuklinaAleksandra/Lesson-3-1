using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            /*   for (int i =0; i<5; i++) 
               {
                   for (int j = 0; j < 5; j++)
                   {
                       if (i==j)
                       {
                           Console.Write(1);
                       }
                       else
                       {
                           Console.Write(0);
                       }

                   }
                   Console.WriteLine();
               }
               Console.WriteLine();
               Console.ReadKey();

            */
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >=0; j--)
                {
                    if (i == j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
