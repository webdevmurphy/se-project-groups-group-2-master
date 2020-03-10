using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Views;


using System.Net;
using Microsoft.Azure.Cosmos;

using group2Project.Models;

namespace group2Project.CosmosDemo
{
    public class CosmosConnection
    {

        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = "https://se2trivia.documents.azure.com:443/";
        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = "QlM2UiD5BFPfikywYogAqMLOp6qjgbRKkqHMbsfGl3k6GZOzZjj7h36xy7wljlijGbSWB46XDauJCLmlWqhltg==";

        // The Cosmos client instance
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Container container;

        // The name of the database and container we will create
        private string databaseId = "TriviaNation";
        private string containerId = "UserNames";

        public async Task GetStartedDemoAsync()
        {
            // Create a new instance of the Cosmos Client
            this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
            await this.CreateDatabaseAsync();
            await this.CreateContainerAsync();
            await this.QueryItemsAsync();
       
        }
       
        private async Task CreateDatabaseAsync()
        {
            // Create a new database
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
            Console.WriteLine("Created Database: {0}\n", this.database.Id);
        }

        private async Task CreateContainerAsync()
        {
            // Create a new container
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/userName");
            Console.WriteLine("Created Container: {0}\n", this.container.Id);
        }

        public async Task addItems(String Id, String firstName, String lastName, String userName, String password, String phoneNumber)
        {
            this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
            await this.CreateDatabaseAsync();
            await this.CreateContainerAsync();
            await this.AddItemsToContainerAsync(Id, firstName, lastName, userName, password, phoneNumber);
        }
        
        public async Task getPassword(String userName, String password)
        {

            try
            {
                this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
                await this.CreateDatabaseAsync();
                await this.CreateContainerAsync();
          
                var sqlQueryText = "SELECT * FROM c WHERE c.userName = " + "'" + userName + "'" + " AND c.password = '" + password + "'";

                Console.WriteLine("Running query: {0}\n", sqlQueryText);

                QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
                FeedIterator<aUser> queryResultSetIterator = this.container.GetItemQueryIterator<aUser>(queryDefinition);
                
                
                List<aUser> aPerson = new List<aUser>();
                 

                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<aUser> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (aUser lastName in currentResultSet)
                    {
                        aPerson.Add(lastName);

                        Console.WriteLine(lastName);

                        MessageBox.Show(lastName.ToString());

                        if (password.Equals(lastName)) ;
                        {

                            MessageBox.Show("UserName: " + userName + "Password: " + password);
                            Console.WriteLine(password);
                            Console.WriteLine(lastName);
                            Console.WriteLine("Match");
                        }
                    }
                }
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show("No Record Found, Create Account!");
            }
        }
        /// <summary>
        /// Add Family items to the container
        /// </summary>
        private async Task AddItemsToContainerAsync(String Id, String firstName, String lastName, String username,String password, String phoneNumber)
        {
            aUser newPerson = new aUser
            {
                Id = Id,
                firstName = firstName,
                lastName = lastName,
                userName = username,
                password = password,
                phoneNumber = phoneNumber
            };

            try
            {
                // Read the item to see if it exists.  
                ItemResponse<aUser> userResponse = await this.container.ReadItemAsync<aUser>(newPerson.Id, new PartitionKey(newPerson.userName));
                Console.WriteLine("Item in database with id: {0} already exists\n", userResponse.Resource.Id);
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {

                Console.WriteLine("***************************************************************");
                // Create an item in the container representing the aUser. Note we provide the value of the partition key for this item, which is "newPerson"
                ItemResponse<aUser> userResponse = await this.container.CreateItemAsync<aUser>(newPerson, new PartitionKey(newPerson.userName));

                // Note that after creating the item, we can access the body of the item with the Resource property off the ItemResponse. We can also access the RequestCharge property to see the amount of RUs consumed on this request.
                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", userResponse.Resource.Id, userResponse.RequestCharge);
            }
        }

        /// <summary>
        /// Run a query (using Azure Cosmos DB SQL syntax) against the container
        /// </summary>
        private async Task QueryItemsAsync()
        {
            var sqlQueryText = "SELECT * FROM c WHERE c.userName = 'Kevin'";

            Console.WriteLine("Running query: {0}\n", sqlQueryText);

            QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
            FeedIterator<Family> queryResultSetIterator = this.container.GetItemQueryIterator<Family>(queryDefinition);

            List<Family> families = new List<Family>();

            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<Family> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (Family family in currentResultSet)
                {
                    families.Add(family);
                    Console.WriteLine(family);
                    MessageBox.Show(family.ToString());
                }
            }
        }


        private async Task ReplaceFamilyItemAsync()
        {
            ItemResponse<Family> wakefieldFamilyResponse = await this.container.ReadItemAsync<Family>("Wakefield.7", new PartitionKey("Wakefield"));
            var itemBody = wakefieldFamilyResponse.Resource;

            // update registration status from false to true
            itemBody.IsRegistered = true;
            // update grade of child
            itemBody.Children[0].Grade = 999;

            // replace the item with the updated content
            wakefieldFamilyResponse = await this.container.ReplaceItemAsync<Family>(itemBody, itemBody.Id, new PartitionKey(itemBody.LastName));
            Console.WriteLine("Updated Family [{0},{1}].\n \tBody is now: {2}\n", itemBody.LastName, itemBody.Id, wakefieldFamilyResponse.Resource);
        }

        /// <summary>
        /// Delete an item in the container
        /// </summary>
        private async Task DeleteFamilyItemAsync()
        {
            var partitionKeyValue = "Wakefield";
            var familyId = "Wakefield.7";

            // Delete an item. Note we must provide the partition key value and id of the item to delete
            ItemResponse<Family> wakefieldFamilyResponse = await this.container.DeleteItemAsync<Family>(familyId, new PartitionKey(partitionKeyValue));
            Console.WriteLine("Deleted Family [{0},{1}]\n", partitionKeyValue, familyId);
        }

        /// <summary>
        /// Delete the database and dispose of the Cosmos Client instance
        /// </summary>
        private async Task DeleteDatabaseAndCleanupAsync()
        {
            DatabaseResponse databaseResourceResponse = await this.database.DeleteAsync();
            // Also valid: await this.cosmosClient.Databases["FamilyDatabase"].DeleteAsync();

            Console.WriteLine("Deleted Database: {0}\n", this.databaseId);

            //Dispose of CosmosClient
            this.cosmosClient.Dispose();
        }


    }
}
