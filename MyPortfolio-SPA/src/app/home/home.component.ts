import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  abouts: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAbouts();
  }

  getAbouts() {
    this.http.get('http://localhost:5000/api/profile').subscribe(response => {
      this.abouts = response;
    }, error => {
      console.log(error);
    });
  }


}
