using System.ComponentModel.DataAnnotations;

namespace NetCoreForum.ViewModels.UserViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email", Prompt = "example@mail.com")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Kullanıcı adı", Prompt = "kullaniciadi")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kullanıcı adı", Prompt = "parola")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kullanıcı adı", Prompt = "parola tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Parola eşleşmiyor")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
