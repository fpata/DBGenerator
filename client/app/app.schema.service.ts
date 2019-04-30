import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';
// Import RxJs required methods

@Injectable()
export class SchemaService {
  
     httpOptions = {
        headers: new Headers({
            'Content-Type': 'application/json'
        })
    };
    // Resolve HTTP using the constructor
    constructor(private _http: Http) { }

    getTables(connectStr:string, DBType:string ): Observable<any> {
       
        const postData = '{"connectStr" : "' + connectStr + '","DBType":"'+ DBType +'"}';
        return this._http.post('/api/Schema/GetTables', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }

    getColumns(connectStr:string, DBType:string, tableName:string): Observable<any> {
        
        const postData = '{"connectStr" : "' + connectStr + '","DBType":"'+ DBType +'","tableName": "' + tableName + '" }';
        return this._http.post('/api/Schema/GetColumns', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }


    getCode(connectStr:string,  DBType:string, tableName:string, CodeType:string, ORM:string): Observable<any> {
      
        const postData = '{"connectStr" : "' + connectStr + '","DBType":"'+ DBType +'","tableName": "' + tableName + '", "codeType" : "' + CodeType+'", "ORM" : "' + ORM +'" }';
        return this._http.post('/api/Schema/GetCode', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }

    createFiles(connectStr:string,  DBType:string, CodeType:string, ORM:string): any {
        const postData = '{"connectStr" : "' + connectStr +  '","DBType":"'+ DBType +'", "codeType" : "' + CodeType+'", "ORM" : "' + ORM +'" }';

        return this._http.post('/api/Schema/CreateFiles', postData, this.httpOptions)
        .pipe(tap((response: Response) => {
            return response.text();
        },
            error => console.log(error)),
        );
      }


}
