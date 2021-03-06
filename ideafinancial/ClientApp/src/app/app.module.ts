import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AngMaterialModule } from './angmaterial.module';
import { routing} from "./app.routing";
import { DrawComponent } from './draw/draw.component';
import { BrowserAnimationsModule,  } from '@angular/platform-browser/animations';
import { UserService } from "./services/user.service";

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DrawComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    routing,
    AngMaterialModule,
    BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
