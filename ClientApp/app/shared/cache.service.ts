import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of'; //proper way to import the 'of' operator
import 'rxjs/add/operator/share';
import 'rxjs/add/operator/map';
//import { CachedData } from './cacheddata';
import { Spell } from '../components/spells/spells.service'

class CachedData {
    _spells;
    get spells() {
        return this._spells;
    }
    set spells(value) {
        this._spells = value;
    }
}

@Injectable()
export class CacheService {
    private data: CachedData;
    private observable: Observable<any>;

    constructor(private http: Http) {
        if (!!!this.data) {
            this.data = new CachedData();
        }
    }

    getSpells(url) {
        if (this.data.spells) {
            console.log("return cached version");
            // if `data` is available just return it as `Observable`
            return Observable.of(this.data.spells);
            
        } else if (this.observable) {
            // if `this.observable` is set then the request is in progress
            // return the `Observable` for the ongoing request
            console.log("return saved observable");
            return this.observable;
        } else {
            // example header (not necessary)
            let headers = new Headers();
            headers.append('Content-Type', 'application/json');
            // create the request, store the `Observable` for subsequent subscribers
            this.observable = this.http.get(url, {
                headers: headers
            })

                .map(response => {
                    // when the cached data is available we don't need the `Observable` reference anymore
                    this.observable = null;

                    if (response.status == 400) {
                        return "FAILURE";
                    } else if (response.status == 200) {
                        this.data.spells = response.json() as Spell[];
                        console.log("return fresh version");
                        return this.data.spells;
                    }
                    // make it shared so more than one subscriber can get the result
                })
                .share();
            return this.observable;
        }
    }
}