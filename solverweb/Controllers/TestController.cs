using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using System.ComponentModel.DataAnnotations;

namespace solverweb.Controllers
{
    
    
    public class TestController : ControllerBase
    {
        [EnableQuery(PageSize = 3)]
        public IQueryable<City> Get()
        {
            
            return new List<City>()
            {
                new City(){CityID=1, Property1="the first"},
                new City(){CityID=2, Property1="the next"},
                new City(){CityID=3, Property1="more"},
                new City(){CityID=4, Property1="yet more"}
            }.AsQueryable();
        }

        [EnableQuery]
        public IQueryable<City> Get([FromODataUri]int keyCityID)
        {
            return Get().Where(x => x.CityID == keyCityID);
        }

    }

    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string Property1 { get; set; }
    }
}
