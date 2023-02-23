using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    
    internal class BasicCode
    {
        char alphabet;
      
        public void VowelAndConsonant()
        {
            Console.WriteLine("Enter Alphabet to check vowel and constant");
            alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("Alphabet is vowel");
            }
            else
            {
                Console.WriteLine("Alphabet is consonant");
            }
            
            



        }
    }
}
