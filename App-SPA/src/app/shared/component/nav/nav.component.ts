import { Router  } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {
  appName = 'Hire lancer';
  constructor(private router: Router) {}

  ngOnInit() {
  }

}
