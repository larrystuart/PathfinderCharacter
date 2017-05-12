import { Component } from '@angular/core';

@Component({
    selector: 'dice',
    templateUrl: './dice.component.html'
})
export class DiceComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
