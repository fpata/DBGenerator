import { Component } from '@angular/core';
import { MatTabChangeEvent, MatRadioButton, MatRadioGroup, MatRadioChange } from '@angular/material';
import { CSharpComponent } from './csharp.component';

@Component({
  selector: 'app-poco',
  templateUrl: './csharp.component.html'
})

export class PocoComponent extends CSharpComponent {
  
  ngAfterViewInit() {
    this.GetCSharpCode('CSharpEntity','None');
  }

  createFiles(fileType:String): void {

  }
}