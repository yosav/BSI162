using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{
    
    /* class User describes the user's attributes and functionality */ 
    public class User
    {
        private string userName;
        private string password;
        /* constructor */
        public User(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
        }
        /* geters and seters */
        public void setUserName(string _userName)
        {
            userName = _userName;
        }
        public string getUserName()
        {
            return userName;
        }
        public void setPassword(string _password)
        {
            password = _password;
        }
        public string getPassword()
        {
            return password;
        }
        /*comparing details between users */
        public bool equals(User diffUser)
        {
            return checkUserName(diffUser) && checkPassword(diffUser);
        }
        /* comparing password between users */
        public bool checkPassword(User diffUser)
        {
            return password.Equals(diffUser.getPassword());

        }
        /* comparing user name between users */
        public bool checkUserName(User diffUser)
        {
            return userName.Equals(diffUser.getUserName());

        }
    }
}
