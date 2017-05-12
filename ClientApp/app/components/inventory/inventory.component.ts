import { Component } from '@angular/core';

@Component({
    selector: 'inventory',
    templateUrl: './inventory.component.html'
})
export class InventoryComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
