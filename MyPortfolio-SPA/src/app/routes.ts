import {Routes} from '@angular/router';
import { ContactComponent } from './contact/contact.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { ProfileComponent } from './profile/profile.component';
import { ProjectComponent } from './project/project.component';

export const appRoutes: Routes = [

    {path:'home', component: HomeComponent},
    {path:'abouts', component: ProfileComponent},
    {path:'header', component: HeaderComponent},
    {path:'project', component: ProjectComponent},
    {path:'contact', component:ContactComponent},
    {path: '**', redirectTo:'home', pathMatch: 'full'},
];