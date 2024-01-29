namespace Qizlo.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string[] Choices { get; set; }
        public int CorrectAnswer { get; set; }
    }
}