import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { SkillsComponent } from './components/skills/skills.component';
import { CharacterComponent } from './components/character/character.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { DiceComponent } from './components/dice/dice.component';
import { SpellsComponent } from './components/spells/spells.component';
import { SpellbooksComponent } from './components/spellbook/spellbooks.component';

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent }, //by having "component:" this is eagerly loaded
    { path: 'spells', component: SpellsComponent },
    { path: 'spellbooks', component: SpellbooksComponent },
    { path: 'skills', component: SkillsComponent },
    { path: 'character', component: CharacterComponent },
    //{ path: 'skills', loadChildren: 'app/components/skills/skills.component#SkillsComponent' }, //by having "loadChildren:" this is lazy loaded, but I think it needs to be a module, not a component???
    { path: 'dice', component: DiceComponent },
    { path: 'inventory', component: InventoryComponent },
    { path: '**', redirectTo: 'home' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule { }

export const routableComponents = [HomeComponent, SkillsComponent, CharacterComponent, InventoryComponent, DiceComponent, SpellsComponent, SpellbooksComponent]