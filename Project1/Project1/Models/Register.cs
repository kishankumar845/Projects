using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    public class Register
    {
        [Key]
        [Column(TypeName = "integer(12)")]
        [Required] //making not-null
        public int AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string LoginPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string ConfirmLoginPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string TransactionPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string ConfirmTransactionPassword { get; set; }

        [Column(TypeName = "integer(6)")]
        [Required]
        public int EnterOtp { get; set; }
    }
}
