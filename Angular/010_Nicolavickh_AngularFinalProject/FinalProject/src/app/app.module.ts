import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PaymentDetailsFormComponent } from './payment-details/payment-details-form/payment-details-form.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { PaymentDetailsTableComponent } from './payment-details/payment-details-table/payment-details-table.component';
import { DataTablesModule } from 'angular-datatables';

@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsFormComponent,
    PaymentDetailsComponent,
    PaymentDetailsTableComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpClientModule,
    DataTablesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
