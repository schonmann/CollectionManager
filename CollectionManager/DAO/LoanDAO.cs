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
        void StartLoan();
        void EndLoan();
        Loan GetById();
    }
}
