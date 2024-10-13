using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.ViewModels.UserViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "{0} gereklidir")]
        [Display(Name = "E-posta", Prompt = "E-posta")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} gereklidir")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola", Prompt = "Parola")]
        public string Password { get; set; } = string.Empty;


        [Display(Name = "Beni hatırla", Prompt = "Beni hatırla")]
        public bool RememberMe { get; set; } = true;

    }
}
