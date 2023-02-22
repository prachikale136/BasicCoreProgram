using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {
        public int Flip;
        public int head = 0;
        public int tail = 0;
        public int Coin;
        public int headCount=0;
        public int tailCount=0;



        double headPercentage;
        double tailPercentage;
        public void FlipCoin()
        {
            //take i/p from user
            Console.WriteLine("Enter the value for number of flips");
            Flip = Convert.ToInt32(Console.ReadLine());

            if (Flip > 0) //if Flip ids grater than 0 then iterate for loop
            {
                for (int i = 0; i < Flip; i++)
                { 
                    Random random= new Random();
                    Coin = random.Next(0, 2);
                    if (Coin == 0)
                    {
                        Console.WriteLine("HEAD");
                        head = 1;
                        headCount++;
                    }
                    else
                    {
                        Console.WriteLine("TAIL");
                        tail =1;
                        tailCount++;
                    }
                }
                headPercentage = (headCount * 100) / Flip;
                Console.WriteLine("percentage of head:" +headPercentage);
                tailPercentage = (tailCount * 100) / Flip;
                Console.WriteLine("Percentage of tail: " + tailPercentage);
            }
        }
        
    }
}
