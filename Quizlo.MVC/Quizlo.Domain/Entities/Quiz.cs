using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quizlo.Domain.Entities
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; } = default!;

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
