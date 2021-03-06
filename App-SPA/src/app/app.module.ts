import { BrowserModule, Title } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from "./app.component";

import { CoreModule } from "./core/core.module";
import { SharedModule } from "./shared/shared.module";

import { HomeModule } from "./module/home/home.module";

import { StarterModule } from "./module/starter/starter.module";
import { AuthModule } from './module/auth/auth.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,

    // Home
    HomeModule,

    // Stater
    StarterModule,

    // AuthModule
    AuthModule,

    // Core & Shared
    CoreModule,
    SharedModule
  ],
  providers: [Title],
  bootstrap: [AppComponent]
})
export class AppModule {}
