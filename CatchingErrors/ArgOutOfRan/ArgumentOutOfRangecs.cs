using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class ArgumentOutOfRangecs
    {   public static void ArgumentOutOfRangeError() {
            List<char> a= new List<char>();
            try
            {
                Console.WriteLine(a[0]);
            }
            catch (ArgumentOutOfRangeException except)
            {
                Console.WriteLine(except);
            }

        }



    }
}
