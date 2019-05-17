import { Component } from '@angular/core';
import { CSharpComponent } from './csharp.component';

@Component({
  selector: 'app-effluentMap',
  templateUrl: './csharp.component.html'
})

export class EFFluentMapComponent extends CSharpComponent
{
 ngAfterViewInit() {
    this.GetCSharpCode('CSharpEntity','EFFluentMap');
  }
}