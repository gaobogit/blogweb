
using NetCoreWeb.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace NetCoreWeb.Repository
{
    public class BaseDBConfig
    {
        static string sqlServerConnection = Appsettings.app(new string[] { "AppSettings", "SqlServer", "SqlServerConnection" });//获取连接字符串

        public static string ConnectionString = sqlServerConnection;
    }
}
