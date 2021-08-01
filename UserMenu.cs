using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment2
{
    class UserMenu
    {
        public static void menu()
        {
            Console.WriteLine("\nPlease choose from this option:"); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("| Array | Jagged " +
                    "| Overload | Circle | Exit |\n"); Console.ForegroundColor = ConsoleColor.White;
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();
            if (userChoice == "ARRAY") { MatrixArray.Box(); }
            if (userChoice == "JAGGED") { Jagged.Jag(); }
            if (userChoice == "OVERLOAD") { overload.UserChoice(); }
            if (userChoice == "CIRCLE") { userCircle.Area(); }
            else { Environment.Exit(0); }


            Console.ReadLine();
        }
    }
}
