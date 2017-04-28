using Nest;
using System;
using System.Configuration;

namespace CollectionManager.Database
{

    public class ConnectionFactory
    {
        public static ElasticClient GetConnection(string address, string user, string password)
        {
            var settings = new ConnectionSettings(new Uri(address));
            var elastic = new ElasticClient(settings);
            return elastic;
        }
    }
}