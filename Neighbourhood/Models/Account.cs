using System.ComponentModel.DataAnnotations;

namespace Neighbourhood.Models
{
    public class Account
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [RegularExpression(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", 
        ErrorMessage = "Must contain from 8 - 20 letters or numbers")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",
        ErrorMessage = "Please enter correct email address")]
        public string user_Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }

    }

}