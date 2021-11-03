import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from "rxjs/operators";
import { PaymentDetail } from '../PaymentDetail';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  endpoint = 'https://localhost:44329/api/PaymentDetails';
  tempDetail: PaymentDetail = {} as PaymentDetail;

  constructor(private http: HttpClient) { }

  addDetail(detail: PaymentDetail){
    let api = `${this.endpoint}`;
    detail.paymentDetailId = 0;
    return this.http.post(api, detail).pipe(catchError(this.handleError));
  }

  updateDetail(detail: PaymentDetail){
    let api = `${this.endpoint}/${detail.paymentDetailId}`;
    return (this.http.put(api, detail).pipe(catchError(this.handleError)));
  }

  getDetails (): Observable<any> {
    const api = `${this.endpoint}`
    return this.http.get(api).pipe( catchError(this.handleError) )
  }

  deleteDetail(id: number){
    let api = `${this.endpoint}/${id}`;
    return (this.http.delete(api).pipe(catchError(this.handleError)))
  }

  handleError(error: HttpErrorResponse){
    console.log(error);
    let msg = '';
    if(error.error instanceof ErrorEvent){
      msg = error.error.message;
    }else{
      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return (throwError(msg));
  }
}
