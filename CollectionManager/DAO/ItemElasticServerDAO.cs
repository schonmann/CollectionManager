using CollectionManager.Models;
using CollectionManager.Database;
using Nest;
using System.Collections.Generic;
using System;

namespace CollectionManager.DAO
{
    public class ItemElasticServerDAO : ItemDAO
    {    

        public Item GetById(string Id) 
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Get<Item>(new Item { Id = Id });
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return res.Source;
        }
        
        //Returns all title registers.
        public Item[] GetAll()
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Item>(s => s.AllTypes());
            if(res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Item>(res.Documents).ToArray();
        }
        
        //Insert title to database.
        public void InsertItem(Item item)
        {
            var elastic = ElasticServer.GetClient();
            var itemType = item.Type.ToString().ToLower();
            var result = elastic.Index(item, m => m.Type(itemType));
            if(result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }

        //Update title in the database.
        public void UpdateItem(Item item)
        {
            var elastic = ElasticServer.GetClient();
            var itemType = item.Type.ToString().ToLower();
            var path = new DocumentPath<Item>(item).Type(itemType);
            var res = elastic.Update<Item>(path, x => x.Doc(item));
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }

        public void DeleteItem(Item item)
        {
            var elastic = ElasticServer.GetClient();
            var itemType = item.Type.ToString().ToLower();
            var result = elastic.Delete<Item>(item, t=>t.Type(itemType));
            if (result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }

        public Item[] GetByFilter(Filter filter)
        {
            throw new NotImplementedException();
        }
    }
}