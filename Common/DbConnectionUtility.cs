using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class DbConnectionUtitly
    {
        public static string GetConnectionString()
        {
            var uriString = ConfigurationManager.AppSettings["SQLSERVER_URI"];
            var uri = new Uri(uriString);
            var connectionString = new SqlConnectionStringBuilder
            {
                DataSource = uri.Host,
                InitialCatalog = uri.AbsolutePath.Trim('/'),
                UserID = uri.UserInfo.Split(':').First(),
                Password = uri.UserInfo.Split(':').Last(),
            }.ConnectionString;

            return connectionString.ToString();
        }

        public static string GetConnectionStringName()
        {
            return DevelopmentUtility.IsDevelopmentServer() ?
                  ConfigurationManager.AppSettings["LocalConnectionStringName"].ToString()
                : ConfigurationManager.AppSettings["WebConnectionStringName"].ToString();
        }
    }
}
