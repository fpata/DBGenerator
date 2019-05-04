import { Component, OnInit, ViewChild } from '@angular/core';
import {  MatTableDataSource, MatPaginator } from '@angular/material';

import { BaseComponent } from '../Base/base.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
  })

  export class HeaderComponent extends BaseComponent {

    tables = new MatTableDataSource([]);
  
    displayedTableColumns: Array<string> = new Array<string>();

    @ViewChild('tablePaginator') tablePaginator: MatPaginator;

 

    ngOnInit() {
      this.tables.paginator = this.tablePaginator;
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
     // this.setDataInTabs(this.selectedTabIndex);
    }
  }