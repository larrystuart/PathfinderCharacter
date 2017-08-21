import { Component, Input } from '@angular/core';
import { SpellService, Spell } from '../spells/spells.service';
import { SpellbookService, Spellbook } from './spellbooks.service';

@Component({
    selector: 'spellbook',
    templateUrl: './spellbook.component.html',
    styleUrls: ['./spellbook.component.css'],
    providers: [SpellService, SpellbookService]
})
export class SpellbookComponent {
    @Input() spellbook: Spellbook;
    
    
    constructor(private spellService: SpellService, private spellbookService: SpellbookService) {
    
    }
}
