// import { NgModule } from '@angular/core';
// import { CommonModule } from '@angular/common';
// import { StarterComponent } from './starter.component';

// import { NavComponent } from './nav/nav.component';
// @NgModule({
//   imports: [CommonModule],
//   declarations: [StarterComponent, NavComponent],
//   exports: [StarterComponent]
// })
// export class StarterModule {}


import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { StarterComponent } from "./starter.component";
import { StartUpNavComponent } from './nav/nav.component';

@NgModule({
  imports: [CommonModule],
  declarations: [
    StarterComponent,
    StartUpNavComponent
  ],
  exports: [StarterComponent]
})
export class StarterModule {}
