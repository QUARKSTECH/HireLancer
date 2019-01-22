import { Startup } from './../../models/startup';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-startups',
  templateUrl: './startups.component.html',
  styleUrls: ['./startups.component.scss']
})
export class StartupsComponent implements OnInit {
  startups: Startup[] = [
    {
      name: 'Startup 1',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 99.00
    },
    {
      name: 'Startup 2',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 85.50
    },
    {
      name: 'Startup 3',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 99.00
    },
    {
      name: 'Startup 4',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 99.00
    },
    {
      name: 'Startup 5',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 99.00
    },
    {
      name: 'Startup 6',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      price: 99.00
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
