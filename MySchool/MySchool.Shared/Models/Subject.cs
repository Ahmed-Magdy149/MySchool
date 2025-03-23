using System;
using System.Collections.Generic;

namespace MySchool.Shared.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<Module> Modules { get; set; } = new List<Module>();
        public bool IsActive { get; set; } = true;
    }

    public class Module
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Order { get; set; }
        public ModuleType Type { get; set; }
        public List<Content> Contents { get; set; } = new List<Content>();
    }

    public enum ModuleType
    {
        Vocabulary,
        Grammar,
        Quiz,
        Exam
    }

    public class Content
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ContentData { get; set; } = string.Empty; // JSON data for different content types
        public int Order { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
