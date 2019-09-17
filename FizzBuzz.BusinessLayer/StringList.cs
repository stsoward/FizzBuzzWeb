using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.BusinessLayer
{   
    public class StringList
    {
        //Returns a FizzBuzz string
        public string NumList(int input)
        {
            string result = "1";
            if (input == 1)
            {
                return result;
            }
            for (int i = 2; i <= input; i++)
            {
                result += ",";
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result += i.ToString();
                }
            }
            return result;
        }                     
    
    }
    
}
