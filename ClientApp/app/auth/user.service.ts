import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class UserService {
    private baseUrl: string = '/api/User/';
    private _currentUser: Observable<User>;
    constructor(private http: Http) {
    }

    getUser(authKey): Observable<User> {
        let value$ = this.http
            .get(this.baseUrl + authKey)
            .map(function (response: Response) {
                return response.json() as User
            });

        return this._currentUser = value$;
    }

    getCurrentUser(): Observable<User> {
        return this._currentUser;
    }
}

export interface User {
    id: string;
    userCharacters: SimpleCharacter[];
    firstName: string;
    lastName: string;
}

export interface SimpleCharacter {
    id: string;
    firstName: string;
    lastName: string;
    gender: string;
    experience: string;
    level: string;
}