using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2Project.Interfaces
{
    interface DBInterface
    {
        void InsertRecord<T>(string table, T record);
        List<T> LoadRecords<T>(string table);
        // T LoadRecordByID<T>(string table, Guid id);  //Couldn't get this one to work properly
        List<T> GetAll<T>(string table);
        void UpsertRecord<T>(string table, Guid id, T record);
        void DeleteRecord<T>(string table, Guid id);
    }
}
