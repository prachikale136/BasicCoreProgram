using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {

        public int dividend;
        public int divisor;
        int quotient;
        int remainder;
        public void QuotientAndRemainder()
        {
            Console.WriteLine("Enter the dividend"); //take divident from user
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor"); //take divisor from user
            divisor = Convert.ToInt32(Console.ReadLine());

            //now calculate the Quotient and remainder
            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("Quotient is :" + quotient);
            Console.WriteLine("Remainder is :" +remainder);
           



        }
    }
}
