import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

interface User{
  isLogin: boolean,
  email?: string
}

@Component({
  selector: 'app-login-reactive-form',
  templateUrl: './login-reactive-form.component.html',
  styleUrls: ['./login-reactive-form.component.css']
})
export class LoginReactiveFormComponent implements OnInit {
  currentUser: User = {isLogin: false};

  loginForm: FormGroup = new FormGroup({
    email: new FormControl('', [Validators.minLength(5), Validators.email, Validators.required]),
    password: new FormControl('', [Validators.required])
  });

  get email(){
    return this.loginForm.get('email');
  }

  get password(){
    return this.loginForm.get('password');
  }

  onLogin(){
  this.currentUser = {
    isLogin: true,
    email: this.loginForm.value.email
  }}

  constructor() { }

  ngOnInit(): void {
  }

}
