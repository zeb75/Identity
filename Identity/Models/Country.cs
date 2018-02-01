using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Country")]
        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}