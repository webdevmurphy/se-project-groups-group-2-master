using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Views;
using System.Net;
using Microsoft.Azure.Cosmos;

using group2Project.Interfaces.database;
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
        private Container courseContainer;

        // The name of the database and userAccount contianer 
        private string databaseId = "TriviaNation";
        private string containerId = "UserNames";

        // The name of the second container for Course listings
        private string containerId2 = "Courses";

        //The name of the third container for Triva Questions
        private string containerId3 = "Questions";

        public async Task NewConnection()
        {
            // Create a new instance of the Cosmos Client
            this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        }

        private async Task CreateDatabaseAsync()
        {
            // Create a new database
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
            Console.WriteLine("Created Database: {0}\n", this.database.Id);
        }

        private async Task CreateUserContainerAsync()
        {
            // Create a new /userName container
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/userName");
            Console.WriteLine("Created Container: {0}\n", this.container.Id);
        }
        //Create a new /Courses containter
        private async Task CreateCoursesContainerAsync()
        {
            this.courseContainer = await this.database.CreateContainerIfNotExistsAsync(containerId2, "/Courses");
            Console.WriteLine("Created Database: {0}\n", this.database.Id);
        }
        //Create a new /Questions containter
        private async Task CreateQuestionsContainerAsync()
        {
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId3, "/Questions");
            Console.WriteLine("Created Database: {0}\n", this.database.Id);
        }

        public async Task addItems(String Id, String firstName, String lastName, String userName, String password, String phoneNumber)
        {
            await this.NewConnection();
            await this.CreateDatabaseAsync();
            await this.CreateUserContainerAsync();
            await this.AddItemsToContainerAsync(Id, firstName, lastName, userName, password, phoneNumber);
        }
        public async Task addCourse(String CourseName)
        {
            await this.NewConnection();
            await this.CreateCoursesContainerAsync();
            await this.AddItemsToContainerCourse(CourseName);
        }
        public async Task addItem(String Question, String Answer, String Course)
        {
            await this.AddItemsToContainerTrivia(Question, Answer, Course);
        }
        public async Task getPassword(String userName, String password)
        {

            try
            {
                await this.NewConnection();
                await this.CreateDatabaseAsync();
                await this.CreateUserContainerAsync();

                var sqlQueryText = "SELECT * FROM c WHERE c.userName = " + "'" + userName + "'" + " AND c.password = '" + password + "'";

                Console.WriteLine("Running query: {0}\n", sqlQueryText);

                QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
                FeedIterator<triviaPlayer> queryResultSetIterator = this.container.GetItemQueryIterator<triviaPlayer>(queryDefinition);


                List<triviaPlayer> aPerson = new List<triviaPlayer>();


                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<triviaPlayer> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (triviaPlayer lastName in currentResultSet)
                    {
                        aPerson.Add(lastName);

                        Console.WriteLine(lastName);

                        MessageBox.Show(lastName.ToString() + " \n " + password.ToString());

                        if (password.Equals(lastName)) ;
                        {
                            Console.WriteLine("C A L L E D");
                            MessageBox.Show("UserName: " + userName + "\n" + "Password: " + password);
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
        /// Add TriviaPlayer items to the container
        /// </summary>
        private async Task AddItemsToContainerAsync(String Id, String firstName, String lastName, String username, String password, String phoneNumber)
        {
            triviaPlayer newPlayer = new triviaPlayer
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
                ItemResponse<triviaPlayer> userResponse = await this.container.ReadItemAsync<triviaPlayer>(newPlayer.Id, new PartitionKey(newPlayer.userName));
                Console.WriteLine("Item in database with id: {0} already exists\n", userResponse.Resource.Id);
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {

                Console.WriteLine("***************************************************************");
                // Create an item in the container representing the triviaPlayer. Note we provide the value of the partition key for this item, which is "newPlayer"
                ItemResponse<triviaPlayer> userResponse = await this.container.CreateItemAsync<triviaPlayer>(newPlayer, new PartitionKey(newPlayer.userName));

                // Note that after creating the item, we can access the body of the item with the Resource property off the ItemResponse. We can also access the RequestCharge property to see the amount of RUs consumed on this request.
                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", userResponse.Resource.Id, userResponse.RequestCharge);
            }
        }

        private async Task AddItemsToContainerCourse(String CourseName)
        {
            Course newCourse = new Course
            {
                Id = CourseName + ".1",
                name = CourseName
            };
            try
            {
                // Read the item to see if it exists.  
                ItemResponse<Course> userResponse = await this.courseContainer.ReadItemAsync<Course>(newCourse.name, new PartitionKey(newCourse.name));
                Console.WriteLine("Item in database with id: {0} already exists\n", userResponse.Resource.name);
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {

                Console.WriteLine("***************************************************************");
                // Create an item in the container representing the Course. Note we provide the value of the partition key for this item, which is "name"
                ItemResponse<Course> userResponse = await this.courseContainer.CreateItemAsync<Course>(newCourse, new PartitionKey(newCourse.name));

                // Note that after creating the item, we can access the body of the item with the Resource property off the ItemResponse. We can also access the RequestCharge property to see the amount of RUs consumed on this request.
                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", userResponse.Resource.name, userResponse.RequestCharge);
            }
        }
        private async Task AddItemsToContainerTrivia(String Question, String Answer, String Course)
        {
            Question triviaInfo = new Question
            {
                question = Question,
                answer = Answer,
                course = Course
            };
        }

        /*  API DEMO REFERENCE MATERIAL  -- REMOVE LATER --

      /// <summary>
      /// Run a query (using Azure Cosmos DB SQL syntax) against the container
      /// </summary>
      private async Task QueryItemsAsync()
      {
          var sqlQueryText = "SELECT * FROM c WHERE c.userName = 'Kevin'";

          Console.WriteLine("Running query: {0}\n", sqlQueryText);

          QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
          FeedIterator<triviaPlayer> queryResultSetIterator = this.container.GetItemQueryIterator<triviaPlayer>(queryDefinition);

          List<triviaPlayer> families = new List<triviaPlayer>();

          while (queryResultSetIterator.HasMoreResults)
          {
              FeedResponse<triviaPlayer> currentResultSet = await queryResultSetIterator.ReadNextAsync();
              foreach (triviaPlayer family in currentResultSet)
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
      */

    }

}
