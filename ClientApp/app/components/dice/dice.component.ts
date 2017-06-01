import { Component, OnInit } from '@angular/core';
import { IDie, DieComponent } from './die.component';
import { getRandomNumber } from '../../shared/index'

@Component({
    selector: 'dice',
    templateUrl: './dice.component.html'
})
export class DiceComponent implements OnInit {

    public dice: IDie[];
    
    ngOnInit() {
        this.dice = [];        
    }

    public addD100() {
        var die: IDie;
        die = {
            dieType: "d100",
            maxValue: 100,
            rollValue: 0
        }

        this.rollDie(die);

        this.dice.push(die);
    }

    public addD20() {
        var die: IDie;
        die = {
            dieType: "d20",
            maxValue: 20,
            rollValue: 0
        }

        this.rollDie(die);
        
        this.dice.push(die);
    }

    public addD12() {
        var die: IDie;
        die = {
            dieType: "d12",
            maxValue: 12,
            rollValue: 0
        }
        this.rollDie(die);

        this.dice.push(die);
    }

    public addD10() {
        var die: IDie;
        die = {
            dieType: "d10",
            maxValue: 10,
            rollValue: 0
        }

        this.rollDie(die);

        this.dice.push(die);
    }

    public addD8() {
        var die: IDie;
        die = {
            dieType: "d8",
            maxValue: 8,
            rollValue: 0
        }

        this.rollDie(die);

        this.dice.push(die);
    }

    public addD6() {
        var die: IDie;
        die = {
            dieType: "d6",
            maxValue: 6,
            rollValue: 0
        }

        this.rollDie(die);

        this.dice.push(die);
    }

    public addD4() {
        var die: IDie;
        die = {
            dieType: "d4",
            maxValue: 4,
            rollValue: 0
        }

        this.rollDie(die);

        this.dice.push(die);
    }

    public totalValue()
    {
        var sum = 0;
        this.dice.forEach(function (die) { sum = sum + die.rollValue });

        return sum;
    }

    public removeDie(die) {
        var index = this.dice.indexOf(die);
        if (index >= 0)
            this.dice.splice(index, 1);
    }


    private rollDie(die) {
        die.rollValue = getRandomNumber(1, +(die.maxValue));
    }

    rollDice() {
        this.dice.forEach(die => this.rollDie(die));
    }
}
