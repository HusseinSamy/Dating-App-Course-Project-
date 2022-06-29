import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'client';

  constructor(private http: HttpClient){}
  ngOnInit(): void {
    this.getUsers();
  }

  getUsers()
  {
    let user: any;
      this.http.get('https://localhost:5001/api/users').subscribe({
        next: res => user = res.constructor,
        error: err => console.log(err)
      });
  }
}
