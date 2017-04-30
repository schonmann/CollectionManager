using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.DAO
{
    public interface InfoDAO
    {
        String[] GetTypes(string locale);
    }
}