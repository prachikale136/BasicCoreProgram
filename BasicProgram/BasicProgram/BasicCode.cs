using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {

        public int N;
        int i;
        public void PowerOfValue()
        {
            Console.WriteLine("Enter the Value");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Power of 2" +N+ "is: " +(Math.Pow(2, N)) );  //calculate the power of number

            Console.WriteLine("Printing till Power VAlue");
            for (i = 0; i <= N; i++)
            {
                Console.WriteLine("Power of 2" +i+ "is :" +(Math.Pow(2, i)));  //iterate the loop till the value of N and pribt the result
            }
            
            //Console.WriteLine("Power of two:" +PowerOfTwo);

            
        }
    }
}
