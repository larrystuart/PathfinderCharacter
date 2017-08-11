import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { DieComponent } from './components/dice/die.component'
import { PagerComponent } from './components/pager/pager.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule, routableComponents } from './app-routing.module';
import { LookupService } from './shared/lookup.service';
import { CacheService } from './shared/cache.service';
import { PagerService } from './shared/pager.service';

@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,
        NavMenuComponent,
        routableComponents,
        DieComponent,
        PagerComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        AppRoutingModule// Must be last to catch all for routing if other routes are added
    ],
    providers: [LookupService, CacheService, PagerService]
})
export class AppModule {
    //constructor(cachedData: CachedData) { }
}
