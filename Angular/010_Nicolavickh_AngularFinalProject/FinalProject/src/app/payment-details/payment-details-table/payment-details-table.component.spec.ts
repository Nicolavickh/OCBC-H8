import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentDetailsTableComponent } from './payment-details-table.component';

describe('PaymentDetailsTableComponent', () => {
  let component: PaymentDetailsTableComponent;
  let fixture: ComponentFixture<PaymentDetailsTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaymentDetailsTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaymentDetailsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
