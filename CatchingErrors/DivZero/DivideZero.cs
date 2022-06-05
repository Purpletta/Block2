using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    public static class DivideByZero
    {
        public static int DivByZero(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }

        public static int DividerFixed(int a, int b)
        {
            try
            {
                if (b != 0) return a / b;
                else return default;
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}
