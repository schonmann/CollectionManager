using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.DAO
{
    interface PersonDAO
    {
        void InsertPerson(Person person);
        Person[] GetAllPerson();
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
    }
}
