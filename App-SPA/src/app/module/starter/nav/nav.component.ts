import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-startup-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class StartUpNavComponent implements OnInit {
  appName = 'Hire lancer';
  constructor() { }

  ngOnInit() {
  }

}
