import { Injectable } from '@angular/core';
import { User } from "../User";
import { Observable, throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class StaffService {
  endpoint = 'http://localhost:4000/users'
  staffs: User[] = [];

  constructor(private http: HttpClient) { }

  addStaff(user: User){
    let api = `${this.endpoint}`;
    return (this.http.post(api, user).pipe(catchError(this.handleError)));
  }

  updateStaff(user: User, id: number){
    let api = `${this.endpoint}/${id}`;
    return (this.http.put(api, user).pipe(catchError(this.handleError)));
  }

  getStaffs (): Observable<any> {
    const api = `${this.endpoint}`

    return this.http.get(api)
    .pipe( catchError(this.handleError) )
  }

  deleteStaff(id: number){
    let api = `${this.endpoint}/${id}`;
    return (this.http.delete(api).pipe(catchError(this.handleError)))
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
