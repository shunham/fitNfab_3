using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class Owner
    {
        [Key]

        public int Oid { get; set; }


        [DisplayName("Email-Id")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        [Required(ErrorMessage = "Please enter Your Name"), MaxLength(20)]
        [DisplayName("Owner Name")]
        public string Name { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*", ErrorMessage = "Only 10 digits Numbers are allowed.")]
        [Required(ErrorMessage = "Enter valid phone number")]
        public long Phone { get; set; }
      

        [RegularExpression("^[a-zA-Z0-9@$]*", ErrorMessage = "Only Alphabets, Numbers and @, $ are allowed.")]
        [Required(ErrorMessage = "Password length should be minimum 4 and maximum 8"), MaxLength(8), MinLength(4)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Required(ErrorMessage = "password not match")]
        public string ConfirmPassword { get; set; }



        [StringLength(300, ErrorMessage = "This field is required")]
        public string Description { get; set; }

        [StringLength(100,ErrorMessage = "should be less than 100")]
        public string Address { get; set; }

        
        public double Latitude { get; set; }

        public double Longitude { get; set; }

    }
}