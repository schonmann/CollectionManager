using Nest;
using System;
using CollectionManager.Models;
using System.Configuration;

namespace CollectionManager.Database
{
    //Singleton to prepare ElasticSearch database client.
    public static class ElasticServer
    {
        private static ElasticClient elastic;
        private static String[] indexes = { Item.DEFAULT_INDEX, Place.DEFAULT_INDEX, Person.DEFAULT_INDEX };

        public static void Initialize()
        {
            //Get connection parameters from app settings.
            var elasticAddress = ConfigurationManager.AppSettings.Get("ElasticAddress");
            var elasticUser = ConfigurationManager.AppSettings.Get("ElasticUser");
            var elasticPassword = ConfigurationManager.AppSettings.Get("ElasticPassword");
            //Add settings to set index mapping for the model classes and basic auth parameters.
            var settings = new ConnectionSettings(new Uri(elasticAddress))
                .MapDefaultTypeIndices(m => m
                .Add(typeof(Item), Item.DEFAULT_INDEX)
                .Add(typeof(Place), Place.DEFAULT_INDEX)
                .Add(typeof(Person), Person.DEFAULT_INDEX))
                .BasicAuthentication(elasticUser, elasticPassword);
            //Initialize elastic client with our predefined settings.
            elastic = new ElasticClient(settings);
            //Create needed indexes.
            foreach(var idx in indexes){
                elastic.CreateIndex(idx);
            }
        }
        public static ElasticClient GetClient()
        {
            if (elastic == null) Initialize();
            return elastic;
        }
    }
}