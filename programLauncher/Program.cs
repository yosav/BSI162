using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SharedClasses;
using System.IO;


namespace programLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileNotFoundException e = new FileNotFoundException();
            Console.WriteLine(e.Message);
            Console.ReadLine();
            testDAL();  
        }
        static void testDAL()
        {
            /* IMPEMENTATION NEEDED */
        }
    }
}
