$(document).ready(function () {
    $.getJSON("/api/QuizGame")
    function Data(data) {
        console.log(data)
    } 
});