using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name{get;set;}
        public string City{get;set;}
        public string Language{get;set;}
        public string Comments{get;set;}
    }
}