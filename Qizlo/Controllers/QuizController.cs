using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Qizlo.Models;

namespace Qizlo.Controllers
{
    public class QuizController : Controller
    {
        private readonly List<Question> questions = new List<Question>
        {
            // Przykładowe pytania
            new Question { Id = 1, QuestionText = "Pytanie 1", Choices = new string[] { "Odp A", "Odp B", "Odp C" }, CorrectAnswer = 0 },
            // Dodaj więcej pytań tutaj
        };

        public IActionResult Index()
        {
            return View(questions);
        }

        [HttpPost]
        public IActionResult SubmitQuiz(List<int> answers)
        {
            int score = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (answers[i] == questions[i].CorrectAnswer)
                {
                    score++;
                }
            }

            // Możesz przekazać wynik do innego widoku lub zrobić coś innego z tym wynikiem
            return View("Result", score);
        }
    }
}
