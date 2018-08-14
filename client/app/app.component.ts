import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';
import { MatTabChangeEvent } from '@angular/material';
import { SchemaService } from './app.schema.service';
import { createInjectable } from '../../node_modules/@angular/compiler/src/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  title = 'DBGen';
  connectStr: String = '';
  selectedTable: String = '';
  tables = [];
  constructor(private appService: SchemaService) { }

  btnConnect_click($event) {
    this.appService.getTables(this.connectStr).subscribe(
      data => { this.tables = JSON.parse(data._body);
        this.createTable();
      });
    }

    btnClear_click($event) {
      alert('btnClear_click');
    }

    tabChanged(tabChangeEvent: MatTabChangeEvent): void {
      console.log(tabChangeEvent);
  }

  createTable(): any {
  }
}
