using Nest;
using System;
using CollectionManager.Models;
using System.Configuration;

namespace CollectionManager.Database
{
    //Singleton class to manage ElasticSearcg database connection.
    public static class ElasticServer
    {
        private static ElasticClient elastic;
        public static void Initialize()
        {
            var elasticAddress = ConfigurationManager.AppSettings.Get("ElasticAddress");
            var elasticUser = ConfigurationManager.AppSettings.Get("ElasticUser");
            var elasticPassword = ConfigurationManager.AppSettings.Get("ElasticPassword");
            var settings = new ConnectionSettings(new Uri(elasticAddress))
                .MapDefaultTypeIndices(m => m
                .Add(typeof(Item), Item.DEFAULT_INDEX)
                .Add(typeof(Place), Place.DEFAULT_INDEX)
                .Add(typeof(Person), Person.DEFAULT_INDEX));
            elastic = new ElasticClient(settings);
            elastic.CreateIndex(Item.DEFAULT_INDEX);
            elastic.CreateIndex(Place.DEFAULT_INDEX);
            elastic.CreateIndex(Person.DEFAULT_INDEX);
        }
        public static ElasticClient GetClient()
        {
            if (elastic == null) Initialize();
            return elastic;
        }
    }
}