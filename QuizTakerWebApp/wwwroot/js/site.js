var answersContainer = document.getElementById("answers-container"),
    questionContent = document.getElementById("question-content"),
    answerResultContainer = document.getElementById("answer-result-container"),
    nextBtn = document.getElementById("next-button"),
    previousBtn = document.getElementById("previous-button");


var quizGame = {
    questions: {},
    current: 0
};

// Get questions from API on page load
$(document).ready(function () {

    var quizId = document.getElementById("quizGameId").innerText;

    var path = "/api/QuizGame" + quizId;

    $.getJSON(path, function (data) {
        quizGame.questions.questions = data;
        renderQuestion();
    });

});

// Render out question and answers
function renderQuestion() {

    questionContent.innerText = quizGame.questions.questions.questions[quizGame.current].questions;

    var count = 0;

    for (var answer in quizGame.questions.questions[quizGame.current].answers) {


        var answerLi = document.createElement("li"),
            answerPosition = document.createElement("span");


        answerPosition.innerText = count++;
        answerPosition.classList.add("hidden");
        answerLi.classList.add("list-group-item");
        answerLi.classList.add("answer-item");
        answerLi.innerText = quizGame.questions.questions[quizGame.current].answers[answer].content;

        answerLi.appendChild(answerPosition);
        answersContainer.appendChild(answerLi);
    }
}

// Clear elements on click
function clearElements() {
    answersContainer.innerHTML = "";
    questionContent.innerText = "";
    answerResultContainer.innerText = "";
}

// On answer click events
$(document).on('click', ".answer-item", function (event) {

    var result = quizGame.questions.questions.questions[quizGame.current].answers[event.currentTarget.getElementsByTagName("span")[0].innerText].isCorrect;

    if (result) {
        answerResultContainer.classList.remove("wrong");
        answerResultContainer.classList.add("correct");
    } else {
        answerResultContainer.classList.remove("correct");
        answerResultContainer.classList.add("wrong");
    }

    answerResultContainer.innerText = result.toString().toUpperCase();

});

// Next button events 
nextBtn.addEventListener("click", function () {
    if (quizGame.current < quizGame.questions.length - 1) {
        quizGame.current++;
    }
    clearElements();
    renderQuestion();
});

// Previous button events
previousBtn.addEventListener("click", function () {
    if (quizGame.current > 0) {
        quizGame.current--;
    }
    clearElements();
    renderQuestion();
});