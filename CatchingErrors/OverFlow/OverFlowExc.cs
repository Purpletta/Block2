using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class OverFlowExc
    {
        public static void OverFlowError() {

            int value = 780000000;
            checked
            {
                try
                {
                    
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
                catch (OverflowException except)
                {
                    Console.WriteLine(except);
           
            }
            }
        }

    }
}
