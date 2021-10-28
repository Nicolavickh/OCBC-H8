import { Component, OnInit } from '@angular/core';
import {Todo} from '../../Models/Todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todos: Todo[]=[];
  constructor() { }

  toggleDone(id:number){
    this.todos.map((v,i) =>{
      if(i==id){
        v.completed = !v.completed;
      }
      console.log(v);
      return v;
    });
  }

  deleteTodo(id:number){
    this.todos = this.todos.filter((v,i) => i !== id);
  }

  addTodo(todo: Todo){
    this.todos.push(todo);
  }

  updateTodo(id:number, todo: string){
    this.todos.map((v,i) =>{
      if(i==id){
        v.completed = !v.completed;
      }
      console.log(v);
      return v;
    });
  }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'Wake Up',
        completed: false
      },
      {
        content: 'Brush Teeth',
        completed: false,
      },
      {
        content: 'Start PC',
        completed: false,
      }
    ];
  }

}
