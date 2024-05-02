using System.ComponentModel.DataAnnotations;

namespace Sistemas_de_Vendas.Models
{
    public class AccessLevel
    {

        public int AccessLevelID { get; set; }

        [Required]
        public string? Level { get; set; }
    }
}
