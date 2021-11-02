import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { StaffService } from '../services/staff.service';
import { User } from "../User";
import { AbstractControl, ValidatorFn } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
@Component({
  selector: 'app-staff-main-page',
  templateUrl: './staff-main-page.component.html',
  styleUrls: ['./staff-main-page.component.css']
})
export class StaffMainPageComponent implements OnInit {
  staffs: User[] = [];
  currentStaff: User= new User();
  closeResult = '';

  constructor(public service:StaffService, private modalService: NgbModal) { }
  getStaffs(){
    this.service.getStaffs().subscribe(dataSource => this.staffs = dataSource as User[]);
  };

  form = {
    inputData: new FormGroup({
      title: new FormControl('', [Validators.required]),
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      role: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required,Validators.minLength(5)]),
      confirmPassword: new FormControl('', [Validators.required]),
    },
    {
      validators: [this.match('password', 'confirmPassword')]
    }),
    updateData: new FormGroup({
      title: new FormControl('', [Validators.required]),
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      role: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required,Validators.minLength(5)]),
      confirmPassword: new FormControl('', [Validators.required]),
    },
    {
      validators: [this.match('password', 'confirmPassword')]
    })
  }

  match(controlName: string, checkControlName: string): ValidatorFn {
    return (controls: AbstractControl) => {
      const control = controls.get(controlName);
      const checkControl = controls.get(checkControlName);

      if (checkControl!.errors && !checkControl!.errors.matching) {
        return null;
      }

      if (control!.value !== checkControl!.value) {
        controls.get(checkControlName)!.setErrors({ matching: true });
        return { matching: true };
      } else {
        return null;
      }
    };
  }

  get title(){
    return (this.form.inputData.get('title'));
  }
  get firstName(){
    return (this.form.inputData.get('firstName'));
  }
  get lastName(){
    return (this.form.inputData.get('lastName'));
  }
  get email(){
    return (this.form.inputData.get('email'));
  }
  get role(){
    return (this.form.inputData.get('role'));
  }
  get password(){
    return (this.form.inputData.get('password'));
  }
  get confirmPassword(){
    return (this.form.inputData.get('confirmPassword'));
  }

  ngOnInit(): void {
    this.service.getStaffs().subscribe((res: any) => {
      if(res) this.staffs = res
    })
  }

  addStaff(){
    this.service.addStaff(this.form.inputData.value).subscribe((res) => {
      if(res){
        this.form.inputData.reset();
        this.getStaffs();
      }
    });
  }

  updateStaff(){
    this.service.updateStaff(this.form.updateData.value, this.currentStaff.id).subscribe((res) => {
      this.getStaffs();
    });
  }

  deleteStaff(id: number){
    this.service.deleteStaff(id).subscribe((res) => {
      this.getStaffs();
    });  
  }

  getStaff(staff: User, content: any){
    this.currentStaff = staff;
    this.modalService.open(content, { size: 'xl' });
    this.form.updateData.controls['title'].setValue(staff.title)
    this.form.updateData.controls['firstName'].setValue(staff.firstName)
    this.form.updateData.controls['lastName'].setValue(staff.lastName)
    this.form.updateData.controls['email'].setValue(staff.email)
    this.form.updateData.controls['role'].setValue(staff.role)
  }

  open(content: any) {
    this.modalService.open(content, { size: 'xl' });
  }
}
