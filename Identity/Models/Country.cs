using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Person> Persons { get; set; }

        public List<City> Cities { get; set; }
    }
}