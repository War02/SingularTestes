using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public String Senha { get; set; }
    }
}
