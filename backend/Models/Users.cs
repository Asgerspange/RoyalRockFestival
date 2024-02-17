using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string? email { get; set; }
        public bool isAdmin { get; set; }
    }
}
