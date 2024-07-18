using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Model.Models
{
    public class LoginAccess
    {
        public int Id { get; set; }

        public string? UserType { get; set; }
        [ForeignKey("Id")]
        public User? User { get; set; }
    }
}
