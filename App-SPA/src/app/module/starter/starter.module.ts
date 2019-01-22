import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StarterComponent } from './starter.component';

import { NavComponent } from './nav/nav.component';
@NgModule({
  imports: [CommonModule],
  declarations: [StarterComponent, NavComponent],
  exports: [StarterComponent]
})
export class StarterModule {}
