import { Component } from '@angular/core';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource } from '@angular/material';
import { BaseComponent } from '../Base/base.component';

@Component({
    selector: 'app-tables',
    templateUrl: './tables.component.html',
    styleUrls: ['./tables.component.css']
  })

  export class TablesComponent extends BaseComponent{

    tables = new MatTableDataSource([]);
    displayedTableColumns: Array<string> = new Array<string>();

  }