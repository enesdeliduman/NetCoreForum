using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.ViewModels.UserViewModels
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "{0} gereklidir")]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} gereklidir")]
        [Display(Name = "Kullanıcı adı", Prompt = "Kullanıcı adı")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} gereklidir")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola", Prompt = "Parola")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} gereklidir")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola tekrar", Prompt = "Parola tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Parola eşleşmiyor")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
