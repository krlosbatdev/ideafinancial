import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.css']
})
export class HomeComponent {

  constructor(private router: Router) { }

  draw() {
    this.router.navigateByUrl('/draw', { skipLocationChange: true });
  }

}
