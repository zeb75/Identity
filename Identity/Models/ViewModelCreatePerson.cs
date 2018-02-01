using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class ViewModelCreatePerson
    {

        [Display(Name = "Person")]
        public string Name { get; set; }

        public City City { get; set; }

        public List<Country> Countries { get; set; }
    }
}