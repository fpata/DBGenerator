import { Component, AfterViewInit } from '@angular/core';
import { CSharpComponent } from './csharp.component';

@Component({
  selector: 'app-dapper',
  templateUrl: './csharp.component.html'
})

export class DapperComponent extends CSharpComponent
{

  ngAfterViewInit()
  {
    this.GetCSharpCode('CSharpEntity','Dapper');
  } 
}