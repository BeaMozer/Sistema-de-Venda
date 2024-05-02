using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Client
    {

        
        public int ClientID { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string? ClientName { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string? PhoneNumber { get; set; }

        [StringLength(11, ErrorMessage = "CPF Inválido", MinimumLength = 11)]
        [Required]
        public string? CPF { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime RegisterDate { get; set; }

        [Required]
        public string? CEP { get; set; }

        [Display(Name = "Endereço")]
        [Required]
        public string? Address { get; set; }

        [Display(Name = "Número")]
        [Required]
        public int Number { get; set; }

        [Display(Name = "Complemento")]
        public string? AdditionalInformation { get; set; }

        [Display(Name = "Cidade")]
        [Required]
        public string? City { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "UF Inválida", MinimumLength = 2)]
        public string? UF { get; set; }

        [Display(Name = "Dados de Acesso")]
        [Required]
        public int RegisterId { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required]
        public int AccessLevel { get; set; }
    }
}
