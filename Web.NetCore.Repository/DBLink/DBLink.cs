using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Web.NetCore.Commons.Helper;

namespace Web.NetCore.Repository
{
    public class DBLink
    {
        //public static string ConnectionString { get; set; }

        public static string ConnectionString = Appsettings.app(new string[] { "AppSettings", "SqlServer", "SqlServerConnection" });
    }
}
