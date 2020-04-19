using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace group2Project.DataConnection
{
    public class MongoClientConn
    {
        private IMongoDatabase db;

        public MongoClientConn(string database)
        {
            var client = new MongoClient("mongodb+srv://mmurph789:564Wa218351@trivanationcluster-0xyhb.azure.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        // T is the record
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        // string table: table that you pass in, whatever model you want thats what will populate from whatever tabel you give us.
        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }


        public List<T> GetAll<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var filter = collection.Find(new BsonDocument()).ToList();

            foreach (var result in collection.ToString())
            {
                Console.WriteLine(result);
            }

            return filter.ToList();
        }




        // mongodb+srv://mmurph789:<password>@trivanationcluster-0xyhb.azure.mongodb.net/test?retryWrites=true&w=majority
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });

        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }




    }
}
