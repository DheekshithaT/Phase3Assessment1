using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace EMSFullStack.Models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public string? EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string? Email { get; set; }
        [ForeignKey("DeptCode")]
        public int DeptCode { get; set; }
    }
}