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
        private string fileDestination;

         public bool searchUser(User user)
        {
            bool found = false;
            string comparedPassword;
            string comparedUserName;
            User comparedUser;
            /* EXCEPTION NEED: TRY AND CATCH (IF THE FILE EXISTS) */
            try {
                DBiterator = new StreamReader("C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Data Base was not found in the specific location.");
                return false;
            }
            while (!DBiterator.EndOfStream & !found)
            {
                comparedUserName = DBiterator.ReadLine();
                comparedPassword = DBiterator.ReadLine();
                comparedUser = new User(comparedUserName, comparedPassword);
                if (user.equals(comparedUser))
                    found = true;
            }
            DBiterator.Dispose();
            return found;
        }
        public bool changePassword(User user, string password)
        {
            fileDestination = "C:\\Users\\itay\\Documents\\Visual Studio 2015\\Projects\\BSI162\\DB.txt";
            FileStream oStream = new FileStream(fileDestination, FileMode.Open, FileAccess.Write, FileShare.Read);
            FileStream iStream = new FileStream(fileDestination, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            /* EXCEPTION NEED: TRY AND CATCH (IF THE FILE EXISTS) */
            StreamWriter writer;
            try {
                DBiterator = new StreamReader(iStream);
                writer = new StreamWriter(oStream);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Data Base was not found in the specific location.");
                return false;
            }
            bool foundUser = false;
            string userNameDB;
            while (!DBiterator.EndOfStream  && !foundUser)
            {
                userNameDB = DBiterator.ReadLine();
                writer.WriteLine(userNameDB);
                if (userNameDB.Equals(user.getUserName()))
                    foundUser = true;
                if(!foundUser)
                {
                    userNameDB = DBiterator.ReadLine();
                    writer.WriteLine(userNameDB);
                }

            }
            if (foundUser)
            {
                writer.WriteLine(password);
            }
            DBiterator.Dispose();
            writer.Dispose();
            return true;
        }
       

    }
   
}
