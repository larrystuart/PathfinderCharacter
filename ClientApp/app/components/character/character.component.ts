import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { maxValue, minValue } from '../../shared/index'

@Component({
    selector: 'character',
    templateUrl: './character.component.html',
    styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {
    characterForm: FormGroup;
    

    ngOnInit() {
        let name = new FormControl(null, [Validators.maxLength(64), Validators.required]);
        

        this.characterForm = new FormGroup({
            name: name
        })
    }
    
}

interface Alignment
{
    id: string;
    goodEvil: number;
    lawChaos: number;
}

