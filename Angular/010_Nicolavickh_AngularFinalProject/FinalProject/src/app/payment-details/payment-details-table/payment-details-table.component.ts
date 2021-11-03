import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { PaymentDetail } from 'src/app/PaymentDetail';
import { PaymentDetailService } from 'src/app/services/payment-detail.service';

@Component({
  selector: 'payment-details-table',
  templateUrl: './payment-details-table.component.html',
  styleUrls: ['./payment-details-table.component.css']
})
export class PaymentDetailsTableComponent implements OnInit {
  @Output() emitter: EventEmitter<any> = new EventEmitter();
  @Input() details: PaymentDetail[] = [];
  selectedDetail: PaymentDetail = {} as PaymentDetail;
  closeResult = '';
  dtOptions: DataTables.Settings = {};

  constructor(public service:PaymentDetailService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5,
      processing: true
    };
    this.service.getDetails().subscribe((res: any) => {
      if(res) this.details = res
    })
  }

  getDetail(detail: PaymentDetail){
    this.emitter.emit(detail);
  }

  deleteDetails(id: number){
    this.service.deleteDetail(id).subscribe(() => {
      this.service.getDetails().subscribe((res: any) => {
        if(res) this.details = res
      })
    });
  }

  openConfirm(content: any, detail: PaymentDetail) {
    this.selectedDetail = detail;
    this.modalService.open(content, {size: 'lg', ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.deleteDetails(detail.paymentDetailId!)
      this.selectedDetail = {} as PaymentDetail;
    }, () => {});
  }
}