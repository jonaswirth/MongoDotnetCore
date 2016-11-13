using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace MongoDotnetCore.Api.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/test
        [HttpGet]
        public string Get()
        {
            return "Read the documentation on github if you don't know what to do.";
        }


        //GET api/test/count/collection1
        [HttpGet("count/{collection}")]
        public long CountCollection(string collection)
        {
            using (MongoHelper mongo = new MongoHelper())
            {
                return mongo.SelectCount(collection);
            }
        }

        //GET api/test/select/collection1
        [HttpGet("select/{collection}")]
        public string SelectAll(string collection)
        {
            using (MongoHelper mongo = new MongoHelper())
            {
                return mongo.SelectAll(collection);
            }
        }

        // GET api/test/select/collection1/582866814d8a102a38716a9d
        [HttpGet("select/{collection}/{id}")]
        public string Get(string collection, string id)
        {
            using(MongoHelper mongo = new MongoHelper())
            {
                return mongo.SelectById(collection, id);
            }
        }

        // POST api/test/insert/testObject1
        [HttpPost("insert/testObject1")]
        public void CreateObject1()
        {
            using (MongoHelper mongo = new MongoHelper())
            {
                mongo.InsertTestObject1();
            }
        }
        // POST api/test/insert/testObject2
        [HttpPost("insert/testObject2")]
        public void CreateObject2()
        {
            using (MongoHelper mongo = new MongoHelper())
            {
                mongo.InsertTestObject2();
            }
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
