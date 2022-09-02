using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Intern
    {
        [Key]
        public int InternId { get; set; }
        public string InternName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string DesignationName { get; set; }
        public string DesignationRole { get; set; }
        public string Qualification { get; set; }
        public string Company_Hours { get; set; }
        public string Intern_hours {get;set;}
    }
}
