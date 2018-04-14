import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  hide = true;
  showSpinner: boolean = false;

  Login() {
    this.showSpinner = true;

    setTimeout(() => {
      this.showSpinner = false;
    }, 400);
  }

  ngOnInit() {
  }

}