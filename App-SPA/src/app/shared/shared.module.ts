import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ProServicesComponent } from "./component/pro-services/pro-services.component";
import { StartupsComponent } from './component/startups/startups.component';

@NgModule({
  imports: [CommonModule],
  declarations: [ProServicesComponent, StartupsComponent],
  exports: [ProServicesComponent, StartupsComponent]
})
export class SharedModule {
}
