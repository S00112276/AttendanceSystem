import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';


@Injectable()
export class AttendanceService {
    isDev: boolean;
    students = [];
    selectedModule = [];

    constructor(private _http: HttpClient, private http: Http) { }

    getStudents(): Observable<any[]> {
        return this._http.get<any[]>(this.prepEndpoint('students'))
            .catch(this.handleError);
    }

    // Handle Error
    private handleError(err: HttpErrorResponse) {
        console.log(err.message);
        return Observable.throw(err.message);
    }

    prepEndpoint(ep) {
        if (this.isDev) {
            return ep;
        } else {
            return 'http://localhost:49785/' + ep;
        }
    }
}