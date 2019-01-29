import { NgModule } from '@angular/core';

import { AuthRoutes } from './auth.routing';
import { CommonModule } from '@angular/common';
import { SharedModule } from './../../shared/shared.module';


import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';


@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    AuthRoutes
  ],
  declarations: [
    LoginComponent,
    RegisterComponent,
    ForgotPasswordComponent
  ],
  exports:  [
    LoginComponent,
    RegisterComponent,
    ForgotPasswordComponent
  ]
})
export class AuthModule { }
