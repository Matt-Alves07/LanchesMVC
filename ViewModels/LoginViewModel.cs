using System.ComponentModel.DataAnnotations;

namespace LanchesMVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo nome não pode ser vazio.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "O campo senha não pode ser vazio.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
