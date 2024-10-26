import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router'; 
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './pages/home/home.component';
import { RoomsComponent } from './pages/rooms/rooms.component'; 
import { AppRoutingModule } from './app-routing.module';
import { AdminComponent } from './pages/admin/admin.component';


const routes: Routes = [ 
  { path: 'rooms', component: RoomsComponent },
  { path: 'admin', component: AdminComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    RoomsComponent,
    AdminComponent 
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes) ,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
