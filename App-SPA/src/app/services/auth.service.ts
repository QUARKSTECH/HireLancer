import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    baseurl = environment.apiUrl + 'auth/';
    decodedToken: any;

    constructor(private http: HttpClient) { }
    login(model: any) {
        debugger;
        return this.http.post(this.baseurl + 'login', model).pipe(
            map((response: any) => {
                debugger;
                const user = response;
                if (user) {
                    localStorage.setItem('token', user.token);
                    // TODO: use auth code
                    this.decodedToken = '';//this.jwtHelper.decodeToken(user.token);
                    console.log(this.decodedToken);
                }
            })
        );
    }

    register(model: any) {
        return this.http.post(this.baseurl + 'register', model);
    }

    loggedIn() {
        const token = localStorage.getItem('token');
        //return !this.jwtHelper.isTokenExpired(token);
    }
}
