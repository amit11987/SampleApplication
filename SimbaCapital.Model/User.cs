using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web.Mvc;


namespace SimbaCapital.Model
{
    [Table("Person")]
    public class Person : AuditableEntity<long>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name="Company/Organisation")]
        public string Company{ get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Position/Role")]
        public string Position { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Town/City")]
        public string Town { get; set; }

        [Required]
        [MaxLength(10)]
        public string Postcode { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        public string Fax { get; set; }

        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Place of Incorporation")]
        public string PlaceOfIncorporation { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Principal Business Activity")]
        public string PrincipalBusinessActivity { get; set; }

        [MaxLength(100)]
        public string Regulator { get; set; }

        [MaxLength(100)]
        [Display(Name = "Regulator Reference")]
        public string RegulatorReference { get; set; }

        
        [Required]
        [MaxLength(100)]
        [Display(Name = "Choose a Password")]
        public string Password { get; set; }


        [Required]
        [MaxLength(100)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
