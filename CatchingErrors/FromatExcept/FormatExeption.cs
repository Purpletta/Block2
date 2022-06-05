using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class FormatExeption
    {   public static void FormatError() {
            string a = "aaa";
            try {
                Console.WriteLine(int.Parse(a));
            }
            catch (FormatException except)
            {
                Console.WriteLine(except);
            }
        }
        
        
        }



    }

