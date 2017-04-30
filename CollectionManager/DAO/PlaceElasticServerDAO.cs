using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;
using CollectionManager.Database;

namespace CollectionManager.DAO
{
    public class PlaceElasticServerDAO : PlaceDAO
    {
        public Place[] GetAllPlaces()
        {
            var results = new List<Place>();
            var elastic = ElasticServer.GetClient();
            var scanResults = elastic.Search<Place>(s => s.From(0).Size(2000).AllTypes().Scroll("5m"));
            //var scrollResults = elastic.Scroll<Title>("5m", scanResults.ScrollId);
            //while (scrollResults.Documents.Count > 0)
            //{
            //    results.AddRange(scrollResults.Documents);
            //    scrollResults = elastic.Scroll<Title>("5m", scanResults.ScrollId);
            //}
            return new List<Place>(scanResults.Documents).ToArray();
        }

        public void InsertPlace(Place place)
        {
            var elastic = ElasticServer.GetClient();
            var result = elastic.Index(place);
            if (result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }
        
    }
}