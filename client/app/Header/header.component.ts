import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import {SESSION_STORAGE, WebStorageService} from 'angular-webstorage-service';
import { BaseComponent } from '../Base/base.component';
import { SchemaService } from '../app.schema.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent extends BaseComponent {

   constructor(@Inject(SESSION_STORAGE) private sessionStorage : WebStorageService,
              protected appService: SchemaService){ super(appService); }

  displayedTableColumns: Array<string> = new Array<string>();
  tables = new MatTableDataSource([]);

  btnConnect_click($event) {
    this.connectStr = this.connectStr.split('\\').join('/');
    if (!this.connectStr.startsWith('Data Source')) this.connectStr = 'Data Source=' + this.connectStr;
    sessionStorage.setItem('ConnectStr',this.connectStr);
    sessionStorage.setItem('DBType',this.DBType);
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
    sessionStorage.clear();
  }

  cbTables_Select($event) {
    this.selectedTable = $event.value;
    sessionStorage.setItem('SelectedTable',this.selectedTable);
  }
}