﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionManager.Models;

namespace CollectionManager.DAO
{
    public class TitleElasticServerDAO : TitleDAO
    {
        public Title GetById(long ID) 
        {
            return null;
        }
        
        //Returns all title registers.
        public Title[] GetAll()
        {
            return null;
        }

        //Returns all by name pattern.
        public Title[] GetByPattern(string pattern)
        {
            return null;
        }

        //Returns all by title type.
        public Title[] GetByType(string type)
        {
            return null;
        }

        //Insert title to database.
        public void InsertTitle(Title t)
        {

        }

        //Update title in the database.
        public void UpdateTitle(Title t)
        {

        }
    }
}