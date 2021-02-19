import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { ProjectComponent } from './project/project.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { appRoutes } from './routes';
import { ContactComponent } from './contact/contact.component';

@NgModule({
  declarations: [					
    AppComponent,
      ProfileComponent,
      ProjectComponent,
      HeaderComponent,
      HomeComponent,
      ContactComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
