// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("mathQuizForm").addEventListener("submit", function(event) {
    let totalQuestions = document.querySelectorAll('.question').length;
    let answeredQuestions = 0;
    for (let i = 0; i < totalQuestions; i++) {
        if (document.querySelector(`input[name='answer${i}']:checked`)) {
            answeredQuestions++;
        }
    }
    if (answeredQuestions !== totalQuestions) {
        alert("Proszę wybrać odpowiedź na każde pytanie.");
        event.preventDefault();
    }
});
