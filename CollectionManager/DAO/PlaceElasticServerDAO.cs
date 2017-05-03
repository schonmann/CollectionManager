using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;
using CollectionManager.Database;
using Nest;

namespace CollectionManager.DAO
{
    public class PlaceElasticServerDAO : PlaceDAO
    {

        public Place[] GetAllPlaces()
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Place>(s => s.AllTypes());
            if(res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Place>(res.Documents).ToArray();
        }

        public void InsertPlace(Place place)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Index(place);
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }

        public void UpdatePlace(Place place)
        {
            var elastic = ElasticServer.GetClient();
            var path = new DocumentPath<Place>(place);
            var res = elastic.Update<Place>(path, x=>x.Doc(place));
            if(res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }
        
        public void DeletePlace(Place place)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Delete<Place>(place);
            if(res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }
    }
}