using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2Project.Interfaces.database
{
    interface ListInterface
    {

        void AddItem();
        void DeleteItem();
        void EditItem();
        String GetItems();
        String GetItem();
    }
}
