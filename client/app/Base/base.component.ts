import { Component, OnInit, ViewChild } from '@angular/core';
import {  MatTableDataSource } from '@angular/material';
import { SchemaService } from '../app.schema.service';

@Component({
    selector: 'app-base',
    templateUrl: './base.component.html',
    styleUrls: ['./base.component.css']
  })
  export class BaseComponent {
        
    selectedTable: string = '';
    connectStr: string = '';
    DBType: string = "SQLite";
   
    constructor(protected appService: SchemaService) { }
  }