import { BaseComponent } from "../Base/base.component";
import { Component, AfterViewInit } from '@angular/core';

@Component({
    selector: 'app-html',
    templateUrl:'./plainHtml.component.html'
  })

export class HTMLComponent extends BaseComponent
{
    code: string ='';
    
    GetHtmlCode(codeType: string, orm: string): void {
        this.connectStr = sessionStorage.getItem('ConnectStr');
        this.DBType = sessionStorage.getItem('DBType');
        this.selectedTable =  sessionStorage.getItem('SelectedTable');
          this.appService.getCode(this.connectStr, this.DBType, this.selectedTable, codeType, orm).subscribe(
          data => {
            this.code = data._body;
          });
      }
}