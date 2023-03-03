using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StudentsMicroService.Infrastructure.Repositories
{
    public class MongoRepository
    {
        protected MongoClient _client;        
        protected IMongoDatabase _database;

        public MongoRepository(
            IConfiguration configuration
        )
        {
            var settings = configuration.GetSection("Mongo");
            _client = new MongoClient(settings["ConnectionString"]);
            _database = _client.GetDatabase(settings["DatabaseName"]);
        }
    }
}
