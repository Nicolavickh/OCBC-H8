import { Component, Input, OnInit } from '@angular/core';
import { Country } from '../models/Country';

@Component({
  selector: 'app-country-detail',
  templateUrl: './country-detail.component.html',
  styleUrls: ['./country-detail.component.css']
})
export class CountryDetailComponent implements OnInit {
  @Input() countryDetail: Country = {} as Country;

  constructor() { }

  ngOnInit(): void {
  }

}
