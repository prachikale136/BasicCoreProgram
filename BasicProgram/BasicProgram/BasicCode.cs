using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {
        public int number1;
        public int number2; 
        public int number3;
      
        public void LargestNumber()
        {
            Console.WriteLine("Enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine(" the 1st number is the greatest number");

                }
                else
                {
                    Console.WriteLine("The 3rd number is the greatest number");
                }
            }

            else if (number2 > number3)
            {
                Console.WriteLine(" The 2nd number is the greatest number");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest number");
            }
           
        }
    }
}
