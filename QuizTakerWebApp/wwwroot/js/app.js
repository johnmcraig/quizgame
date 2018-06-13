const app = new Vue({
    el: "#app",
    data: {
        quiz: [],
        question: 0,
        clicked: false,
        answered: false,
        correct: null,
        count: 0
    },
    methods: {
        nextQuiz: function () {
            this.question++ //suggested to name qIdIndex to rep number of array
            this.answered = false
            this.correct = null
        },
        prevQuiz: function () {
            this.question--
            this.answered = false
            this.correct = null
        },
        answerEvent(isCorrect) {
            this.answered = true
            if (isCorrect === true) {
                this.correct = true
            } else {
                this.correct = false
            }
        }
    },
    mounted: function () {
        axios.get("/api/QuizGame")
            .then(function (response) {
                this.quiz = response.data
            }.bind(this))
            .catch(function (error) {
                this.error = "Could not load Quizzes"
            }.bind(this));
    }
});