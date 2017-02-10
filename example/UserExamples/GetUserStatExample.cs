﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jmessage.common;
using jmessage.util;
using jmessage.user;
using jmessage;

namespace example
{
    class GetUserStatExample: JMessageExampleBase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****开始修改用户信息******");
            UserClient client = new UserClient(app_key, master_secret);
            UserPayload user = new UserPayload("jintian");
            client.getUserStat(user);
            Console.ReadLine();
        }
    }
}
