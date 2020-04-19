using System.ComponentModel.DataAnnotations;

namespace PatternsDemo.Domain.DBModels
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
