using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Facebook_2._0.Models
{
    public class SignUpModel
    {
        [Display(Name = "First Name*")]
        [Required(ErrorMessage = "First Name is a required field")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name*")]
        [Required(ErrorMessage = "Last Name is a required field")]
        public string LastName { get; set; }

        [Display(Name = "Email*")]
        [Required(ErrorMessage = "Emmail is a required field")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number*")]
        [Required(ErrorMessage = "Phone Number is a required field")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date Of Birth*")]
        [Required(ErrorMessage = "Date Of Birth is a required field")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Password*")]
        [Required(ErrorMessage = "Password is a required field")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "You need to provide a password with at least 8 characters")]
        public string Password { get; set; }

        [Display(Name = "Re Enter Password*")]
        [Compare("Password", ErrorMessage = "the password doesnt match")]
        [DataType(DataType.Password)]
        public string ReEnterPassword { get; set; }
    }
}