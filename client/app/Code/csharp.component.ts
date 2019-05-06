import { Component } from '@angular/core';
import { MatTabChangeEvent, MatRadioButton, MatRadioGroup, MatRadioChange } from '@angular/material';

import { BaseComponent } from '../Base/base.component';

@Component({
  selector: 'app-csharp',
  templateUrl: './csharp.component.html',
  styleUrls: ['./csharp.component.css']
})

export class CSharpComponent extends BaseComponent {
  ORM: string = 'None';
  codeCSharpEntity: string = '';
  codeCSharpDAL: String = '';
  codeCSharpDALDbContext: String = '';
  selectedCSharpTab = 0;

  public GetData(){
    this.GetCSharpCode(this.ORM, this.selectedCSharpTab);
  }

  tabCSharpChanged(tabChangeEvent: MatTabChangeEvent): void {
    this.selectedCSharpTab = tabChangeEvent.index;
    this.GetCSharpCode(this.ORM, this.selectedCSharpTab);
  }


  ORM_Change($event) {
    this.GetCSharpCode($event.value, this.selectedCSharpTab);
  }

  GetCSharpCode(orm: string, codeIndex: number): void {
    this.connectStr = sessionStorage.getItem('ConnectStr');
    this.DBType = sessionStorage.getItem('DBType');
    this.selectedTable =  sessionStorage.getItem('SelectedTable');
    var codeType: string = '';
    var code: string = '';
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
        code = data._body;
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

  createFiles(fileType:String): void {

  }
}