using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharedClasses;

namespace DAL
{
    public interface IDAL
    {
        /* Searching user in the data base */
        bool searchUser(User user);
        /* Changing the password of a given user in the data base (in case he exists there) */
        bool changePassword(User user, string password);
    }
    public class DAL_v1 : IDAL
    {
        private StreamReader DBiterator;
        
         public bool searchUser(User user)
        {
            bool found = false;
            string comparedPassword;
            string comparedUserName;
            User comparedUser;
            /* EXCEPTION NEED: TRY AND CATCH (IF THE FILE EXISTS) */
            DBiterator = new StreamReader("C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt");

            while (!DBiterator.EndOfStream & !found)
            {
                comparedUserName = DBiterator.ReadLine();
                comparedPassword = DBiterator.ReadLine();
                comparedUser = new User(comparedUserName, comparedPassword);
                if (user.equals(comparedUser))
                    found = true;
            }
          
            return found;
        }
        public bool changePassword(User user, string password)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt");
            bool foundUser = false;
            string userNameDB;
            /* EXCEPTION NEED: TRY AND CATCH (IF THE FILE EXISTS) */
            DBiterator = new StreamReader("C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt");
            while (!DBiterator.EndOfStream  && !foundUser)
            {
                userNameDB = DBiterator.ReadLine();
                writer.WriteLine(userNameDB);
                if (userNameDB.Equals(user.getUserName()))
                    foundUser = true;
                userNameDB = DBiterator.ReadLine();
                writer.WriteLine(userNameDB);
            }
            if (foundUser)
            {
                writer.WriteLine(password);
            }
            DBiterator.Close();
            writer.Close();
            return true;
        }
       

    }
   
}
