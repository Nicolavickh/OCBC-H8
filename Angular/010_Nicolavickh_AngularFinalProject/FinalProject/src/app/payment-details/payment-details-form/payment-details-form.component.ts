import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { PaymentDetail } from '../../PaymentDetail';
import { PaymentDetailService } from '../../services/payment-detail.service';

@Component({
  selector: 'payment-details-form',
  templateUrl: './payment-details-form.component.html',
  styleUrls: ['./payment-details-form.component.css']
})
export class PaymentDetailsFormComponent implements OnInit {
  @Input() selectedDetail: PaymentDetail = {} as PaymentDetail;
  @Output() emitter: EventEmitter<any> = new EventEmitter();
  details: PaymentDetail[] = [];
  pipe = new DatePipe('en-US');

  constructor(public service:PaymentDetailService) { }

  form = {
    inputData: new FormGroup({
      paymentDetailId: new FormControl(''),
      cardOwnerName: new FormControl('', [Validators.required]),
      cardNumber: new FormControl('', [Validators.required, Validators.minLength(16), Validators.maxLength(16)]),
      expirationDate: new FormControl('', [Validators.required]),
      securityCode: new FormControl('', [Validators.required])
    })
  };

  get cardOwnerName(){
    return (this.form.inputData.get('cardOwnerName'));
  }
  get cardNumber(){
    return (this.form.inputData.get('cardNumber'));
  }
  get expirationDate(){
    return (this.form.inputData.get('expirationDate'));
  }
  get securityCode(){
    return (this.form.inputData.get('securityCode'));
  }

  getDetails(){
    this.service.getDetails().subscribe(dataSource =>{
      this.details = dataSource as PaymentDetail[];
      this.emitter.emit(dataSource);
    });
  };

  manageDetail(){
    if((this.form.inputData.get('paymentDetailId')?.value == '')){
      this.addDetail();
    }else{
      this.updateDetail()
    }
  }

  addDetail(){
    this.service.addDetail(this.form.inputData.value).subscribe((res) => {
      if(res){
        this.form.inputData.reset();
        this.getDetails();
      }
    });
  }

  updateDetail(){
    this.service.updateDetail(this.form.inputData.value).subscribe((res) => {
      if(res){
        this.form.inputData.reset();
        this.getDetails();
      }
    });
  }

  ngOnInit(): void {
  }

  ngDoCheck(){
    if(Object.keys(this.selectedDetail).length > 0){
      this.form.inputData.controls['paymentDetailId'].setValue(this.selectedDetail.paymentDetailId)
      this.form.inputData.controls['cardOwnerName'].setValue(this.selectedDetail.cardOwnerName)
      this.form.inputData.controls['cardNumber'].setValue(this.selectedDetail.cardNumber)
      this.form.inputData.controls['expirationDate'].setValue(this.pipe.transform(this.selectedDetail.expirationDate, 'yyyy-MM-dd'))
      this.form.inputData.controls['securityCode'].setValue(this.selectedDetail.securityCode)
      this.resetForm();
    }
  }

  resetForm(){
    this.selectedDetail = {} as PaymentDetail;
  }
}
