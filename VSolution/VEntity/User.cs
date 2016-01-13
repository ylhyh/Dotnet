﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSolution.VEntity
{
    public class User : BaseEntity
    {
        public int Id
        {
            get;
            set;
        }

        public string UserId
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Nickname
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string MobilePhone
        {
            get;
            set;
        }
    }
}
