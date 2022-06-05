using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class KeyNotFoundExcept
    { public static void KeyNotFoundError() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("5", 5);
            dict.Add("6", 6);
            try
            {
                Console.WriteLine(dict["111"]);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
