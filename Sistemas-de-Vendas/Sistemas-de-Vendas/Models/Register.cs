using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Register
    {

        public int RegisterID { get; set; }

        [Display(Name = "Usuário")]
        [Required]
        public string? UserName { get; set; }

        [Display(Name = "Senha")]
        [Required]
        [StringLength(15, ErrorMessage = "A senha deve ter entre 6 a 15 caracteres",  MinimumLength = 6)]
        public string? Password { get; set; }
    }
}
