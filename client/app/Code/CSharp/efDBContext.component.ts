import { Component, AfterViewInit } from '@angular/core';
import { CSharpComponent } from './csharp.component';

@Component({
  selector: 'app-dbContext',
  templateUrl: './csharp.component.html'
})

export class EF_DBContextComponent extends CSharpComponent
{

  ngAfterViewInit()
  {
    this.GetCSharpCode('CSharpDBContext','None');
  } 
}