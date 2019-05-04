import { Component, OnInit, ViewChild } from '@angular/core';
import { Http, Response } from '@angular/http';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource, MatRadioButton, MatRadioGroup, MatRadioChange } from '@angular/material';
import { createInjectable } from '@angular/compiler/src/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'DBGen';
  selectedTabIndex = 0;

  tabChanged(tabChangeEvent: MatTabChangeEvent): void {
    this.selectedTabIndex = tabChangeEvent.index;
    //this.setDataInTabs(this.selectedTabIndex);
  
 }

  /*setDataInTabs(tabIndex: number) {
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
  }*/  
}
