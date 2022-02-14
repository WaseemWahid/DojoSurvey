using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {

        [Required]
        [MinLength(3)]
        public string Name{get;set;}

        [Required]
        public string City{get;set;}
        [Required]
        public string Language{get;set;}
        [Required]
        [MinLength(20)]
        public string Comments{get;set;}
    }
}