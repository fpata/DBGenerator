import { NgModule } from '@angular/core';

import {MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
, MatInputModule, MatDividerModule, MatSelectModule} from '@angular/material';

@NgModule({
  imports: [ MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule],
  exports: [MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule],
  declarations: []
})
export class MaterialModule { }
