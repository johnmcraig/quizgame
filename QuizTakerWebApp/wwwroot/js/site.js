$(document).ready(function () {
    var uploadedQuiz = document.getElementById("uploadedQuiz"),
        nextQuestionBtn = document.getElementById("nextQuestionBtn"),
        clickCount = 0,
        currentQuestionId;

    var countClicks = function () {
        clickCount++;
    };

    var clickAction = function clickAction(action) {
        var answerSubmission = {
            questionId: currentQuestionId,
            answerId: action.currentTarget.id
        };
        countClicks();

        $.getJSON("/api/QuizGame/", answerSubmission)
            .done(function (data) {

                var correct = data.isCorrect;
                var incorrect = !data.isCorrect;
                var chances = 3;

                if (correct) {
                    document.getElementById("answer-result").innerHTML =
                        '<div class="panel panel-primary">' +
                        '<div class="panel-heading">' +
                        'Correct' +
                        '</div>' +
                        '<div class="panel-body right-answer">' +
                        'Yeah! You got it.' +
                        '</div>' +
                        '</div>';
                }
                else if (incorrect && clickCount < 3) {
                    document.getElementById("answer-result").innerHTML =
                        '<div class="panel panel-danger">' +
                        '<div class="panel-heading">' +
                        'Incorrect' +
                        '</div>' +
                        '<div class="panel-body wrong-answer">' +
                        'You were incorrect ' +
                        clickCount + ' time(s), ' +
                        'You have ' + (chances - clickCount) +
                        ' chance(s) left.' +
                        '</div>' +
                        '</div>';
                }
                else {
                    var answerBoxes = document.getElementsByClassName('answerBox');
                    for (var i = 0; i < answerBoxes.length; i++) {
                        answerBoxes[i].removeEventListener('click', clickAction);
                    }

                    document.getElementById("answer-result").innerHTML =
                        '<div class="panel panel-danger gameOver">' +
                        '<div class="panel-heading">' +
                        'Incorrect' +
                        '</div>' +
                        '<div class="panel-body wrong-answer">' +
                        'Sorry, you got 3 incorrect. Go to the next Question' +
                        '</div>' +
                        '</div>';
                }
            })
            .fail(function (jqxhr, textStatus, error) {
                alert("Could not load Quiz");
            });
    };

    $.getJSON("/api/QuizGame", function (data) {
        clickCount = 0;

        var questionDiv = document.createElement('div');
        document.getElementById('answer-result').innerHTML = '';

        uploadedQuiz.innerHTML = "";
        currentQuestionId = data.questionId;

        uploadedQuiz.appendChild(questionDiv);
        questionDiv.innerText = data.Content;

        data.answers.forEach(function (val) {
            var answerDiv = document.createElement('div');

            answerDiv.innerText = val.Content;
            answerDiv.id = val.answerId;
            answerDiv.addEventListener('click', clickAction);
            uploadedQuiz.appendChild(answerDiv);

            answerDiv.className = 'answerBox';
            answerDiv.addEventListener("mouseenter", function (event) {
                event.target.style.color = "green";
            });
            answerDiv.addEventListener("mouseout", function (event) {
                event.target.style.color = "black";
            });


            uploadedQuiz.className = 'questionText';
        });
    });

    nextQuestionBtn.addEventListener('click', function () {
        $.getJSON("/api/QuizGame", function (data) {
            clickCount = 0;


            var questionDiv = document.createElement('div');
            document.getElementById('answer-result').innerHTML = '';

            uploadedQuiz.innerHTML = "";
            currentQuestionId = data.questionId;

            uploadedQuiz.appendChild(questionDiv);
            questionDiv.innerText = data.Content;

            data.answers.forEach(function (val) {
                var answerDiv = document.createElement('div');

                answerDiv.innerText = val.Content;
                answerDiv.id = val.answerId;
                answerDiv.addEventListener('click', clickAction);
                uploadedQuiz.appendChild(answerDiv);

                answerDiv.className = 'answerBox';
                answerDiv.addEventListener("mouseenter", function (event) {
                    event.target.style.color = "green";
                });
                answerDiv.addEventListener("mouseout", function (event) {
                    event.target.style.color = "black";
                });


                uploadedQuiz.className = 'questionText';
            });
        });
    });
});