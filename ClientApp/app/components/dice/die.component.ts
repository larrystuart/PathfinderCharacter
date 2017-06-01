import { Component, Input } from '@angular/core';

@Component({
    selector: 'die',
    templateUrl: './die.component.html'
})
export class DieComponent {
    @Input() die: IDie;
}

export interface IDie{
    dieType: string;
    rollValue: number;
    maxValue: number;
}