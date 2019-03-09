import { BrowserModule, Title } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";

import { CoreModule } from "./core/core.module";
import { SharedModule } from "./shared/shared.module";

import { HomeModule } from "./module/home/home.module";

import { StarterModule } from "./module/starter/starter.module";
import { AuthModule } from './module/auth/auth.module';

import { AuthService } from '../app/services/auth.service';

import {HttpClientModule} from '@angular/common/http';
@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,

    // Home
    HomeModule,

    // Stater
    StarterModule,

    // AuthModule
    AuthModule,

    // Core & Shared
    CoreModule,
    SharedModule,

    HttpClientModule
  ],
  providers: [Title, AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
