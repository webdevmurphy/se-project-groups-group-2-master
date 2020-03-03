using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace group2Project.DataConnection
{
    class AzureCosmos
    {
        //Connection info for database
        static string EndpointUri = "https://se2trivia.documents.azure.com:443/";
        //Protect this string, if in production envrionement. Do not show to anyone!
        static string AuthKey = "QlM2UiD5BFPfikywYogAqMLOp6qjgbRKkqHMbsfGl3k6GZOzZjj7h36xy7wljlijGbSWB46XDauJCLmlWqhltg==";



        static DocumentClient client;

        public static async Task  displayAllDatabases()
        {
            try
            {
                using (client = new DocumentClient(new Uri(EndpointUri), AuthKey))
                {
                    //List all databases in the account db is an alias that represents a database object. returns entire object.
                    IEnumerable<Database> databases = from db in client.CreateDatabaseQuery()
                                                      select db;

                    Console.WriteLine("*********11111111111111111111***************");

                    //loop over database names
                    foreach (var item in databases)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("****************Database Return************");
                        Console.WriteLine("Database name: " + item.Id);

                    }

                    Console.WriteLine("##### END Database LIST #####");


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        public static async Task getSpecficDatabase(String name)
        {
            string databaseId = name;

            try
            {
                using (client = new DocumentClient(new Uri(EndpointUri), AuthKey))
                {

                    IEnumerable<Database> databases = from db in client.CreateDatabaseQuery()
                                                      select db;

                    Database newdb = (from db in client.CreateDatabaseQuery()
                                      where db.Id == databaseId
                                      select db).AsEnumerable().FirstOrDefault();

                    Console.WriteLine(newdb + ")))))0000((((((");

                    foreach (var item in databases)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("****************Selected DB Return************");

                        //item 
                        Console.WriteLine("Database name: " + item);

                    }

                    if (newdb == null)
                    {
                        Console.WriteLine("Database Does not Exist!!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }










        public static async Task getCollection()
        {

            try
            {
                using (client = new DocumentClient(new Uri(EndpointUri), AuthKey))
                {
                    IEnumerable<Database> databases = from db in client.CreateDatabaseQuery()
                                                      select db;


                    //databaseId = name of database we are looking for
                    string databaseId = "TriviaNation";

                    Database newdb = (from db in client.CreateDatabaseQuery()
                                      where db.Id == databaseId
                                      select db).AsEnumerable().FirstOrDefault();

                    IEnumerable<DocumentCollection> collections = from col in client.CreateDocumentCollectionQuery(newdb.SelfLink)
                                                                  select col;

                    Console.WriteLine("##########START COLLECTION INFO##########");

                    foreach (var item in collections)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("****************Collection Return************");
                    }

                    string collectionId = "MyCollections";

                    DocumentCollection newcol = (from col in client.CreateDocumentCollectionQuery(newdb.SelfLink)
                                                 where col.Id == collectionId
                                                 select col).AsEnumerable().FirstOrDefault();

                    if (newcol == null)
                    {
                        newdb = await client.CreateDatabaseAsync(new Database() { Id = databaseId });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }


        public static async Task createDatabase(String dataName)
        {
            try
            {
                using (client = new DocumentClient(new Uri(EndpointUri), AuthKey))
                {
                    IEnumerable<Database> databases = from db in client.CreateDatabaseQuery()
                                                      select db;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }





        }

    }
}
