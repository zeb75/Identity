using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public City City { get; set; }
    }
}