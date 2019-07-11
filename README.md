# Quiz Game (Formally QuizTaker)
> A web application using SQL, ASP.NET Core 2.0, Enitity Framework Core, and Vue.js as a Quiz Game.

## Function
This application implements full CRUD functionality on making quizzes, questions, and their answers. These are generated as data objects, which are saved to a database. A single page uses the Vue.js framework to consume the JSON data and displays it as a grade-able quiz game.

## Guide
Create a quiz and give it a title and author. The date should automatically populate. Then create a question for that quiz by matching its `id` (This may seem to be a ridget implementation and may produce issues that will probably be fixed in the future). Answers are aslo created the same way by matching them to the question `id` and checking them off if they are the correct answer, otherwise the default boolean is set to `false` when initialized. 

## Tools Used
The following tools were used to created the application:
- ASP.NET Core 2.0.3
- SQL Server
- Entity Framework Core
- HTML5, CSS3, JavaScript
- Vue.js 2.0

## Usage
This was built to demo a Quiz application project for CCALearn (Code Career Academy), a bootcamp in Lawrenceville Georgia. 
