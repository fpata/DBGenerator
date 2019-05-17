
import { BaseComponent } from 'client/app/Base/base.component';
import { Component, AfterViewInit } from '@angular/core';

@Component({
    selector: 'app-csharp',
    templateUrl:'./csharp.component.html'
  })
  export class CSharpComponent extends BaseComponent {
    code : string = '';

    GetCSharpCode(codeType: string, orm: string): void {
        this.connectStr = sessionStorage.getItem('ConnectStr');
        this.DBType = sessionStorage.getItem('DBType');
        this.selectedTable =  sessionStorage.getItem('SelectedTable');
          this.appService.getCode(this.connectStr, this.DBType, this.selectedTable, codeType, orm).subscribe(
          data => {
            this.code = data._body;
          });
      }
  }