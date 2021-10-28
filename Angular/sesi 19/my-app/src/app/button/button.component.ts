import { EventEmitter, Component, OnInit, Output, Input } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Output() clickEventHandler: EventEmitter<string> = new EventEmitter();
  @Input() actionName = '';
  constructor() { }

  resizeCounter(){
    this.clickEventHandler.emit();
  }

  ngOnInit(): void {
  }

}
