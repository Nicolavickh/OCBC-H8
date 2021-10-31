import { Component } from '@angular/core';
import { Country } from "./models/Country";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CountryInformationSystem';
  menu: number = 1;
  countryId: number = 0;
  countryDetail:Country = {id: 0, name:'', capital:'', area:0, population: 0, gdp: 0, currency:''};
  countries: Country[] = [
    {
      id: 1,
      name: 'United States',
      capital: 'Washington D.C.',
      area: 9833520,
      population: 331449281,
      gdp: 69375,
      currency: 'United States Dollar'
    },
    {
      id: 2,
      name: 'China',
      capital: 'Beijing',
      area: 9596961,
      population: 1411778724,
      gdp: 18931,
      currency: 'Chinese Yuan'
    },
    {
      id: 3,
      name: 'Japan',
      capital: 'Tokyo',
      area: 377975,
      population: 125360000,
      gdp: 44585,
      currency: 'Japanese Yen'
    },
    {
      id: 4,
      name: 'Russia',
      capital: 'Moscow',
      area: 17098246,
      population: 146171015,
      gdp: 29485,
      currency: 'Russian Ruble'
    },
    {
      id: 5,
      name: 'Canada',
      capital: 'Ottawa',
      area: 9984670,
      population: 38246108,
      gdp: 53089,
      currency: 'Canndaian Dollar'
    },
  ];
  ;

  openCountryDetail(id: number){
    this.menu = 3;
    this.countryId = id;
    let temp = this.countries.find(x => x.id == this.countryId)
    this.countryDetail.id = temp?.id as number;
    this.countryDetail.area = temp?.area as number;
    this.countryDetail.capital = temp?.capital as string;
    this.countryDetail.currency = temp?.currency as string;
    this.countryDetail.gdp = temp?.gdp as number;
    this.countryDetail.population = temp?.population as number;
    this.countryDetail.name = temp?.name as string;
  }
}