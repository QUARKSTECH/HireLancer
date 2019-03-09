import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  model: any = {};


  constructor(private authService: AuthService, private router: Router) { }

  levels: Array<Object> = [
    { value: "startup", name: "Startup" }
    //,{ value: "investor", name: "Investor" }
  ];

  ngOnInit() {
    this.model.selectedLevel = this.levels[0];
  }

  register() {
    debugger;
    if (this.model.selectedLevel) {
      this.model.selectedLevel = this.model.selectedLevel.value;
    }
    this.authService.register(this.model).subscribe(() => {
      //this.alertify.success('Registration Successfull');
      alert('Registration successfully');
      this.model = {};
      this.router.navigate(['/starter']);
      //this.modalRef.hide();
    }, error => {
      // Step 1. Get all the object keys.
      let evilResponseProps = Object.keys(error.error);
      // Step 2. Create an empty array.
      let goodResponse = [];
      // Step 3. Iterate throw all keys.
      for (let prop of evilResponseProps) {
        goodResponse.push(error.error[prop].join(' '));
      }
      //this.alertify.error(error);
      alert(goodResponse.join("\n"));
    });
  }

}
