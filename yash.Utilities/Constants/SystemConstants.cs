using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Utilities.Constants
{
    public class SystemConstants
    {
        //your server name here
        private const string SQL_SERVER_NAME = "QUOC-TUAN";



        //ten chuoi ket noi trong appsettings.json
        public const string MainConnectionString = "YashDb";
        //chuoi ket noi 
        public const string ConnectionString = "Server="+SQL_SERVER_NAME+";Database=YashDb;uid=sa;pwd=123;Trusted_Connection=True;";
    }
}
