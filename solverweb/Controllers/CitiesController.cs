using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using System.ComponentModel.DataAnnotations;

namespace solverweb.Controllers
{
    
    
    public class CitiesController : ControllerBase
    {
        [EnableQuery(PageSize = 3)]
        public IQueryable<City> Get()
        {
            
            return new List<City>()
            {
                new City(){Key="a", Property1="the first"},
                new City(){Key="b", Property1="the next"},
                new City(){Key="c", Property1="more"},
                new City(){Key="d", Property1="yet more"}
            }.AsQueryable();
        }


    }

    public class City
    {
        [Key]
        public string Key { get; set; }
        public string Property1 { get; set; }
    }
}
