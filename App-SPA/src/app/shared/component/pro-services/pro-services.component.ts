import { Component, OnInit } from "@angular/core";
import { ProService } from "../../models/pro-service";
import { ProServiceStatus } from "../../enum/pro-service-status.enum";

@Component({
  selector: "app-pro-services",
  templateUrl: "./pro-services.component.html",
  styleUrls: ["./pro-services.component.scss"]
})
export class ProServicesComponent implements OnInit {
  services: ProService[] = [
    {
      name: 'Service 1',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 99.00
    },
    {
      name: 'Service 2',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 85.50
    },
    {
      name: 'Service 3',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 99.00
    },
    {
      name: 'Service 4',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 99.00
    },
    {
      name: 'Service 5',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 99.00
    },
    {
      name: 'Service 6',
      iconPath : '',
      description : 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo aut magni perferendis.',
      rating: '3',
      status: ProServiceStatus.proVerified,
      price: 99.00
    }
  ];

  constructor() {}

  ngOnInit() {}
}
