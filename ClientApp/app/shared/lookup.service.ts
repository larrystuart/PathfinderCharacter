import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class LookupService {
    private baseUrl: string = '/api/Lookups/';

    constructor(private http: Http) {
    }

    getHeroClasses(): Observable<HeroClass[]> {
        let value$ = this.http
            .get(this.baseUrl + 'HeroClasses')
            .map(function (response: Response) {
                return response.json() as HeroClass[]
            });

        return value$;
    }

    getSchools(): Observable<School[]> {
        let value$ = this.http
            .get(this.baseUrl + 'Schools')
            .map(function (response: Response) { return response.json() as School[] });

        return value$;
    }

    getSavingThrows(): Observable<SavingThrow[]> {
        let value$ = this.http
            .get(this.baseUrl + 'SavingThrows')
            .map(function (response: Response) { return response.json() as SavingThrow[] });

        return value$;
    }

}

export interface School {
    id: string;
    name: string;
}

export interface HeroClass {
    id: string;
    name: string;
}

export interface SavingThrow {
    id: string;
    name: string;
}
