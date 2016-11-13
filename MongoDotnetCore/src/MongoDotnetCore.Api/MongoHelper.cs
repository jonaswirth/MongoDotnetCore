using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDotnetCore.Api
{
    public class MongoHelper : IDisposable
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public MongoHelper()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");
        }

        public long SelectCount(string colllectionName)
        {
            var collection = _database.GetCollection<BsonDocument>(colllectionName);
            var filter = new BsonDocument();
            return collection.Find(filter).Count();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
