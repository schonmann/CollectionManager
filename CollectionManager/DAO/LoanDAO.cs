using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.DAO
{
    interface LoanDAO
    {
        void StartLoan(ModelWrapper wrapper);
        void EndLoan(ModelWrapper wrapper);
        Loan[] GetByPerson(string id);
        Loan[] GetByItem(string id);
        Loan[] GetAll();
    }
}
