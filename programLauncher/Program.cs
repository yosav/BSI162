using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SharedClasses;


namespace programLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
                
                DAL_v1 dal = new DAL_v1();
               User user = new User("markr", "yxgx73fo");
                if (dal.searchUser(user)) 
                    Console.WriteLine("yyy");
                Console.WriteLine("stam");
              dal.changePassword(user, "12345678");
         
        }
    }
}
