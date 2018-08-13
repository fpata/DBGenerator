import { Injectable } from '@angular/core';
import { Http, Response , Headers} from '@angular/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';
// Import RxJs required methods

@Injectable()
export class SchemaService {

    // Resolve HTTP using the constructor
    constructor(private _http: Http) { }

    getTables(connectStr): Observable<any> {
        const httpOptions = {
            headers: new Headers({
              'Content-Type':  'application/json'
            })
          };
        const postData = '{\"connectStr\" : \"' + connectStr + '" }';
            return this._http.post('/api/Schema/GetTables', connectStr, httpOptions)
        .pipe(tap((response: Response) => {
            return response.text();
        },
        error => console.log(error)),
   );
    }
}
