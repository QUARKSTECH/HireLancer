import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  model: any = {};
  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit() {
  }

  login() {
    debugger;
    this.authService.login(this.model).subscribe(next => {
      //this.alertify.success('Logged in successfully');
      alert('Logged in successfully');
      if (this.authService.decodedToken.unique_name === 'admin') {
        this.router.navigate(['/admin']);
      } else {
        this.router.navigate(['/starter']);
      }
    }, error => {
      if (!error.error) {
        alert("Invalid user");
      }
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

  logout() {
    localStorage.removeItem('token');
    //this.alertify.message('Logged out');
    alert('Logged out');
    this.model = {};
    this.router.navigate(['/home']);
  }

}
