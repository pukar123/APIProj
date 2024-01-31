using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiredFirstInfrastructure.Database.Implementations
{
    public class MongoDatabaseFactory: IMongoDatabaseFactory
    {
        private readonly IMongoDatabase _database;

        public MongoDatabaseFactory(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
