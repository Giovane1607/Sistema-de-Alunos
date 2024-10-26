import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {RoomsComponent} from '../app/pages/rooms/rooms.component';
import {AdminComponent} from '../app/pages/admin/admin.component';


const routes: Routes = [
  {path:'admin', component: AdminComponent},
  {path:'rooms', component: RoomsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
