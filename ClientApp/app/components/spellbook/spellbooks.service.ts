import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/of';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { HeroClass, SavingThrow, School } from '../../shared/lookup.service';
import { Spell, SpellClass, Subschool, ComponentType, SpellSubschool, SpellComponent, SpellSavingThrow, SpellService } from '../spells/spells.service';
import { CharacterService, SimpleCharacter } from '../character/character.service';

@Injectable()
export class SpellbookService
{
    private booksBaseUrl: string = '/api/Spellbook/';

    private _currentCharacter: SimpleCharacter;
    private _spellbooks: BehaviorSubject<Spellbook[]> = new BehaviorSubject<Spellbook[]>(undefined);

    spellbooks$ = this._spellbooks.asObservable();

    constructor(private http: Http, private characterService: CharacterService)
    {
        characterService.currentCharacter$.subscribe(result => {
            this._currentCharacter = result as SimpleCharacter;

            this.getCharacterSpellbooks(this._currentCharacter.id);
        });
    }

    private getCharacterSpellbooks(characterId) {
        this.http
            .get(this.booksBaseUrl + "getbooks/" + characterId)
            .subscribe(response => {
                this._spellbooks.next(response.json() as Spellbook[]);
            });
    }

    public getSpellbook(spellbookId)
    {
        return this.http
            .get(this.booksBaseUrl + spellbookId)
            .map(response => {
                console.log(response.json() as Spellbook);
                return response.json() as Spellbook;
            });
    }
}

export interface Spellbook {
    id: string;
    name: string;
    spells: SpellbookSpell[];
    isActive: boolean;
}

export interface SpellbookSpell {
    id: string;
    quantity: number;
    //metaMagics: MetaMagic;
    spell: Spell;
    used: number;
}