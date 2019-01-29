import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HomeComponent } from "./home.component";

import { SharedModule } from "../../shared/shared.module";
import { SearchBannerComponent } from "./search-banner/search-banner.component";

@NgModule({
  imports: [CommonModule, SharedModule],
  declarations: [
    HomeComponent,
    SearchBannerComponent,
  ],
  exports: [HomeComponent]
})
export class HomeModule {}
