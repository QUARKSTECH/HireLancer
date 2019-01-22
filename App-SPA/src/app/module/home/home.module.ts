import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HomeComponent } from "./home.component";

import { NavComponent } from "./nav/nav.component";
import { SharedModule } from "../../shared/shared.module";

@NgModule({
  imports: [CommonModule, SharedModule],
  declarations: [HomeComponent, NavComponent],
  exports: [HomeComponent]
})
export class HomeModule {
}
