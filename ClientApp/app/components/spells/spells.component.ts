import { Component } from '@angular/core';
import { LookupService, HeroClass, School, SavingThrow } from '../../shared/lookup.service';
import { SpellService, Spell } from './spells.service';
import { PagerService } from '../../shared/pager.service';
import { Http } from '@angular/http';

@Component({
    selector: 'spells',
    templateUrl: './spells.component.html',
    styleUrls: ['./spells.component.css'],
    providers: [SpellService, PagerService]
})
export class SpellsComponent {
    private spells: Spell[];
    public visibleSpells: Spell[];
    public filteredSpells: Spell[];
    public message: string;
    public filterClassId: string;
    public filterLevel: number;
    public filterLevels: number[] = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    public filterClasses: HeroClass[];
    public filterSchoolId: string;
    public filterSavingThrowId: string;
    public filterSchools: School[];
    public filterSavingThrows: SavingThrow[];
    public filterSearchQuery: string = "";
    public http: Http;

    // pager object
    public pager: any = {};

    constructor(http: Http, private lookupService: LookupService, private spellService: SpellService, private pagerService: PagerService) {

        spellService.getAll().subscribe(result => {
            this.spells = result;
            this.setDefaultFilteredSpells();
        });

        lookupService.getHeroClasses().subscribe(result => {
            this.filterClasses = result;
        });

        lookupService.getSchools().subscribe(result => {
            this.filterSchools = result;
        });

        lookupService.getSavingThrows().subscribe(result => {
            this.filterSavingThrows = result;
        });

        //only use this to populate the database from the raw spell data
        //http.get('/api/Spells/DataMigrate').subscribe(result => {
        //    this.message = result.text.toString();
        //});
    }

    public getSpellLevelByClass(spell: Spell): string {
        return spell.classes.find(c => c.heroClass.id == this.filterClassId).classLevel.toString();
    }
  
    public filterByLevel(level) {
        if (this.filterLevel == level)
        {
            level = null;
        }
        this.filterLevel = level;

        this.filterSpells();
    }

    public filterByClass(classId) {
        if (this.filterClassId == classId) {
            classId = null;
        }
        this.filterClassId = classId;

        this.filterSpells();
    }

    public filterBySchool(schoolId) {
        if (this.filterSchoolId == schoolId) {
            schoolId = null;
        }
        this.filterSchoolId = schoolId;

        this.filterSpells();
    }
    
    public filterBySavingThrow(savingThrowId) {
        if (this.filterSavingThrowId == savingThrowId) {
            savingThrowId = null;
        }
        this.filterSavingThrowId = savingThrowId;

        this.filterSpells();
    }

    private sortSpells()
    {
        var tempFilterClassId = this.filterClassId;  //the sort has its own 'this' scope, this bypasses that

        this.filteredSpells.sort(function(spell1, spell2) {
            var spellClass1 = tempFilterClassId ? spell1.classes.find(c => c.heroClass.id == tempFilterClassId) : spell1.classes[0];
            var spellClass2 = tempFilterClassId ? spell2.classes.find(c => c.heroClass.id == tempFilterClassId) : spell2.classes[0];

            if (spellClass1.classLevel < spellClass2.classLevel) {
                return -1;
            } else if (spellClass1.classLevel > spellClass2.classLevel) {
                return 1;
            } else {
                return 0;
            }
        });
    }

    private setDefaultFilteredSpells()
    {
        this.filteredSpells = this.spells.slice(0); //cheap and easy way to clone.
        this.sortSpells();
    }

    public setPagedData(event)
    {
        this.visibleSpells = event.data as Spell[];
    }

    public filterSpells() {
        if (this.spells && !this.filterClassId && !this.filterSchoolId && this.filterLevel == null && !this.filterSchoolId && !this.filterSavingThrowId && !!!this.filterSearchQuery)
        {
            this.setDefaultFilteredSpells();
        }
        else
        {
            this.filteredSpells = this.spells.filter(spell => {
                return spell.classes.some(c =>
                    (this.filterSearchQuery === "" || spell.name.toLowerCase().indexOf(this.filterSearchQuery.toLowerCase()) !== -1)
                    && (!this.filterClassId || c.heroClass.id == this.filterClassId)
                    && (this.filterLevel == null || c.classLevel == this.filterLevel))
                    && (spell.school == null || !this.filterSchoolId || spell.school.id == this.filterSchoolId)
                    && (spell.spellSavingThrows == null || !this.filterSavingThrowId || spell.spellSavingThrows.some(s => s.savingThrow.id == this.filterSavingThrowId));
            });
        }
        
        this.sortSpells();
    }
    
}
