using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.DAO
{
    interface ItemDAO
    {
        Item GetById(long ID);
        Item[] GetAll();
        Item[] GetByPattern(string pattern);
        Item[] GetByType(string type);
        void InsertTitle(Item title);
        void Delete(Item item);
    }
}
