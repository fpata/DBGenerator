import { Component } from '@angular/core';
import { BaseComponent } from '../Base/base.component';

@Component({
    selector: 'app-typescript',
    templateUrl: './typescript.component.html',
    styleUrls: ['./typescript.component.css']
  })

  export class TypeScriptComponent extends BaseComponent {
    codeTypeScript: string = '';
  }