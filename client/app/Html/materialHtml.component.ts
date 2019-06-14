import { Component, AfterViewInit } from '@angular/core';
import { HTMLComponent } from './html.component';

@Component({
  selector: 'app-materialHml',
  templateUrl: './plainHtml.component.html'
})

export class MaterialHtmlComponent extends HTMLComponent
{

  ngAfterViewInit()
  {
    this.GetHtmlCode('HTML','Material');
  } 
}