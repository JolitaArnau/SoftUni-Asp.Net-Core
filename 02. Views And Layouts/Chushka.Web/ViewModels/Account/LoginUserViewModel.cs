namespace Chushka.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "You must enter an username")]
        [StringLength(100, ErrorMessage = "Username length must between 6 and 100 characters", MinimumLength = 6)]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must enter a password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password length must between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}