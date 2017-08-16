import { Component } from '@angular/core';
import { UserService, User } from '../../auth/user.service';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent {
    public name: string = "";

    constructor(private userService: UserService) {
        userService.getCurrentUser().subscribe(result => {
            this.name = result.firstName + " " + result.lastName;
        });
        
    }
}
