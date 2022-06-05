using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatchingErrors
{
    class FileOpenError
    {
        public static void FileOpener()
        {
            try
            {
                using (StreamReader sr = new StreamReader("1"))
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
