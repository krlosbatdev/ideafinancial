import { MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule,MatProgressSpinnerModule } from '@angular/material';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule,MatProgressSpinnerModule],
  exports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule, MatProgressSpinnerModule]
})

export class AngMaterialModule { }
