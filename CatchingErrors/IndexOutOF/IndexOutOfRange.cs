using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingErrors
{
    class IndexOutOfRange
    {
        public static void IndexOut()
        {
            int[] a = new int[5];
            try
            {
                for (int i = 0; i < 10; i++) {
                    a[i] += 6;
                
                }
            }
            catch (IndexOutOfRangeException except)
            {
                Console.WriteLine(except);
            }
        }
    }
}
