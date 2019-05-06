import { Component } from '@angular/core';
import { BaseComponent } from '../Base/base.component';

@Component({
  selector: 'app-typescript',
  templateUrl: './typescript.component.html',
  styleUrls: ['./typescript.component.css']
})

export class TypeScriptComponent extends BaseComponent {
  codeTypeScript: string = '';
  ORM: string = 'None';
  
  public GetData(): void {
    this.connectStr = sessionStorage.getItem('ConnectStr');
    this.DBType = sessionStorage.getItem('DBType');
    this.selectedTable =  sessionStorage.getItem('SelectedTable');
    this.appService.getCode(this.connectStr, this.DBType, this.selectedTable, "TypeScript", this.ORM).subscribe(
      data => {
        this.codeTypeScript = data._body;
      });
  }

  createFiles(fileType:String): void {

  }
}