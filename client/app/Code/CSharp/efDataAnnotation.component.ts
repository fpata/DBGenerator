import { Component } from '@angular/core';
import { CSharpComponent } from './csharp.component';

@Component({
  selector: 'app-efdataannotate',
  templateUrl: './csharp.component.html'
})

export class EFDataAnnotationComponent extends CSharpComponent {

  ngAfterViewInit() {
    this.GetCSharpCode('CSharpEntity','EntityFramework');
  }
   
}