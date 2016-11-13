using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDotnetCore.Api.Models;

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

        internal long SelectCount(string colllectionName)
        {
            var collection = _database.GetCollection<BsonDocument>(colllectionName);
            var filter = new BsonDocument();
            return collection.Find(filter).Count();
        }

        internal void InsertTestObject1()
        {
            var doc = new BsonDocument(new TestObject1().ToBsonDocument());
            var collection = _database.GetCollection<BsonDocument>("collection1");
            collection.InsertOne(doc);
        }

        internal void InsertTestObject2()
        {
            var doc = new BsonDocument(new TestObject2().ToBsonDocument());
            var collection = _database.GetCollection<BsonDocument>("collection2");
            collection.InsertOne(doc);
        }

        internal string SelectAll(string col)
        {
            var collection = _database.GetCollection<BsonDocument>(col);
            var filter = new BsonDocument();
            return collection.Find(filter).ToList().ToJson();
        }

        internal string SelectById(string col, string id)
        {
            var collection = _database.GetCollection<BsonDocument>(col);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            return collection.Find(filter).ToList().ToJson();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
