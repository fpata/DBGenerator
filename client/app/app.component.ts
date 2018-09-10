import { Component, OnInit, ViewChild } from '@angular/core';
import { Http, Response } from '@angular/http';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource } from '@angular/material';
import { SchemaService } from './app.schema.service';
import { createInjectable } from '../../node_modules/@angular/compiler/src/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'DBGen';
  connectStr: string = '';
  selectedTable: string = '';
  selectedTabIndex = 0;
  tables = new MatTableDataSource([]);
  tableColumns = new MatTableDataSource([]);
  codeCSharp: string = '';
  codeTypeScript: string = '';
  displayedTableColumns: Array<string> = new Array<string>();
  displayedColumns: Array<string> = new Array<string>();

  @ViewChild('tablePaginator') tablePaginator: MatPaginator;
  @ViewChild('columnPaginator') columnPaginator: MatPaginator;

  constructor(private appService: SchemaService) { }

  ngOnInit(){
    this.tables.paginator = this.tablePaginator;
    this.tableColumns.paginator = this.columnPaginator;
  }

  btnConnect_click($event) {
    this.appService.getTables(this.connectStr).subscribe(
      data => {
        this.tables.data = JSON.parse(data._body);

        var keysArray = new Array<string>();
        Object.keys(this.tables.data[0]).forEach(function (k) {
          keysArray.push(k);
        });
        this.displayedTableColumns = keysArray;

      
      });
  }

  btnClear_click($event) {
    window.location.reload();
  }

  cbTables_Select($event) {
    this.selectedTable = $event.value;
    this.setDataInTabs(this.selectedTabIndex);
  }

  tabChanged(tabChangeEvent: MatTabChangeEvent): void {
    this.selectedTabIndex = tabChangeEvent.index;
    this.setDataInTabs(this.selectedTabIndex);
  }

  createFiles(codeType): void {
    this.appService.createFiles(this.connectStr, codeType).subscribe(response => console.log(response));
  }

  setDataInTabs(tabIndex: number) {
    if (this.selectedTable == null || this.selectedTable == 'undefined') return;
    switch (tabIndex) {
      case 1:
        this.appService.getColumns(this.connectStr, this.selectedTable).subscribe(
          data => {
            this.tableColumns.data = JSON.parse(data._body);
           
            var keysArray = new Array<string>();
            Object.keys(this.tableColumns.data[0]).forEach(function (k) {
              keysArray.push(k);
            });
            this.displayedColumns = keysArray;

           
          });
        break;
      case 2:
        this.appService.getCode(this.connectStr, this.selectedTable, "CSharp").subscribe(
          data => {
            this.codeCSharp = data._body;
          });
        break;
      case 3:
        this.appService.getCode(this.connectStr, this.selectedTable, "TypeScript").subscribe(
          data => {
            this.codeTypeScript = data._body;
          });
        break;
      default:
        break;
    }
  }
}
