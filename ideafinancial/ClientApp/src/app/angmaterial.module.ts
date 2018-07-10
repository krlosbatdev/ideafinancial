import { MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule } from '@angular/material';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule],
  exports: [MatButtonModule, MatSliderModule, MatToolbarModule, MatCardModule, MatInputModule]
})

export class AngMaterialModule { }
