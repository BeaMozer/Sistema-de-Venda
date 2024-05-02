using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Product
    {

        public int ProductID { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required]
        public string? ProductName { get; set; }

        [Display(Name = "Descrição")]
        [Required]
        public string? Description { get; set; }

        [Display(Name = "Preço")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Quantidade em estoque")]
        [Required]  
        public int StockAmount { get; set; }

        [Display(Name = "Categoria")]
        [Required]
        public int Category { get; set; }
    }
}
