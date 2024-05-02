using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Employee
    {

        public int EmployeeID { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string? EmployeeName { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "CPF")]
        [Required]
        [StringLength(11, ErrorMessage = "CPF Inválido", MinimumLength = 11)]
        public string? EmployeeCPF { get; set; }

        [Display(Name = "Cargo")]
        [Required]
        public string? Position { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required]
        public int AccessLevel { get; set; }

        [Display(Name = "Data de Início")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }


        [Display(Name = "Dados de Acesso")]
        [Required]
        public int Register { get; set; }

    }
}
