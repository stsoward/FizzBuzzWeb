using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.BusinessLayer
{
    public class InRange
    {
        
        //Checks if int is in range 1-300
        public bool IsInRange(int input)
        {
            if (input > 300 || input < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 300");
                return false;
            }
            return true;
        }
        
    }
}
