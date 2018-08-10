import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';

import { SchemaService } from './app.schema.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DBGen';
  connectStr: String = '';
  selectedTable: String = '';
  constructor(private _appService: SchemaService) { }

  btnConnect_click($event) {
    alert('Connect Clicked');
    }

    btnClear_click($event) {
      alert('btnClear_click');
    }
}
