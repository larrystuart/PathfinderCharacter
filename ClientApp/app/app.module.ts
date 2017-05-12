import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { SpellsFilter } from './components/spells/spells.component';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule, routableComponents } from './app-routing.module';

@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        SpellsFilter,
        AppComponent,
        NavMenuComponent,
        routableComponents
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        RouterModule,
        AppRoutingModule // Must be last to catch all for routing if other routes are added
    ],
})
export class AppModule {
}
