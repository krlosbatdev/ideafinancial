
import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { DrawComponent } from "./draw/draw.component";


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'draw', component: DrawComponent }
]

export const routing = RouterModule.forRoot(routes);
