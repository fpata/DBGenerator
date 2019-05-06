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
  @ViewChild('appTables') appTables;
  @ViewChild('appColumns') appColumns;
  @ViewChild('appCSharp') appCSharp;
  @ViewChild('appTypeScript') appTypeScript;

  tabChanged(tabChangeEvent: MatTabChangeEvent): void {
    this.selectedTabIndex = tabChangeEvent.index;
    this.setDataInTabs(this.selectedTabIndex);

  }

  setDataInTabs(tabIndex: number) {

    switch (tabIndex) {
      case 0:
        this.appTables.GetData();
      case 1:
        this.appColumns.GetData();
        break;
      case 2:
        this.appCSharp.GetData();
        break;
      case 3:
        this.appTypeScript.GetData();
        break;
    }
  }
}
