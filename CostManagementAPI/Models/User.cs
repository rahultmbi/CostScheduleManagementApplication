using System;

namespace CostManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }     
        public string Username { get; set; }        
        public byte[] PasswordHash { get; set; }    
        public byte[] PasswordSalt { get; set; }    
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActive { get; set; }
        public string Country { get; set; }
    }
}