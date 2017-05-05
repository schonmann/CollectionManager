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
        Item GetById(string ID);
        Item[] GetAll();
        void InsertItem(Item title);
        void DeleteItem(Item item);
        Item[] GetByFilter(Filter filter);
    }
}
