using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diragansEFCoreApiExam1.Models
{
    public class Product { 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public int CategoryID { get; set; }

        public double Price { get; set; }
        public int TotalStock { get; set; }
        public DateTime LastOrderDate { get; set; }

    }
}
