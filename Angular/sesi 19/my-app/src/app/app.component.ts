import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  counter = 0;

  resize(action: string){
    if(action == '+'){
      this.counter ++;
    }else if(action == '-'){
      this.counter --;
    }else{
      this.counter = 0;
    }
  }
}
