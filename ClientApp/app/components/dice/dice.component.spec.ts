/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { assert } from 'chai';
import { DiceComponent } from './dice.component';
import { TestBed, async, ComponentFixture } from '@angular/core/testing';

let fixture: ComponentFixture<DiceComponent>;

describe('Dice component', () => {
    beforeEach(() => {
        TestBed.configureTestingModule({ declarations: [DiceComponent] });
        fixture = TestBed.createComponent(DiceComponent);
        fixture.detectChanges();
    });

    it('should display a title', async(() => {
        const titleText = fixture.nativeElement.querySelector('h1').textContent;
        expect(titleText).toEqual('Dice');
    }));

    it('should start with count 0, then increments by 1 when clicked', async(() => {
        const countElement = fixture.nativeElement.querySelector('strong');
        expect(countElement.textContent).toEqual('0');

        const incrementButton = fixture.nativeElement.querySelector('button');
        incrementButton.click();
        fixture.detectChanges();
        expect(countElement.textContent).toEqual('1');
    }));
});
