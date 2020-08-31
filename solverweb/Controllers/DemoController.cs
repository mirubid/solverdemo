using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;

namespace solverweb.Controllers
{
    
    
    public class DemoController : ControllerBase
    {
        [EnableQuery(PageSize = 3)]
        public IQueryable<Demo> Get()
        {
            return new List<Demo>()
            {
                new Demo(){Key="a", Property1="the first"},
                new Demo(){Key="b", Property1="the next"},
                new Demo(){Key="c", Property1="more"},
                new Demo(){Key="d", Property1="yet more"}
            }.AsQueryable();
        }


    }

    public class Demo
    {
        public string Key { get; set; }
        public string Property1 { get; set; }
    }
}
