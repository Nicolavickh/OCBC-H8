import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { AuthService } from "src/app/services/auth.service";
import { Router } from "@angular/router";

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  form = {
    inputData: new FormGroup({
      name: new FormControl('', [Validators.required, Validators.minLength(5)]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required,Validators.minLength(5)])
    })
  }

  constructor( public authService: AuthService, public router: Router ) { }

  get name(){
    return(this.form.inputData.get('name'))
  }

  get password(){
    return(this.form.inputData.get('password'))
  }

  get email(){
    return(this.form.inputData.get('email'))
  }

  ngOnInit(): void {
  }

  registerUser(){
    this.authService.signUp(this.form.inputData.value).subscribe((res) => {
      if (res){
        this.form.inputData.reset();
        this.router.navigate(['session26', 'login']);
      }
    });
  }

}
