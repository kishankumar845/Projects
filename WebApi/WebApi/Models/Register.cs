using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Register
    {
        [Key]
        [Column(TypeName="integer(12)")]
        public int AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string LoginPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string ConfirmLOginPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")] 
        public string TransactionPassword { get; set; }

        [Column(TypeName = "integer(30)")]
        public string ConfirmTransactionPassword { get; set; }

        [Column(TypeName = "integer(6)")]
        public int EnterOtp { get; set; }
    }
}
