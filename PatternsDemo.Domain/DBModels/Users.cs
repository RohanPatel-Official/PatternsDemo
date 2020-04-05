using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsDemo.Domain.DBModels
{
    public class Users
    {
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
