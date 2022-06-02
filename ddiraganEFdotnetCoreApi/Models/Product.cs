using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ddiraganEFdotnetCoreApi.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductID { get; set; }
        public string? ProductName { get; set; }
        public int CategoryID { get; set; }

        public double Price { get; set; }
        public int TotalStock { get; set; }
        public DateTime LastOrderDate { get; set; }

    }
}
