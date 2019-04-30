import { NgModule } from '@angular/core';

import {MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
, MatInputModule, MatDividerModule, MatSelectModule, MatTableModule, MatPaginatorModule, 
MatRadioModule} from '@angular/material';

@NgModule({
  imports: [ MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule,MatTableModule, MatPaginatorModule],
  exports: [MatButtonModule,  MatToolbarModule, MatCardModule ,  MatTabsModule, MatFormFieldModule
  , MatInputModule, MatDividerModule, MatSelectModule,MatTableModule, MatPaginatorModule,
  MatRadioModule],
  declarations: []
})
export class MaterialModule { }
