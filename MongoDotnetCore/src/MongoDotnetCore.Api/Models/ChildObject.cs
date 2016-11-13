using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDotnetCore.Api.Models
{
    public class ChildObject
    {
        public int Int;
        public string Str;

        public ChildObject()
        {
            Int = new Random().Next(1, 100);
            Str = "Test  " + new Random().Next(1, 100);
        }
    }
}
