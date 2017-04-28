using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.DAO
{
    interface TitleDAO
    {
        Title GetById(long ID);
        Title[] GetAll();
        Title[] GetByPattern(string pattern);
        Title[] GetByType(string type);
        void InsertTitle(Title title);
    }
}
