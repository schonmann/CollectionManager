using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.DAO
{
    public class InfoElasticServerDAO : InfoDAO
    {
        public string[] GetTypes(string locale)
        {
            switch (locale)
            {
                case "pt-br":
                    return Enum.GetNames(typeof(ItemTypePt));
                case "en-us":
                    return Enum.GetNames(typeof(ItemType));
                default:
                    return Enum.GetNames(typeof(ItemType));
            }
        }
    }
}