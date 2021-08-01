using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment2
{
    class userCircle
    {
        public static void Area()
        {
            Console.WriteLine("Give me the first circle's radius ");
            int rad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the second circle's radius ");
            int rad2 = Convert.ToInt32(Console.ReadLine());
            
            Circle c1 = new Circle();
            c1._radius = rad1;
            Circle c2 = new Circle();
            c2._radius = rad2;
            Circle c3 = c1 + c2;
            Console.WriteLine("The size of your combined circle's areas is " + c3._area);
          

            c1._area = c1._radius * c1._radius * Convert.ToInt32(Math.PI);
            c2._area = c2._radius * c2._radius * Convert.ToInt32(Math.PI);
            
            if (c1._area > c2._area)
            {
                Console.WriteLine("The first circle is bigger by " + (c1._area - c2._area));
            }
            if (c1._area < c2._area)
            {
                Console.WriteLine("The second circle is bigger by " + (c2._area - c1._area));
            }
            UserMenu.menu();
        }
        
    }
}
