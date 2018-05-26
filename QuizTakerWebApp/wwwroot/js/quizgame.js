// Test JSON by returning objects into console output
$(document).ready(function () {
    $.getJSON("/api/QuizGame");
    function Data(data) {
        console.log(data);
    } 
});

// The actual path as an uri then call AJAX then bind the data to a list element
const uri = "/api/QuizGame/";
let quizzes = null;

$(document).ready(function () {
    $.getJSON(uri)
        .done(function (data) {
            $.each(data, function (key, quiz) {
                $('<li>', { text: formatQuiz(quiz) }).appendTo($('#quiz-title'));
            });
        });
});

// find quiz by id :: Url = api/QuizGame/id
function find() {
    var id = $('#quizId').val();
    $.getJSON(uri + '/' + id)
        .done(function (data) {
            $('#quiz-title').text(formatItem(data));
        })
        .fail(function (jqXHR, testStatus, err) {
            $('#quiz-title').text('Error' + err);
        });
}