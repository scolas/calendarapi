﻿using Calendar.Models;
using CalendarApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.BusinessLayer
{
    public interface IBusinessAuth
    {
        bool VerifyLogin(string uname, string pass);
        bool Logout(string uname, string pass);
        void createUser(User user);
        bool isLoggedIn();
    }
}
