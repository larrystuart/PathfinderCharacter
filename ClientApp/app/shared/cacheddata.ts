import { Injectable } from '@angular/core';

@Injectable()
export class CachedData {
    _spells;
    get spells() {
        return this._spells;
    }
    set spells(value) {
        this._spells = value;
    }
}

