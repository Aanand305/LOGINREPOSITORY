using System.ComponentModel.DataAnnotations;

namespace LOGINREPOSITORY.ViewModel
{
    public class SignInModel
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
