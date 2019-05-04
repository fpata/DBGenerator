import { Component, OnInit, ViewChild } from '@angular/core';
import {  MatPaginator, MatTableDataSource } from '@angular/material';
import { BaseComponent } from '../Base/base.component';

@Component({
    selector: 'app-columns',
    templateUrl: './columns.component.html',
    styleUrls: ['./columns.component.css']
  })

  export class ColumnsComponent extends BaseComponent {
    tableColumns = new MatTableDataSource([]);
    displayedColumns: Array<string> = new Array<string>();

    @ViewChild('columnPaginator') columnPaginator: MatPaginator;

    ngOnInit() {
      this.tableColumns.paginator = this.columnPaginator;
    }
  }