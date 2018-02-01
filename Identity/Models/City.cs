using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        public virtual List<Person> People { get; set; }
    }
}