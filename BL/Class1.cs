using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;
using DAL;

namespace BL
{
   /* Declaration of enum status to determine the current status of the user */
    public enum status { correct, incorrect, locked };

    interface BL
    {
        /* atempt to login the user by vertifing credentials to the data-base */
        status Login(User user);
        /* changing the password to the one that was suggested by the user */
        bool changePassword(User user, String suggestedPassword);
        /* reset the password to random password matching the pre-condition */      
        bool resetPassword(User user);

    }
}
