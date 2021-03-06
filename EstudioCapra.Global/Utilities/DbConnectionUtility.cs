﻿using System;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;

namespace Common
{
    public static class DbConnectionUtitly
    {
        public static string GetADONetConnectionString()
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

        public static string GetEntityConnectionString()
        {
            var uriString = ConfigurationManager.AppSettings["SQLSERVER_URI"];
            var uri = new Uri(uriString);
            string providerName = "System.Data.SqlClient";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = uri.Host,
                InitialCatalog = uri.AbsolutePath.Trim('/'),
                UserID = uri.UserInfo.Split(':').First(),
                Password = uri.UserInfo.Split(':').Last()
            };

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder =
                new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/Models.EstudioCapraEntities.csdl|
                            res://*/Models.EstudioCapraEntities.ssdl|
                            res://*/Models.EstudioCapraEntities.msl";

            return entityBuilder.ToString();
        }

        public static string GetConnectionStringName()
        {
            return DevelopmentUtility.IsDevelopmentServer() 
                ? ConfigurationManager.AppSettings["LocalConnectionString"].ToString() 
                : GetADONetConnectionString();
        }

    }
}
