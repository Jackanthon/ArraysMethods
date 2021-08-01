using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment2
{
    class Jagged
    {
        public static void Jag()
        {
            string[][] studentgrades = new string[5][];

            studentgrades[0] = new string[] { "Math", "Science", "History", "Art" };
            studentgrades[1] = new string[] { "Science", "History" };
            studentgrades[2] = new string[] { "Math", "Gym", "Art" };
            studentgrades[3] = new string[] { "Science", "History", "Art", "Technologies" };
            studentgrades[4] = new string[] { "Math", "Science", "Geography", "Art, Writing, Spanish" };
                    Console.Write("Here are the students classes:\n");
            for (int i = 0; i < studentgrades.GetLength(0); i++)
            {
                    Console.Write("\nStudent " + (i+1));
                for (int j = 0; j < studentgrades[i].Length; j++)
                {
                    Console.Write(": " + studentgrades[i][j]);
                }
            }
            Console.WriteLine();
            UserMenu.menu();
        }
    }
}

//Create a jagged array to store grades of 5 students for varied subjects and print them.
//char[ ][ ] studentgrades = new char[5][];

//studentgrades[0] = new char[5];