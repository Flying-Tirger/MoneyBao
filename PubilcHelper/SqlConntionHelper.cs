﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubilcHelper
{
    public static class SqlConntionHelper
    {
        /// <summary>
        /// 配置连接字符串
        /// </summary>
        /// <returns></returns>
        public static string GetConntion()
        {
            string connectionString = "Data Source=DESKTOP-QE3UFHO;Initial Catalog=MoneyLeopard;User ID=sa;pwd=159878";
           
            return connectionString;
        }
    }
}
