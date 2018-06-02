var app = new Vue({
    el: "#index-page",
    data: {
        appName: "Quiz Game",
        error: "",
        quiz: [],
        questions: [],
        answers: []
    },
    methods: {
        nextQuiz: function (next) {
            this.quiz++;
        },
        prevQuiz: function (prev) {
            this.quiz--;
        }  
    },
    mounted: function () {
        //CALL API
        axios.get("/api/QuizGame")
            .then(function (response) {
                this.quiz = response.data[0]
                this.questions = response.data[0].questions
                this.answers = response.data[0].questions[0].answers
            }.bind(this))
            .catch(function () {
                this.error = "Could not load Quizzes" 
            }.bind(this));
    }
});

/*
 *  Start 
 *  var quizzes = [];
 *  var currentQuizId = 0;
 *  var currentQuestionId = 0;
 *  ?? var currentAsnwerId = 0; ??
 *  []
 *  Quiz
 *      Questions []
 *          Question
 *              Content
 *              Answer []
 *                  Content
 *                  isCorrect
 * Select Quiz:
 * Next Question Button
 *  -> Get currentQuestion from currentQuiz
 *      innerHTML = Question.text
 *          for ( var answer in questions )
 * 
 * 
*/