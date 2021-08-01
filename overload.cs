using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment2
{
    class overload
    {
        public static int Add(int a, int b)
        {
            int output = a + b;
            Console.Write("Your output " + output);
            return output;
        }
        public static int Add(int a, int b, int c)
        {
            int output = a + b + c;
            Console.Write("Your output " + output);

            return output;
        }
        public static float Multiply(float a, float b)
        {
            float output = a * b;
            Console.Write("Your output " + output);

            return output;
        } 
        public static float Multiply(float a, float b, float c)
        {
            float output = a * b * c;
            Console.Write("Your output " + output);

            return output;
        }
        public static void UserChoice()
        {
            Console.WriteLine("Would you like to add or multiply ");
            string userChoice = Console.ReadLine();
            
            if (userChoice == "add")
            {
                Console.WriteLine("Enter the first number ");
                int userNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number ");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                string UserNum3 = "";
                do
                {
                    Console.WriteLine("Enter the third number if you'd like ");
                    UserNum3 = Console.ReadLine();
                    if (!string.IsNullOrEmpty(UserNum3))
                    {
                        Add(userNum1, userNum2, Convert.ToInt32(UserNum3));
                    }
                    else
                    {
                        Add(userNum1, userNum2);
                        Console.WriteLine("\n");
                        UserMenu.menu();
                    }
                } while (string.IsNullOrEmpty(UserNum3));
            }


            if (userChoice == "multiply")
            {
                Console.WriteLine("Enter the first number ");
                float userNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number ");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                string UserNum3 = "";
                do
                {
                    Console.Write("Enter the third number if you'd like ");
                    UserNum3 = Console.ReadLine();
                    if (!string.IsNullOrEmpty(UserNum3))
                    {
                        Multiply(userNum1, userNum2, Convert.ToInt32(UserNum3));
                    }
                    else
                    {
                        Multiply(userNum1, userNum2);
                        Console.WriteLine("\n");
                        UserMenu.menu();
                    }
                } while (string.IsNullOrEmpty(UserNum3));
            }
            Console.WriteLine("\n");
            UserMenu.menu();
        }
    }
}

//Create a console application to create following overloaded methods:

//Int Add(int a, int b) , int Add(int a, int b, int c)
//float Multiply(float a, float b), float Multiply(float a, float b, float c)
//Call the above methods by providing a menu to user.