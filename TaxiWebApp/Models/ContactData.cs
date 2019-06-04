using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxiWebApp.Models
{
    public class ContactData
    {
        [Required(ErrorMessage ="Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Display(Name ="Contact No")]
        public string ContactNo { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter Message")]
        [StringLength(200,ErrorMessage ="Message can not have more than 200 character")]
        public string Message { get; set; }
    }
}