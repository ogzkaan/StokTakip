using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Stok_Takip
{
    public static class Controller
    {
        public static String cnnVal(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

}

 