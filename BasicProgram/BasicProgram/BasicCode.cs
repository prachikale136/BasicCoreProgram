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
        double sum =0.0;
        public void PrimeFactor()
        {
            Console.WriteLine("Enter the number to find prime factor");
            N = Convert.ToInt32(Console.ReadLine());
            while (N%2 == 0)
            {
                Console.WriteLine(2 + "");
                N /= 2;
                for (int i = 3; i <= Math.Sqrt(N); i+=2)
                { 
                    while (N %i == 0) 
                    {
                        Console.WriteLine(i + "");
                        N /= i;
                    }
                }
                if (N> 2)
                {
                    Console.WriteLine( N );
                }
              
            }
           



        }
    }
}
