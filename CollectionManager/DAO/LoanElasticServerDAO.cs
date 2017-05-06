using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;
using CollectionManager.Database;
using Nest;

namespace CollectionManager.DAO
{
    public class LoanElasticServerDAO : LoanDAO
    {
        public Loan[] GetAll()
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Loan>();
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Loan>(res.Documents).ToArray();
        }

        public Loan[] GetByItem(string id)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Loan>(s=>s.Query(q=>q.Match(m=>m.Field(f=>f.ItemId).Query(id))));
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Loan>(res.Documents).ToArray();
        }

        public Loan[] GetByPerson(string id)
        {
            var elastic = ElasticServer.GetClient();
            var res = elastic.Search<Loan>(s => s.Query(q => q.Match(m => m.Field(f => f.PersonId).Query(id))));
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
            return new List<Loan>(res.Documents).ToArray();
        }

        public void StartLoan(Item item, Person person, DateTime date)
        {
            //Create new loan object with item's and person's id, saving it's start date.
            var newLoan = new Loan
            {
                Id = item.Id + person.Id,
                ItemId = item.Id,
                PersonId = person.Id,
                StartDate = date
            };
            //Insert loan in ElasticSearch.
            var elastic = ElasticServer.GetClient();
            var result = elastic.Index(newLoan);
            if (result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }

        public void EndLoan(Item item, Person person, DateTime date)
        {
            //Create new loan object with end date for partial update in Elastic.
            var newLoan = new Loan
            {
                Id = item.Id + person.Id,
                EndDate = date,
                Ended = true
            };
            //Update loan in ElasticSearch.
            var elastic = ElasticServer.GetClient();
            var path = new DocumentPath<Loan>(newLoan);
            var res = elastic.Update<Loan>(path, x => x.Doc(newLoan));
            if (res.ServerError != null) throw new System.Exception(res.ServerError.Error.ToString());
        }
    }
}
