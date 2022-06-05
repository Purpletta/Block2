using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class InvalidCast
    {
        public static string InvalidCastExcept()
        {
            object a = 5.28289;
            string s = null;
            try
            {
                s = (string)a;
            }
            catch (System.InvalidCastException except)
            {
                Console.WriteLine(except);
            }

            return s;
        }
    }
}
