import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
// Import RxJs required methods

@Injectable()
export class SchemaService {

    // Resolve HTTP using the constructor
    constructor(private _http: Http) { }

    getTables(connectStr): Observable<any> {
        const body = '{ConnectStr : ' + connectStr + '}';
        return this._http.post('/api/Schema/GetTables', body)
        .pipe(map((response: Response) => {
            return response.json();
        }));
    }
}
