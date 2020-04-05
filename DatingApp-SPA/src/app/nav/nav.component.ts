import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged seccessfully');
    }, error => {
      console.log(error);
    });
  }

  logout() {
    localStorage.removeItem('token');
    console.log('Logged out');
  }

  loggedIn() {
    const user = localStorage.getItem('token');
    return !!user;
  }

}
