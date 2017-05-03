using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;
using CollectionManager.Database;
using Nest;

namespace CollectionManager.DAO
{
    public class PersonElasticServerDAO : PersonDAO
    {
        public void DeletePerson(Person person)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Delete<Person>(person);
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }

        public Person[] GetAllPerson()
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Person>(s => s.AllTypes());
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Person>(res.Documents).ToArray();
        }

        public void InsertPerson(Person person)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Index<Person>(person);
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }

        public void UpdatePerson(Person person)
        {
            var elastic = ElasticServer.GetClient();
            var path = new DocumentPath<Person>(person);
            var res = elastic.Update(path, x => x.Doc(person));
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }
    }
}