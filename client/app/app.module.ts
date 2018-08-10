import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import {FormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MaterialModule} from './material.module';
import { AppComponent } from './app.component';
import { SchemaService } from './app.schema.service';
@NgModule({
  declarations: [
    AppComponent
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
