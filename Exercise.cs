using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_one
{
    public class Exercise
    {
        public static string TaskOne(int n)
        {
            int divider = 2;
            int odd = n % divider;
            string message = "";

            if (n < 1 || n > 100)
            {
                message = "Not found!";
            }

            if (n > 20 && odd == 0)
            {
                message = $"{n} is not Weird";
            }
            
            if(n >= 2 && n <= 5 && odd == 0)  
            {
                message = $"{n} is not Weird";
            }

            if (n >= 6 && n <= 20 && odd == 0)
            {
                message = $"{n} is Weird";
            }

            if(odd != 0)
            {
                message = $"{n} is Weird";
            }

            return message;
        }
    }
}