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
        int temp;
        public void SwapTwoNumber()
        {
            Console.WriteLine("Enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2= Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Before Swapping");
            Console.WriteLine("First Number" +number1);
            Console.WriteLine("second Number " + number2);

            temp = number1; //store number1 value into the temp variable
            number1= number2;  //store number 2 value into the number 1 variable
            number2= temp;  //and last store  temp value to the number 2 variable
            
            Console.WriteLine("After Swapping");
            Console.WriteLine("First number:" +number1);
            Console.WriteLine("Second Number:" + number2);



        }
    }
}
