using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {

        public int Year;
        public void LeapYear()
        {
            Console.WriteLine("Enter the Year");
            Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 400) == 0)
            {
                Console.WriteLine("Year is leap year");
            }
            else if ((Year % 100) == 0)
            {
                Console.WriteLine("Year is  Leap Year");
            }
            else if ((Year % 4) == 0)
            {
                Console.WriteLine("Year is leap year");
            }
            else 
            {
                Console.WriteLine("Year is not Leap year");
            }

        }
    }
}
