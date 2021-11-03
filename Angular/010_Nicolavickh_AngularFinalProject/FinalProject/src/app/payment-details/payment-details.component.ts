import { Component, OnInit } from '@angular/core';
import { PaymentDetail } from '../PaymentDetail';
import { PaymentDetailService } from '../services/payment-detail.service';

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styleUrls: ['./payment-details.component.css']
})
export class PaymentDetailsComponent implements OnInit {
  selectedDetail: PaymentDetail = {} as PaymentDetail;
  details: PaymentDetail[] = [];

  constructor(public service:PaymentDetailService) {}

  getDetail(detail: PaymentDetail){
    this.selectedDetail = detail;
  }

  getDetails(details: PaymentDetail[]){
    this.details = details;
  }

  ngOnInit(): void {
  }
}
