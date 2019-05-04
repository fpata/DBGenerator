import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import {FormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MaterialModule} from './material.module';
import { AppComponent } from './app.component';
import {HeaderComponent} from './Header/header.component';
import {TablesComponent} from './Schema/tables.component';
import {ColumnsComponent} from './Schema/columns.component';
import {CSharpComponent} from './Code/csharp.component';
import {TypeScriptComponent} from './Code/typescript.component';
import { SchemaService } from './app.schema.service';

@NgModule({
  declarations: [
    AppComponent,HeaderComponent,TablesComponent,ColumnsComponent,CSharpComponent, TypeScriptComponent
  ],
  
  imports: [
    BrowserModule,
    MaterialModule,
    HttpModule,
    FormsModule,
    BrowserAnimationsModule
  ],
  providers: [SchemaService],
  bootstrap: [AppComponent]
})

export class AppModule { }
