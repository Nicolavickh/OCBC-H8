import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Country } from '../models/Country';

@Component({
  selector: 'app-all-countries',
  templateUrl: './all-countries.component.html',
  styleUrls: ['./all-countries.component.css']
})
export class AllCountriesComponent implements OnInit {
  @Input() countries: Country[] = [] as Country[];
  @Output() emitter = new EventEmitter<number>();

  constructor() { }

  ngOnInit(): void {
  }
  sendToParent(id: number){
    this.emitter.emit(id);
  }
}
