using System;
using System.Collections.Generic;

namespace MySchool.Shared.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public string Text { get; set; } = string.Empty;
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public int Order { get; set; }
        public QuestionType Type { get; set; } = QuestionType.MultipleChoice;
        public int Points { get; set; } = 1;
    }

    public enum QuestionType
    {
        MultipleChoice,
        TrueFalse,
        Matching
    }

    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }
        public int Order { get; set; }
    }

    public class StudentProgress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContentId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public string Answers { get; set; } = string.Empty; // JSON data of student answers
        public string Feedback { get; set; } = string.Empty; // Teacher feedback
    }
}
