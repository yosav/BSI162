using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;

namespace DAL
{
    interface DAL
    {
        /* Searching user in the data base */
        bool searchUser(User user);
        /* Changing the password of a given user in the data base (in case he exists there) */
        bool changePassword(User user);
    }
}
