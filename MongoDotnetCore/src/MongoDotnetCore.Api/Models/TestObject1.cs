using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDotnetCore.Api.Models
{
    public class TestObject1
    {
        public ObjectId _id;
        public int Int;
        public DateTime Datetime;
        public double Double;

        public TestObject1()
        {
            _id = ObjectId.GenerateNewId();
            Int = new Random().Next(1, 100);
            Datetime = DateTime.Now;
            Double = new Random().Next(1, 100);
        }
    }
}
