using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentSYS.Models
{
    public class PaymentDetail
    {
      //  https://www.codaffection.com/asp-net-core-article/angular-crud-with-asp-net-core-web-api/#llc_comments
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
