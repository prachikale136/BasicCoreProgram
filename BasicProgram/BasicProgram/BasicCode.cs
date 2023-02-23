using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {
        public int input;
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter number to check even or odd");
            input = Convert.ToInt32(Console.ReadLine());

            if ((input % 2) == 0)
            {
                Console.WriteLine("number is even Number");
            }
            else
            {
                Console.WriteLine("Number is Odd Number");
            }
            



        }
    }
}
