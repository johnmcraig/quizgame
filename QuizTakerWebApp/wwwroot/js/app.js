const app = new Vue({
    el: "#app",
    data: {
        quiz: [],
        question: 0,
    },
    methods: {
        nextQuiz: function () {
            this.question++
        },
        prevQuiz: function () {
            this.question--
        }  
    },
    mounted: function () {
        axios.get("/api/QuizGame")
            .then(function (response) {
                this.quiz = response.data
            }.bind(this))
            .catch(function () {
                this.error = "Could not load Quizzes" 
            }.bind(this));
    }
});