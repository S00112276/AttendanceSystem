import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor() { }

  hide = true;
  showSpinner: boolean = false;
  match = new FormControl('', [Validators.required, Validators.email]);

  getErrorMessage() {
    return this.match.hasError('required') ? 'You must confirm your password' :
      this.match.hasError('email') ? 'Passwords do not match' :
        '';
  }

  Register() {
    this.showSpinner = true;

    setTimeout(() => {
      this.showSpinner = false;
    }, 400);
  }

  ngOnInit() {
  }

}