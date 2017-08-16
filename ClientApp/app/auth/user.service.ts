import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class UserService {
    private baseUrl: string = '/api/User/';

    constructor(private http: Http) {
    }

    getUser(): Observable<User> {
        let value$ = this.http
            .get(this.baseUrl + '12345-getProperAuth')
            .map(function (response: Response) {
                return response.json() as User
            });

        return value$;
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