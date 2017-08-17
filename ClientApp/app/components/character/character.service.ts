import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import 'rxjs/add/operator/map';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class CharacterService {
    private baseUrl: string = '/api/Character/';
    private _currentCharacter: BehaviorSubject<SimpleCharacter> = new BehaviorSubject<SimpleCharacter>(undefined);

    currentCharacter$ = this._currentCharacter.asObservable();

    constructor(private http: Http) {
    }

    public setCharacter(characterId) {
        this.http
            .get(this.baseUrl + characterId)
            .subscribe(response => {
               this._currentCharacter.next(response.json() as SimpleCharacter);
            });
    }
}

export interface SimpleCharacter {
    id: string;
    firstName: string;
    lastName: string;
    gender: string;
    experience: string;
    level: string;
}
