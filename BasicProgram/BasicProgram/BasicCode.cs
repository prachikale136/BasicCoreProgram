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
        public void HarmonicValue()
        {
            Console.WriteLine("Enter the number of term");
            N = Convert.ToInt32(Console.ReadLine());

            
            for (i = 1; i <= N; i++)
            {
                Console.WriteLine("1/{0} + ", +i);  //Print harmonic vlaue
              
            }
            sum += 1 / (float)i;   //sum = sum + float(i)
                                   // sum = 0.0 +(float)i
            Console.WriteLine("Sum of serious {0} to {1}:", N, sum);



        }
    }
}
