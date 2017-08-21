import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/of';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { HeroClass, SavingThrow, School } from '../../shared/lookup.service';
import { CacheService } from '../../shared/cache.service';

@Injectable()
export class SpellService
{
    private baseUrl: string = '/api/Spells/';
    
    constructor(private http: Http, private cacheService: CacheService)
    {
    }
    
    getAll(): Observable<Spell[]> {
        return this.cacheService.getSpells(this.baseUrl + 'Spells');
    }


    
}

function mapSpells(response: Response): Spell[] {

    // The response of the API has a results
    // property with the actual results
    return response.json() as Spell[]; //.map(toSpell)
}

//for a custom mapping - I can replace the function in the map above with this custom one
function toSpell(s: any): Spell {
    let spell = <Spell>({
        id: s.id,
        area: s.area,
        augmentedText: s.augmentedText
    });
    return spell;
}

export interface RawSpell {
    id: number;
    SLA_Level: number;
    acid: boolean;
    adept: number;
    air: boolean;
    alchemist: number;
    antipaladin: number;
    area: string;
    augmented: string;
    bard: number;
    bloodline: string;
    bloodrager: number;
    casting_time: string;
    chaotic: boolean;
    cleric: number;
    cold: boolean;
    components: string;
    costly_components: boolean;
    curse: boolean;
    darkness: boolean;
    death: boolean;
    deity: string;
    description: string;
    description_formated: string;
    descriptor: string;
    disease: boolean;
    dismissible: boolean;
    divine_focus: boolean;
    domain: string;
    draconic: boolean;
    druid: number;
    duration: string;
    earth: boolean;
    effect: string;
    electricity: boolean;
    emotion: boolean;
    evil: boolean;
    fear: boolean;
    fire: boolean;
    focus: boolean;
    force: boolean;
    full_text: string;
    good: boolean;
    haunt_statistics: string;
    hunter: number;
    inquisitor: number;
    investigator: number;
    language_dependent: boolean;
    lawful: boolean;
    light: boolean;
    linktext: string;
    magus: number;
    material: boolean;
    material_costs: number;
    meditative: boolean;
    medium: number;
    mesmerist: number;
    mind_affecting: boolean;
    mythic: boolean;
    mythic_text: string;
    name: string;
    occultist: number;
    oracle: number;
    pain: boolean;
    paladin: number;
    patron: string;
    poison: boolean;
    psychic: number;
    range: string;
    ranger: number;
    ruse: boolean;
    saving_throw: string;
    school: string;
    shadow: boolean;
    shaman: number;
    shapeable: boolean;
    short_description: string;
    skald: number;
    somatic: boolean;
    sonic: boolean;
    sor: number;
    source: string;
    spell_level: string;
    spell_resistence: string;
    spiritualist: number;
    subschool: string;
    summoner: number;
    targets: string;
    verbal: boolean;
    water: boolean;
    witch: number;
    wiz: number;
}

export interface Spell {
    id: string;
    name: string;
    shortDescription: string;
    classes: SpellClass[];
    school: School;
    spellSubschools: Subschool[];
    spellSavingThrows: SpellSavingThrow[];
    htmlDescription: string;
    area: string;
    augmentedText: string;
    duration: string;
    effect: string;
    range: string;
    targets: string;
    spellResistance: boolean;
    spellResistanceHarmless: boolean;
    spellResistanceObject: boolean;
    components: SpellComponent[];
}

export interface Subschool
{
    id: string;
    name: string;
}

export interface SpellSubschool {
    id: string;
    subschool: Subschool;
}

export interface SpellClass {
    id: string;
    heroClass: HeroClass;
    classLevel: number;
}

export interface SpellSavingThrow {
    id: string;
    savingThrow: SavingThrow;
}

export interface SpellComponent {
    id: string;
    material: string;
    materialCost: Currency;
    componentType: ComponentType;
}

export interface Currency {
    id: string;
    amount: number;
    currencyUnit: CurrencyUnit;
}

export interface ComponentType {
    id: string;
    name: string;
    symbol: string;
}

export interface CurrencyUnit {
    id: string;
    name: string;
    nameShort: string;
    valueFactor: number;
}