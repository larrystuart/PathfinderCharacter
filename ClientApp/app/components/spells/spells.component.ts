import { Component, Pipe, PipeTransform } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

//todo:extract to separate file
@Pipe({ name: 'spellsFilter' })
export class SpellsFilter implements PipeTransform {
    transform(spells: Spell[], filterClassId: string, filterSpellLevel: number, filterSchoolId: string, filterSavingThrowId: string): Spell[] {
        return spells.filter(function (el: any) {
            
            return el.classes.some(c =>
                (!filterClassId || c.heroClass.id == filterClassId)
                && (filterSpellLevel == null || c.classLevel == filterSpellLevel))
                && (el.school == null || !filterSchoolId || el.school.id == filterSchoolId)
                && (el.spellSavingThrows == null || !filterSavingThrowId || el.spellSavingThrows.some(s => s.savingThrow.id == filterSavingThrowId));
        }).sort(function (spell1, spell2) {
            var spellClass1 = filterClassId ? spell1.classes.find(c => c.heroClass.id == filterClassId) : spell1.classes[0];
            var spellClass2 = filterClassId ? spell2.classes.find(c => c.heroClass.id == filterClassId) : spell2.classes[0];

            if (spellClass1.classLevel < spellClass2.classLevel) {
                return -1;
            } else if (spellClass1.classLevel > spellClass2.classLevel) {
                return 1;
            } else {
                return 0;
            }
        });
    }
}

@Component({
    selector: 'spells',
    templateUrl: './spells.component.html',
    styleUrls: ['./spells.component.css']
})
export class SpellsComponent {
    public spells: Spell[];
    public message: string;
    public http: Http;
    public filterClassId: string;
    public filterLevel: number;
    public filterLevels: number[] = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    public filterClasses: HeroClass[];
    public filterSchoolId: string;
    public filterSavingThrowId: string;
    public filterSchools: School[];
    public filterSavingThrows: SavingThrow[];

    public getSpellLevelByClass(spell: Spell): string {
        return spell.classes.find(c => c.heroClass.id == this.filterClassId).classLevel.toString();
    }

    public filterByLevel(level) {
        if (this.filterLevel == level)
        {
            level = null;
        }
        this.filterLevel = level;
    }

    public filterByClass(classId) {
        if (this.filterClassId == classId) {
            classId = null;
        }
        this.filterClassId = classId;
    }

    public filterBySchool(schoolId) {
        if (this.filterSchoolId == schoolId) {
            schoolId = null;
        }
        this.filterSchoolId = schoolId;
    }

    public filterBySavingThrow(savingThrowId) {
        if (this.filterSavingThrowId == savingThrowId) {
            savingThrowId = null;
        }
        this.filterSavingThrowId = savingThrowId;
    }

    constructor(http: Http) {
        http.get('/api/Spells/Spells').subscribe(result => {
            //console.log(result.json()[0]);
            this.spells = result.json() as Spell[];
        });

        http.get('/api/Lookups/HeroClasses').subscribe(result => {
            //console.log(result.json()[0]);
            this.filterClasses = result.json() as HeroClass[];
        });

        http.get('/api/Lookups/Schools').subscribe(result => {
            //console.log(result.json()[0]);
            this.filterSchools = result.json() as School[];
        });

        http.get('/api/Lookups/SavingThrows').subscribe(result => {
            //console.log(result.json()[0]);
            this.filterSavingThrows = result.json() as SavingThrow[];
        });

        //only use this to populate the database from the raw spell data
        //http.get('/api/Spells/DataMigrate').subscribe(result => {
        //    this.message = result.text.toString();
        //});
    }
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

interface Subschool
{
    id: string;
    name: string;
}

interface SpellSubschool {
    id: string;
    subschool: Subschool;
}

interface SpellClass {
    id: string;
    heroClass: HeroClass;
    classLevel: number;
}

interface School {
    id: string;
    name: string;
} 

interface HeroClass {
    id: string;
    name: string;
}

interface SpellSavingThrow {
    id: string;
    savingThrow: SavingThrow;
}

interface SavingThrow {
    id: string;
    name: string;
}

interface SpellComponent {
    id: string;
    material: string;
    materialCost: Currency;
    componentType: ComponentType;
}

interface Currency {
    id: string;
    amount: number;
    currencyUnit: CurrencyUnit;
}

interface ComponentType {
    id: string;
    name: string;
    symbol: string;
}

interface CurrencyUnit {
    id: string;
    name: string;
    nameShort: string;
    valueFactor: number;
}