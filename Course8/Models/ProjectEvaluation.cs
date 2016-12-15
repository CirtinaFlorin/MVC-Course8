using Course8.CustomAtributes;
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
    public class ProjectEvaluation:IValidatableObject
    {
        [MaxWords(3)]
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Rating < 2 && Name.ToLower().StartsWith("john"))
            { yield return new ValidationResult("Sorry John, you can't do this"); }
        }
    }

}