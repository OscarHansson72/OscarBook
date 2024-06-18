using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facebook_2._0.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                if (DateOfBirth.Month > DateTime.Now.Month && DateOfBirth.Day > DateTime.Now.Day)
                    return DateTime.Now.Year - DateOfBirth.Year - 1;
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
    }
}