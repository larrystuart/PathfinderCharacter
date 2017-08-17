import { Component } from '@angular/core';
import { UserService, User } from '../../auth/user.service';
import { CharacterService, SimpleCharacter } from '../character/character.service';
import { Observable } from 'rxjs/Observable';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent {
    public character: SimpleCharacter;
    public user: User;

    constructor(private userService: UserService, private characterService: CharacterService) {
        userService.getCurrentUser().subscribe(result => {
            this.user = result as User;
        });

        characterService.currentCharacter$.subscribe(result => {
            this.character = result as SimpleCharacter;
        });

        
    }


}
