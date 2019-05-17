import { Component } from '@angular/core';
import {NestedTreeControl} from '@angular/cdk/tree';
import {MatTreeNestedDataSource} from '@angular/material/tree';



  interface DBGenNavigation{
    name: string;
    children?:DBGenNavigation[];
  }

  @Component({
    selector: 'app-navigation',
    templateUrl: './navigationMenu.component.html',
    styleUrls: ['./navigationMenu.component.css']
  })

  export class NavigationMenu {
    treeControl = new NestedTreeControl<DBGenNavigation>(node => node.children);
    dataSource = new MatTreeNestedDataSource<DBGenNavigation>();
    hasChild = (_: number, node: DBGenNavigation) => !!node.children && node.children.length > 0;
    constructor(){
      this.dataSource.data = Navigation_Tree;
    }

  }

  const Navigation_Tree : DBGenNavigation[] =
  [
  {
    name: 'Schema',
    children: [
     { name:'Tables'},
     {name:'Columns'}
    ]     
  },
  {
    name:'Code',
    children:[
      { name:'CSharp',
      children:[
        {name:'Entity-POCO'},
        {name:'Entity-EntityFramework-DataAnnotations'},
        {name:'Entity-EntityFramework-FluentMapping'},
        {name:'Entity-Dapper'}
      ]
    },
      {name:'Typescript'}
    ]
  }
];