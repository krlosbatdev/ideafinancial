import { Draw } from './../models/draw.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { tap } from 'rxjs/operators';
import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private userUrl = '/api/users/';
  public user:User;
  constructor(private http: HttpClient) { }

  getUser(id:number ) {
    return this.http.get(this.userUrl + id)
      .pipe(tap(user=> this.user = user as User));
  }
  draw(amount: number) {
    const headers = new Headers({
      'Content-Type': 'application/json'
    });

    let draw: Draw = {
      userId : this.user.id,
      amount : amount
    }
    return this.http.post<Draw>(this.userUrl, draw);
  }
}
