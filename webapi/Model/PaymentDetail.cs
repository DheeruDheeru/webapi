using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Model
{
    public class PaymentDetail
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwner { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string ExpiryDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string CVV { get; set; }

    }
}
