import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { maxValue, minValue } from '../../shared/index'
import { UserService, User } from '../../auth/user.service';
import { CharacterService, SimpleCharacter } from '../../components/character/character.service';

@Component({
    selector: 'character',
    templateUrl: './character.component.html',
    styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {
    public characterForm: FormGroup;
    private simpleCharacters: SimpleCharacter[] = [];
    public selectedCharacter: SimpleCharacter;
    
    constructor(private userService: UserService, private characterService: CharacterService)
    {
        userService.getCurrentUser().subscribe(result => {
            this.simpleCharacters = result.userCharacters as SimpleCharacter[];
        });

        characterService.currentCharacter$.subscribe(result => {
            this.selectedCharacter = result as SimpleCharacter;  
        });
    }

    public selectCharacter(characterId)
    {
        this.characterService.setCharacter(characterId);
    }

    ngOnInit() {
        let name = new FormControl(null, [Validators.maxLength(64), Validators.required]);
        
        this.characterForm = new FormGroup({
            name: name
        });
    }
    
}

interface Alignment
{
    id: string;
    goodEvil: number;
    lawChaos: number;
}

