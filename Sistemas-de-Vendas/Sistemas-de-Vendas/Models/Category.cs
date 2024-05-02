using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [Display(Name = "Nome da Categoria")]
        public string? CategoryName { get; set; }
    }
}
