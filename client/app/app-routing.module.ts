import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {TablesComponent} from './Schema/tables.component';
import {ColumnsComponent} from './Schema/columns.component';
import {PocoComponent} from './Code/CSharp/poco.component';
import {TypeScriptComponent} from './Code/typescript.component';
import { EFDataAnnotationComponent } from './Code/CSharp/efDataAnnotation.component';
import { EFFluentMapComponent } from './Code/CSharp/efFluentMap.component';
import { EF_DBContextComponent } from './Code/CSharp/efDBContext.component';
import { DALComponent } from './Code/CSharp/dal.component';
import { DapperComponent } from './Code/CSharp';


const routes: Routes = [
    { path: 'Tables', component: TablesComponent },
    { path: 'Columns', component: ColumnsComponent },
    { path: 'Entity-POCO', component: PocoComponent },
    { path: 'Entity-Dapper', component: DapperComponent },
    { path: 'Entity-EntityFramework-DataAnnotations', component: EFDataAnnotationComponent },
    { path: 'Entity-EntityFramework-FluentMapping', component: EFFluentMapComponent },
    { path: 'EntityFramework-DBContext', component: EF_DBContextComponent },
    { path: 'EntityFramework-DAL', component: DALComponent },
    { path: 'TypeScript', component: TypeScriptComponent }
  ];

@NgModule({
    imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ],
  declarations: []
})
export class AppRoutingModule {

    
}


