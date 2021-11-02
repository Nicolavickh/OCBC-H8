import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';

import { LoginReactiveFormComponent } from './login-reactive-form.component';

const validUser = {
  email: 'test@gmail.com',
  password: '12345'
};

describe('LoginReactiveFormComponent', () => {
  let component: LoginReactiveFormComponent;
  let fixture: ComponentFixture<LoginReactiveFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [ LoginReactiveFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginReactiveFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render email and password input elements', () => {
    const compiled = fixture.debugElement.nativeElement;
    const formElement = compiled.querySelector('#loginForm');
    const emailInputElement = formElement.querySelector('input[id="email"]');
    const passInputElement = formElement.querySelector('input[id="password"]');

    expect(emailInputElement).toBeTruthy();
    expect(passInputElement).toBeTruthy();
  });

  it('Check initial value of login form group', () => {
    const loginFormGroup = component.loginForm;
    const loginFormValue = {
      email: '',
      password: ''
    }
    expect(loginFormGroup.value).toEqual(loginFormValue);
  });

  it('Validate email input: `required, minLength(5), email type`', () => {
    const email = component.email;

    email?.setValue('');
    expect(email?.hasError('required')).toBeTruthy();

    email?.setValue('abcd');
    expect(email?.hasError('minlength')).toBeTruthy();

    email?.setValue('abcdefghij');
    expect(email?.hasError('email')).toBeTruthy();
  });

  it('Invalid form when empty', () => {
    const email = component.email;
    const pass = component.password;

    email?.setValue('');
    pass?.setValue('');
    expect(component.loginForm.valid).toBeFalsy();
  });

  it('Check form validity when validator are fullfiled', () => {
    const compiled = fixture.debugElement.nativeElement;
    const emailInputElement = compiled.querySelector('input[id="email"]');
    const passInputElement = compiled.querySelector('input[id="password"]');

    if(!!emailInputElement && !!passInputElement){
      emailInputElement.value = validUser.email;
      emailInputElement.dispatchEvent(new Event('input'));

      passInputElement.value = validUser.password;
      passInputElement.dispatchEvent(new Event('input'));
      fixture.detectChanges();
    }
    expect(component.loginForm.valid).toBeTruthy;
  });

  it('Submitting form and set currentUser', () => {
    const compiled = fixture.debugElement.nativeElement;
    const emailInputElement = compiled.querySelector('input[id="email"]');
    const passInputElement = compiled.querySelector('input[id="password"]');

    if(!!emailInputElement && !!passInputElement){
      emailInputElement.value = validUser.email;
      emailInputElement.dispatchEvent(new Event('input'));

      passInputElement.value = validUser.password;
      passInputElement.dispatchEvent(new Event('input'));
      fixture.detectChanges();
    }

    const button = compiled.querySelector('button');
    button.click();

    expect(component.currentUser.email).toEqual(validUser.email);
    expect(component.currentUser.isLogin).toBeTruthy();
  });

});
