$(document).ready(function () {

    var ulQuizzes = $('#ulQuizzes');

    $('#get-btn').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/QuizGame',
            dataType: 'json',
            success: function (data) {

                ulQuizzes.empty();
                $.each(data, function (index, val) {
                    var quizId = val.quizId;
                    var quizTitle = val.title;
                    var quizQuestion = val.questions;
                    var quizAnswer = val.answers;
                    ulQuizzes.append('<li>' + quizId + ' ' + quizTitle + ' ' + quizQuestion + ' ' + quizAnswer + '</li>');
                });
            }
        });
    });

    $('#clear-btn').click(function () {
        ulQuizzes.empty();
    });

});