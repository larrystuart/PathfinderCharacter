import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { maxValue, minValue } from '../../shared/index'

@Component({
    selector: 'skills',
    templateUrl: './skills.component.html',
    styleUrls: ['./skills.component.css']
})
export class SkillsComponent implements OnInit {
    skillsForm: FormGroup;
    private maxPoints:number;

    ngOnInit() {
        this.maxPoints = 20;
        let acrobatics = new FormControl(0, [maxValue(99), minValue(0), Validators.required]);
        let appraise = new FormControl(0, [maxValue(99), minValue(0), Validators.required]);

        this.skillsForm = new FormGroup({
            acrobatics: acrobatics,
            appraise: appraise
        })
    }

    
}
