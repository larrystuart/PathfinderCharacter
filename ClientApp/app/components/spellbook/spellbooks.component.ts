import { Component } from '@angular/core';
import { SpellService, Spell } from '../spells/spells.service';
import { SpellbookService, Spellbook } from './spellbooks.service';

@Component({
    selector: 'spellbooks',
    templateUrl: './spellbooks.component.html',
    styleUrls: ['./spellbooks.component.css'],
    providers: [SpellService, SpellbookService]
})
export class SpellbooksComponent {
    public spellbooks: Spellbook[] = [];
    public selectedSpellbook: Spellbook;
    
    constructor(private spellService: SpellService, private spellbookService: SpellbookService) {
        spellbookService.spellbooks$.subscribe(result => {
            this.spellbooks = result;
        });
    }

    public setSelectedSpellbook(spellbook) {
        this.selectedSpellbook = spellbook;
    }
}
