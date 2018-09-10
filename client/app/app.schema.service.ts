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

    getTables(connectStr:string): Observable<any> {
       
        const postData = '{"connectStr" : "' + connectStr + '"}';
        return this._http.post('/api/Schema/GetTables', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }

    getColumns(connectStr:string, tableName:string): Observable<any> {
        
        const postData = '{"connectStr" : "' + connectStr + '","tableName": "' + tableName + '" }';
        return this._http.post('/api/Schema/GetColumns', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }


    getCode(connectStr:string, tableName:string, CodeType:string): Observable<any> {
      
        const postData = '{"connectStr" : "' + connectStr + '","tableName": "' + tableName + '", "codeType" : "' + CodeType+'" }';
        return this._http.post('/api/Schema/GetCode', postData, this.httpOptions)
            .pipe(tap((response: Response) => {
                return response.text();
            },
                error => console.log(error)),
            );
    }

    createFiles(connectStr:string, CodeType:string): any {
        const postData = '{"connectStr" : "' + connectStr +  '", "codeType" : "' + CodeType+'" }';

        return this._http.post('/api/Schema/CreateFiles', postData, this.httpOptions)
        .pipe(tap((response: Response) => {
            return response.text();
        },
            error => console.log(error)),
        );
      }


}
