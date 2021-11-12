using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DapperApp.DataAccess
{
    public class Connection
    {
        protected SqlConnection ConnectDB() => new SqlConnection(ConfigurationManager.ConnectionStrings["Amazon"].ConnectionString);
    }
}
