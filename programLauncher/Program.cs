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
                
                DAL_v1 dal = new DAL_v1();
               User user = new User("itayro", "ibS3gvex");
                if (dal.searchUser(user)) 
                    Console.WriteLine("yyy");
                Console.WriteLine("stam");
              dal.changePassword(user, "123");
           /*   StreamReader str = new StreamReader("C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt");
            str.Close();
*/
        }
    }
}
