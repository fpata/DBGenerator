import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {TablesComponent} from './Schema/tables.component';
import {ColumnsComponent} from './Schema/columns.component';
import {CSharpComponent} from './Code/csharp.component';
import {TypeScriptComponent} from './Code/typescript.component';


const routes: Routes = [
    { path: 'Tables', component: TablesComponent },
    { path: 'Columns', component: ColumnsComponent },
    { path: 'CSharp', component: CSharpComponent },
    { path: 'TypeScript', component: TypeScriptComponent }
  ];

@NgModule({
    imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ],
  declarations: []
})
export class AppRoutingModule {

    
}


