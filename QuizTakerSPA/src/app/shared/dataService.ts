import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';


@Injectable()
export class DataService {

  constructor(private http: HttpClient) { }

  public quizzes = [];

  loadQuizzes() {
    return this.http.get('/api/QuizGame').pipe(map((data: any[]) => {
      this.quizzes = data;
      return true;
    }));
  }
}
