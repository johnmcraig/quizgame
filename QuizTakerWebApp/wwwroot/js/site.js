//$(document).ready(function () {

//    var ulQuizzes = $('#ulQuizzes');
//    var ulQuestions = $('#ulQuestions');
//    let uri = 'api/QuizGame';

//    $.getJSON(uri, function (data) {
//        $.each(data.quizId, function (i, title) {
//            console.log(title);
//        });
//    });

//    $('#get-btn').click(function () {
//        $.ajax({
//            type: 'GET',
//            url: 'api/QuizGame',
//            dataType: 'json',
//            success: function (data) {

//                ulQuizzes.empty();

//                $.each(data, function (index, val) {
//                    var quizId = val.quizId;
//                    var quizTitle = val.title;
//                    var authName = val.author;
//                    var pubDate = val.publishDate;

//                    var questions = val.questions;

                    
//                    var answerId = val.answerId;
//                    var quizQuestion = val.questions;
//                    var quizAnswer = val.answers;

//                    ulQuizzes.append('<li>' + quizId + ' ' + quizTitle + ' ' + authName + ' ' + pubDate + '</li>');

//                    $.each(questions, function (index, val) {
//                        ulQuestions.append('<li>' + questions + ' ' + '</li>');
//                    });


//                });
//            }
//        });
//    });

//    $('#clear-btn').click(function () {
//        ulQuizzes.empty();
//        questionLi.empty();
//    });

//    $('#next-btn').click(function () {

//    });

//    $('#previous-btn').click(function () {

//    });

//});

/*
 *
 * Original jQuery that is no longer used but may be usefull later
 * 
 */

// Get questions from API on page load 
//$(document).ready(function () {
//    var quizId = document.getElementById("quizId").innerText;
//    var path = "/api/QuizGame/" + quizId;

//    $.getJSON(path, function (data) {
//        game.questions = data;
//        renderQuestion();
//    });
//});

//// Game data object 
//var game = {
//    questions: {},
//    current: 0,
//}

//// Variables for elements
//var answersHolder = document.getElementById("answers-container"),
//    questionContent = document.getElementById("question-content"),
//    nextBtn = document.getElementById("next-btn"),
//    previousBtn = document.getElementById("previous-btn"),
//    answerResultHolder = document.getElementById("answer-result-container");


//// Render out question and answers
//function renderQuestion() {
//    questionContent.innerText = game.questions[game.current].questions;
//    var count = 0;
//    for (var answer in game.questions[game.current].answers) {

//        var answerLi = document.createElement("li"),
//            answerPosition = document.createElement("span");

//        answerPosition.innerText = count++;
//        answerPosition.classList.add("hidden");
//        answerLi.classList.add("list-group-item");
//        answerLi.classList.add("answer-item");
//        answerLi.innerText = game.questions[game.current].answers[answer].content;

//        answerLi.appendChild(answerPosition);
//        answersHolder.appendChild(answerLi);
//    };
//};

//// Next button events 
//nextBtn.addEventListener("click", function () {
//    if (game.current < game.questions.length - 1) {
//        game.current++;
//    }
//    clearElements();
//    renderQuestion();
//})

//// Previous button events
//previousBtn.addEventListener("click", function () {
//    if (game.current > 0) {
//        game.current--;
//    }
//    clearElements();
//    renderQuestion();
//})

//// Clear elements function
//function clearElements() {
//    answersHolder.innerHTML = "";
//    questionContent.innerText = "";
//    answerResultHolder.innerText = "";
//}

//// On answer click events
//$(document).on('click', ".answer-item", function (event) {
//    var result = game.questions[game.current].Answers[event.currentTarget.getElementsByTagName("span")[0].innerText].isCorrect;

//    if (result) {
//        answerResultHolder.classList.remove("wrong");
//        answerResultHolder.classList.add("correct");
//    } else {
//        answerResultHolder.classList.remove("correct");
//        answerResultHolder.classList.add("wrong");
//    }

//    answerResultHolder.innerText = result.toString().toUpperCase();

//});