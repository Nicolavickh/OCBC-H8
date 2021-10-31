import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Country } from '../models/Country';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  @Input() countries: Country[] = [];
  @Output() emitter = new EventEmitter<number>();
  mostPopulatedCountries: Country[] = [];
  largestCountries: Country[] = [];
  constructor() { }

  ngOnInit(): void { 
    this.mostPopulatedCountries = [...this.countries].sort((a,b) => (a.population < b.population) ? 1 : ((b.population < a .population) ? -1 : 0));
    this.mostPopulatedCountries = [...this.mostPopulatedCountries].slice(0,3);
    this.largestCountries = [...this.countries].sort((a,b) => (a.area < b.area) ? 1 : ((b.area < a .area) ? -1 : 0));
    this.largestCountries = [...this.largestCountries.slice(0,3)]
  }

  sendToParent(id: number){
    this.emitter.emit(id);
  }

}
