import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { UserService } from "../services/user.service";
import { User } from "../models/user.model";


@Component({
  selector: 'app-draw',
  templateUrl: './draw.component.html',
  styleUrls: ['./draw.component.css']
})
export class DrawComponent implements OnInit {

  amountFormControl;

  constructor(private router: Router, public userService: UserService) {

   }

  ngOnInit() {
    this.amountFormControl = new FormControl('', [
      Validators.required,
      Validators.max(this.userService.user.availableFunds),
      Validators.min(1)
    ]);
  }



  matcher = new MyErrorStateMatcher();

  goToHome() {
    this.router.navigateByUrl('/', { skipLocationChange: true });
  }

  submit(){
    this.userService.draw(this.amountFormControl.value).subscribe(a => this.router.navigateByUrl('/', { skipLocationChange: true }) );
  }
}


/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
