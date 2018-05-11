import { Http } from '@angular/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quiz-game',
  templateUrl: './quiz-game.component.html',
  styleUrls: ['./quiz-game.component.css']
})
export class QuizGameComponent implements OnInit {
  quizzes: any;

  constructor(private http: Http) { }

  ngOnInit() {
    this.getQuizzes();
  }

  getQuizzes() {
    this.http.get('https://localhost:44305/api/QuizGame').subscribe(response => {
    this.quizzes = response.json();
    });
  }
}
