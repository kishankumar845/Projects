using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class EuDetails
    {
        [Column(TypeName = "nvarchar(5)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Fname { get; set; }
        [Column(TypeName = "integer(10)")]
        public long Mobileno { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Emailid { get; set; }
        [Column(TypeName = "integer(30)")]
        public long Aadharno { get; set; }

        [Column(TypeName = "Date(10)")]
        public DateOnly Dob { get; set; }

    }
    public class RAddress
    {
        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Landmark { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }

        [Column(TypeName = "integer(6)")]
        public int Pincode { get; set; }

    }

    public class PAddress
    {

        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Landmark { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }

        [Column(TypeName = "integer(6)")]
        public int Pincode { get; set; }
    }

    public class OccupationDetails
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Occupationtype { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string SourceOfIncome { get; set; }

        [Column(TypeName = "decimal(x,y)")]
        public double GrossAnnualIncome { get; set; }
    }

    public class DebitCard
    {
        [Column(TypeName = "boolean")]
        public Boolean NeedACard { get; set; }
        [Column(TypeName = "boolean")]
        public Boolean IAgree = true;
    }

}
