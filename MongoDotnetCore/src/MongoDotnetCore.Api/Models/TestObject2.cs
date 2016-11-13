using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDotnetCore.Api.Models
{
    public class TestObject2
    {
        public ObjectId _id;
        public DateTime Datetime;
        public List<ChildObject> List = new List<ChildObject>();

        public TestObject2()
        {
            _id = ObjectId.GenerateNewId();
            Datetime = DateTime.Now;
            for(int i = 0; i < 3; i++)
            {
                List.Add(new ChildObject());
            }
        }
    }
}
