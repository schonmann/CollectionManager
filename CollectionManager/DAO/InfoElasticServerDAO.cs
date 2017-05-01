using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;
using CollectionManager.Database;
using Nest;

namespace CollectionManager.DAO
{
    public class InfoElasticServerDAO : InfoDAO
    {
        public string[] GetTypes()
        {
            return Enum.GetNames(typeof(ItemType));
        }
    }
}