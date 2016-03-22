using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;
using BL;


namespace PL
{
    interface PL
    {
        /* The login command of the user (credential vertification) */
        /* Returns enum status (correct/incorrect/locked user) */
        status login();
        /* The initiation of the toolKit (welcome messege) */
        void Init();
        /* The main interaction with the user */
        void Run();
        /* The posibility of changing the password */
        //bool for self checking-!!
        bool changePassword(User user);
    }
}
