﻿using EnlaceNoivas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnlaceNoivas.Helpers
{
    public class LoginHelper
    {
        public static User getCurrentUser(string UserOrEmail){
            db db = new db();
            return db.User.Where(user => user.Username == UserOrEmail || user.Email == UserOrEmail).FirstOrDefault();
        }
    }
}