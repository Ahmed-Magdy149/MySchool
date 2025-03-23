using System;
using System.Collections.Generic;

namespace MySchool.Shared.Models
{
    public enum UserRole
    {
        Student,
        Teacher,
        Admin
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
