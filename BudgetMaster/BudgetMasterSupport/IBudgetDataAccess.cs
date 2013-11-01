using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetMasterSupport
{
    public interface IBudgetDataAccess
    {
        //define methods to be implemented
        //database functionality
        void RetrieveData();
        void InsertData();
        void UpdateData();
        void DeleteData();
    }
}
