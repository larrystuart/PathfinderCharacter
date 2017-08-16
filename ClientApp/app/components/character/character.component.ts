import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { maxValue, minValue } from '../../shared/index'
import { UserService, User, SimpleCharacter } from '../../auth/user.service';

@Component({
    selector: 'character',
    templateUrl: './character.component.html',
    styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {
    characterForm: FormGroup;
    simpleCharacters: SimpleCharacter[] = [];
    
    constructor(private userService: UserService)
    {
        userService.getCurrentUser().subscribe(result => {
            this.simpleCharacters = result.userCharacters as SimpleCharacter[];
        });
    }

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

