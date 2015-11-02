using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Index ID")]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Middlename")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Mobile No")]
        //[DataType(DataType.PhoneNumber)]
        //[DisplayFormat(DataFormatString = "{0:(###)-###-####}")]
        public long MobileNumber { get; set; }

        [Display(Name = "Tel No")]
        //[DataType(DataType.PhoneNumber)]
        //[DisplayFormat(DataFormatString = "{0:(###)-###-####}")]
        public long Telephone { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
        public decimal YearlyIncome { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDay.Year;
                if (BirthDay > today.AddYears(-age)) age--;
                return age;
            }
        }

        public DateTime DateCreated { get; set; }

    }
}
