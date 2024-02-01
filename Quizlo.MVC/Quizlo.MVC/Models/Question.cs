namespace Quizlo.MVC.Models
{
    public class Question
    {
        public int Id {get; set;}
        public string Pytanie { get; set; }
        public List<string> Opcje {get; set;}
        public string Odpowiedz {get; set;}
    }
}
