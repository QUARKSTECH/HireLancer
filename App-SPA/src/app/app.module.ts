import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";

import { CoreModule } from "./core/core.module";
import { SharedModule } from "./shared/shared.module";

import { HomeModule } from "./module/home/home.module";

import { StarterModule } from "./module/starter/starter.module";

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,

    // Home
    HomeModule,

    // Stater
    StarterModule,

    // Core & Shared
    CoreModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
