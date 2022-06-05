using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class ArrayTypeMismatchExcept
    {

        public static void ArrayTypeMismatchError()
        {
            string[] charA = { "a", "aa", "aaa" };
            Object[] b= charA;
            try
            {
                b[2] = 100; // adding money
                Console.WriteLine(b[2]);
            }
            catch (ArrayTypeMismatchException except)
            {
                Console.WriteLine(except);
            }
        }
    }
}
