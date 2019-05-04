import { Component, ViewChild, OnInit } from '@angular/core';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource } from '@angular/material';
import { BaseComponent } from '../Base/base.component';
import { SchemaService } from '../app.schema.service';

@Component({
  selector: 'app-tables',
  templateUrl: './tables.component.html',
  styleUrls: ['./tables.component.css']
})

export class TablesComponent extends BaseComponent {

  displayedTableColumns: Array<string> = new Array<string>();
  tables = new MatTableDataSource([]);

  @ViewChild('tablePaginator') tablePaginator: MatPaginator;

  constructor(protected appService: SchemaService) {super(appService);}
  
  ngOnInit() {
    this.tables.paginator = this.tablePaginator;
  }
}