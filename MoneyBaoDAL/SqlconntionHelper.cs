﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoDAL
{
    public static class SqlconntionHelper
    {
        /// <summary>
        /// 配置连接字符串
        /// </summary>
        /// <returns></returns>
        public static string GetConntion()
        {
            string connectionString = "Data Source=192.168.43.68;Initial Catalog=MoneyLeopard;User ID=sa";
            return connectionString;
        }
    }
}
