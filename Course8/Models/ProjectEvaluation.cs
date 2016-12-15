using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Models
{
    //Exercise 2 - Course 9
    [Bind(Exclude = "Country")]

    //Exercise 1 - Course 8
    public class ProjectEvaluation
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //Exercise 3 - Course 9
        [Range(1,10)]
        [Required]
        public double Rating { get; set; }
        public int Id { get; set; } //Exercise 7 - course 8
        //Exercise 3 - Course 9
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}