import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ProServicesComponent } from "./component/pro-services/pro-services.component";
import { StartupsComponent } from "./component/startups/startups.component";
import { NavComponent } from "./component/nav/nav.component";
import { BreadcrumbComponent } from "./component/breadcrumb/breadcrumb.component";

@NgModule({
  imports: [CommonModule],
  declarations: [
    ProServicesComponent,
    StartupsComponent,
    NavComponent,
    BreadcrumbComponent
  ],
  exports: [
    ProServicesComponent,
    StartupsComponent,
    NavComponent,
    BreadcrumbComponent
  ]
})
export class SharedModule {}
