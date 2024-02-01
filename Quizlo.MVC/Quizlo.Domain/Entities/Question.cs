using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quizlo.Domain.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string? Text { get; set; } 

        [Required]
        public List<string> Options { get; set; } = new List<string>(); 

        [Required]
        public string? CorrectAnswer { get; set; } 

        public int QuizId { get; set; } 
        public Quiz? Quiz { get; set; } 
    }
}
