import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './module/home/home.component';
import { StarterComponent } from './module/starter/starter.component';
import { AuthRoutingModule } from './module/auth/auth.routing';


const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'starter',
    component: StarterComponent
  },
  {
    path: '**',
    component: HomeComponent
  },
];

@NgModule({
  imports: [
    AuthRoutingModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
