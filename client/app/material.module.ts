import { NgModule } from '@angular/core';

import {MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
, MatInputModule, MatDividerModule, MatSelectModule, MatTableModule} from '@angular/material';

@NgModule({
  imports: [ MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule,MatTableModule],
  exports: [MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule,MatTableModule],
  declarations: []
})
export class MaterialModule { }
