using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment2
{
    class MatrixArray
    {
        public static void Box()
        {

            int[,] arr2d = new int[3, 3]{
                                {1, 2, 3},
                                {3, 4, 5},
                                {6, 7, 8}
                            };

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\n---------------\n");
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {

                    //arr2d[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("| {0} |", arr2d[i, j]);
                }
            }
                Console.WriteLine("\n---------------");
                    Console.ForegroundColor = ConsoleColor.White;
            UserMenu.menu();
        }
    }
}
