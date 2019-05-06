import { Component, ViewChild, OnInit, Inject } from '@angular/core';
import { MatTabChangeEvent, MatPaginator, MatTableDataSource } from '@angular/material';
import { BaseComponent } from '../Base/base.component';
import { SchemaService } from '../app.schema.service';
import { SESSION_STORAGE, WebStorageService } from 'angular-webstorage-service';

@Component({
  selector: 'app-tables',
  templateUrl: './tables.component.html',
  styleUrls: ['./tables.component.css']
})

export class TablesComponent extends BaseComponent {

  displayedTableColumns: Array<string> = new Array<string>();
  tables = new MatTableDataSource([]);

  @ViewChild('tablePaginator') tablePaginator: MatPaginator;

  constructor(@Inject(SESSION_STORAGE) private sessionStorage : WebStorageService,
  protected appService: SchemaService){ super(appService); }
  
  ngOnInit() {
    this.tables.paginator = this.tablePaginator;
  }

  public GetData()
  {
    this.connectStr = sessionStorage.getItem('ConnectStr');
    this.DBType = sessionStorage.getItem('DBType');
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
}