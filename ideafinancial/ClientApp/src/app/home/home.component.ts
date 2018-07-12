import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from "../services/user.service";
import { User } from "../models/user.model";


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.css']
})
export class HomeComponent implements OnInit{
  user:User;

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit() {
    this.userService.getUser("Ann")
      .subscribe(user => this.user = user as User
    );
  }

  draw() {
    this.router.navigateByUrl('/draw', { skipLocationChange: true });
  }

}
