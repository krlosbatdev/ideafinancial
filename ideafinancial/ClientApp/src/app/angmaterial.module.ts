import { MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule } from '@angular/material';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule],
  exports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule]
})

export class AngMaterialModule { }
