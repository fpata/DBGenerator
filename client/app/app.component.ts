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
  connectStr: string = '';
  selectedTable: string = '';
  selectedTabIndex = 0;
  tables = [];
  tableColumns = [];
  codeCSharp:string = '';
  codeTypeScript :string = '';
  displayedTableColumns: string[] = ['Name'];
  displayedColumns :string[] = ['ColumnName', 'Type'];
  constructor(private appService: SchemaService) { }

  btnConnect_click($event) {
    this.appService.getTables(this.connectStr).subscribe(
      data => { this.tables = JSON.parse(data._body);
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
      this.appService.createFiles(this.connectStr,codeType).subscribe( response => console.log(response));
    }

    setDataInTabs(tabIndex:number){
      switch (tabIndex) {
        case 1:
        this.appService.getColumns(this.connectStr,this.selectedTable).subscribe(
          data => { this.tableColumns = JSON.parse(data._body);
           
          });
          break;
          case 2:
          this.appService.getCode(this.connectStr,this.selectedTable, "CSharp").subscribe(
            data => { this.codeCSharp = data._body;
              console.log(this.codeCSharp);
            });
            break;
            case 3:
            this.appService.getCode(this.connectStr,this.selectedTable, "TypeScript").subscribe(
            data => { this.codeTypeScript = data._body;
              console.log(this.codeTypeScript);
            });
            break;
        default:
          break;
      }
    }

}
