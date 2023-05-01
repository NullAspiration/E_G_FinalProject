using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_G_FinalProject.Models.Entities
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string AccountName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        public string Amount { get; set; }
    }
}
