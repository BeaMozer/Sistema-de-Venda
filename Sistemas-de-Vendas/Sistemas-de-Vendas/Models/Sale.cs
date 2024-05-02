using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class Sale
    {

        public int SaleID { get; set; }

        [Display(Name = "Data da Venda")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }

        [Required]
        [Display(Name = "ID Cliente")]
        public int Client { get; set; }

        [Required]
        [Display(Name = "ID Produto")]
        public int Product { get; set; }

        [Required]
        [Display(Name = "ID Funcionário")]
        public int Employee { get; set; }
    }
}
