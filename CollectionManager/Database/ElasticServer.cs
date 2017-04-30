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
        private static String[] indexes = { Item.ELASTIC_INDEX, Place.ELASTIC_INDEX, Person.ELASTIC_INDEX, Loan.ELASTIC_INDEX };
        public static void Initialize()
        {
            //Get connection parameters from app settings.
            var elasticAddress = ConfigurationManager.AppSettings.Get("ElasticAddress");
            var elasticUser = ConfigurationManager.AppSettings.Get("ElasticUser");
            var elasticPassword = ConfigurationManager.AppSettings.Get("ElasticPassword");
            //Add settings to set index mapping for the model classes and basic auth parameters.
            var settings = new ConnectionSettings(new Uri(elasticAddress))
                .MapDefaultTypeIndices(m => m
                .Add(typeof(Item), Item.ELASTIC_INDEX).Add(typeof(Place), Place.ELASTIC_INDEX)
                .Add(typeof(Person), Person.ELASTIC_INDEX).Add(typeof(Loan), Loan.ELASTIC_INDEX))
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