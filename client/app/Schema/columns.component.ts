import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { BaseComponent } from '../Base/base.component';
import { SESSION_STORAGE, WebStorageService } from 'angular-webstorage-service';
import { SchemaService } from '../app.schema.service';

@Component({
  selector: 'app-columns',
  templateUrl: './columns.component.html',
  styleUrls: ['./columns.component.css']
})

export class ColumnsComponent extends BaseComponent {
  tableColumns = new MatTableDataSource([]);
  displayedColumns: Array<string> = new Array<string>();

  constructor(@Inject(SESSION_STORAGE) private sessionStorage : WebStorageService,
  protected appService: SchemaService){ super(appService); }


  @ViewChild('columnPaginator') columnPaginator: MatPaginator;

  ngOnInit() {
    this.tableColumns.paginator = this.columnPaginator;
  }

  public GetData(): void {
    this.connectStr = sessionStorage.getItem('ConnectStr');
    this.DBType = sessionStorage.getItem('DBType');
    this.selectedTable =  sessionStorage.getItem('SelectedTable');
      this.appService.getColumns(this.connectStr, this.DBType, this.selectedTable).subscribe(
        data => {
          this.tableColumns.data = JSON.parse(data._body);

          var keysArray = new Array<string>();
          Object.keys(this.tableColumns.data[0]).forEach(function (k) {
            keysArray.push(k);
          });
          this.displayedColumns = keysArray;
        });
  }
}