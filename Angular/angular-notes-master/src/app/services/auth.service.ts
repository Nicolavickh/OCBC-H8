import { Injectable } from '@angular/core';
import { User } from "../models/User";
import { Observable, throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  endpoint: string = 'http://localhost:3000';

  constructor(private http: HttpClient) { }

  signUp(user: User): Observable<any>{
    let api = `${this.endpoint}/register`;
    return (this.http.post(api, user).pipe(catchError(this.handleError)));
  }

  signIn(user: User): Observable<any>{
    let api = `${this.endpoint}/login`;
    return (this.http.post(api, user).pipe(catchError(this.handleError)))
  }

  handleError(error: HttpErrorResponse){
    let msg = '';
    if(error.error instanceof ErrorEvent){
      msg = error.error.message;
    }else{
      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return (throwError(msg));
  }
}
