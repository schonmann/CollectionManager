using Nest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CollectionManager.Database
{
    //Singleton class to manage ElasticSearcg database connection.
    public static class ElasticDb
    {
        private static ElasticClient elastic;
        public static void Initialize()
        {
            var elasticAddress = ConfigurationManager.AppSettings.Get("ElasticAddress");
            var elasticUser = ConfigurationManager.AppSettings.Get("ElasticUser");
            var elasticPassword = ConfigurationManager.AppSettings.Get("ElasticPassword");
            elastic = ConnectionFactory.GetConnection(elasticAddress, elasticUser, elasticPassword);
        }
        public static ElasticClient GetInstace()
        {
            if (elastic == null) Initialize();
            return elastic;
        }
    }
}