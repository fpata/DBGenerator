import { Component, OnInit, ViewChild } from '@angular/core';
import { Http, Response } from '@angular/http';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource, MatRadioButton, MatRadioGroup, MatRadioChange } from '@angular/material';
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
  ORM: string = 'None';
  DBType: string = "SQLite"
  selectedTable: string = '';
  selectedTabIndex = 0;
  tables = new MatTableDataSource([]);
  tableColumns = new MatTableDataSource([]);
  codeCSharpEntity: string = '';
  codeCSharpDAL: String = '';
  codeCSharpDALDbContext: String = '';
  codeTypeScript: string = '';
  displayedTableColumns: Array<string> = new Array<string>();
  displayedColumns: Array<string> = new Array<string>();
  selectedCSharpTab = 0;

  @ViewChild('tablePaginator') tablePaginator: MatPaginator;
  @ViewChild('columnPaginator') columnPaginator: MatPaginator;

  constructor(private appService: SchemaService) { }

  ngOnInit() {
    this.tables.paginator = this.tablePaginator;
    this.tableColumns.paginator = this.columnPaginator;
  }

  btnConnect_click($event) {
    this.connectStr = this.connectStr.split('\\').join('/');
    if (!this.connectStr.startsWith('Data Source')) this.connectStr = 'Data Source=' + this.connectStr;

    this.appService.getTables(this.connectStr, this.DBType).subscribe(
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

  tabCSharpChanged(tabChangeEvent: MatTabChangeEvent): void {
    this.selectedCSharpTab = tabChangeEvent.index;
    this.GetCSharpCode(this.ORM, this.selectedCSharpTab);
  }

  ORM_Change($event) {
    this.GetCSharpCode($event.value, this.selectedCSharpTab);
  }
  createFiles(codeType): void {
    this.appService.createFiles(this.connectStr, this.DBType, codeType, this.ORM).subscribe(response => console.log(response));
  }

  setDataInTabs(tabIndex: number) {
    if (this.selectedTable == null || this.selectedTable == 'undefined') return;
    switch (tabIndex) {
      case 1:
        this.appService.getColumns(this.connectStr, this.DBType, this.selectedTable).subscribe(
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
        this.GetCSharpCode(this.ORM, this.selectedCSharpTab);
        break;
      case 3:
        this.appService.getCode(this.connectStr, this.DBType, this.selectedTable, "TypeScript", this.ORM).subscribe(
          data => {
            this.codeTypeScript = data._body;
          });
        break;
      default:
        break;
    }
  }



  GetCSharpCode(orm: string, codeIndex: number): void {

    var codeType: string = '';
    var code:string = '';
    switch (codeIndex) {
      case 0:
        codeType = 'CSharpEntity';
        break;
      case 1:
        codeType = 'CSharpDAL';
        break;
      case 2:
        codeType = 'CSharpDBContext';
        break;
      default:
        codeType = 'CSharpEntity';
        break;
    }
    this.appService.getCode(this.connectStr, this.DBType, this.selectedTable, codeType, orm).subscribe(
      data => {
        code= data._body;
        switch (codeIndex) {
          case 0:
            this.codeCSharpEntity = code;
            break;
          case 1:
            this.codeCSharpDAL = code;
            break;
          case 2:
            this.codeCSharpDALDbContext = code;
            break;
        }
      });
     
  }
}
