import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Task } from 'src/app/Models/Task';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent implements OnInit {
  tasks: Task[] = [];
  categories = [
    'School',
    'Work',
    'Hobby',
    'Daily'
  ];

  onSubmit(form: NgForm){
    const {taskName, category} = form.value;
    this.tasks.push(new Task(taskName, false, category));
    form.reset();
  }

  toggleDone(id:number){
    this.tasks.map((v,i) =>{
      if(i==id){
        v.isCompleted = !v.isCompleted;
      }
      console.log(v);
      return v;
    });
  }

  deleteTask(id:number){
    this.tasks = this.tasks.filter((v,i) => i !== id);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
