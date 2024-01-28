using System;
using System.ComponentModel.DataAnnotations;

namespace Blogownia.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required] // Oznacza, że treść komentarza jest wymagana
        public string Content { get; set; } = string.Empty; // Inicjalizacja domyślna, aby uniknąć ostrzeżeń CS8618

        public DateTime DatePosted { get; set; } = DateTime.Now; // Ustawienie domyślnej daty na obecną

        // Relacja z User i Post
        public int UserId { get; set; }
        public User User { get; set; } // Poprawiono typ na User
        public int PostId { get; set; }
        public Post Post { get; set; } // Poprawiono typ na Post
    }
}
