using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Dodano dla walidacji

namespace Blogownia.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required] // Oznacza, że tytuł posta jest wymagany
        public string Title { get; set; } = string.Empty; // Inicjalizacja domyślna, aby uniknąć ostrzeżeń CS8618

        [Required] // Oznacza, że treść posta jest wymagana
        public string Content { get; set; } = string.Empty; // Inicjalizacja domyślna

        public DateTime DatePosted { get; set; } = DateTime.Now; // Ustawienie domyślnej daty na obecną

        // Relacja z User
        public int UserId { get; set; }
        public User? User { get; set; } // Dopuść wartość null

        // Relacja z Comment
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}

